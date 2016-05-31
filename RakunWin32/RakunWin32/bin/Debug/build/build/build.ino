int Delay_4_0=5;
int SimpleLED_3_1=HIGH;
int SimpleLED_3_0=13;
int flame_2_0=4;
int flame_2_1;
void setup()
{
    pinMode(flame_2_0,INPUT);
    pinMode(SimpleLED_3_0,OUTPUT);
    
}
void loop()
{
    flame_2_1=digitalRead(flame_2_0);
    SimpleLED_3_1=flame_2_1;
    digitalWrite(SimpleLED_3_0,SimpleLED_3_1);
    delay(Delay_4_0);
    
}

