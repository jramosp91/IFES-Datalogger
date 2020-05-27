void ISR_Timer1Handler(void)
{ 
//Serial.print("number of pulses channel 1: ");
  Serial.print(revs1);
  Serial.print("H");
//Serial.print("number of pulses channel 2: ");
  Serial.print(revs2);
  Serial.print("I");
//Serial.print("number of pulses channel 3: ");
  Serial.print(revs3);
  Serial.print("J");
  Serial.println("");
   
}
