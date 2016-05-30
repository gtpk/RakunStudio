/**********************************************************************************************
 *  Matrix 8x8 LED
 *  For 74HC595 x2 (without ULN2803)  
 *  the drive is referenced from  http://www.instructables.com/id/LED-Dot-Matrix-Display-1/
 *  the animation is referenced from http://www.bleq.nl/arduino/   
 *  TIDY By YFROBOT
 *********************************************************************************************/

#include <TimerOne.h>
#include "animation.h"

//Pin connected to DS of 74HC595
int SER = 9;
//Pin connected to ST_CP of 74HC595
int RCK  = 10;
//Pin connected to SH_CP of 74HC595
int SRCK  = 11;

// A number indicating when to advance to the next frame
unsigned long nextImage = 0;
// A counter to know what frame we're showing
int animationIndex = 0;
// 8x8 Point temporary array
byte brightnesses[64];
// Matrix image frame for 8x8 LED
int M[8];

void setup() {
  //set pins to output so you can control the shift register
  pinMode(RCK, OUTPUT);
  pinMode(SRCK, OUTPUT);
  pinMode(SER, OUTPUT);
}

void loop() {
  if(animationIndex >= animationFrames) 
  {
    //restart animation index
    animationIndex = 0;
  }
  else{
    //load Delay time for Image
    nextImage = animationDelays[animationIndex];

    //load image(converted)
    for(int i=0; i<64; i++) {
      brightnesses[i] = (animation[animationIndex][i/4] >> (i%4*2)) & B00000001;
      M[i/8] |= (brightnesses[i] << (i%8)) ;
    }
    //Update Image
    screenUpdate(nextImage);
    animationIndex ++;

    //clear M[]
    for(int i=0; i<(8); ++i) {
      M[i]=0;
    }
  }
}

void screenUpdate(unsigned long frametime) 
{ // function to display image
  unsigned long startime=millis();
  while(millis()-startime<frametime)
  {
    byte row = B10000000; // row 1 
    for (byte k = 0; k < 8; k++) 
    {
      digitalWrite(RCK, LOW); // open latch ready to receive data
      shiftOut(~row); // row binary number
      shiftOut(M[k]); // LED array (inverted) 
      // Close the latch, sending the data in the registers out to the matrix
      digitalWrite(RCK, HIGH);
      row = row>> 1; // bitshift right
    }
  } 
}

//shift function
void shiftOut(byte myDataOut) {
  //internal function setup
  boolean pinState;

  //clear shift register read for sending data
  digitalWrite(RCK, LOW);
  // for each bit in dataOut send out a bit
  for (int i = 0; i <= 7; i++)  {
    //set clockPin to LOW prior to sending bit
    digitalWrite(SRCK, LOW);
    /*if the value of DataOut and (logical AND) a bitmask
     are true, set pinState to 1 (HIGH)*/
    if ( myDataOut & (1<<i) ) {
      pinState= HIGH;
    }
    else {     
      pinState= LOW;
    }
    //Sets the pin to HIGH or LOW depending on pinState
    digitalWrite(SER, pinState);
    //send bit out on rising edge of clock
    digitalWrite(SRCK, HIGH);
    digitalWrite(SER, LOW);
  }
  //stop shifting
  digitalWrite(SRCK, LOW);
}


