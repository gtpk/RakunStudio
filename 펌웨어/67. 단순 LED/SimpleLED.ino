int buzzerPin=13;    
int BuzzInPut = HIGH;

void setup() 
{
  pinMode(buzzerPin,OUTPUT); 
} 

void loop() 
{ 
  digitalWrite(buzzerPin,BuzzInPut);
}

