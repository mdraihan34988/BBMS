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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BloodBankSystem.Views
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
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
            Admin a = new Admin();
            a.Show();
        }

        private void HistoryFromClosingEventClick(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDonor_Click(object sender, EventArgs e)
        {
            buttonPDF.Visible = true;
            RequestChart.Visible = false;
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var donor = BloodDonorController.GetAllDonor();
            dataGridViewHistory.DataSource = donor;
            
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            buttonPDF.Visible = true;
            RequestChart.Visible = false;
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var request = RequestController.GetAllRequest();
            dataGridViewHistory.DataSource = request;
        }

        private void BalanceButtonClick(object sender, EventArgs e)
        {
            buttonPDF.Visible = false;
            dataGridViewHistory.DataSource = null;
            var result = RequestController.GetBalance();
            labelBalance.Text = result.ToString()+" BDT";
            var res = RequestController.GetRequestBalance();
            int i = 0;
            RequestChart.Visible = true;

            string[] arr = new string[20];







            foreach (var series in RequestChart.Series)
            {
                series.Points.Clear();
            }
            RequestChart.Titles.Clear();
            RequestChart.Titles.Add("Request Balance");
           




            foreach (var val in res)
            {
                
                    arr[i] = res[i].ToString();
                
                
                i++;

            }

            for (int j = 0; j < arr.Length && i > 0; j = j + 2)
            {
                RequestChart.Series["Balance"].Points.AddXY(arr[j], arr[j + 1]);
                i = i - 2;

            }

        }

        private void History_Load(object sender, EventArgs e)
        {
            RequestChart.Visible = false;
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("D:/ExportPDF.pdf", FileMode.Create));
            doc.Open();
            Paragraph p = new Paragraph(" \t\t  Report  " +
                "\n" +
                "\n" +
                "\n");
            doc.Add(p);
            PdfPTable pt = new PdfPTable(dataGridViewHistory.Columns.Count);
            for(int j=0;j<dataGridViewHistory.Columns.Count;j++)
            {
                pt.AddCell(new Phrase(dataGridViewHistory.Columns[j].HeaderText));
            }

            pt.HeaderRows = 1;


            for(int l=0;l<dataGridViewHistory.Rows.Count;l++)
            {
                for(int k=0;k<dataGridViewHistory.Columns.Count;k++)
                {
                    pt.AddCell(new Phrase(dataGridViewHistory[k, l].Value.ToString()));

                }
            }
            doc.Add(pt);
            doc.Close();

            MessageBox.Show("Export Pdf Successfully!", "Success");




        }
    }
}
