#include <Event.h>
#include <Timer.h>


String value;
char command;
bool ConnectionState = false;
int SyncTimer;
int DisconnectTimer;
int DefaultTimer;
Timer t;    //Timer from library Timer.h
Timer t2;   //Disconnect timer
Timer t3;   //Defaults timer

void setup()
{
  pinMode(7,OUTPUT);
  pinMode(8,OUTPUT);
  pinMode(9,OUTPUT);
  pinMode(10,OUTPUT); //LED
  
  Serial.begin(9600);
  Serial.setTimeout(100);
}

void loop()
{
  //Checking connection
  while (ConnectionState == false)
  {
    t.update();
    t2.update();
    t3.update();
    
    Serial.println("CR HA_AS_001"); //Connection Request HexAxis_AudioSwitcher_v0.0.1
    digitalWrite(10,HIGH);
    delay(50);
    digitalWrite(10,LOW);
    delay(300);
    if (Serial.available())
    {
      value = Serial.readString();
      value.trim();

      if (value == "CC") //Confirm Connection
      {
        Serial.println("CV"); //Connection validated
        ConnectionState = true;
        t3.stop(DefaultTimer);
        SyncTimer = t.after(5000, Sync);
      }
    }
  }

  //Refreshing timer
  t.update();
  t2.update();
  t3.update();
  digitalWrite(10,HIGH);

  //Recieving commands
  if (Serial.available())
  {
    value = Serial.readStringUntil('x');
    value.trim();
    
    //7pin-yellow(SP-nothing/SP-all)
    //8pin-green (HP-all/HP-TV)
    //9pin-white (PC-all/PCTV-all)
    
    if (value == "SP0")
    {
     //SP off
    digitalWrite(7,HIGH);
    }
    
    if (value == "SP1")
    {
     //SP - PC
     digitalWrite(7,LOW);
     digitalWrite(9,LOW);
    }
    
    if (value == "SP2")
    {
     //SP - PCTV
    digitalWrite(7,LOW);
    digitalWrite(9,HIGH);
    }
    
    if (value == "HP1")
    {
     //HP - PC
     digitalWrite(9,LOW);
     digitalWrite(8,HIGH);
    }
    
    if (value == "HP2")
    {
     //HP - PCTV
    digitalWrite(9,HIGH);
    digitalWrite(8,HIGH);
    }
    
    if (value == "HP3")
    {
     //HP - TV
     digitalWrite(8,LOW);
    }
    
    //Synchronisation timer
    if (value == "sync")
    {
      t2.stop(DisconnectTimer);
      SyncTimer = t.after(5000, Sync);
    }
    value= " ";
  }
  //delay(25);

}

void Sync()
{
  t.stop(SyncTimer);
  Serial.println("sync");
  DisconnectTimer = t2.after(5000, Disconnect);
  return;
}

void Disconnect()
{
   t2.stop(DisconnectTimer);
   ConnectionState = false;
   DefaultTimer =t3.after(10000,ReturnDefaults);
   return;
}

void ReturnDefaults()
{
  //SP - PC
     digitalWrite(7,LOW);
     digitalWrite(9,LOW);
     
  //HP - TV
     digitalWrite(8,LOW);
     
return;
}

