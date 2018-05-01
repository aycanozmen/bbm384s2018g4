using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS
{
    public class User
    {
        int _id;
        string _name;
        string _surname;
        string _username;
        string _password;
        string _role;
        string _phone;
        string _gender;
        string _birthDate;
        public User()
        {

        }

        public User(int id, string name, string surname, string username, string password,  string role,string phone,
                   string gender, string birthDate)
        {
            this._id = id;
            this._name = name;
            this._surname = surname;
            this._username = username;
            this._password = password;
            this._role = role;
            this._phone = phone;
            this._gender = gender;
            this._birthDate = birthDate;
            

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

        public string Role
        {
            get
            {
                return _role;
            }

            set
            {
                _role = value;
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

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
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

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public string BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                _birthDate = value;
            }
        }

      


    }
}