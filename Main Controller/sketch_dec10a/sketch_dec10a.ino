#include <AltSoftSerial.h>
AltSoftSerial portOne;

boolean x0=false;
boolean x1=false;
boolean x2=false;
boolean x3=false;
boolean x4=false;
boolean x5=false;
boolean x6=false;
boolean x7=false;
boolean x8=false;
boolean x9=false;
boolean x10=false;


void setup()
{
  portOne.begin(9600);
  Serial.begin(115200);
  pinMode(13,OUTPUT);
  pinMode(12,OUTPUT);
  pinMode(11,OUTPUT);
  pinMode(10,OUTPUT);
  pinMode(9,OUTPUT);
  pinMode(8,OUTPUT);
  pinMode(7,OUTPUT);
  ///////////////

  //////////////
  
  pinMode(22,OUTPUT);
  pinMode(23,OUTPUT);
  pinMode(24,OUTPUT);
  pinMode(25,OUTPUT);
  pinMode(26,OUTPUT);
  pinMode(27,OUTPUT);
  pinMode(28,OUTPUT);
  pinMode(29,OUTPUT);
  pinMode(30,OUTPUT);
  pinMode(31,OUTPUT);
  pinMode(32,OUTPUT);
  pinMode(33,OUTPUT);
  pinMode(34,OUTPUT);
  ////////////////
  pinMode(38,INPUT);
  pinMode(39,INPUT);
  pinMode(40,INPUT);
  pinMode(41,INPUT);
  pinMode(42,INPUT);
  pinMode(43,INPUT);
  pinMode(44,INPUT);
  pinMode(45,INPUT);
  pinMode(50,INPUT);
  pinMode(51,INPUT);
  pinMode(52,INPUT);
  
}
void loop ()
{
  char c;
  if (portOne.available()) {
  c = portOne.read();
  //Serial.print(c);
  
  }
  char data = Serial.read();
  
  ////// feh 3aek kter we lazm nshof el inByte
 
 
  switch (c)
  {
    case'A':
   if(digitalRead(38)==LOW & x0==false){ 
    digitalWrite(13,LOW) ;
    digitalWrite(13,HIGH) ;
    Serial.println("iA");
  }
   if(digitalRead(39)==LOW & x0==true )
    {digitalWrite(13,LOW) ;
    digitalWrite(13,HIGH) ;
    Serial.println("IA");
  }
    break;
    case'B':
    if(digitalRead(40)==LOW & x1==false){ 
    digitalWrite(12,LOW) ;
    digitalWrite(12,HIGH) ;
    Serial.println("kB");
  }
   if(digitalRead(41)==LOW & x1 ==true )
    {digitalWrite(12,LOW) ;
    digitalWrite(12,HIGH) ;
    Serial.println("KB");
  }
    break;
    case'C':
    if(digitalRead(42)==LOW& x2==false){ 
    digitalWrite(11,LOW) ;
    digitalWrite(11,HIGH) ;
    Serial.println("mC");
  }
   if(digitalRead(43)==LOW& x2==true )
    {digitalWrite(11,LOW) ;
    digitalWrite(11,HIGH) ;
  Serial.println("MC");}
    break;
    case'D':
    if(digitalRead(44)==LOW& x3==false){ 
    digitalWrite(10,LOW) ;
    digitalWrite(10,HIGH) ;
  Serial.println("oD");}
   if(digitalRead(45)==LOW& x3==true )
    {digitalWrite(10,LOW) ;
    digitalWrite(10,HIGH) ;
  Serial.println("OD");}
    break;
    case'E': 
    if(digitalRead(50)==LOW& x4==false){ 
    digitalWrite(9,LOW) ;
    digitalWrite(9,HIGH) ;
  Serial.println("qE");}
   if(digitalRead(51)==LOW& x4 ==true )
    {digitalWrite(9,LOW) ;
    digitalWrite(9,HIGH) ;
  Serial.println("QE");}
    break;
    case'F':  
   if(digitalRead(52)==LOW & x5==true){ 
    digitalWrite(8,LOW) ;
    digitalWrite(8,HIGH) ;
    Serial.println("SF");
   }
   if(x5==false & analogRead(A0)<500){ 
    digitalWrite(8,LOW) ;
    digitalWrite(8,HIGH) ;
    Serial.println("sF");
   }
    break;
    //////////////////////////////
    case'X':  
    Serial.println("X");
    break;
    case'Y':  
    Serial.println("Y");
    break;
    case'Z':  
    Serial.println("Z");
    break;

    
    // Enable
    
    case'H': digitalWrite(23,HIGH);break;
    case'h' : digitalWrite(23,LOW);break;
    case'J': digitalWrite(25,HIGH);break;
    case'j' : digitalWrite(25,LOW);break;
    case'L': digitalWrite(27,HIGH);break;
    case'l' : digitalWrite(27,LOW);break;
    case'N': digitalWrite(29,HIGH);break;
    case'n' : digitalWrite(29,LOW);break;
    case'P': digitalWrite(31,HIGH);break;
    case'p' : digitalWrite(31,LOW);break;
    case'R': digitalWrite(33,HIGH);break;
    case'r' : digitalWrite(33,LOW);break;

     // Direction
    
    case'I': digitalWrite(22,HIGH);x0=true;break;
    case'i' : digitalWrite(22,LOW);x0=false;break;
    case'K': digitalWrite(24,HIGH);x1=true;break;
    case'k' : digitalWrite(24,LOW);x1=false;break;
    case'M': digitalWrite(26,HIGH);x2=true;break;
    case'm' : digitalWrite(26,LOW);x2=false;break;
    case'O': digitalWrite(28,HIGH);x3=true;break;
    case'o' : digitalWrite(28,LOW);x3=false;break;
    case'Q': digitalWrite(30,HIGH);x4=true;break;
    case'q' : digitalWrite(30,LOW);x4=false;break;
    case'S': digitalWrite(32,HIGH);x5=true;break;
    case's' : digitalWrite(32,LOW);x5=false;break;

    
  
  }
 
  switch (data)
  {
    
    case'A':
   if(digitalRead(38)==LOW & x0==false){ 
    digitalWrite(13,LOW) ;
    digitalWrite(13,HIGH) ;}
   if(digitalRead(39)==LOW & x0==true )
    {digitalWrite(13,LOW) ;
    digitalWrite(13,HIGH) ;}
    break;
    case'B':
    if(digitalRead(40)==LOW & x1==false){ 
    digitalWrite(12,LOW) ;
    digitalWrite(12,HIGH) ;}
   if(digitalRead(41)==LOW & x1 ==true )
    {digitalWrite(12,LOW) ;
    digitalWrite(12,HIGH) ;}
    break;
    case'C':
    if(digitalRead(42)==LOW& x2==false){ 
    digitalWrite(11,LOW) ;
    digitalWrite(11,HIGH) ;}
   if(digitalRead(43)==LOW& x2==true )
    {digitalWrite(11,LOW) ;
    digitalWrite(11,HIGH) ;}
    break;
    case'D':
    if(digitalRead(44)==LOW& x3==false){ 
    digitalWrite(10,LOW) ;
    digitalWrite(10,HIGH) ;}
   if(digitalRead(45)==LOW& x3==true )
    {digitalWrite(10,LOW) ;
    digitalWrite(10,HIGH) ;}
    break;
    case'E': 
    if(digitalRead(50)==LOW& x4==false){ 
    digitalWrite(9,LOW) ;
    digitalWrite(9,HIGH) ;}
   if(digitalRead(51)==LOW& x4 ==true )
    {digitalWrite(9,LOW) ;
    digitalWrite(9,HIGH) ;}
    break;
    case'F':   
      if(digitalRead(52)==LOW & x5==true){ 
    digitalWrite(8,LOW) ;
    digitalWrite(8,HIGH) ;
   }
   if(x5==false & analogRead(A0)<500){ 
    digitalWrite(8,LOW) ;
    digitalWrite(8,HIGH) ;
   }

    
    // Enable
    
    case'H': digitalWrite(23,HIGH);break;
    case'h' : digitalWrite(23,LOW);break;
    case'J': digitalWrite(25,HIGH);break;
    case'j' : digitalWrite(25,LOW);break;
    case'L': digitalWrite(27,HIGH);break;
    case'l' : digitalWrite(27,LOW);break;
    case'N': digitalWrite(29,HIGH);break;
    case'n' : digitalWrite(29,LOW);break;
    case'P': digitalWrite(31,HIGH);break;
    case'p' : digitalWrite(31,LOW);break;
    case'R': digitalWrite(33,HIGH);break;
    case'r' : digitalWrite(33,LOW);break;

     // Direction
    
    case'I': digitalWrite(22,HIGH);x0=true;break;
    case'i' : digitalWrite(22,LOW);x0=false;break;
    case'K': digitalWrite(24,HIGH);x1=true;break;
    case'k' : digitalWrite(24,LOW);x1=false;break;
    case'M': digitalWrite(26,HIGH);x2=true;break;
    case'm' : digitalWrite(26,LOW);x2=false;break;
    case'O': digitalWrite(28,HIGH);x3=true;break;
    case'o' : digitalWrite(28,LOW);x3=false;break;
    case'Q': digitalWrite(30,HIGH);x4=true;break;
    case'q' : digitalWrite(30,LOW);x4=false;break;
    case'S': digitalWrite(32,HIGH);x5=true;break;
    case's' : digitalWrite(32,LOW);x5=false;break;

    
  
  }

}

