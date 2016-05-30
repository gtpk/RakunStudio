/*************************************
 * Sound LED experiment 
 * Function: When there is sound, light LED, and delay 5s; otherwise the LED is off 
 *************************************/

int soundPin = 5;    
int ledPin = 13;    
int soundValue;

void setup() 
{ 
  pinMode(ledPin,OUTPUT); 
  pinMode(soundPin,OUTPUT);

} 
void loop() 
{ 
  soundValue = digitalRead(soundPin);
  if(soundValue == HIGH){
  digitalWrite(ledPin,HIGH); 
  delay(5000);
  }else
  digitalWrite(ledPin,LOW);

}


