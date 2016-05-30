int Delay_12_0=5;
int IFEqual_3_1=0;
int IFEqual_3_0=0;
int SimpleLED_5_1=HIGH;
int SimpleLED_5_0=13;
int SimpleLED_4_1=HIGH;
int SimpleLED_4_0=13;
int flame_2_0=4;
int flame_2_1;
void setup()
{
    pinMode(flame_2_0,INPUT);
    pinMode(SimpleLED_5_0,OUTPUT);
    pinMode(SimpleLED_4_0,OUTPUT);
    
}
void loop()
{
    flame_2_0=4;
    flame_2_1=digitalRead(flame_2_0);
    IFEqual_3_0=flame_2_1;
    IFEqual_3_1=HIGH;
    if(IFEqual_3_0==IFEqual_3_1)
    {
        SimpleLED_5_0=13;
        SimpleLED_5_1=HIGH;
        digitalWrite(SimpleLED_5_0,SimpleLED_5_1);
        
    }
    else
    {
        SimpleLED_4_0=13;
        SimpleLED_4_1=LOW;
        digitalWrite(SimpleLED_4_0,SimpleLED_4_1);
        
    }
    Delay_12_0=500;
    delay(Delay_12_0);
    
}

