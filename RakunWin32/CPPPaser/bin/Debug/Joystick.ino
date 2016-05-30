int sensorPin = 7; // Z-axis pin number
int value = 0;

void setup() { 
  pinMode(7, OUTPUT); 
  Serial.begin(9600); 
} 

void loop() { 
  value = analogRead(0); // X-axis read analog pin 0
  Serial.print("X:"); 
  Serial.print(value, DEC); 

  value = analogRead(1); // Y-axis read analog pin 0
  Serial.print(" | Y:"); 
  Serial.print(value, DEC); 

  value = digitalRead(7); // Z-axis read digital pin 0
  Serial.print(" | Z: "); 
  Serial.println(value, DEC); 

  delay(100); 
}
