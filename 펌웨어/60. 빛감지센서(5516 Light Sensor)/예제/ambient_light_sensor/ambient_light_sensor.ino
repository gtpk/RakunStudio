/************************************************************************
 * Light control LED brightness
 * 
 * Experiment Description: photoresistor induction environmental light intensity, brightness control led
 * 
 * Usage: the same photoresistor
 * 
 * Applications: reduce power consumption, and more used in mobile phones, laptops, tablet PCs and other mobile devices
 **************************************************************************/

int light_Pin = A5;      
int ledPin = 11;         
int sensorval = 0;       

void setup() { 

  pinMode(ledPin, OUTPUT);  
  Serial.begin(9600);

} 

void loop() {

  sensorval= analogRead(light_Pin);   

  Serial.println(sensorval);

  int brightness = map(sensorval ,0,1023,0,255);

  analogWrite(ledPin, brightness);

}

