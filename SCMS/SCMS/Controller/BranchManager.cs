using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class BranchManager : User
    {
        string _branchName;
        public BranchManager(int id, string name, string surname, string username, string password, string role, string phone, string gender, string birthDate) : base(id, name, surname, username, password, role, phone, gender, birthDate)
        {
        }


        public string BranchName
        {
            get
            {
                return _branchName;
            }

            set
            {
                _branchName = value;
            }
        }
    }
}