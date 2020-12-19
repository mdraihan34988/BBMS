using BloodBankSystem.Controllers;
using BloodBankSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem.Views
{
    public partial class ChangePassword : Form
    {
        Member mem;
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(dynamic member)
        {
            InitializeComponent();
            this.mem = member;
        }

        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == textBoxRepass.Text)
            {
                string errors = "";
                errors += textBoxNewPassword.Text.Length == 0 ? "\nPlease Provide New Password" : "";
                errors += textBoxRepass.Text.Length == 0 ? "\nPlease provide Retype Password" : "";
                errors += textBoxOldPassword.Text.Length == 0 ? "\nPlease Provide Old Password" : "";
                if (errors.Length == 0)
                {
                    var result = ResisterController.VerifyPassword(mem.Username);
                    if (result == textBoxOldPassword.Text)
                    {
                        ResisterController.UpdatePassword(mem.Username, textBoxNewPassword.Text);
                        MessageBox.Show("Password Changed Succesfully", "Message");
                        this.Hide();
                        RegisteredMember a = new RegisteredMember(mem);
                        a.Show();

                    }
                    else
                    {
                        MessageBox.Show("Your password is incorrect", "Alert");
                    }
                }
                else
                {
                    MessageBox.Show(errors, "Filled the flowing!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("New password and re-Enter pasword doesn't match", "Alert");
            }
        }

        private void ChangePasswordFromClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember a = new RegisteredMember(mem);
            a.Show();

        }
    }
}
