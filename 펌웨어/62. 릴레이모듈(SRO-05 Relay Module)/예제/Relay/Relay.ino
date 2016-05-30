/**************************************************
 * Single relay control experiment 
 * According to the photoresistor sensed light intensity to control light switch 
 * In addition to light here, you can also take other household appliances, according to their needs change 
 * Installed, you need to understand some electrical knowledge, the operation must pay attention to safety!!!
 ***************************************************/

#define Relay 9      
#define Photoresistance A1
int Val = 0;         

void setup()
{
  pinMode(Relay, OUTPUT);   
}

void loop(){

  Val = analogRead(Photoresistance);      

  if(Val<150){             
    digitalWrite(Relay,HIGH);
  }
  else{
    digitalWrite(Relay,LOW);
  }
  delay(10);               
}






