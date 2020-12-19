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
    public partial class BloodReqNon : Form
    {
        public BloodReqNon()
        {
            InitializeComponent();
        }

        private void BloodReqNon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     
      
       

        

      
       
      

        private void RequestButtonClick(object sender, EventArgs e)
        {
            string errors = "";
            errors += comboBoxBloodGroup.SelectedItem == null ? "\nPlease Provide Blood Group\n" : "";
            errors += textBoxQuantity.Text.Length == 0 ? "Please Provide Quantity\n" : "";
            if (textBoxQuantity.Text.Length != 0)
            {
                errors += Int32.Parse(textBoxQuantity.Text) < 0 ? "Quantity can not be negetive\n" : "";


            }

            if (errors == "")
            {
                string user = textBoxUsrname.Text;
                string reqtype;
                int quantity = Int32.Parse(textBoxQuantity.Text);
                string membertype = textBoxMemberStatus.Text;
                string bloodgroup = comboBoxBloodGroup.SelectedItem.ToString();
                var result = BloodStockController.CheckRequest(bloodgroup, quantity);
                if (result != 0)
                {
                    reqtype = "Accepted";
                    MessageBox.Show("Request Accepted. \n" + "Your service charge is : " + quantity * 100, "Success");
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream("D:/ExportPDF.pdf", FileMode.Create));
                    doc.Open();
                    Paragraph p = new Paragraph("Reciet  \n" + "\n" +
                        "User Type: Unregistered \n" +
                        "Blood Group: " + bloodgroup+"\n"+
                        "Quantity: "+ quantity+ "\n" +
                        "Service Charge: " + quantity * 100);
                    doc.Add(p);
                    doc.Close();

                    MessageBox.Show("Download Successfully a PDF of the Reciet!", "Success");

                }
                else
                {
                    reqtype = "Rejected";
                    MessageBox.Show("Request Rejected", "Failed");
                }
                RequestController.InsertRequest(user, membertype, reqtype, bloodgroup, quantity);
                buttonBack.PerformClick();
            }
            else
            {
                MessageBox.Show(errors, "Filled the flowing!");
                return;


            }



        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void BloodReqNon_Load(object sender, EventArgs e)
        {

        }
    }
}
