int ledPin = 11;
int sensorPin = A0;
int sensorValue = 0;

void setup()
{
  pinMode(ledPin,OUTPUT);          
}

void loop()
{
  //Read the values ​​A0 analog ports (0-5V corresponds 0-1204 value)
  sensorValue = analogRead(sensorPin);     
  //PWM maximum value of the analog port 255 so the value n is divided by 4
  analogWrite(ledPin , sensorValue/4);        

}



