/*********************
 * Joystick control 
 ************************/
int X,Y,K;

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  X = analogRead(A0);
  Y = analogRead(A1);
  K = analogRead(A3);
  Serial.print("X=");
  Serial.print(X,DEC);
  Serial.println("Y=");
  Serial.print(Y,DEC);
  Serial.println("K=");
  Serial.print(K,DEC);
  delay(1000);
}

