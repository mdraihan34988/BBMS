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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_eclips1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1=new Login();
            l1.Show();
       
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchDoner s1 = new SearchDoner();
            s1.Show();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage s1 = new HomePage();
            s1.Show();

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodReqNon bn = new BloodReqNon();
            bn.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
