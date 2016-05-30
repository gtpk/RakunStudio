int Led=13; // defined LED pin
int button=3; // definded button
int val;

void setup(){
  pinMode(Led,OUTPUT); 
  pinMode(button,INPUT);
}

void loop(){
  val=digitalRead(button);
  if(val==HIGH){ //When the module detects a signal, LED flashes
    digitalWrite(Led,HIGH);
  }else{
    digitalWrite(Led,LOW);
  }
}
