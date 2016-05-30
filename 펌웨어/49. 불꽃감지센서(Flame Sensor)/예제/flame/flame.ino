/************************************
 * Fire alarm test 
 * Function: When there is a flame, the buzzer alarm
 ************************************/

int flamePin=4;      
int flameValue;

void setup() 
{ 
  pinMode(flamePin,INPUT);
} 

void loop() 
{ 
  flameValue = digitalRead(flamePin); 
}

