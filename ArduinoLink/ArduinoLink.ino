//Arduino 控制面板兼讀取資料
void(* resetFunc) (void) = 0;
byte LEDpin = 13;
byte Vin=A0;
float temp=0,voltage=0;
byte control;
void setup() 
{
     pinMode(LEDpin, OUTPUT); 
     pinMode(Vin,INPUT);//A0當作電壓輸入腳，需接上<5V電壓及GND，未接上會顯示浮動電壓的3.04倍值
     for (int i=2;i<=4;i++){  //2~4腳為電壓控制面板腳，先歸1啟動時不做任何動作，進入loop後透過VB控制增減及切換模式
      pinMode(i,OUTPUT);
      digitalWrite(i,HIGH);
     }
     Serial.begin(9600);//通訊速度9600
}
 
void loop() 
{    

    if (Serial.available()){
     control = Serial.read();
     if (control=='m'){
      digitalWrite(2,LOW);
      delay(500);
      digitalWrite(2,HIGH);
     }       
     if (control=='u'){
      digitalWrite(3,LOW);
      delay(500);
      digitalWrite(3,HIGH);
     }       
     if (control=='d'){
      digitalWrite(4,LOW);
      delay(500);
      digitalWrite(4,HIGH);
     }   
     if (control=='x'){
      resetFunc(); 
      delay(100);         
     }
    }
     //以上為對各輸入腳進行觸及的動作
     
  
     temp=analogRead(Vin)*15.2;//電壓讀取
     float voltage =temp /1023;//電壓計算
     Serial.println(voltage);//顯示電壓
     digitalWrite(LEDpin,HIGH);
     delay(100);
     digitalWrite(LEDpin,LOW);
     delay(900);     
}     
 
 
