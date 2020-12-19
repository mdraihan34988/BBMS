using BloodBankSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Controllers
{
    public class RequestController
    {
        static Database db = new Database();
        public static ArrayList GetAllRequest()
        {
            return db.Requests.GetAllRequest();
        }
        public static ArrayList GetRequest()
        {
            return db.Requests.GetRequest();
        }
        public static ArrayList GetRequestBalance()
        {
            return db.Requests.GetRequestBalance();
        }
        public static void InsertRequest(string user,string memtype,string reqtype,string bloodgroup,int quantity)
        {
            db.Requests.InsertRequest(user, memtype, reqtype, bloodgroup, quantity);
        }
        public static int GetBalance()
        {
            return db.Requests.GetBalance();
        }
        public static int GetMemberBalance(string uname)
        {
            return db.Requests.GetMemberBalance(uname);
        }
        public static ArrayList GetAllMemberRequest(string uname)
        {
            return db.Requests.GetAllMemberRequest(uname);
        }

    }
}
