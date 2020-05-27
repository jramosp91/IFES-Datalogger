void Pulso_1() {

  if (estadoPulso1 == ALTO)
  {
    if (pulseState1 == LOW)
    {
      estadoPulso1 = BAJO;
      pulseCounter1++;
    }
  }
  if (estadoPulso1 == BAJO)
  {
    if (pulseState1 == HIGH)
    {
      estadoPulso1 = ALTO;
    }
  }

  
}
