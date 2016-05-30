/*************************************************
 * LED light control
 * Experiment Description: photoresistor ambient light intensity sensor, control led light off
 *************************************************/

int photoresistancePin = 5;  //Defined voltage read port.
int ledPin = 11;   //Set led digital pin
int sensorval = 0;       //Define variables sensorval

void setup() { 

  pinMode(ledPin, OUTPUT);  //Set ledPin foot mode, OUTPUT to output

} 

void loop() { 

  sensorval= digitalRead(photoresistancePin);    //Read values ​​from the sensor

  if(sensorval == 0)
  {      
    /*Adjustment potentiometer, adjust the light sensor sensitivity*/
    digitalWrite(ledPin, LOW);//When the light intensity is too strong led off.
  }
  else
  {
    digitalWrite(ledPin, HIGH); //When the light intensity is too low led light.
  }
}



