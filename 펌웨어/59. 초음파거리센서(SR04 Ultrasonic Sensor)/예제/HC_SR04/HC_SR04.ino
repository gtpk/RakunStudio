/***********************************
 * Ultrasonic Ranging 
 * Ultrasonic distance measurement, serial display
 * BY YFROBOT
 ************************************/
 
const int TrigPin = 2; 
const int EchoPin = 3; 
float cm; 

void setup() 
{ 
  Serial.begin(9600); 
  pinMode(TrigPin, OUTPUT); 
  pinMode(EchoPin, INPUT); 
}

void loop() 
{ 
  digitalWrite(TrigPin, LOW); //Low-high-low-fat one short pulse to TrigPin 
  delayMicroseconds(2); 
  digitalWrite(TrigPin, HIGH); 
  delayMicroseconds(10); 
  digitalWrite(TrigPin, LOW); 

  cm = pulseIn(EchoPin, !(LOW)) / 58.0; //Echo time will be converted into cm
  cm = (int(cm * 100.0)) / 100.0; //Two decimal places
  Serial.print(cm); 
  Serial.print("cm"); 
  Serial.println(); 
  delay(1000); 
} 




