int ledPin = 13;
int buttonPin = 12;
int buttonValue = 0;

void setup ()
{             
  
  pinMode(ledPin,OUTPUT);
  
}
void loop()
{
  buttonValue =digitalRead(buttonPin);            
  
  if (buttonValue == LOW){          
    
    digitalWrite(ledPin,HIGH); 
    delay(3000);
    digitalWrite(ledPin,LOW);
  }
  
} 



