int Led=13; // defined LED pin
int sensor=3; // definded sensor
int val;

void setup(){
  pinMode(Led,OUTPUT); 
  pinMode(sensor,INPUT);
}

void loop(){
  val=digitalRead(sensor);
  if(val==HIGH){ //When the module detects a signal, LED flashes.
    digitalWrite(Led,HIGH);
  }else{
    digitalWrite(Led,LOW);
  }
}
