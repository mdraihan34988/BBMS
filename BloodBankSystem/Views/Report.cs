using System;
using BloodBankSystem.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BloodBankSystem.Views
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void ReportFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Report_Load(object sender, EventArgs e)
        {
            MemberChart.Visible = false;
            DonorChart.Visible = false;
            RequestChart.Visible = false;

        }

       

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a1 = new Admin();
            a1.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }

        private void RequestClickedEvent(object sender, EventArgs e)
        {
            MemberChart.Visible = false;
            DonorChart.Visible = false;
            RequestChart.Visible = true;
            var res = RequestController.GetRequest();
            int i = 0;

            string[] arr = new string[20];







            foreach (var series in RequestChart.Series)
            {
                series.Points.Clear();
            }
            RequestChart.Titles.Clear();
            RequestChart.Titles.Add("Request Quantity");

            foreach (var val in res)
            {
                arr[i] = res[i].ToString();
                i++;

            }

            for (int j = 0; j < arr.Length && i > 0; j = j + 2)
            {
                RequestChart.Series["Quantity"].Points.AddXY(arr[j], arr[j + 1]);
                i = i - 2;

            }

        }

        private void MemberClickedEvent(object sender, EventArgs e)
        {
            MemberChart.Visible = true;
            DonorChart.Visible = false;
            RequestChart.Visible = false;

            var res = ResisterController.GetGenderArray();







            foreach (var series in MemberChart.Series)
            {
                series.Points.Clear();
            }
            MemberChart.Titles.Clear();
            MemberChart.Titles.Add("Member by Gender");
            MemberChart.Series["Series1"].Points.AddXY(res[0],res[1].ToString());
            if (!res.Contains("Female"))
            {
                MemberChart.Series["Series1"].Points.AddXY("Female", "0");
            }
            else
            {
                MemberChart.Series["Series1"].Points.AddXY(res[2], res[3].ToString());
            }

            



        }

        private void DonorClickedEvent(object sender, EventArgs e)
        {
            MemberChart.Visible = false;
            DonorChart.Visible = true;
            RequestChart.Visible = false;
            var res = BloodDonorController.GetDonor();
            int i = 0;

            string[] arr= new string[20];







            foreach (var series in DonorChart.Series)
            {
                series.Points.Clear();
            }
            DonorChart.Titles.Clear();
            DonorChart.Titles.Add("Donate Quantity");

            foreach(var val in res)
            {
                arr[i] = res[i].ToString();
                i++;

            }

            for(int j=0;j<arr.Length &&i>0;j=j+2)
            {
                DonorChart.Series["Quantity"].Points.AddXY(arr[j],arr[j+1]);
                i=i-2;

            }
            
            

        }

        private void MemberChart_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }
    }
}
