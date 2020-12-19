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
    public partial class BloodDonate : Form
    {
        Member mem;
       
        public BloodDonate()
        {
            InitializeComponent();
        }
        public BloodDonate(dynamic member)
        {
            InitializeComponent();
            this.mem = member;
           

        }









        private void BloodDonate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       



       

        private void SubmitButtonClicked(object sender, EventArgs e)
        {
            BloodDonorController.InsertDonateInfo(mem);
            BloodStockController.UpdateStock(mem.Blood_Group);
            MessageBox.Show("Thank you for your donation","Message");
            //buttonBack.PerformClick();
            this.Hide();
            RegisteredMember f1 = new RegisteredMember(mem);
            f1.Show();
        }

        private void BackButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember f1 = new RegisteredMember(mem);
            f1.Show();
        }

       
        private void DonateBloodLoadingEvent(object sender, EventArgs e)
        {
            DateTime result = BloodDonorController.GetLastDonateDate(mem.Username);
            TimeSpan donatetime = DateTime.Now.Subtract(result);
            if(result==DateTime.Parse("01/01/1753"))
            {
                dateTimePickerLastTimeDonate.Visible = false;
            }
            else
            {
                
               
                dateTimePickerLastTimeDonate.Visible = true;
                dateTimePickerLastTimeDonate.Value = DateTime.Parse( result.ToShortDateString());


            }
            
            if (donatetime.TotalDays >= 90)
            {
                buttonSubmit.Visible = true;

            }
            else
            {
                double a = 90 - donatetime.TotalDays;
                int c = (int)a;
                MessageBox.Show("You can not donate blood before " + c.ToString() + " Days", "Alert");
               // buttonBack.PerformClick();

            }

        }

        private void panelBloodDonate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
