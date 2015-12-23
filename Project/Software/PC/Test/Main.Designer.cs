namespace AudioSwitcher
{
    partial class HexAxis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexAxis));
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCTVSpeakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Arrow2 = new System.Windows.Forms.PictureBox();
            this.TV_Headphone = new System.Windows.Forms.PictureBox();
            this.PCTV_Headphone = new System.Windows.Forms.PictureBox();
            this.PC_Headphone = new System.Windows.Forms.PictureBox();
            this.PCTV_Speaker = new System.Windows.Forms.PictureBox();
            this.PC_Speaker = new System.Windows.Forms.PictureBox();
            this.Speaker = new System.Windows.Forms.PictureBox();
            this.Headphone = new System.Windows.Forms.PictureBox();
            this.Arrow1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TV_Headphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTV_Headphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC_Headphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTV_Speaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC_Speaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Headphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PCToolStripMenuItem,
            this.pCTVSpeakerToolStripMenuItem});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(164, 48);
            // 
            // PCToolStripMenuItem
            // 
            this.PCToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.PCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PCToolStripMenuItem.Image")));
            this.PCToolStripMenuItem.Name = "PCToolStripMenuItem";
            this.PCToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.PCToolStripMenuItem.Text = "PC -> Speaker";
            this.PCToolStripMenuItem.Click += new System.EventHandler(this.PCToolStripMenuItem_Click);
            // 
            // pCTVSpeakerToolStripMenuItem
            // 
            this.pCTVSpeakerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.pCTVSpeakerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pCTVSpeakerToolStripMenuItem.Image")));
            this.pCTVSpeakerToolStripMenuItem.Name = "pCTVSpeakerToolStripMenuItem";
            this.pCTVSpeakerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pCTVSpeakerToolStripMenuItem.Text = "PCTV -> Speaker";
            this.pCTVSpeakerToolStripMenuItem.Click += new System.EventHandler(this.PCTVToolStripMenuItem_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.MenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "HexAxis Audio Settings";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "label1";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Audio Switcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 30);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox4.Location = new System.Drawing.Point(1031, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(674, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Source";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Log";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 30);
            this.panel2.TabIndex = 10;
            // 
            // Arrow2
            // 
            this.Arrow2.BackColor = System.Drawing.Color.Transparent;
            this.Arrow2.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_Arrow;
            this.Arrow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Arrow2.Location = new System.Drawing.Point(278, 366);
            this.Arrow2.Name = "Arrow2";
            this.Arrow2.Size = new System.Drawing.Size(100, 134);
            this.Arrow2.TabIndex = 17;
            this.Arrow2.TabStop = false;
            // 
            // TV_Headphone
            // 
            this.TV_Headphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.TV_Headphone.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_TV_white;
            this.TV_Headphone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TV_Headphone.Location = new System.Drawing.Point(850, 344);
            this.TV_Headphone.Name = "TV_Headphone";
            this.TV_Headphone.Size = new System.Drawing.Size(180, 180);
            this.TV_Headphone.TabIndex = 16;
            this.TV_Headphone.TabStop = false;
            this.TV_Headphone.MouseEnter += new System.EventHandler(this.TV_Headphone_MouseEnter);
            this.TV_Headphone.MouseLeave += new System.EventHandler(this.TV_Headphone_MouseLeave);
            this.TV_Headphone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TV_Headphone_MouseUp);
            // 
            // PCTV_Headphone
            // 
            this.PCTV_Headphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.PCTV_Headphone.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_TVPC_gray;
            this.PCTV_Headphone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCTV_Headphone.Location = new System.Drawing.Point(630, 344);
            this.PCTV_Headphone.Name = "PCTV_Headphone";
            this.PCTV_Headphone.Size = new System.Drawing.Size(180, 180);
            this.PCTV_Headphone.TabIndex = 15;
            this.PCTV_Headphone.TabStop = false;
            this.PCTV_Headphone.MouseEnter += new System.EventHandler(this.PCTV_Headphone_MouseEnter);
            this.PCTV_Headphone.MouseLeave += new System.EventHandler(this.PCTV_Headphone_MouseLeave);
            this.PCTV_Headphone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCTV_Headphone_MouseUp);
            // 
            // PC_Headphone
            // 
            this.PC_Headphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.PC_Headphone.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_PC_gray;
            this.PC_Headphone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PC_Headphone.Location = new System.Drawing.Point(416, 344);
            this.PC_Headphone.Name = "PC_Headphone";
            this.PC_Headphone.Size = new System.Drawing.Size(180, 180);
            this.PC_Headphone.TabIndex = 14;
            this.PC_Headphone.TabStop = false;
            this.PC_Headphone.MouseEnter += new System.EventHandler(this.PC_Headphone_MouseEnter);
            this.PC_Headphone.MouseLeave += new System.EventHandler(this.PC_Headphone_MouseLeave);
            this.PC_Headphone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PC_Headphone_MouseUp);
            // 
            // PCTV_Speaker
            // 
            this.PCTV_Speaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.PCTV_Speaker.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_TVPC_gray;
            this.PCTV_Speaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCTV_Speaker.Location = new System.Drawing.Point(630, 96);
            this.PCTV_Speaker.Name = "PCTV_Speaker";
            this.PCTV_Speaker.Size = new System.Drawing.Size(180, 180);
            this.PCTV_Speaker.TabIndex = 13;
            this.PCTV_Speaker.TabStop = false;
            this.PCTV_Speaker.MouseEnter += new System.EventHandler(this.PCTV_Speaker_MouseEnter);
            this.PCTV_Speaker.MouseLeave += new System.EventHandler(this.PCTV_Speaker_MouseLeave);
            this.PCTV_Speaker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCTV_Speaker_MouseUp);
            // 
            // PC_Speaker
            // 
            this.PC_Speaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.PC_Speaker.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_PC_white;
            this.PC_Speaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PC_Speaker.Location = new System.Drawing.Point(416, 96);
            this.PC_Speaker.Name = "PC_Speaker";
            this.PC_Speaker.Size = new System.Drawing.Size(180, 180);
            this.PC_Speaker.TabIndex = 12;
            this.PC_Speaker.TabStop = false;
            this.PC_Speaker.MouseEnter += new System.EventHandler(this.PC_Speaker_MouseEnter);
            this.PC_Speaker.MouseLeave += new System.EventHandler(this.PC_Speaker_MouseLeave);
            this.PC_Speaker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PC_Speaker_MouseUp);
            // 
            // Speaker
            // 
            this.Speaker.BackColor = System.Drawing.Color.Transparent;
            this.Speaker.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_Speaker_white;
            this.Speaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Speaker.Location = new System.Drawing.Point(58, 96);
            this.Speaker.Name = "Speaker";
            this.Speaker.Size = new System.Drawing.Size(180, 180);
            this.Speaker.TabIndex = 5;
            this.Speaker.TabStop = false;
            // 
            // Headphone
            // 
            this.Headphone.BackColor = System.Drawing.Color.Transparent;
            this.Headphone.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_Headphone_white;
            this.Headphone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Headphone.Location = new System.Drawing.Point(58, 344);
            this.Headphone.Name = "Headphone";
            this.Headphone.Size = new System.Drawing.Size(180, 180);
            this.Headphone.TabIndex = 4;
            this.Headphone.TabStop = false;
            // 
            // Arrow1
            // 
            this.Arrow1.BackColor = System.Drawing.Color.Transparent;
            this.Arrow1.BackgroundImage = global::AudioSwitcher.Properties.Resources.Icon_Arrow;
            this.Arrow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Arrow1.Location = new System.Drawing.Point(278, 123);
            this.Arrow1.Name = "Arrow1";
            this.Arrow1.Size = new System.Drawing.Size(100, 134);
            this.Arrow1.TabIndex = 18;
            this.Arrow1.TabStop = false;
            // 
            // HexAxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 619);
            this.Controls.Add(this.Arrow1);
            this.Controls.Add(this.Arrow2);
            this.Controls.Add(this.TV_Headphone);
            this.Controls.Add(this.PCTV_Headphone);
            this.Controls.Add(this.PC_Headphone);
            this.Controls.Add(this.PCTV_Speaker);
            this.Controls.Add(this.PC_Speaker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Speaker);
            this.Controls.Add(this.Headphone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HexAxis";
            this.Text = "HexAxis AudioSwitcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HexAxis_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TV_Headphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTV_Headphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC_Headphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTV_Speaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC_Speaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Headphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PCToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Headphone;
        private System.Windows.Forms.PictureBox Speaker;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PC_Speaker;
        private System.Windows.Forms.PictureBox PCTV_Speaker;
        private System.Windows.Forms.PictureBox PC_Headphone;
        private System.Windows.Forms.PictureBox PCTV_Headphone;
        private System.Windows.Forms.PictureBox TV_Headphone;
        private System.Windows.Forms.PictureBox Arrow2;
        private System.Windows.Forms.PictureBox Arrow1;
        private System.Windows.Forms.ToolStripMenuItem pCTVSpeakerToolStripMenuItem;
    }
}

