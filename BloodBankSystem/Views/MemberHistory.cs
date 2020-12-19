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
    public partial class MemberHistory : Form
    {
        Member mem;
        public MemberHistory()
        {
            InitializeComponent();
        }
        public MemberHistory(dynamic member)
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

        private void MemberHistoryFromCLosinfEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AmountPaidButtonClick(object sender, EventArgs e)
        {
            buttonPDF.Visible = false;
            dataGridViewHistory.DataSource = null;
            var result = RequestController.GetMemberBalance(mem.Username);
            labelBalance.Text = result.ToString()+" BDT";
        }

        private void RequestHIstoryButtonClick(object sender, EventArgs e)
        {
            buttonPDF.Visible = true;
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var request = RequestController.GetAllMemberRequest(mem.Username);
            dataGridViewHistory.DataSource = request;
        }

        private void buttonDonor_Click(object sender, EventArgs e)
        {
            buttonPDF.Visible = true;
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var donor = BloodDonorController.GetAllDonateHistory(mem.Username);
            dataGridViewHistory.DataSource = donor;
        }

        private void MemberHistory_Load(object sender, EventArgs e)
        {

        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("D:/"+this.mem.Username+".pdf", FileMode.Create));
            doc.Open();
            Paragraph p = new Paragraph("   Report  " +
                "" +
                "" +
                "");
            doc.Add(p);
            PdfPTable pt = new PdfPTable(dataGridViewHistory.Columns.Count);
            for (int j = 0; j < dataGridViewHistory.Columns.Count; j++)
            {
                pt.AddCell(new Phrase(dataGridViewHistory.Columns[j].HeaderText));
            }

            pt.HeaderRows = 1;


            for (int l = 0; l < dataGridViewHistory.Rows.Count; l++)
            {
                for (int k = 0; k < dataGridViewHistory.Columns.Count; k++)
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
