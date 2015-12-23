//Libraries
#include <Event.h>
#include <Timer.h>

//Variables
String value;
char command;
bool ConnectionState = false;
int SyncTimer;
int DisconnectTimer;
int DefaultTimer;

Timer t;    //Timer from library Timer.h
Timer t2;   //Disconnect timer

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Setup

void setup()
{
  pinMode(7,OUTPUT);
  pinMode(8,OUTPUT);
  pinMode(9,OUTPUT);
  pinMode(10,OUTPUT); //LED
  
  Serial.begin(9600);
  Serial.setTimeout(100);
}

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Update

void loop()
{
  //Checking connection
  while (ConnectionState == false)
  {
    t.update();
    t2.update();
    
    Serial.println("CR HA_AS_001"); //Connection Request to HexAxis_AudioSwitcher_v0.0.1
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
        SyncTimer = t.after(5000, Sync);
      }
    }
  }

  //Refreshing timer
  t.update();
  t2.update();
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

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Syncronisation

void Sync()
{
  t.stop(SyncTimer);
  Serial.println("sync");
  DisconnectTimer = t2.after(5000, Disconnect);
  return;
}

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Connection lost

void Disconnect()
{
   t2.stop(DisconnectTimer);
   ConnectionState = false;

   //Default settings
   //SP - PC
     digitalWrite(7,LOW);
     digitalWrite(9,LOW);
     
  //HP - TV
     digitalWrite(8,LOW);
     
   return;
}

