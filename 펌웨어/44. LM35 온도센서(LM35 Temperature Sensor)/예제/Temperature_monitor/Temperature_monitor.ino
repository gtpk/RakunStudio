/*******************************
 * Real-time temperature measurement temperature sensor 
 * Serial Monitor to observe real-time temperature
 ******************************/
 
const int sensorPin =A5; 
int sensorValue;
double temperatureValue;

void setup(){
  
  Serial.begin(9600);
  
}

void loop()
{
  
  //Read out the value of the temperature sensor
  sensorValue = analogRead(sensorPin);
  Serial.print("sensor = " );
  Serial.print(sensorValue);
  
  //Translation of the temperature value
  temperatureValue =(sensorValue*0.488758553);
  Serial.print("temperature = " );
  Serial.println(temperatureValue);
  delay(1000);
  
}



