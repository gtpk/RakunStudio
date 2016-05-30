/***************************************
 * Infrared sensor (infrared sensor) 
 * When moving person or animal, the output of a high level, the lighting LED, the delay 2S
 ****************************************/

int sensorPin = 10;  
int ledPin = 12;
int sensorVal = 0;

void setup()
{
  pinMode(ledPin,OUTPUT);
  pinMode(sensorPin, INPUT);
  Serial.begin(9600);  
}

void loop()
{
  int in = digitalRead(sensorPin); 
  if(in == 1){
    digitalWrite(ledPin,HIGH);
    delay(2000);
  }
  else digitalWrite(ledPin,LOW);
  Serial.println(in); //Someone output high when nobody 0 1
  delay(200);    
}


