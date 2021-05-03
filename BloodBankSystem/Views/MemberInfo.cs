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
            //Document doc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
           
            //PdfWriter.GetInstance(doc, new FileStream("D:/ExportPDF.pdf", FileMode.Create));
            //doc.Open();
            //Paragraph p = new Paragraph(" \t\t\t  Report  " +
            //    "\n" +
            //    "\n" +
            //    "\n");
            //doc.Add(p);
            //PdfPTable pt = new PdfPTable(dataGridViewMember.Columns.Count);
            //pt.DefaultCell.Padding = 1;
            //pt.WidthPercentage = 100;
            //pt.HorizontalAlignment = Element.ALIGN_LEFT;
            //for (int j = 0; j < dataGridViewMember.Columns.Count; j++)
            //{
            //    pt.AddCell(new Phrase(dataGridViewMember.Columns[j].HeaderText));
            //}
            
            //pt.HeaderRows = 1;


            //for (int l = 0; l < dataGridViewMember.Rows.Count; l++)
            //{
            //    for (int k = 0; k < dataGridViewMember.Columns.Count; k++)
            //    {
            //        pt.AddCell(new Phrase(dataGridViewMember[k, l].Value.ToString()));

            //    }
            //}
            //doc.Add(pt);
            //doc.Close();

            //MessageBox.Show("Export Pdf Successfully!", "Success");
            //--------------------------------------------------------------


            if (dataGridViewMember.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridViewMember.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridViewMember.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridViewMember.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                
                                Paragraph p = new Paragraph(" \t\t\t  Report  " +
                                    "\n" +
                                    "\n" +
                                    "\n");
                                pdfDoc.Add(p);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        
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
