using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankSystem.Models;
using System.Collections;

namespace BloodBankSystem.Controllers
{
    public class ResisterController
    {
        static Database db = new Database();

        public static bool ResisterMember(string name,string username,string pass,string blgrp,DateTime dob,string mobnum,string prof,string gen,string mail,string add,byte[] a)
        {
            Member m = new Member();
            User u = new User();
            m.Name = name;
            m.Username = username;
            u.Password = pass;
            u.Status = "Valid";
            u.Type = "User";
            u.Username = username;
            m.Blood_Group = blgrp;
            m.Date_Of_Birth = dob;
            m.Mobile_Number = mobnum;
            m.Profession = prof;
            m.Gender = gen;
            m.Gmail = mail;
            m.Address = add;
            m.Profile_Picture =a;
            return db.Members.ResisterMember(m,u);
        }
        public static ArrayList GetAllMember()
        {
            return db.Members.GetAllMember();
        }
        public static ArrayList GetMember(string bloodgroup)
        {
            return db.Members.GetMember(bloodgroup);
        }
        public static dynamic ResisterUpdateMember(string mobilenumber,string email,string address,string user)
        {
            return db.Members.ResisterUpdateMember(mobilenumber,email,address,user);
        }
        public static string Verify(string username)
        {
            return db.Members.Verify(username);
        }
        public static void UpdatePassword(string user,string pass)
        {
            db.Members.UpdatePassword(user,pass);
        }
        public static ArrayList GetGenderArray()
        {
            return db.Members.GetGenderArray();
        }
        public static string VerifyPassword(string user)
        {
            return db.Members.VerifyPassword(user);
        }
        public static dynamic updatepermission(string a, string b)
        {
            return db.Members.updatepermission(a, b);
        }
    }
}
