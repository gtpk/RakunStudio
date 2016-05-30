/***************************************
 * Touch switch test 
 * Finger touches the touch area, high output, LED lights
 ****************************************/

#define ledPin 12      
#define touchPin 10    
int Value = 0;

void setup() { 
  
  pinMode(ledPin,OUTPUT);  
  pinMode(touchPin,INPUT);
}

void loop() 
{ 
  
  Value = digitalRead(touchPin);
  
  if(Value == LOW)    digitalWrite(ledPin,HIGH);

  else     digitalWrite(ledPin,LOW); 

}



