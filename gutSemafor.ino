
int RGBblue=10;
int RGBgreen=3;
int RGBred=4;
int BIred=5;
int BIgreen=11;
int LED=6;
int Eqk=A0;
int Buzzer=8;
int Button=9;

void setup()
{
  Serial.begin(115200);
  pinMode(RGBblue,OUTPUT);
  
  pinMode(RGBgreen,OUTPUT);
  
  pinMode(RGBred,OUTPUT);
  
  pinMode(BIred,OUTPUT);
  
  pinMode(LED,OUTPUT);

  pinMode(Eqk,INPUT);

  pinMode(Button,INPUT);
  
  pinMode(Buzzer,OUTPUT);

  pinMode(BIgreen,OUTPUT);
  // initialisation of the serial connection
  start();
}



void loop()
{
  //delay(1000);
  //float r= analogRead(Eqk);
  //Serial.print(r);
  //Serial.println();
  eqK();
  cars();
  //pede();

}



void eqK(){
  float r;
  while((r=analogRead(Eqk))!=0){
    for(int i=0;i<5;i++){
    Serial.println("EarthQ ON");
    digitalWrite(BIred,LOW);
    digitalWrite(BIgreen,LOW);
    digitalWrite(RGBgreen,HIGH);
    digitalWrite(RGBred,HIGH);
    digitalWrite(LED,HIGH);
    delay(500);
    digitalWrite(RGBgreen,LOW);
    digitalWrite(RGBred,LOW);
    digitalWrite(RGBblue,LOW);
    digitalWrite(LED,LOW);
    delay(500);
    }
  }
   Serial.println("EarthQ OFF");
  }


void start(){
    digitalWrite(RGBred,HIGH);
    digitalWrite(BIred,HIGH);
    delay(10000);
    digitalWrite(RGBred,LOW);
    digitalWrite(BIred,LOW);
  }
void cars(){
   Serial.println("CarS RED");
  eqK();
  digitalWrite(RGBred,HIGH);
  eqK();
  rightG();
  eqK();
  digitalWrite(LED,LOW); 
  //blink green while red 
  eqK();
  digitalWrite(RGBred,LOW);
  eqK();
  digitalWrite(RGBgreen,HIGH);
  for(int i=0;i<30;i++){
   Serial.println("Cars GREEN");
    eqK();
    digitalWrite(RGBgreen,HIGH);
    delay(500); 
  }  
  
  
  eqK();
  Serial.println("Cars RED");
  digitalWrite(RGBred,HIGH);
  Serial.println("Cars RED");
  eqK();
  delay(3000);
  eqK();
  digitalWrite(RGBgreen,LOW);
  eqK();  
  }

void rightG(){  
  Serial.print("IntermitentG ON")
  for(int i=0;i<10;i++){
    eqK();
    if(i==1){
      tone(Buzzer,150);
      Serial.println("Pedestrian ON");
      digitalWrite(BIred,LOW);
      digitalWrite(BIgreen,HIGH);
      eqK();
      }
    if(i==9){
      eqK();
      digitalWrite(BIgreen,LOW);
      digitalWrite(BIred,HIGH);
      tone(Buzzer,300);
      Serial.println("Pedestrian OFF");
      }
    digitalWrite(LED,HIGH);
    delay(500);
    eqK();
    digitalWrite(LED,LOW);
    delay(500); 
  }
  eqK();
   Serial.println("IntermitentG OFF");
}


