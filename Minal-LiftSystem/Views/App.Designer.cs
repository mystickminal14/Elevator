namespace Minal_LiftSystem
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.LiftBase = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.LiftLeftDoor_1 = new System.Windows.Forms.PictureBox();
            this.LiftRightDoor_1 = new System.Windows.Forms.PictureBox();
            this.LiftLeftDoor_G = new System.Windows.Forms.PictureBox();
            this.LiftRightDoor_G = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GoDown = new System.Windows.Forms.Button();
            this.GoUp = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.OpenDoor = new System.Windows.Forms.Button();
            this.CloseDoor = new System.Windows.Forms.Button();
            this.firstFloor = new System.Windows.Forms.Button();
            this.groundFloor = new System.Windows.Forms.Button();
            this.CloseDownTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenDownTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseUpTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenUpTimer = new System.Windows.Forms.Timer(this.components);
            this.LiftTimerUp = new System.Windows.Forms.Timer(this.components);
            this.LiftTimerDown = new System.Windows.Forms.Timer(this.components);
            this.display_g = new System.Windows.Forms.Button();
            this.display_1 = new System.Windows.Forms.Button();
            this.recordView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftLeftDoor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftRightDoor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftLeftDoor_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftRightDoor_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1223, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1364, 716);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(760, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(289, 297);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // LiftBase
            // 
            this.LiftBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LiftBase.BackgroundImage")));
            this.LiftBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LiftBase.Location = new System.Drawing.Point(833, 426);
            this.LiftBase.Name = "LiftBase";
            this.LiftBase.Size = new System.Drawing.Size(199, 232);
            this.LiftBase.TabIndex = 8;
            this.LiftBase.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox6.Location = new System.Drawing.Point(760, 377);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(289, 297);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // LiftLeftDoor_1
            // 
            this.LiftLeftDoor_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LiftLeftDoor_1.BackgroundImage")));
            this.LiftLeftDoor_1.Location = new System.Drawing.Point(833, 62);
            this.LiftLeftDoor_1.Name = "LiftLeftDoor_1";
            this.LiftLeftDoor_1.Size = new System.Drawing.Size(102, 232);
            this.LiftLeftDoor_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LiftLeftDoor_1.TabIndex = 11;
            this.LiftLeftDoor_1.TabStop = false;
            // 
            // LiftRightDoor_1
            // 
            this.LiftRightDoor_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LiftRightDoor_1.BackgroundImage")));
            this.LiftRightDoor_1.Location = new System.Drawing.Point(930, 62);
            this.LiftRightDoor_1.Name = "LiftRightDoor_1";
            this.LiftRightDoor_1.Size = new System.Drawing.Size(102, 232);
            this.LiftRightDoor_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LiftRightDoor_1.TabIndex = 15;
            this.LiftRightDoor_1.TabStop = false;
            // 
            // LiftLeftDoor_G
            // 
            this.LiftLeftDoor_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LiftLeftDoor_G.BackgroundImage")));
            this.LiftLeftDoor_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LiftLeftDoor_G.Location = new System.Drawing.Point(833, 426);
            this.LiftLeftDoor_G.Name = "LiftLeftDoor_G";
            this.LiftLeftDoor_G.Size = new System.Drawing.Size(102, 232);
            this.LiftLeftDoor_G.TabIndex = 16;
            this.LiftLeftDoor_G.TabStop = false;
            // 
            // LiftRightDoor_G
            // 
            this.LiftRightDoor_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LiftRightDoor_G.BackgroundImage")));
            this.LiftRightDoor_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LiftRightDoor_G.Location = new System.Drawing.Point(930, 426);
            this.LiftRightDoor_G.Name = "LiftRightDoor_G";
            this.LiftRightDoor_G.Size = new System.Drawing.Size(102, 232);
            this.LiftRightDoor_G.TabIndex = 17;
            this.LiftRightDoor_G.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(912, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 40);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GoDown
            // 
            this.GoDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoDown.BackgroundImage")));
            this.GoDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoDown.Location = new System.Drawing.Point(778, 160);
            this.GoDown.Name = "GoDown";
            this.GoDown.Size = new System.Drawing.Size(40, 40);
            this.GoDown.TabIndex = 28;
            this.GoDown.UseVisualStyleBackColor = true;
            this.GoDown.Click += new System.EventHandler(this.GoDown_Click);
            // 
            // GoUp
            // 
            this.GoUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoUp.BackgroundImage")));
            this.GoUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoUp.Location = new System.Drawing.Point(778, 531);
            this.GoUp.Name = "GoUp";
            this.GoUp.Size = new System.Drawing.Size(40, 40);
            this.GoUp.TabIndex = 31;
            this.GoUp.UseVisualStyleBackColor = true;
            this.GoUp.Click += new System.EventHandler(this.GoUp_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.display.Location = new System.Drawing.Point(482, 137);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(202, 87);
            this.display.TabIndex = 34;
            this.display.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(912, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 40);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(471, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(224, 313);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // OpenDoor
            // 
            this.OpenDoor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenDoor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenDoor.BackgroundImage")));
            this.OpenDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenDoor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDoor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OpenDoor.Location = new System.Drawing.Point(509, 370);
            this.OpenDoor.Name = "OpenDoor";
            this.OpenDoor.Size = new System.Drawing.Size(55, 50);
            this.OpenDoor.TabIndex = 39;
            this.OpenDoor.UseVisualStyleBackColor = true;
            this.OpenDoor.Click += new System.EventHandler(this.OpenDoor_Click);
            // 
            // CloseDoor
            // 
            this.CloseDoor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseDoor.BackgroundImage")));
            this.CloseDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseDoor.Location = new System.Drawing.Point(593, 370);
            this.CloseDoor.Name = "CloseDoor";
            this.CloseDoor.Size = new System.Drawing.Size(60, 50);
            this.CloseDoor.TabIndex = 40;
            this.CloseDoor.UseVisualStyleBackColor = true;
            this.CloseDoor.Click += new System.EventHandler(this.CloseDoor_Click);
            // 
            // firstFloor
            // 
            this.firstFloor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstFloor.BackgroundImage")));
            this.firstFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstFloor.Location = new System.Drawing.Point(550, 230);
            this.firstFloor.Name = "firstFloor";
            this.firstFloor.Size = new System.Drawing.Size(60, 50);
            this.firstFloor.TabIndex = 41;
            this.firstFloor.UseVisualStyleBackColor = true;
            this.firstFloor.Click += new System.EventHandler(this.firstFloor_Click);
            // 
            // groundFloor
            // 
            this.groundFloor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groundFloor.BackgroundImage")));
            this.groundFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groundFloor.Location = new System.Drawing.Point(550, 296);
            this.groundFloor.Name = "groundFloor";
            this.groundFloor.Size = new System.Drawing.Size(60, 50);
            this.groundFloor.TabIndex = 42;
            this.groundFloor.UseVisualStyleBackColor = true;
            this.groundFloor.Click += new System.EventHandler(this.groundFloor_Click);
            // 
            // CloseDownTimer
            // 
            this.CloseDownTimer.Tick += new System.EventHandler(this.CloseDownTimer_Tick);
            // 
            // OpenDownTimer
            // 
            this.OpenDownTimer.Tick += new System.EventHandler(this.OpenDownTimer_Tick);
            // 
            // CloseUpTimer
            // 
            this.CloseUpTimer.Tick += new System.EventHandler(this.CloseUpTimer_Tick);
            // 
            // OpenUpTimer
            // 
            this.OpenUpTimer.Tick += new System.EventHandler(this.OpenUpTimer_Tick);
            // 
            // LiftTimerUp
            // 
            this.LiftTimerUp.Tick += new System.EventHandler(this.LiftTimerUp_Tick);
            // 
            // LiftTimerDown
            // 
            this.LiftTimerDown.Tick += new System.EventHandler(this.LiftTimerDown_Tick);
            // 
            // display_g
            // 
            this.display_g.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_g.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.display_g.Location = new System.Drawing.Point(769, 456);
            this.display_g.Name = "display_g";
            this.display_g.Size = new System.Drawing.Size(58, 58);
            this.display_g.TabIndex = 44;
            this.display_g.UseVisualStyleBackColor = false;
            // 
            // display_1
            // 
            this.display_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.display_1.Location = new System.Drawing.Point(769, 87);
            this.display_1.Name = "display_1";
            this.display_1.Size = new System.Drawing.Size(58, 58);
            this.display_1.TabIndex = 45;
            this.display_1.UseVisualStyleBackColor = false;
            // 
            // recordView
            // 
            this.recordView.AllowUserToOrderColumns = true;
            this.recordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordView.Location = new System.Drawing.Point(24, 16);
            this.recordView.Name = "recordView";
            this.recordView.RowHeadersWidth = 51;
            this.recordView.RowTemplate.Height = 24;
            this.recordView.Size = new System.Drawing.Size(403, 658);
            this.recordView.TabIndex = 46;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 686);
            this.Controls.Add(this.recordView);
            this.Controls.Add(this.LiftLeftDoor_1);
            this.Controls.Add(this.LiftLeftDoor_G);
            this.Controls.Add(this.display_1);
            this.Controls.Add(this.display_g);
            this.Controls.Add(this.LiftRightDoor_1);
            this.Controls.Add(this.groundFloor);
            this.Controls.Add(this.firstFloor);
            this.Controls.Add(this.CloseDoor);
            this.Controls.Add(this.OpenDoor);
            this.Controls.Add(this.display);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.GoUp);
            this.Controls.Add(this.GoDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LiftRightDoor_G);
            this.Controls.Add(this.LiftBase);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "App";
            this.Text = "/;n";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftLeftDoor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftRightDoor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftLeftDoor_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftRightDoor_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox LiftBase;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox LiftLeftDoor_1;
        private System.Windows.Forms.PictureBox LiftRightDoor_1;
        private System.Windows.Forms.PictureBox LiftLeftDoor_G;
        private System.Windows.Forms.PictureBox LiftRightDoor_G;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GoDown;
        private System.Windows.Forms.Button GoUp;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button OpenDoor;
        private System.Windows.Forms.Button CloseDoor;
        private System.Windows.Forms.Button firstFloor;
        private System.Windows.Forms.Button groundFloor;
        private System.Windows.Forms.Timer CloseDownTimer;
        private System.Windows.Forms.Timer OpenDownTimer;
        private System.Windows.Forms.Timer OpenUpTimer;
        private System.Windows.Forms.Timer CloseUpTimer;
        private System.Windows.Forms.Timer LiftTimerUp;
        private System.Windows.Forms.Timer LiftTimerDown;
        private System.Windows.Forms.Button display_g;
        private System.Windows.Forms.Button display_1;
        private System.Windows.Forms.DataGridView recordView;
    }
}

