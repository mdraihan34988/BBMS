namespace BloodBankSystem.Views
{
    partial class BloodDonate
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
            this.panelBloodDonate = new System.Windows.Forms.Panel();
            this.dateTimePickerLastTimeDonate = new System.Windows.Forms.DateTimePicker();
            this.labelHeder = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelLastDonateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlood = new System.Windows.Forms.PictureBox();
            this.panelBloodDonate.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlood)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBloodDonate
            // 
            this.panelBloodDonate.AutoScroll = true;
            this.panelBloodDonate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBloodDonate.Controls.Add(this.dateTimePickerLastTimeDonate);
            this.panelBloodDonate.Controls.Add(this.labelHeder);
            this.panelBloodDonate.Controls.Add(this.pictureBoxBlood);
            this.panelBloodDonate.Controls.Add(this.buttonSubmit);
            this.panelBloodDonate.Controls.Add(this.labelLastDonateTime);
            this.panelBloodDonate.Location = new System.Drawing.Point(-8, 101);
            this.panelBloodDonate.Name = "panelBloodDonate";
            this.panelBloodDonate.Size = new System.Drawing.Size(815, 381);
            this.panelBloodDonate.TabIndex = 0;
            this.panelBloodDonate.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBloodDonate_Paint);
            // 
            // dateTimePickerLastTimeDonate
            // 
            this.dateTimePickerLastTimeDonate.Enabled = false;
            this.dateTimePickerLastTimeDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerLastTimeDonate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLastTimeDonate.Location = new System.Drawing.Point(539, 103);
            this.dateTimePickerLastTimeDonate.MaxDate = new System.DateTime(5000, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerLastTimeDonate.Name = "dateTimePickerLastTimeDonate";
            this.dateTimePickerLastTimeDonate.Size = new System.Drawing.Size(235, 21);
            this.dateTimePickerLastTimeDonate.TabIndex = 7;
            this.dateTimePickerLastTimeDonate.Visible = false;
            // 
            // labelHeder
            // 
            this.labelHeder.AutoSize = true;
            this.labelHeder.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeder.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeder.Location = new System.Drawing.Point(316, 3);
            this.labelHeder.Name = "labelHeder";
            this.labelHeder.Size = new System.Drawing.Size(244, 57);
            this.labelHeder.TabIndex = 6;
            this.labelHeder.Text = "Donate Blood";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSubmit.Location = new System.Drawing.Point(578, 172);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(135, 42);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.SubmitButtonClicked);
            // 
            // labelLastDonateTime
            // 
            this.labelLastDonateTime.AutoSize = true;
            this.labelLastDonateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastDonateTime.ForeColor = System.Drawing.Color.Maroon;
            this.labelLastDonateTime.Location = new System.Drawing.Point(256, 101);
            this.labelLastDonateTime.Name = "labelLastDonateTime";
            this.labelLastDonateTime.Size = new System.Drawing.Size(277, 25);
            this.labelLastDonateTime.TabIndex = 0;
            this.labelLastDonateTime.Text = "Last Time Blood Donated";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Location = new System.Drawing.Point(-8, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 81);
            this.panel2.TabIndex = 1;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.Red;
            this.labelLogo.Location = new System.Drawing.Point(98, 10);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(220, 41);
            this.labelLogo.TabIndex = 15;
            this.labelLogo.Text = "Life Saver";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Controls.Add(this.pictureBoxLogo);
            this.panel3.Controls.Add(this.labelLogo);
            this.panel3.Location = new System.Drawing.Point(-8, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 104);
            this.panel3.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::BloodBankSystem.Properties.Resources.Go_back_icon2;
            this.buttonBack.Location = new System.Drawing.Point(742, 18);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackButtonClicked);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BloodBankSystem.Properties.Resources.l1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(72, 65);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxBlood
            // 
            this.pictureBoxBlood.Image = global::BloodBankSystem.Properties.Resources.L11;
            this.pictureBoxBlood.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBlood.Name = "pictureBoxBlood";
            this.pictureBoxBlood.Size = new System.Drawing.Size(256, 266);
            this.pictureBoxBlood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBlood.TabIndex = 2;
            this.pictureBoxBlood.TabStop = false;
            // 
            // BloodDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBloodDonate);
            this.MaximizeBox = false;
            this.Name = "BloodDonate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodDonate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloodDonate_FormClosing);
            this.Load += new System.EventHandler(this.DonateBloodLoadingEvent);
            this.panelBloodDonate.ResumeLayout(false);
            this.panelBloodDonate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBloodDonate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelLastDonateTime;
        private System.Windows.Forms.PictureBox pictureBoxBlood;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastTimeDonate;
    }
}