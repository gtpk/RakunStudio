int Led=13; // defined LED pin
int sensor=3; // definded sensor
int val;

void setup(){
  pinMode(Led,OUTPUT); 
  pinMode(sensor,INPUT);
  //Serial.begin(9600);
}

void loop(){
  val=digitalRead(sensor);
  //Serial.println(val);
  if(val==HIGH){ //When the module detects a signal, LED flashes
    digitalWrite(Led,HIGH);
  }else{
    digitalWrite(Led,LOW);
  }
}
