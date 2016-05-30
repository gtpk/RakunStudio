/***************************************
 * Magnetic switch experiments 
 * Reed switch controlled LED lights (the experiment using the magnet)
 ****************************************/

#define ledPin 13 
#define reed_switchPin 10 
int reed_switchValue = 0;

void setup() { 
  
  pinMode(ledPin,OUTPUT); 
  pinMode(reed_switchPin,INPUT);
  
}

void loop() 
{ 
  
  reed_switchValue = digitalRead(reed_switchPin);
  
  //When the magnet close to the reed
  if(reed_switchValue == LOW) {
    digitalWrite(ledPin,HIGH); //LED ON
  }
  else { 
    digitalWrite(ledPin,LOW); //LED OFF
  }
}



