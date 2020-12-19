using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections;

namespace BloodBankSystem.Models
{
    public class Members
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string query;
        Byte[] ImageByteArray;
        public Members()
        {
             conn = new SqlConnection("Server=desktop-5v4h2f1\\sqlexpress;Database=Blood_Bank_Management;User Id=sa;Password=123456;");
        }

        public bool ResisterMember(Member member,User u)
        {
            int result = 0;
            try
            {
                           
                conn.Open();
                byte[] img = member.Profile_Picture;

                query = "INSERT INTO Members (Username,Name,Blood_Group,Date_Of_Birth,Gender,Profession,Mobile_Number,Gmail,Address,Profile_Picture) " +
                                        "VALUES('" + member.Username + "','" +member.Name+ "','" + member.Blood_Group + "','" + member.Date_Of_Birth +
                                        "','" + member.Gender + "','" + member.Profession + "','" + member.Mobile_Number + "','" + member.Gmail +
                                         "','" + member.Address + "',@img)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                result = cmd.ExecuteNonQuery();
                conn.Close();
                
            }
            catch(Exception)
            {
                MessageBox.Show("User Name Already exists!","Alert");
                conn.Close();
            }
            if (result != 0)
            {
                try
                {

                    conn.Open();
                   

                    query = "INSERT INTO Users (Username,Password,Status,Type) " +
                                            "VALUES('" + u.Username + "','" + u.Password + "','" + u.Status + "','" + u.Type + "')";
                    cmd = new SqlCommand(query, conn);
                   
                    result = cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Alert");
                    conn.Close();
                }

                return true;

            } 
            else 
            return false;
        }
        public ArrayList GetGenderArray()
        {
            ArrayList a = new ArrayList();
            
            try
            {
                conn.Open();
                string query = "SELECT count(Gender) as Total,Gender from Members Group by Gender";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    a.Add(reader.GetString(reader.GetOrdinal("Gender")));
                    
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
        public Member ValidityMember(string uname,string pass)
        {
            Member member = null;
            try
            {
                conn.Open();
                string query = "SELECT * FROM Members WHERE Username='" + uname + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    member = new Member();

                    member.Name = reader.GetString(reader.GetOrdinal("Name"));
                    member.Profile_Picture = (byte[])(reader[reader.GetOrdinal("Profile_Picture")]);
                    member.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    member.Username = reader.GetString(reader.GetOrdinal("Username"));




                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();
            }


            return member;

        }
        public User Validity(string uname, string pass)
        {
            User member = null;
            try
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Username='" + uname + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    member = new User();

                    
                    member.Username = reader.GetString(reader.GetOrdinal("Username"));
                    member.Type = reader.GetString(reader.GetOrdinal("Type"));
                    member.Status = reader.GetString(reader.GetOrdinal("Status"));





                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();
            }


            return member;

        }

        public ArrayList GetAllMember()
        {
            ArrayList members = new ArrayList();
           
         
            try
            {
                conn.Open();
                query = "Select * from Members,Users where Members.Username =Users.Username and Type='User'";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    MemberInfo a = new MemberInfo();
                    a.Name = reader.GetString(reader.GetOrdinal("Name"));
                    a.Username = reader.GetString(reader.GetOrdinal("Username"));                  
                    a.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    a.Date_Of_Birth = reader.GetDateTime(reader.GetOrdinal("Date_Of_Birth"));
                    a.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    a.Mobile_Number = reader.GetString(reader.GetOrdinal("Mobile_Number"));
                    a.Address = reader.GetString(reader.GetOrdinal("Address"));
                    a.Gmail = reader.GetString(reader.GetOrdinal("Gmail"));
                    a.Profession = reader.GetString(reader.GetOrdinal("Profession"));
                    a.Status = reader.GetString(reader.GetOrdinal("Status"));
                  
                   
                    members.Add(a);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return members;


        }
        public bool updatepermission(string a, string b)
        {
            int result = 0;
            try
            {

                conn.Open();


                query = "Update Users set Status='" + a + "' where USERNAME='" + b + "'";
                cmd = new SqlCommand(query,conn);
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Alert");
                conn.Close();
            }
            if (result != 0) return true;
            else return false;

        }
        public ArrayList GetMember(string bloodgroup)
        {
            ArrayList members = new ArrayList();
           
            try
            {
                conn.Open();
                query = "Select Name,Address,Mobile_Number,Gmail from Members where Blood_Group ='" + bloodgroup + "'";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    SearchMember a = new SearchMember();
                    a.Name = reader.GetString(reader.GetOrdinal("Name"));
                    a.Mobile_Number = reader.GetString(reader.GetOrdinal("Mobile_Number"));
                    a.Address = reader.GetString(reader.GetOrdinal("Address"));
                    a.Gmail = reader.GetString(reader.GetOrdinal("Gmail"));


                    members.Add(a);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return members;
        }
        public Member ResisterUpdateMember(string mobilenumber,string email,string address,string user)
        {
            Member member = null;
            int result = 0;
            try
            {
                conn.Open();
                string query = "update Members set Mobile_Number='"+mobilenumber+"',Gmail='"+email+"',Address='"+address+"' where Username='"+user+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();
            }
            if(result!=0)
            {
                return this.GetUpdateMember(user);

            }


            return member;
        }
        public Member GetUpdateMember(string username)
        {
            Member member = null;

            try
            {
                conn.Open();
                query = "Select * from Members where Username ='" + username + "'";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    member = new Member();
                    
                    member.Name = reader.GetString(reader.GetOrdinal("Name"));
                  
                    member.Mobile_Number = reader.GetString(reader.GetOrdinal("Mobile_Number"));
                    member.Address = reader.GetString(reader.GetOrdinal("Address"));
                    member.Gmail = reader.GetString(reader.GetOrdinal("Gmail"));
                    member.Profile_Picture = (byte[])(reader[reader.GetOrdinal("Profile_Picture")]);
                    member.Blood_Group = reader.GetString(reader.GetOrdinal("Blood_Group"));
                    member.Username = reader.GetString(reader.GetOrdinal("Username"));
                  
                    




                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return member;
        }
        public string Verify(string username)
        {
            string result = null;

            try
            {
                conn.Open();
                query = "Select Mobile_Number from Members where Username ='" + username + "'";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    result = reader.GetString(reader.GetOrdinal("Mobile_Number"));




                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return result;


        }
        public void UpdatePassword(string username,string password)
        {
            try
            {
                conn.Open();
                string query = "update Members set Password='" + password + "' where Username='" + username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();
            }
        }
        public string VerifyPassword(string username)
        {
            string result = null;

            try
            {
                conn.Open();
                query = "Select Password from Members where Username ='" + username + "'";
                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    result = reader.GetString(reader.GetOrdinal("Password"));




                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
                conn.Close();

            }
            return result;


        }
    }
}
