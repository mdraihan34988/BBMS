using BloodBankSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Controllers
{
    public class BloodDonorController
    {
        static Database db = new Database();
        public static ArrayList GetAllDonor()
        {
            return db.BloodDonors.GetAllDonor();

        }
        public static ArrayList GetDonor()
        {
            return db.BloodDonors.GetDonor();

        }
        public static ArrayList GetAllDonateHistory(string username)
        {
            return db.BloodDonors.GetAllDonateHistory(username);
        }
        public static dynamic GetLastDonateDate(string Username)
        {
            return db.BloodDonors.GetLastDonateDate(Username);
        }
        public static void InsertDonateInfo(Member member)
        {
            db.BloodDonors.InsertDonateInfo(member);
        }

    }
}
