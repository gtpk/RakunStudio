/**************************************************************
 * Infrared remote control decoding
 * Experiment Description: parsing the remote control key
 ****************************************************************/

#include <IRremote.h>

int RECV_PIN = 11;   //IR receiver OUTPUT terminated at pin 11
IRrecv irrecv(RECV_PIN);   // Define IRrecv object to receive infrared signals
decode_results  results;   //Decoding results on decode_results constructed object results in

void setup(){
  
  Serial.begin(9600);
  irrecv.enableIRIn(); // Start IR decoding   
  
}

void loop() {
  
  if (irrecv.decode(&results))  {        //Decoding is successful, the group received an infrared signal 
    Serial.print("irCode: ");  
    Serial.print(results.value,HEX);    // Output IR decoding results (hexadecimal)
    //results.value is unsigned long type, header files have introduced
    delay(100);   //Key debounce
    Serial.print(",  bits: ");         
    Serial.println(results.bits);
    // Infrared symbol digit  
    irrecv.resume();
  }   
  
}


