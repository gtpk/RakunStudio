/**************************************************
 * Face 
 * ( 8x8 Led Dot Matrix with two 74HC595 on Arduino)
 * 
 * by YFROBOT 
 ***************************************************/

#include "TimerOne.h"

#define ROW_DATA ((row[0]<<7)|(row[1]<<6)|(row[2]<<5)|(row[3]<<4)|(row[4]<<3)|(row[5]<<2)|(row[6]<<1)|(row[7]<<0))
#define COL_DATA ((col[0]<<7)|(col[1]<<6)|(col[2]<<5)|(col[3]<<4)|(col[4]<<3)|(col[5]<<2)|(col[6]<<1)|(col[7]<<0))

//Pin connected to DS of 74HC595
int SER = 9;
//Pin connected to ST_CP of 74HC595
int RCK  = 10;
//Pin connected to SH_CP of 74HC595
int SRCK  = 11;
int row[8]={
  0, 0, 0, 0, 0, 0, 0, 0};
int col[8]={
  0, 0, 0, 0, 0, 0, 0, 0};
byte screen[8] = {
  0, 0, 0, 0, 0, 0, 0, 0};
volatile byte screenRow = 0;
volatile byte screenCol = 0;

void setup() {
  Timer1.initialize(100);
  pinMode(RCK, OUTPUT);
  pinMode(SRCK, OUTPUT);
  pinMode(SER, OUTPUT);
  Timer1.attachInterrupt(doubleBuffer);
  Serial.begin(9600);

}

void doubleBuffer() {
  row[screenRow]=0;
  col[screenCol]=1;  

  screenCol++;
  if (screenCol >= 8) {
    screenCol = 0;
    screenRow++;
    if (screenRow >= 8) {
      screenRow = 0;
    }
  }
  if((screen[screenRow] >> screenCol) & B1 == B1) {
    row[screenRow]=1;
    col[screenCol]=0;
    digitalWrite(RCK,LOW);
    shiftOut(COL_DATA);
    shiftOut(ROW_DATA);
    digitalWrite(RCK,HIGH);
  } 
}

void allOFF() {
  for (int i = 0; i < 8; i++)
    screen[i] = B00000000;
}

void allON() {
  for (int i = 0; i < 8; i++)
    screen[i] = B11111111;
}
void on(byte row, byte column) {
  screen[column-1] |= (B1 << (row - 1));
}

void off(byte row, byte column) {
  screen[column-1] &= ~(B1 << (row - 1));
}

void loop() {
  smile();
  allOFF();
  lol();
  allOFF();
}

void smile()
{
  on(1, 1);on(1, 2);on(1, 7);on(1, 8);
  on(2, 1);on(2, 2);on(2, 7);on(2, 8);
  on(4, 4);on(4, 5);on(5, 4);on(5, 5);
  on(7, 2);on(7, 7);
  on(8, 3);on(8, 4);on(8, 5);on(8, 6);
  delay(1000);
}
void lol()
{
  on(1,1);on(1,2);on(1,3);on(1,4);on(1,5);on(1,6);on(1,7);on(1,8);
  on(2,1);on(2,3);on(2,6);on(2,8);
  on(3,1);on(3,2);on(3,7);on(3,8);
  on(4,1);on(4,8);
  on(5,1);on(5,3);on(5,4);on(5,5);on(5,6);on(5,8);
  on(6,1);on(6,3);on(6,6);on(6,8);
  on(7,1);on(7,3);on(7,6);on(7,8);
  on(8,1);on(8,2);on(8,3);on(8,4);on(8,5);on(8,6);on(8,7);on(8,8);
  
  delay(1000);
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

