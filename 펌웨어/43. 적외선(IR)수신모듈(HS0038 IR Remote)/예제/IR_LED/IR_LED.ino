/*****************************************************************
 * Infrared remote control LED *
  Experiment Description: Press the power button on the remote control, LED off, press the mute button, LED light
 ******************************************************************/
#include <IRremote.h>

int RECV_PIN = 11;   
int LED = 10;        

IRrecv irrecv(RECV_PIN);   // Define IRrecv object to receive infrared signals
decode_results results;   //Decoding results on decode_results constructed object results in


void irdisplay(unsigned long value)  // After pressing the button, the display of the remote control buttons corresponding 
{
  switch(value){         //Determine which key is pressed, the button displays the name of the serial port
  case 0xFFA25D:
    Serial.println("POWER");
    digitalWrite(LED, LOW);          //The power button is pressed, the LED lights perform a shutdown
    break;
  case 0xFF629D:
    Serial.println("Mode");
    break;
  case 0xFFE21D:
    Serial.println("MUTE");
    digitalWrite(LED, HIGH);        //Mute button is pressed, the LED lights up execution
    break;

  case 0xFF22DD:
    Serial.println("PLAY/PAUSE");
    break;
  case 0xFF02FD:
    Serial.println("PREV");
    break;
  case 0XFFC23D:
    Serial.println("NEXT");
    break;
  case 0xFFE01F:
    Serial.println("EQ");
    break;
  case 0xFFA857:
    Serial.println("-");
    break;
  case 0xFF906F:
    Serial.println("+");
    break;
  case 0xFF6897:
    Serial.println("0");
    break;
  case 0xFF9867:
    Serial.println("BACK");
    break;
  case 0xFFB04F:
    Serial.println("U/SD");
    break;
  case 0xFF30CF:
    Serial.println("1");
    break;
  case 0xFF18E7:
    Serial.println("2");
    break;
  case 0xFF7A85:
    Serial.println("3");
    break;
  case 0xFF10EF:
    Serial.println("4");
    break;
  case 0xFF38C7:
    Serial.println("5");
    break;
  case 0xFF5AA5:
    Serial.println("6");
    break;
  case 0xFF42BD:
    Serial.println("7");
    break;
  case 0xFF4AB5:
    Serial.println("8");
    break;
  case 0xFF52AD:
    Serial.println("9");
    break;
  }
}
void setup()
{
  pinMode(LED,OUTPUT);          // LED output pin is defined
  Serial.begin(9600);          
  irrecv.enableIRIn();          //Start IR decoding
}
void loop() {
  if (irrecv.decode(&results))  
  {//Decoding is successful, the group received an infrared signal  
    irdisplay(results.value);    
    irrecv.resume();          
  }   
}



