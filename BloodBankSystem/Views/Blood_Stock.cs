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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace BloodBankSystem.Views
{
    public partial class Blood_Stock : Form
    {
        public Blood_Stock()
        {
            InitializeComponent();
        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage a = new HomePage();
            a.Show();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void BloodStockFromClosingEventClicked(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BloodStockFormLoad(object sender, EventArgs e)
        {
            buttonPDF.Visible = true;
            int j = 0;
            var bloodstock = BloodStockController.GetAllBloodGroup();
            dataGridViewStock.DataSource = bloodstock;

            foreach (var series in StockChart.Series)
            {
                series.Points.Clear();
            }
            StockChart.Titles.Clear();
            StockChart.Titles.Add("Blood Stock");
            BloodStock a = new BloodStock();

            foreach (var item in bloodstock)
            {
                a = (BloodStock)item;
                StockChart.Series["Blood Stock"].Points.AddXY(a.Blood_Group.ToString(), a.Stock.ToString());


            }

        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("D:/ExportPDF.pdf", FileMode.Create));
            doc.Open();
            Paragraph p = new Paragraph("\t\t\t   Report  " +
                "\n" +
                "\n" +
                "\n");
            doc.Add(p);
            PdfPTable pt = new PdfPTable(dataGridViewStock.Columns.Count);
            for (int j = 0; j < dataGridViewStock.Columns.Count; j++)
            {
                pt.AddCell(new Phrase(dataGridViewStock.Columns[j].HeaderText));
            }

            pt.HeaderRows = 1;


            for (int l = 0; l < dataGridViewStock.Rows.Count; l++)
            {
                for (int k = 0; k < dataGridViewStock.Columns.Count; k++)
                {
                    pt.AddCell(new Phrase(dataGridViewStock[k, l].Value.ToString()));

                }
            }
            doc.Add(pt);
            doc.Close();

            MessageBox.Show("Export Pdf Successfully!", "Success");
        }
    }
}
