int sensor = 10; // Select digital pin of sensor

void setup() { 
  pinMode(sensor,OUTPUT); // defined port
} 

void loop() { 
  digitalWrite(sensor,HIGH); // sensor on
  delay(1000); 
  digitalWrite(sensor,LOW); // sensor off 
  delay(1000); 
}
