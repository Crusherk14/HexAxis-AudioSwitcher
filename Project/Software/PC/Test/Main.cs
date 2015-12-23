//Hex Axis Audio Switcher

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace AudioSwitcher
{
    public partial class HexAxis : Form
    {
        public HexAxis()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //VARIABLES

        private static SerialPort SP = new SerialPort("COM0", 9600);
        private bool ConnectionState = false;
        private bool mouseDown;
        private int mouseX = 0, mouseY = 0, ctry = 0, porttry = 0, count = 3, synctimer = 30, cooldown = 0;
        private int SPstate = 1, HPstate = 3, SPmemory=1; //States: 0-Nothing, 1-PC, 2-PCTV, 3-TV

        System.Media.SoundPlayer Sound_Hover = new System.Media.SoundPlayer(@"Hover.wav");
        System.Media.SoundPlayer Sound_Error = new System.Media.SoundPlayer(@"Error.wav");


        

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //INITIALIZATION
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Adjusting UPDATE timer
            System.Windows.Forms.Timer TMR = new System.Windows.Forms.Timer();
            TMR.Enabled = true;
            TMR.Interval = 500;
            TMR.Tick += new EventHandler(TMR_Tick);
        }

        //ON CLOSING
        private void HexAxis_FormClosing(object sender, FormClosingEventArgs e)
        {
            NotifyIcon.Visible = false;
            NotifyIcon.Icon = null;
        }

        //UPDATE
        private void TMR_Tick(object sender, EventArgs e)
        {
            if (cooldown>0)
            {
                cooldown -= 1;
                return;
            }

            //Checking connection
            if (ConnectionState==false)
            {
                LabelWrite("Trying to connect to (COM" + porttry + "): " + ctry + " attempt", label4);
                try
                {
                    SP.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    SP.Open();
                    SP.ReadTimeout = 50;
                    SP.WriteTimeout = 50;
                }
                catch (Exception)
                {
                    ctry = 5;
                }
                ctry += 1;
                if (ctry/6>=1)
                {
                    porttry += 1;
                    ctry = 1;
                    SP.Close();
                    SP = new SerialPort("COM" + porttry, 9600);
                }
                if (porttry>=16)
                {
                    porttry = 0;
                    count -= 1;
                }
                if (count == 0)
                {
                    LabelWrite("Cant find AudioSwitcher. Check your USB port.", label4);
                    count = 3;
                    porttry = 0;
                    ctry = 0;
                    cooldown = 20;
                }
            }

            
            //Synchronisation Disconnect
            if (ConnectionState == true)
            {
                synctimer -= 1;
                if (synctimer<=0)
                {
                    synctimer = 20;
                    SP.Close();
                    ConnectionState = false;
                    porttry -= 1;
                }
            }
             
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //SYSTEM

        //Contex Menu
        private void PCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SPstate != 1)
            {
                SPstate = 1;
                HPstate = 3;
                Apply();
            }
        }
        private void PCTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SPstate != 2)
            {
                SPstate = 2;
                HPstate = 3;
                Apply();
            }
        }

        //NotifyIcon
        private void notifyIcon1_Click(object sender, MouseEventArgs e1)
        {
            if (e1.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                this.WindowState = FormWindowState.Minimized;
                }else{
                    this.WindowState = FormWindowState.Normal;
                }
            }

        }

        //Panel Movement
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //MAIN PANEL


        //Exit Button
        /*
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NotifyIcon.Visible = false;
            NotifyIcon.Icon = null;
            SP.Close();
            pictureBox1.BackColor = Color.DarkRed;
            Close();
        }
        
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DodgerBlue;
        }
         
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DarkGray;
        }
        */

        //Minimize Button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Chartreuse;
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.DarkGray;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //MAIN CODE

        //Buttons State Check

        private void PC_Speaker_MouseUp(object sender, MouseEventArgs e)
        {
            if (SPstate!=1)
            {
            SPstate = 1;
            HPstate = 3;
            Apply();
            }
        }

        private void PCTV_Speaker_MouseUp(object sender, MouseEventArgs e)
        {
            if (SPstate != 2)
            {
                SPstate = 2;
                HPstate = 3;
                Apply();
            }
        }

        private void PC_Headphone_MouseUp(object sender, MouseEventArgs e)
        {
            if(HPstate !=1)
            {
                if (HPstate == 3)
                {
                    SPmemory = SPstate;
                }
                SPstate = 0;
                HPstate = 1;
                Apply();
            }
        }

        private void PCTV_Headphone_MouseUp(object sender, EventArgs e)
        {
            if(HPstate !=2)
            {
                if (HPstate == 3)
                {
                    SPmemory = SPstate;
                }
                SPstate = 0;
                HPstate = 2;
                Apply();
            }
        }

        private void TV_Headphone_MouseUp(object sender, EventArgs e)
        {
            if (HPstate !=3)
            {
                SPstate = SPmemory;
                HPstate = 3;
                Apply();
            }
        }


        //SerialPort
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = SP.ReadLine();
            data = data.Trim();
            
            if (data == "CR HA_AS_001")
            {
                SP.Write("CC");
                ConnectionState = true;
            }

            if (data == "CV")
            {
                LabelWrite("Successfully Connected",label4);
                synctimer = 30;
                Thread.Sleep(500);
                Apply();

                count = 3;
                ctry = 0;
                cooldown = 0;
            }


            
            //Synchronisation
            if (data == "sync")
            {
                LabelWrite("Sync Success", label4);
                SP.Write("syncx");
                synctimer = 30;
            }
             

            
        }
        

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //FUNCTIONS

        //Applying changes
        void Apply()
        {
            if (SPstate == 0)
            {
                Arrow1.BackgroundImage = null;
                Speaker.BackgroundImage = Properties.Resources.Icon_Speaker_gray;
                PC_Speaker.BackgroundImage = Properties.Resources.Icon_PC_gray;
                PCTV_Speaker.BackgroundImage = Properties.Resources.Icon_TVPC_gray;
                SWrite("SP0x");
            }

            if (HPstate == 3)
            {

                PC_Headphone.BackgroundImage = Properties.Resources.Icon_PC_gray;
                TV_Headphone.BackgroundImage = Properties.Resources.Icon_TV_white;
                PCTV_Headphone.BackgroundImage = Properties.Resources.Icon_TVPC_gray;
                SWrite("HP3x");
            }

            if (SPstate == 1)
            {
                Speaker.BackgroundImage = Properties.Resources.Icon_Speaker_white;
                Arrow1.BackgroundImage = Properties.Resources.Icon_Arrow;
                PC_Speaker.BackgroundImage = Properties.Resources.Icon_PC_white;
                PCTV_Speaker.BackgroundImage = Properties.Resources.Icon_TVPC_gray;
                SWrite("SP1x");
            }

            if (SPstate == 2)
            {
                Speaker.BackgroundImage = Properties.Resources.Icon_Speaker_white;
                Arrow1.BackgroundImage = Properties.Resources.Icon_Arrow;
                PC_Speaker.BackgroundImage = Properties.Resources.Icon_PC_gray;
                PCTV_Speaker.BackgroundImage = Properties.Resources.Icon_TVPC_white;
                SWrite("SP2x");
            }
            if (HPstate == 1)
            {
                PC_Headphone.BackgroundImage = Properties.Resources.Icon_PC_white;
                PCTV_Headphone.BackgroundImage = Properties.Resources.Icon_TVPC_gray;
                TV_Headphone.BackgroundImage = Properties.Resources.Icon_TV_gray;
                SWrite("HP1x");
            }
            if (HPstate == 2)
            {
                PC_Headphone.BackgroundImage = Properties.Resources.Icon_PC_gray;
                PCTV_Headphone.BackgroundImage = Properties.Resources.Icon_TVPC_white;
                TV_Headphone.BackgroundImage = Properties.Resources.Icon_TV_gray;
                SWrite("HP2x");
            }
        }

        //Change Label.text
        void LabelWrite(string TXT, Label OBJ)
        {
            this.BeginInvoke(new SetTextDeleg(si_DataReceived),
                    new object[] { TXT,OBJ });
        }
        //delegation
        private delegate void SetTextDeleg(string text, Label OBJ);
        //Changing data in label
        void si_DataReceived(string TXT, Label OBJ)
        {
            OBJ.Text = TXT.Trim();
        }

        //Write to Serial Port
        void SWrite(string TXT)
        {
            if (ConnectionState==true)
            {
                SP.Write(TXT);
            }
            else
            {
                //Sound_Error.Play();
                LabelWrite("Waiting for connection...",label4);
            }
        }

        //MENU SELECTING

        private void PC_Speaker_MouseEnter(object sender, EventArgs e)
        {
            //Sound_Hover.Play();
            PC_Speaker.BackColor = Color.FromArgb(89, 197, 255);
        }

        private void PC_Speaker_MouseLeave(object sender, EventArgs e)
        {
            PC_Speaker.BackColor = Color.FromArgb(31, 174, 255);
        }

        private void PCTV_Speaker_MouseEnter(object sender, EventArgs e)
        {
            PCTV_Speaker.BackColor = Color.FromArgb(89, 197, 255);
        }

        private void PCTV_Speaker_MouseLeave(object sender, EventArgs e)
        {
            PCTV_Speaker.BackColor = Color.FromArgb(31, 174, 255);
        }

        private void PC_Headphone_MouseEnter(object sender, EventArgs e)
        {
            PC_Headphone.BackColor = Color.FromArgb(89, 197, 255);
        }

        private void PC_Headphone_MouseLeave(object sender, EventArgs e)
        {
            PC_Headphone.BackColor = Color.FromArgb(31, 174, 255);
        }

        private void PCTV_Headphone_MouseEnter(object sender, EventArgs e)
        {
            PCTV_Headphone.BackColor = Color.FromArgb(89, 197, 255);
        }

        private void PCTV_Headphone_MouseLeave(object sender, EventArgs e)
        {
            PCTV_Headphone.BackColor = Color.FromArgb(31, 174, 255);
        }

        private void TV_Headphone_MouseEnter(object sender, EventArgs e)
        {
            TV_Headphone.BackColor = Color.FromArgb(89, 197, 255);
        }

        private void TV_Headphone_MouseLeave(object sender, EventArgs e)
        {
            TV_Headphone.BackColor = Color.FromArgb(31, 174, 255);
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    }
}
