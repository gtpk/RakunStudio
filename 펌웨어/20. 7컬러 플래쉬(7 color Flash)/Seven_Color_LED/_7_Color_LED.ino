int LED = 13; // Select digital pin of a LED

void setup() { 
  pinMode(LED,OUTPUT); // defined port
} 

void loop() { 
  digitalWrite(LED,HIGH); // LED on
  delay(2000); 
  digitalWrite(LED,LOW); // LED off 
  delay(2000); 
}
