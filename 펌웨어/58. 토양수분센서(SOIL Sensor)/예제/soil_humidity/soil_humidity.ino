/**************************************************
 * Soil moisture Reminder 
 * When the soil moisture reaches a certain level, light led, owner watering tips
 * BY YFRobot
 ***************************************************/

#define ledPin 12      
#define humidityPin 10     
int Value = 0;

void setup() { 
  
  pinMode(ledPin,OUTPUT);  
  pinMode(humidityPin,INPUT);
}

void loop() 
{ 
  
  Value = digitalRead(humidityPin);
  

  if(Value == LOW) {
    digitalWrite(ledPin,HIGH);
  }
  else { 
    digitalWrite(ledPin,LOW); 
  }
}



