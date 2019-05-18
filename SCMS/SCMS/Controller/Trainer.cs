using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class Trainer : User
    {
        String _domain;
      
        public Trainer(int id, string name, string surname, string username, string password, string role, string phone, string gender, string birthDate, string domain) : base(id, name, surname, username, password, role, phone, gender, birthDate)
        {
            this._domain = domain;
        }

        public string Domain
        {
            get
            {
                return _domain;
            }

            set
            {
                _domain = value;
            }
        }
    }
}