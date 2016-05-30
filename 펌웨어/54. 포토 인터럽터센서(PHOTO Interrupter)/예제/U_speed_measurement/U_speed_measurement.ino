/************************************************************************
 * Motor speed
 * Note; measured values ​​out of some error, 
   the actual value is greater than the motor shaft 
   because of the code disc and a distance
 ************************************************************************/

//Set the module pin to digital pin 2 (program uses interrupt function, UNO interrupt pin as digital pins 2 and 3)
int U_Pin = 2;    
float Val = 0;    
float time;  
float Speed;  

void setup(){

  Serial.begin(9600);
  attachInterrupt(0,count,CHANGE);    //Trigger pin level changes
}

void loop(){

  time = millis();
  Speed =  (Val/40)/(time/60000) ;
  Serial.println(Speed);
}

void count(){
  Val += 1;
}



