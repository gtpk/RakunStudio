int relay = 10; // Select digital pin of relay

void setup() { 
  pinMode(relay,OUTPUT); // defined port
} 

void loop() { 
  digitalWrite(relay,HIGH); // relay on
  delay(1000); 
  digitalWrite(relay,LOW); // relay off 
  delay(1000); 
}
