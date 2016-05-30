int SPin = 11;
int LedPin = 13;
int SVal=0;

void setup(){
  pinMode(SPin,INPUT);
  pinMode(LedPin,OUTPUT);
}

void loop(){
  SVal = digitalRead(SPin);
  digitalWrite(LedPin,SVal);
}
