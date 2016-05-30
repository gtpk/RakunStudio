/************************************************
 * Temperature alarm reminder 
 * Temperature is 20 ℃ ~ 30 ℃, green light; 
 * Temperature is 30 ℃ ~ 40 ℃, the yellow light; 
 * Temperature is below 20 ℃ and above 40 ℃, the red light
 *************************************************/
 
int led_green=9;
int led_yellow=10;
int led_red=11;
int sensorPin =A5; 

void setup(){ 
  
  for(int j=9;j<=11;j++){
    pinMode(j,OUTPUT); //Red, green and yellow connector pin set to output mode
  }
  
}

void loop(){ 
  
  int sensorValue;

  while(1) 
  {
    sensorValue=analogRead(sensorPin);//Read voltage value of the temperature sensor 
    if(sensorValue>41&&sensorValue<61)//Temperature is 20 ℃ ~ 30 ℃, the green light 
    { 
      digitalWrite(led_green,HIGH);//Green On
      digitalWrite(led_yellow,LOW);//Yellow Off
      digitalWrite(led_red,LOW);//Red Off
    } 
    else if(sensorValue>=61&&sensorValue<81)//Temperature is 30 ℃ ~ 40 ℃, the yellow light
    { 
      digitalWrite(led_yellow,HIGH);//Yellow On
      digitalWrite(led_green,LOW);//Green Off
      digitalWrite(led_red,LOW);//Red Off
    } 
    else// Temperature is below 20 ℃ and above 40 ℃, the red light
    {
      digitalWrite(led_red,HIGH);//Red On
      digitalWrite(led_yellow,LOW);//Yellow Off
      digitalWrite(led_green,LOW);//Green Off
    }
  }
}


