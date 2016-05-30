/***************************************
 * Hall sensor module test 
 * When the magnet close to the Hall element, high output, LED lights
 ****************************************/

#define ledPin 12       
#define hallPin 10      
int HallValue = 0;

void setup() { 
  
  pinMode(ledPin,OUTPUT); 
}

void loop() 
{ 
  
  HallValue = digitalRead(hallPin);
  
  if(HallValue == LOW) {
    digitalWrite(ledPin,HIGH); 
  }
  else { 
    digitalWrite(ledPin,LOW); 
  }
}



