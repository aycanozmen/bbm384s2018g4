using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class Payment
    {
        int _id;
        string _type;
        string _exp;

        public Payment()
        {

        }
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

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Exp
        {
            get
            {
                return _exp;
            }

            set
            {
                _exp = value;
            }
        }
    }
}