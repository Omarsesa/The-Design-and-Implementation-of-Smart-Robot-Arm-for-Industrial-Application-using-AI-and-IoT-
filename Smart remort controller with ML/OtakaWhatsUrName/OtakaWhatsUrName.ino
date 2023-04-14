

#include <LiquidCrystal.h>
#include <AltSoftSerial.h>

AltSoftSerial portOne;
int x1=0,x2=0,x3=0,x4=0,x5=0,x6=0;
LiquidCrystal lcd(22, 24, 26, 28, 30, 32);

int button1=0;
int button2=0;
int button3=0;
int button4=0;
int button5=0;
int button6=0;
int button7=0;
int button8=0;
int button9=0;
int button10=0;
int button11=0;
int button12=0;
int buttonVR=5;
int buttonSave=4;
int buttonStopSaving=3;
int button1Repeating=6;


void setup() 
{
  pinMode(23,INPUT);
    pinMode(25,INPUT);
      pinMode(27,INPUT);
        pinMode(29,INPUT);
          pinMode(31,INPUT);
            pinMode(33,INPUT);
              pinMode(35,INPUT);
                pinMode(37,INPUT);
                  pinMode(39,INPUT);
                    pinMode(41,INPUT);
                      pinMode(43,INPUT);
                        pinMode(45,INPUT);
                         pinMode(4,INPUT);
                         pinMode(3,INPUT);
                         pinMode(5,INPUT);
                         pinMode(2,INPUT);
                    
                    
                        
                          

  lcd.begin(20,4);
 /////
 Serial.begin(9600);
  portOne.begin(9600);
  
  /////(!sERIAL) ANA SHETEHA
  lcd.setCursor(0, 0);
  lcd.print("Remote Mode On");
  lcd.setCursor(14, 3);
  lcd.print("O.Sesa");
  
}

void loop() 
{
  int VarResistance=analogRead(A0);
  button1=digitalRead(25);
  button2=digitalRead(23);
  button3=digitalRead(29);
  button4=digitalRead(27);
  button5=digitalRead(31);
  button6=digitalRead(33);
  button7=digitalRead(37);
  button8=digitalRead(35);
  button9=digitalRead(39);
  button10=digitalRead(41);
  button11=digitalRead(45);
  button12=digitalRead(43);
  buttonVR=digitalRead(5);
  buttonSave=digitalRead(4);
  buttonStopSaving=digitalRead(3);
  button1Repeating=digitalRead(6);
//  lcd.setCursor(0, 1);
//  lcd.print("Speed = ");
//  lcd.print(VarResistance);
// 

  
 if(buttonVR==HIGH)
 {
    lcd.setCursor(0, 2);
    lcd.print("Speed = ");
    lcd.print(VarResistance);
 }
 
  if(button1 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x1 Left ");
 // lcd.print(x1);
  
 // x1++; 
 portOne.println("IA"); 
  delay(VarResistance);
  delay(20);
}   
  if(button2 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x1 Right");
  //lcd.print(x1);
  //x1--;  
  portOne.println("iA");
  delay(VarResistance);
  delay(20);
} 
if(button3 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x2 Down ");
 // lcd.print(x2);
  
 // x2++;  
  portOne.println("KB");
  delay(VarResistance);
  
}   
  if(button4 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x2 Up   ");
 // lcd.print(x2);
  
  //x2--;  
  portOne.println("kB");
  delay(VarResistance);
} 
if(button5 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x3 Up   ");
  //lcd.print(x3);
  //x3++;  
  portOne.println("MC");
  delay(VarResistance);
  delay(32);
}   
  if(button6 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x3 Down ");
  //lcd.print(x3);
  //x3--;  
  portOne.println("mC");
  delay(VarResistance);
  delay(32);
} 
if(button7 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x4 Down ");
  //lcd.print(x4);
  
  //x4++;  
  portOne.println("OD");
  delay(VarResistance);
  delay(10);
}   
  if(button8 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x4 Up   ");
  //lcd.print(x4);
  //x4--;  
  portOne.println("oD");
  delay(VarResistance);
  delay(10);
} 
if(button9 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x5 Right");
 // lcd.print(x5);
  //x5++;  
   portOne.println("QE");
  delay(VarResistance);
  delay(15);
}   
  if(button10 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x5 Left ");
  //lcd.print(x5);
  //x5--;  
   portOne.println("qE");
  delay(VarResistance);
  delay(15);

} 
  if(button11 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x6 Open ");
  //lcd.print(x6);
  
  //x6++;  
   portOne.println("SF");
  delay(VarResistance);
  delay(5);
}   
  if(button12 == HIGH)
{
  //lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("x6 Close ");
  //lcd.print(x6);
  //x6--;  
   portOne.println("sF");
  delay(VarResistance);
  delay(5);
} 
if(buttonSave==HIGH)
{
  lcd.setCursor(0, 1);
  lcd.print("Saving    "); 
   portOne.println("X");
}

if(buttonStopSaving==HIGH)
{
  lcd.setCursor(0, 1);
  lcd.print("DataSaved");

   portOne.println("Y");
}
if(button1Repeating==HIGH)
{
  lcd.setCursor(0, 1);
  lcd.print("Repeating");

   portOne.println("Z");
}


    
}

