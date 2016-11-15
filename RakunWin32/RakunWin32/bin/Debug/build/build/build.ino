int IFEqual_2_1=0;
int IFEqual_2_0=0;
int flame_5_0=4;
int SimpleLED_3_0=13;
int SimpleLED_3_1=HIGH;
void setup()
{
    pinMode(SimpleLED_3_0,OUTPUT);
    pinMode(flame_5_0,INPUT);
    
}
void loop()
{
    digitalWrite(SimpleLED_3_0,SimpleLED_3_1);
    IFEqual_2_0=SimpleLED_3_1;
    IFEqual_2_1=LOW;
    if(IFEqual_2_0==IFEqual_2_1)
    {
        flame_5_1=LOW;
        flame_5_1=digitalRead(flame_5_0);
        
    }
    else
    {
        
    }
    
}

