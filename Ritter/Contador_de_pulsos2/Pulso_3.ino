void Pulso_3() {
if (estadoPulso3 == ALTO)
  {
    if (pulseState3 == LOW)
    {
      estadoPulso3 = BAJO;
      pulseCounter3++;
    }
  }
 if (estadoPulso3 == BAJO)
  {
    if (pulseState3 == HIGH)
    {
      estadoPulso3 = ALTO;
    }
  }
  
}
