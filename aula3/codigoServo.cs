#include<Servo.h>

Servo servo;
int pos = 0;
#define servoPin 5
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo.attach(servoPin);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available() > 0){
    char comando = Serial.read();
    if(comando == '0'){
      servo.write(0);
    }
    if(comando == '1'){
      servo.write(90);
    }
    if(comando == '2'){
      servo.write(180);
    }
  }
}
