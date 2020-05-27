#include <TimerOne.h>
#define BAJO  0
#define ALTO  1


int pulseCounter1 = 0;
int estadoPulso1 = ALTO;
int pulseCounter2 = 0;
int estadoPulso2 = ALTO;
int pulseCounter3 = 0;
int estadoPulso3 = ALTO;

float revs1 = pulseCounter1 / 1000.0;
float revs2 = pulseCounter2 / 1000.0;
float revs3 = pulseCounter3 / 1000.0;

///Entradas de pines de pulsos de los ritter
int pulseState1 = digitalRead(2);
int pulseState2 = digitalRead(3);
int pulseState3 = digitalRead(4);

///Funciones
void ISR_Timer1Handler(); // Contador General por interrupcion
void Pulso_1(); // Contador Pulso 1
void Pulso_2(); // Contador Pulsto 2
void Pulso_3(); // COntador Pulso 3

//Serial
void Recepcion_Serial(); // recepcion de dato serial

String mySt;



void setup() {
  // initialize the button pin as a input:
  pinMode(2, INPUT);
  pinMode(3, INPUT);
  pinMode(4, INPUT);
  // initialize serial communication:
  Serial.begin(9600);
  Timer1.initialize(1000000); //Dispara cada 1 seg
  Timer1.attachInterrupt(ISR_Timer1Handler); // Activa la interrupcion y la asocia a la ISR
   }

void loop() {

Recepcion_Serial();
Pulso_1();
Pulso_2();
Pulso_3();

}
