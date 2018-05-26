
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
    Serial.println(r);
    
    digitalWrite(BIred,LOW);
    Serial.println("BIred OFF");
    digitalWrite(BIgreen,LOW);
    Serial.println("BIgreen OFF");
    digitalWrite(RGBgreen,HIGH);
    Serial.println("RGBgreen HIGH");
    digitalWrite(RGBred,HIGH);
    Serial.println("RGBred HIGH");
    //digitalWrite(RGBblue,HIGH);
    digitalWrite(LED,HIGH);
    Serial.println("LED HIGH");
    delay(500);

    digitalWrite(RGBgreen,LOW);
    Serial.println("RGBgreen LOW");
    digitalWrite(RGBred,LOW);
    Serial.println("RGBred LOW");
    digitalWrite(RGBblue,LOW);
    Serial.println("RGBblue LOW");
    digitalWrite(LED,LOW);
    Serial.println("LED OFF");
    delay(500);
    }
  }
  }


void start(){
    digitalWrite(RGBred,HIGH);
    Serial.println("RGBred HIGH");
    digitalWrite(BIred,HIGH);
    Serial.println("BIred HIGH");
    delay(10000);
    digitalWrite(RGBred,LOW);
    Serial.println("RGBred LOW");
    digitalWrite(BIred,LOW);
    Serial.println("BIred LOW");
  }
void cars(){
  eqK();
  digitalWrite(RGBred,HIGH);
  Serial.println("RGBred HIGH");
  eqK();
  rightG();
  eqK();
  digitalWrite(LED,LOW); 
  Serial.println("LED LOW"); 
  //blink green while red 
  eqK();
  digitalWrite(RGBred,LOW);
  Serial.println("RGBred LOW");
  eqK();
  digitalWrite(RGBgreen,HIGH);
  Serial.println("RGBgreen HIGH");
  for(int i=0;i<30;i++){
    eqK();
    digitalWrite(RGBgreen,HIGH);
    Serial.println("RGBgreen HIGH");
    delay(500); 
    
  }  
  
  eqK();
  digitalWrite(RGBred,HIGH);
  Serial.println("RGBred HIGH");
  eqK();
  delay(3000);
  eqK();
  digitalWrite(RGBgreen,LOW);
  Serial.println("RGBgreen LOW");
  eqK();  
  }

void rightG(){  
  for(int i=0;i<10;i++){
    eqK();
    if(i==1){
      tone(Buzzer,150);
      digitalWrite(BIred,LOW);
      Serial.println("BIred LOW");
      digitalWrite(BIgreen,HIGH);
      Serial.println("BIgreen HIGH");
      eqK();
      }
    if(i==9){
      eqK();
      digitalWrite(BIgreen,LOW);
      Serial.println("BIgreen LOW");
      digitalWrite(BIred,HIGH);
      Serial.println("BIred HIGH");
      tone(Buzzer,300);
      }
    digitalWrite(LED,HIGH);
    Serial.println("LED HIGH");
    delay(500);
    eqK();
    digitalWrite(LED,LOW);
    Serial.println("LED LOW"); 
    delay(500); 
  }
  eqK();
}


