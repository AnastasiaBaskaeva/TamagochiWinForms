using System.Drawing;

namespace kursach
{
    partial class tamagochi
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tamagochi));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressHappiness = new PurpleProgressBar();
            this.progressTired = new PurpleProgressBar();
            this.progressHungry = new PurpleProgressBar();
            this.btn_WakeUp = new PurpleButton();
            this.btnPlay = new PurpleButton();
            this.btnSleep = new PurpleButton();
            this.btnToMenu = new PurpleButton();
            this.btnFeed = new PurpleButton();
            this.btnBackgroundSelect = new PurpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_01.png");
            this.imageList1.Images.SetKeyName(1, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_02.png");
            this.imageList1.Images.SetKeyName(2, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_09.png");
            this.imageList1.Images.SetKeyName(3, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_10.png");
            this.imageList1.Images.SetKeyName(4, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_15.png");
            this.imageList1.Images.SetKeyName(5, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_04.png");
            this.imageList1.Images.SetKeyName(6, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_18.png");
            this.imageList1.Images.SetKeyName(7, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_19.png");
            this.imageList1.Images.SetKeyName(8, "Custom-Edited---Tamagotchi-Customs---Lovelitchi_14.png");
            this.imageList1.Images.SetKeyName(9, "System.Drawing.Bitmap");
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(298, 210);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "счастье";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "усталость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "голод";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressHappiness
            // 
            this.progressHappiness.Location = new System.Drawing.Point(480, 220);
            this.progressHappiness.Margin = new System.Windows.Forms.Padding(2);
            this.progressHappiness.Maximum = 10000;
            this.progressHappiness.MinimumSize = new System.Drawing.Size(1, 20);
            this.progressHappiness.Name = "progressHappiness";
            this.progressHappiness.Size = new System.Drawing.Size(200, 25);
            this.progressHappiness.TabIndex = 20;
            this.progressHappiness.Value = 10000;
            // 
            // progressTired
            // 
            this.progressTired.Location = new System.Drawing.Point(480, 150);
            this.progressTired.Margin = new System.Windows.Forms.Padding(2);
            this.progressTired.Maximum = 10000;
            this.progressTired.MinimumSize = new System.Drawing.Size(1, 20);
            this.progressTired.Name = "progressTired";
            this.progressTired.Size = new System.Drawing.Size(200, 25);
            this.progressTired.TabIndex = 19;
            // 
            // progressHungry
            // 
            this.progressHungry.Location = new System.Drawing.Point(480, 80);
            this.progressHungry.Margin = new System.Windows.Forms.Padding(2);
            this.progressHungry.Maximum = 10000;
            this.progressHungry.MinimumSize = new System.Drawing.Size(1, 20);
            this.progressHungry.Name = "progressHungry";
            this.progressHungry.Size = new System.Drawing.Size(200, 25);
            this.progressHungry.TabIndex = 18;
            // 
            // btn_WakeUp
            // 
            this.btn_WakeUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.btn_WakeUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WakeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WakeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_WakeUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btn_WakeUp.Location = new System.Drawing.Point(30, 290);
            this.btn_WakeUp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_WakeUp.Name = "btn_WakeUp";
            this.btn_WakeUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_WakeUp.Size = new System.Drawing.Size(150, 40);
            this.btn_WakeUp.TabIndex = 11;
            this.btn_WakeUp.Text = "разбудить";
            this.btn_WakeUp.UseVisualStyleBackColor = false;
            this.btn_WakeUp.Click += new System.EventHandler(this.btnWakeUp_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnPlay.Location = new System.Drawing.Point(30, 210);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 40);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "играть";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.btnSleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnSleep.Location = new System.Drawing.Point(30, 130);
            this.btnSleep.Margin = new System.Windows.Forms.Padding(2);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(150, 40);
            this.btnSleep.TabIndex = 2;
            this.btnSleep.Text = "спать";
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnToMenu
            // 
            this.btnToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.btnToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToMenu.FlatAppearance.BorderSize = 0;
            this.btnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnToMenu.Location = new System.Drawing.Point(624, 10);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(66, 40);
            this.btnToMenu.TabIndex = 25;
            this.btnToMenu.Text = "Menu";
            this.btnToMenu.UseVisualStyleBackColor = false;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.btnFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnFeed.Location = new System.Drawing.Point(30, 50);
            this.btnFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(150, 40);
            this.btnFeed.TabIndex = 1;
            this.btnFeed.Text = "кормить";
            this.btnFeed.UseVisualStyleBackColor = false;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnBackgroundSelect
            // 
            this.btnBackgroundSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.btnBackgroundSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackgroundSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackgroundSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnBackgroundSelect.Image = global::kursach.Properties.Resources.backgroundIcon;
            this.btnBackgroundSelect.Location = new System.Drawing.Point(635, 336);
            this.btnBackgroundSelect.Name = "btnBackgroundSelect";
            this.btnBackgroundSelect.Size = new System.Drawing.Size(50, 50);
            this.btnBackgroundSelect.TabIndex = 26;
            this.btnBackgroundSelect.UseVisualStyleBackColor = true;
            this.btnBackgroundSelect.Click += new System.EventHandler(this.btnSelectBackground_Click);
            // 
            // tamagochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 437);
            this.Controls.Add(this.btnBackgroundSelect);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressHappiness);
            this.Controls.Add(this.progressTired);
            this.Controls.Add(this.progressHungry);
            this.Controls.Add(this.btn_WakeUp);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "tamagochi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tamagochi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tamagochi_FormClosing);
            this.Load += new System.EventHandler(this.tamagochi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox;
        private PurpleButton btnFeed;
        private PurpleButton btnSleep;
        private PurpleButton btnPlay;
        private PurpleButton btn_WakeUp; 
        private PurpleButton btnToMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PurpleProgressBar progressHappiness;
        private PurpleProgressBar progressTired;
        private PurpleProgressBar progressHungry;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PurpleButton btnBackgroundSelect;
    }
}

