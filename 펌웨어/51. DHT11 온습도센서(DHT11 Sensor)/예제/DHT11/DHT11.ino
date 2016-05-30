/**************************************
 * DHT11 temperature and humidity alarm sound and light experiments 
 * When the indoor temperature is not appropriate, flashing LED alerts 
 * When the indoor humidity inappropriate buzzer
 **************************************/

#include <dht11.h>

dht11 DHT11;

#define DHT11PIN A0
int H_Buzzer = 2;     
int T_Led = 3;       

void setup(){

  pinMode(H_Buzzer,OUTPUT);
  pinMode(T_Led,OUTPUT); 
  Serial.begin(9600);
  Serial.println("DHT11 Monitoring");
  Serial.print("\n");

}

void loop(){

  int val = DHT11.read(DHT11PIN);
  Serial.print("Read sensor: ");
  switch (val)
  {
  case DHTLIB_OK:
    Serial.println("OK");
    break;
  case DHTLIB_ERROR_CHECKSUM: 
    Serial.println("Checksum error"); 
    break;
  case DHTLIB_ERROR_TIMEOUT: 
    Serial.println("Time out error"); 
    break;
  default: 
    Serial.println("Unknown error"); 
    break;
  }

  //Output humidity and indoor humidity to determine the suitability of such discomfort is lit to remind
  Serial.print("Humidity (%): ");
  Serial.println((float)DHT11.humidity); 
  if((DHT11.humidity<=40)||(DHT11.humidity>=60))
    digitalWrite(H_Buzzer,HIGH);
  else 
    digitalWrite(H_Buzzer,LOW);

  //Output temperature and the room temperature to determine the suitability of such discomfort is lit to remind
  Serial.print("Temperature (oC): ");
  Serial.println((float)DHT11.temperature);
  if((DHT11.temperature<=18)||(DHT11.temperature>=25))
   Blink();
  else
    digitalWrite(T_Led,LOW);
  delay(2000);
}

void Blink(){
  for(int i=0;i<3;i++){
    digitalWrite(T_Led,HIGH);
    delay(500);
    digitalWrite(T_Led,LOW);
    delay(500);
  }
}


