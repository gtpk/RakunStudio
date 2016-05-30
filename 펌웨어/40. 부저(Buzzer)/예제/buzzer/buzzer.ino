int buzzer=13;

void setup() { 
  
  pinMode(buzzer,OUTPUT);
  
}

void loop() {
  
  unsigned char i,j;
  
  while(1) 
  { 
    
    for(i=0;i<80;i++)
    { 
      digitalWrite(buzzer,HIGH);//Sound on 
      delay(1);//wait 1ms 
      digitalWrite(buzzer,LOW);//Sound off
      delay(1);//wait 1ms 
    } 
    
    for(i=0;i<100;i++)//Another output sound frequency
    { 
      digitalWrite(buzzer,HIGH);//Sound on 
      delay(2);//wait 2ms 
      digitalWrite(buzzer,LOW);//Sound off 
      delay(2);//wait 2ms 
    } 
  } 
}



