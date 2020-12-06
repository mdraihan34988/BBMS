using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace BloodBankSystem.Models
{
    public class BloodStocks
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string query;
        public BloodStocks()
        {
            conn = new SqlConnection("Server=desktop-5v4h2f1\\sqlexpress;Database=Blood_Bank_Management;User Id=sa;Password=123456;");
        }
        public ArrayList GetAllBloodGroup()
        {
            ArrayList BloodStock = new ArrayList();
            try
            {
                conn.Open();
                query = "Select * from BloodStocks";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    BloodStock a = new BloodStock();
                  
                    a.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    a.Stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                    a.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    BloodStock.Add(a);
                }
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"Alert");
                conn.Close();
            }
            return BloodStock;
           

        }
        public int CheckRequest(string bloodgroup,int quantity)
        {
            int result = 0;
            try
            {
                conn.Open();
                query = "Update BloodStocks set Stock=Stock-'" + quantity + "' where Stock>='" + quantity + "' and Blood_Group='"+bloodgroup+"'";
                cmd = new SqlCommand(query, conn);
                result = cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Alert");
            }
            return result;
        }
        public void UpdateStock(string bloodgroup)
        {
            try
            {
                conn.Open();
                query = "Update BloodStocks set Stock=Stock+1 where Blood_Group='" + bloodgroup + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Alert");
                conn.Close();
            }
        }
    }
}
