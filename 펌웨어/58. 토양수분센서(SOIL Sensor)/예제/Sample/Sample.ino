/*
  # Connect the sensor to the A0(Analog 0) pin on the Arduino board
  
  # the sensor value description
  # 0  ~300     dry soil
  # 300~700     humid soil
  # 700~950     in water
*/

void setup(){
  
  Serial.begin(57600);
  
}

void loop(){
  
  Serial.print("SOIL Sensor Value:");
  Serial.println(analogRead(0));  
  delay(100);
  
}
