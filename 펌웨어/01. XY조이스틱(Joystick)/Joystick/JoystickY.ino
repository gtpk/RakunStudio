int sensorPin = 7; // Z-axis pin number
int value = 0;

void setup() { 
  pinMode(7, OUTPUT); 
  Serial.begin(9600); 
} 

void loop() { 
  value = analogRead(1); // Y-axis read analog pin 0
}
