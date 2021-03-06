/******************************************
 * Based Arduino 328 Dashboard + Speaker
 *****************************************/
 
int song[] = {

  277,277,415,415,466,466,415,
  370,370,330,330,311,311,277,
  415,415,370,370,330,330,311,
  415,415,370,370,330,330,311,
  277,277,415,415,466,466,415,
  370,370,330,330,311,311,277,

  370,494,466,554,494,370,311,415,330, 
  415,554,494,466,415,370,330,311, 
  370,494,466,554,494,370,311,415,330,
  415,554,494,466,554,659,494,
  622,554,466,415,466,494,415,466,370,
  370,330,370,415,415,554,494,466,
  554,554,466,370,370,330,370,622,494,
  415,466,494,466,554,494,415,370,
  622,554,494,370,311,415,330,
  554,494,466,415,370,
  370,622,554,370,494,466,
  466,415,415,415,554,554,
  622,554,494,370,311,415,330,330,
  554,494,466,415,370,622,311,622,
  740,659,622,554,622,659,
  659,622,622,554,554,494,

};

int noteDurations[] = {

  2,2,2,2,2,2,1,
  2,2,2,2,2,2,1,
  2,2,2,2,2,2,1,
  2,2,2,2,2,2,1,
  2,2,2,2,2,2,1,
  2,2,2,2,2,2,1,

  1,1,2,2,2,2,2,1,2,
  2,1,2,2,2,2,2,1,
  1,1,2,2,2,2,2,1,2,
  2,2,2,1,1,1,1,2,
  2,2,1,2,2,2,2,1,2,
  2,2,2,2,1,1,1,2,
  2,1,2,2,2,2,2,1,2,
  2,2,2,1,1,2,1,2,
  2,2,1,1,2,1,2,
  2,2,1,1,2,2,
  1,1,1,1,1,1,
  2,1,2,1,2,1,2,
  2,2,1,1,2,1,2,2,
  2,2,1,1,1,1,2,1,
  1,1,1,1,2,2,
  1,1,2,1,2,1,

};

int buzzer=9;

void setup() {
}

void loop() {
  
  sing();  
  
}

void sing(){
  
    for (int thisNote = 0; thisNote <154; thisNote++)
  {
    int noteDuration = 1000/noteDurations[thisNote];
    // Calculated for each beat of time, for example one second with a beat
    // Fourth beat is the 1000/4 milliseconds, eighth shot is 1000/8 ms
    tone(buzzer, song[thisNote],noteDuration);
    int pauseBetweenNotes = noteDuration * 1.30; 
    // Pause interval between each note, to 130% of the notes is better
    delay(pauseBetweenNotes);
    noTone(buzzer);
  }
  
}

