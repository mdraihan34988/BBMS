using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankSystem.Controllers;
using BloodBankSystem.Models;

namespace BloodBankSystem.Views
{
    public partial class RegisteredMember : Form
    {
        Member mem;
       
        public RegisteredMember()
        {
            InitializeComponent();
        }
        public RegisteredMember(dynamic member)
        {
            InitializeComponent();
            this.mem = member;
            labelName.Text = member.Name;
            labelBloodGroup.Text = member.Blood_Group;
            MemoryStream ms = new MemoryStream(member.Profile_Picture);
            pictureBoxProfile.Image = Image.FromStream(ms);
            


        }

      

       

        private void Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
        
     

       

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void Donate_BloodButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            BloodDonate a = new BloodDonate(mem);
            a.Show();
        }

        private void Blood_RequestClick(object sender, EventArgs e)
        {
            this.Hide();
            BloodRequest a = new BloodRequest(mem);
            a.Show();
        }

        private void HistoryButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            MemberHistory a = new MemberHistory(mem);
            a.Show();
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            EditInformation a = new EditInformation(mem);
            a.Show();
        }
    }
}
