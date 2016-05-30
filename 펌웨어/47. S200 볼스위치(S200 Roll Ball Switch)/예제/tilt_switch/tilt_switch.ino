/**************************************************
 * Tilt switch experiments 
 * When the sensor is tilted to a certain angle, lit LED; otherwise the LED is off
 ***************************************************/

#define ledPin 13 
#define sensorPin A2
int sensorValue = 0;

void setup(){
  pinMode(ledPin ,OUTPUT); 

}
void loop(){

  sensorValue = analogRead(sensorPin);

  if (sensorValue > 1000) //1000 is the actual process of feeling appropriate value 512 = 2.5 V
  {
    digitalWrite(ledPin,LOW); //LED OFF 
  } 
  else
  { 
    digitalWrite(ledPin,HIGH); //LED ON
  }
}

