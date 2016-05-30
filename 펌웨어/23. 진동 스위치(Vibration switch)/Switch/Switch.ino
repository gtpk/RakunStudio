int Led=13; // defined LED pin
int Switch=3; // definded Switch
int val;

void setup(){
  pinMode(Led,OUTPUT); 
  pinMode(Switch,INPUT);
}

void loop(){
  val=digitalRead(Switch);
  if(val==HIGH){ //When the module detects a signal, LED flashes
    digitalWrite(Led,LOW);
  }else{
    digitalWrite(Led,HIGH);
  }
}
