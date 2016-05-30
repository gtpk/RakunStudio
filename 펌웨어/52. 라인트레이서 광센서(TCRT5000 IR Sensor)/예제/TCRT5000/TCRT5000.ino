/***************************************
 * TCRT5000 switch module 
 * Black objects close, high output, light LED; white object, no reaction; 
 * General 3-5 module, you can do line patrol car
 ****************************************/

#define ledPin 12       
#define sensorPin 10    
int Value = 0;

void setup() { 

  pinMode(ledPin,OUTPUT); 
  pinMode(sensorPin,INPUT);
}

void loop() 
{ 

  Value = digitalRead(sensorPin);

  if(Value == HIGH)    digitalWrite(ledPin,HIGH); 

  else     digitalWrite(ledPin,LOW); 

}




