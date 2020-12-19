namespace BloodBankSystem.Views
{
    partial class RegisteredMember
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDonateBlood = new System.Windows.Forms.Button();
            this.buttonBloodRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBloodGroup = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Location = new System.Drawing.Point(-7, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 69);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(97, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 41);
            this.label6.TabIndex = 12;
            this.label6.Text = "Life Saver";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 107);
            this.panel1.TabIndex = 0;
            // 
            // buttonDonateBlood
            // 
            this.buttonDonateBlood.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDonateBlood.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDonateBlood.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDonateBlood.Location = new System.Drawing.Point(344, 100);
            this.buttonDonateBlood.Name = "buttonDonateBlood";
            this.buttonDonateBlood.Size = new System.Drawing.Size(181, 46);
            this.buttonDonateBlood.TabIndex = 0;
            this.buttonDonateBlood.Text = "Donate Blood";
            this.buttonDonateBlood.UseVisualStyleBackColor = false;
            this.buttonDonateBlood.Click += new System.EventHandler(this.Donate_BloodButtonClick);
            // 
            // buttonBloodRequest
            // 
            this.buttonBloodRequest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBloodRequest.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBloodRequest.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBloodRequest.Location = new System.Drawing.Point(344, 168);
            this.buttonBloodRequest.Name = "buttonBloodRequest";
            this.buttonBloodRequest.Size = new System.Drawing.Size(181, 44);
            this.buttonBloodRequest.TabIndex = 1;
            this.buttonBloodRequest.Text = "Blood Request";
            this.buttonBloodRequest.UseVisualStyleBackColor = false;
            this.buttonBloodRequest.Click += new System.EventHandler(this.Blood_RequestClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome To Our System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.labelBloodGroup);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelGroup);
            this.panel2.Controls.Add(this.buttonHistory);
            this.panel2.Controls.Add(this.pictureBoxProfile);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonBloodRequest);
            this.panel2.Controls.Add(this.buttonDonateBlood);
            this.panel2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(-4, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 395);
            this.panel2.TabIndex = 1;
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodGroup.Location = new System.Drawing.Point(203, 318);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(36, 25);
            this.labelBloodGroup.TabIndex = 11;
            this.labelBloodGroup.Text = "    ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(312, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 27);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "           ";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(68, 318);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(117, 25);
            this.labelGroup.TabIndex = 9;
            this.labelGroup.Text = "Blood Group";
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHistory.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.Maroon;
            this.buttonHistory.Location = new System.Drawing.Point(344, 235);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(181, 42);
            this.buttonHistory.TabIndex = 7;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.HistoryButtonClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEdit.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonEdit.Location = new System.Drawing.Point(344, 301);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(181, 42);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::BloodBankSystem.Properties.Resources.m1;
            this.pictureBoxProfile.Location = new System.Drawing.Point(73, 112);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(166, 183);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 6;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BloodBankSystem.Properties.Resources.l1;
            this.pictureBox6.Location = new System.Drawing.Point(19, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(72, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = global::BloodBankSystem.Properties.Resources.Apps_Dialog_Logout_icon;
            this.buttonLogout.Location = new System.Drawing.Point(747, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(48, 48);
            this.buttonLogout.TabIndex = 19;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.LogoutButtonClick);
            // 
            // RegisteredMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "RegisteredMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Member_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDonateBlood;
        private System.Windows.Forms.Button buttonBloodRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelBloodGroup;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonEdit;
    }
}