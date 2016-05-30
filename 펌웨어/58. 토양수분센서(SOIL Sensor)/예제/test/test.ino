int humidityPin = A0;
int sensorVal ;

void setup(){

  Serial.begin(9600);
}

void loop(){

  sensorVal = analogRead(humidityPin);
  Serial.print("soil moisture:");
  Serial.println(sensorVal);

  if(sensorVal < 350 && sensorVal >= 0)  
    Serial.print("No water");

  else if(sensorVal < 500 && sensorVal >= 350)   
    Serial.print("Little water"); 

  else if( sensorVal >= 500)  
    Serial.print("More water");
  delay(800);  
}




