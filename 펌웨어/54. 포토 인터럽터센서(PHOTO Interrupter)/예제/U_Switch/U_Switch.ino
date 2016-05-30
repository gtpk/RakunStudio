/*******************************************
 * LED photoelectric switch control 
 * When there is an obstruction between the U-shaped switch, high output, LED lights
 ******************************************/

int U_Pin = 10;   
int LEDPin = 12;  
int U_Val;        

void setup(){

  pinMode(LEDPin,OUTPUT);

}

void loop(){
  
  U_Val = digitalRead(U_Pin);

  if(U_Val == HIGH)
    digitalWrite(LEDPin,HIGH);
  else  digitalWrite(LEDPin,LOW);
}

