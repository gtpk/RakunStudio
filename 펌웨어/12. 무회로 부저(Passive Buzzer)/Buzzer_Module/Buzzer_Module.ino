int buzzer=11; 

void setup(){
  pinMode(buzzer,OUTPUT); 
}

void loop(){
  unsigned char i,j;
  while(1){
    for(i=0;i<80;i++){ //A frequency sound
      digitalWrite(buzzer,HIGH);//Buzzer On
      delay(1);
      digitalWrite(buzzer,LOW);//Buzzer Off
      delay(1);
    }
    for(i=0;i<500;i++){
      digitalWrite(buzzer,HIGH);//Buzzer On
      delay(2);
      digitalWrite(buzzer,LOW);//Buzzer Off
      delay(2);
    }
  }
}
