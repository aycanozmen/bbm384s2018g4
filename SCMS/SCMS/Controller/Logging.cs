using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS
{
    public class Logging
    {
        int _id;

        DateTime _login;
        DateTime _logout;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public DateTime Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        public DateTime Logout
        {
            get
            {
                return _logout;
            }

            set
            {
                _logout = value;
            }
        }
    }
}