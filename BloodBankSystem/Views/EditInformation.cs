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
    public partial class EditInformation : Form
    {
        Member mem;
        public EditInformation()
        {
            InitializeComponent();
        }
        public EditInformation(dynamic member)
        {
            InitializeComponent();
            this.mem = member;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember f1 = new RegisteredMember(mem);
            f1.Show();
        }

        private void EditInfoFromClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == null && textBoxEmail.Text == null && textBoxMobileNumber.Text == null)
            {
                MessageBox.Show("All text field are empty", "Alert");
            }
            else
            { 

                if (textBoxMobileNumber.Text.Length != 11 && textBoxMobileNumber.Text!=null)
                {
                    MessageBox.Show("Invalid Phone Number", "Alert");
                }
                else
                {
                    string mobile = (textBoxMobileNumber.Text == null) ? mem.Mobile_Number : textBoxMobileNumber.Text;
                    string gmail = (textBoxEmail.Text == null) ? mem.Gmail : textBoxEmail.Text;
                    string address = (textBoxAddress.Text == null) ? mem.Address : textBoxAddress.Text;

                    var res = ResisterController.ResisterUpdateMember(mobile, gmail, address, mem.Username);
                    if (res != null)
                    {
                        this.mem = res;
                        MessageBox.Show("Information Updated Successfully", "Message");
                        this.Hide();
                        RegisteredMember a = new RegisteredMember(mem);
                        a.Show();



                    }
                }
            }
                

        }

        private void ChangePassworLinkLabelClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangePassword a = new ChangePassword(mem);
            a.Show();
        }
    }
}
