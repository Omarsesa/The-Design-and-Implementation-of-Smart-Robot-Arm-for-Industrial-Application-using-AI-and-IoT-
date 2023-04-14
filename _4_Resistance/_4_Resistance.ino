
void setup() 
{
  Serial.begin(115200); 
}
void loop() 
{
  int sensorValue0 = analogRead(A0);
  int sensorValue1 = analogRead(A1);
  int sensorValue2 = analogRead(A2);
  int sensorValue3 = analogRead(A3);
  int sensorValue4 = analogRead(A4);
  int sensorValue5 = analogRead(A5);
  int SV1 = map(sensorValue1 , 0,1023, 0, 270);
  int SV2 = map(sensorValue2 , 0,1023, 0, 90);
  int SV3 = map(sensorValue3 , 0,1023, 0, 90);
  int SV4 = map(sensorValue4 , 0,1023, 0, 180);
  int SV5 = map(sensorValue5 , 0,1023, 0, 180);
  
  
  
  
  Serial.print("A=");                       
  Serial.println(SV1);    
delay(10);
  Serial.print("B=");                       
  Serial.println(SV2);   
delay(10);
  Serial.print("C=");                        
  Serial.println(SV3);      
delay(10);
  Serial.print("D=");                       
  Serial.println(SV4);        
delay(10);  
  Serial.print("E=");                       
  Serial.println(SV5);   
delay(10);
Serial.print("F=");                       
  Serial.println(sensorValue0);   
delay(10);
}
