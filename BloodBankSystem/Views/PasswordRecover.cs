using BloodBankSystem.Controllers;
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
    public partial class PasswordRecover : Form
    {
        public PasswordRecover()
        {
            InitializeComponent();
        }

        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            if(textBoxPassword.Text==textBoxRepass.Text)
            {
                string errors = "";
                errors += textBoxPassword.Text.Length == 0 ? "\nPlease Provide Password" : "";
                errors += textBoxRepass.Text.Length == 0 ? "\nPlease provide Retype password" : "";
                errors += textBoxUsername.Text.Length == 0 ? "\nPlease Provide User Name" : "";
                errors += (textBoxMobileNumber.Text.Length == 0 || textBoxMobileNumber.Text.Length != 11) ? "\nPlease Provide a Valid Mobile Number" : "";
                if (errors.Length==0)
                {
                    var result = ResisterController.Verify(textBoxUsername.Text);
                    if (result == textBoxMobileNumber.Text)
                    {
                        ResisterController.UpdatePassword(textBoxUsername.Text, textBoxPassword.Text);
                        MessageBox.Show("Password recover successfully", "Message");

                    }
                    else
                    {
                        MessageBox.Show("Your mobile number is incorrect", "Alert");
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
                MessageBox.Show("Password and Re-Enter pasword doesn't match", "Alert");
            }
            

        }

        private void PasswordRecoverFromClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }
    }
}
