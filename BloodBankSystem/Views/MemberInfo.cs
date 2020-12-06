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
    public partial class MemberInfo : Form
    {
        string a, b, c;
        public MemberInfo()
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

        private void MemberInfoFromClosingEventClick(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MemberInfoLoad(object sender, EventArgs e)
        {
            var member = ResisterController.GetAllMember();
            dataGridViewMember.DataSource = member;
            buttonPDF.Visible = true;
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("D:/ExportPDF.pdf", FileMode.Create));
            doc.Open();
            Paragraph p = new Paragraph(" \t\t\t  Report  " +
                "\n" +
                "\n" +
                "\n");
            doc.Add(p);
            PdfPTable pt = new PdfPTable(dataGridViewMember.Columns.Count);
            for (int j = 0; j < dataGridViewMember.Columns.Count; j++)
            {
                pt.AddCell(new Phrase(dataGridViewMember.Columns[j].HeaderText));
            }

            pt.HeaderRows = 1;


            for (int l = 0; l < dataGridViewMember.Rows.Count; l++)
            {
                for (int k = 0; k < dataGridViewMember.Columns.Count; k++)
                {
                    pt.AddCell(new Phrase(dataGridViewMember[k, l].Value.ToString()));

                }
            }
            doc.Add(pt);
            doc.Close();

            MessageBox.Show("Export Pdf Successfully!", "Success");
        }

        private void ManageClickEvent(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var res = ResisterController.updatepermission(b, c);
                if (!res)
                {


                }
                else
                {
                    MessageBox.Show("Status Changed", "Message");
                    textBox1.Text = "";
                    var member = ResisterController.GetAllMember();
                    dataGridViewMember.DataSource = member;
                }

            }
            else
            {
                MessageBox.Show("Select User to manage", "Alert");
            }
        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMember.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dataGridViewMember.CurrentRow.Selected = true;
                textBox1.Text = dataGridViewMember.Rows[e.RowIndex].Cells["userName"].FormattedValue.ToString();
                c = dataGridViewMember.Rows[e.RowIndex].Cells["userName"].FormattedValue.ToString();
                a = dataGridViewMember.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                if (a == "Invalid")
                {
                    b = "Valid";
                }
                if (a == "Valid")
                {
                    b = "Invalid";
                }
            }

        }
    }
}
