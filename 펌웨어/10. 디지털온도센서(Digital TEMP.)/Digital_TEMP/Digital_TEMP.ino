int sensorPin = 3; // Z-axis pin number
int value = 0;

void setup() { 
  pinMode(sensorPin, OUTPUT); 
  Serial.begin(9600); 
} 

void loop() { 
  value = digitalRead(sensorPin); // Z-axis read digital pin 0
  Serial.print("TEMP : "); 
  Serial.println(value, DEC); 

  delay(100); 
}
