using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class Branch

    {
        int _id;
        string _name;
        string _city;
        string __district;
        string _street;
        string _phone;

        public Branch()
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

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string District
        {
            get
            {
                return __district;
            }

            set
            {
                __district = value;
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }

            set
            {
                _street = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
    }
}