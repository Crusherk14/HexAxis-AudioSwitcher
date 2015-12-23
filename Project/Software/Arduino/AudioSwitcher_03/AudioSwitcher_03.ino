//Libraries
#include <Event.h>
#include <Timer.h>

//Variables
bool ConnectionState = false; //True - Connected, False - No connection

//Timers
int SyncTimer;
int DisconnectTimer;

//Timers from library Timer.h
Timer t;    //Sync timer
Timer t2;   //Disconnect timer

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Setup

void setup()
{
  pinMode(7,OUTPUT);  //Yellow
  pinMode(8,OUTPUT);  //Green
  pinMode(9,OUTPUT);  //White
  
  pinMode(10,OUTPUT); //LED

  //Initializing Serial Connection
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
    //Refreshing timers
    t.update();
    t2.update();

    //Sending connection request
    Serial.println("CR HA_AS_001"); //Connection Request to HexAxis_AudioSwitcher_v0.0.1

    //Led blink
    digitalWrite(10,HIGH);
    delay(50);
    digitalWrite(10,LOW);

    //Waiting for answer
    delay(300);
    if (Serial.available())
    {
      String value = Serial.readString();
      value.trim();

      //Connection confirmation
      if (value == "CC") //Confirm Connection
      {
        Serial.println("CV"); //Connection validated
        ConnectionState = true;
        SyncTimer = t.after(5000, Sync);
      }
    }
  }

  //Refreshing timers
  t.update();
  t2.update();
  digitalWrite(10,HIGH);

  //Recieving Commands
  if (Serial.available())
  {
    String value = Serial.readStringUntil('x');
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

