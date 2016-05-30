/**********************************************
 * Vibrating alarm test 
 * Vibration sensors to control the buzzer, vibration, to the buzzer 
 * High level alarm; buzzer low vibration to not work 
 * (Using the interrupt function mode, UNO interrupt pin D2, D3)
 **********************************************/

#define buzzerPin 13
#define sensorPin 2  

unsigned char state = 0;

void setup() 
{ 
  pinMode(buzzerPin, OUTPUT); 
  pinMode(sensorPin, INPUT);
  //D2 port for external interrupt 0, when the falling edge of the trigger when the function is called blink
  attachInterrupt(0, blink, FALLING);

}
void loop()
{
  if(state != 0)
  {
    state = 0;
    digitalWrite(buzzerPin,HIGH);
    delay(500);
  }  
  else 
    digitalWrite(buzzerPin,LOW);
} 

//Falling edge triggered interrupt function blink ()
void blink()
{
  state++;
}



