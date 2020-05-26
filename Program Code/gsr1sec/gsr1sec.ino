void setup(){
  Serial.begin(9600);
}

void loop(){
  long sum = 0;
  for(int i = 0; i < 10; i++ ) {
    int sensorValue=analogRead( A0 );
    sum += sensorValue;
    delay(100);
  }
  Serial.println( sum / 10.0 );
}
