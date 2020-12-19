using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem.Models
{
    public class Requests
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string query;
        public Requests()
        {
            conn = new SqlConnection("Server=desktop-5v4h2f1\\sqlexpress;Database=Blood_Bank_Management;User Id=sa;Password=123456;");

        }
        public ArrayList GetRequest()
        {
            ArrayList a = new ArrayList();


            try
            {
                conn.Open();
                query = "SELECT sum(Quantity) as Total,Blood_Group from Requests Group by Blood_Group";

                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    a.Add(reader.GetString(reader.GetOrdinal("Blood_Group")));

                    a.Add(reader.GetInt32(reader.GetOrdinal("Total")));




                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return a;
        }
        public ArrayList GetRequestBalance()
        {
            ArrayList a = new ArrayList();


            try
            {
                conn.Open();
                query = "SELECT sum(ServiceCharge) as Total,Blood_Group from Requests Group by Blood_Group";

                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    a.Add(reader.GetString(reader.GetOrdinal("Blood_Group")));

                    a.Add(reader.GetInt32(reader.GetOrdinal("Total")));




                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return a;
        }
        public ArrayList GetAllRequest()
        {
            ArrayList requests = new ArrayList();


            try
            {
                conn.Open();
                query = "Select * from Requests";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Request a = new Request();
                    a.Blood_Group= reader.GetString(reader.GetOrdinal("Blood_Group"));
                    a.Username = reader.GetString(reader.GetOrdinal("Username"));
                    a.Order_Status = reader.GetString(reader.GetOrdinal("Order_Status"));
                    a.Member_Status = reader.GetString(reader.GetOrdinal("Member_Status"));
                    a.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                    a.Order_Serial = reader.GetInt32(reader.GetOrdinal("Order_Serial"));
                    a.ServiceCharge = reader.GetInt32(reader.GetOrdinal("ServiceCharge"));
                    


                    requests.Add(a);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return requests;
        }
        public void InsertRequest(string username,string membertype,string ordertype,string bloodgroup,int quantity)
        {
            int servchar = 0;
            if (membertype == "Non-Registered" && ordertype == "Accepted")
            {
                servchar = quantity * 100;
            }
            else if (membertype == "Registered" && ordertype == "Accepted")
            {
                servchar = quantity * (100/2);
            }
            else
                servchar = 0;
            try
            {
                conn.Open();
                query="Insert into Requests (Order_Status,Blood_Group,Member_Status,Quantity,Username,ServiceCharge) values ('"+ordertype+"','" +bloodgroup+"','"+membertype+"','"+quantity+"','"+username+ "','" + servchar + "')";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch(Exception e)
            {
                //MessageBox.Show(e.Message, "Alert");
                conn.Close();
            }

        }
        public int GetBalance()
        {
            int result=0;
            try
            {
                conn.Open();
                query = "Select sum(ServiceCharge) as Balance from Requests";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    result = reader.GetInt32(reader.GetOrdinal("Balance"));



                   
                }
                conn.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return result;
        }
        public int GetMemberBalance(string username)
        {
            int result = 0;
            try
            {
                conn.Open();
                query = "Select sum(ServiceCharge) as Balance from Requests where Username ='"+username+"'";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    result = reader.GetInt32(reader.GetOrdinal("Balance"));




                }
                conn.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return result;
        }
        public ArrayList GetAllMemberRequest(string uname)
        {
            ArrayList requests = new ArrayList();


            try
            {
                conn.Open();
                query = "Select * from Requests where Username='"+uname+"'";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Request a = new Request();
                    a.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    a.Username = reader.GetString(reader.GetOrdinal("Username"));
                    a.Order_Status = reader.GetString(reader.GetOrdinal("Order_Status"));
                    a.Member_Status = reader.GetString(reader.GetOrdinal("Member_Status"));
                    a.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                    a.Order_Serial = reader.GetInt32(reader.GetOrdinal("Order_Serial"));
                    a.ServiceCharge = reader.GetInt32(reader.GetOrdinal("ServiceCharge"));



                    requests.Add(a);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return requests;
        }
    }
}
