#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,16,2);

int humidityPin = A0;
int sensorVal ;

void setup()
{
  lcd.init(); 
  lcd.backlight();
  Serial.begin(9600);
}

void loop(){
  sensorVal = analogRead(humidityPin);
  lcd.print("soil moisture:");
  lcd.setCursor(0, 1);
  lcd.print(sensorVal);

  if(sensorVal < 350 && sensorVal >= 0){
    lcd.setCursor(4, 1);
    lcd.print("No water");
  }
  else if(sensorVal < 500 && sensorVal >= 350){
    lcd.setCursor(4, 1);
    lcd.print("Little water"); 
  }
  else if( sensorVal >= 500){
    lcd.setCursor(4, 1);
    lcd.print("More water");
  }
  delay(800);
  lcd.clear();    
}




