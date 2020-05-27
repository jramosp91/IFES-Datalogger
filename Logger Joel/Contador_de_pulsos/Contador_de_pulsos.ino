#include <TimerOne.h>

#define BAJO  0
#define ALTO  1

unsigned long pulseCounter1 = 0;
int estadoPulso1 = ALTO;

unsigned long pulseCounter2 = 0;
int estadoPulso2 = ALTO;

unsigned long pulseCounter3 = 0;
int estadoPulso3 = ALTO;

char myChar;


void ISR_Timer1Handler(void)
{
  //  //Serial.print("number of pulses channel 1: ");
  //  Serial.print(pulseCounter1);
  //  Serial.print("ritter_1");
  //  //Serial.print("number of pulses channel 2: ");
  //  Serial.print(pulseCounter2);
  //  Serial.print("ritter_2");
  //  //Serial.print("number of pulses channel 3: ");
  //  Serial.print(pulseCounter3);
  //  Serial.print("ritter_3");

float revs1 = pulseCounter1 / 1000.0;
float revs2 = pulseCounter2 / 1000.0;
float revs3 = pulseCounter3 / 1000.0;
    myChar= "";
  
  if (Serial.available() > 0) {
     myChar = Serial.read();
     Serial.read();
   }

  if (myChar == '+') {
    float rst = 1;

    if (rst = 1) {
      revs1=0;
      revs2=0;
      revs3=0;
      pulseCounter1 = 0;
      pulseCounter2 = 0;
      pulseCounter3 = 0;
      rst = 0;

    }
  }

  //Serial.print("number of pulses channel 1: ");
  Serial.print(revs1);
  Serial.print("H");
  //Serial.print("number of pulses channel 2: ");
  Serial.print(revs2);
  Serial.print("I");
  //Serial.print("number of pulses channel 3: ");
  Serial.print(revs3);
  Serial.print("J");
}

void setup()
{
  // initialize the button pin as a input:
  pinMode(2, INPUT);
  pinMode(3, INPUT);
  pinMode(4, INPUT);
  // initialize serial communication:
  Serial.begin(9600);

  Timer1.initialize(100000); //Dispara cada 1 seg
  Timer1.attachInterrupt(ISR_Timer1Handler); // Activa la interrupcion y la asocia a la ISR
}

void loop()
{
  int pulseState1 = digitalRead(2);
  int pulseState2 = digitalRead(3);
  int pulseState3 = digitalRead(4);

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
