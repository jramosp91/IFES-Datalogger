void Pulso_2() {

  if (estadoPulso2 == ALTO)
  {
    if (pulseState2 == LOW)
    {
      estadoPulso2 = BAJO;
      pulseCounter2++;
    }
  }
if (estadoPulso2 == BAJO)
  {
    if (pulseState2 == HIGH)
    {
      estadoPulso2 = ALTO;
    }
  }

  
}
