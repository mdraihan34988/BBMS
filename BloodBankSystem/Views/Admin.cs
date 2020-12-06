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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }  

       

        
        private void StockButtonClick(object sender, EventArgs e)
        {
           
            
                this.Hide();
                Blood_Stock a = new Blood_Stock();
                a.Show();
            
        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h1 = new HomePage();
            h1.Show();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void HistoryButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            History a = new History();
            a.Show();
        }

        private void MemberInformationButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            MemberInfo a = new MemberInfo();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report a = new Report();
            a.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
