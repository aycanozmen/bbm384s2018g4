using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class Member : User
    {
        double _height;
        double _weight;
        double _waistline;
        double _arm;
        double _leg;
        double _shoulder;
        double _chest;
        double _bodyFat;
        int _active;
        int _attendance;

        public Member(int id, string name, string surname, string username, string password, string role, string phone, string gender, string birthDate, double height, double weight, double arm, double waistline, double leg, double chest, double shoulder, double bodyFat, int active) : base(id, name, surname, username, password, role, phone, gender, birthDate)
        {

            this._height = height;
            this._weight = weight;
            this._arm = arm;
            this._bodyFat = bodyFat;
            this._active = active;

        }

        public double Shoulder
        {
            get
            {
                return _shoulder;
            }

            set
            {
                _shoulder = value;
            }
        }

        public int Attendance
        {
            get
            {
                return _attendance;
            }

            set
            {
                _attendance = value;
            }
        }

        public double Leg
        {
            get
            {
                return _leg;
            }

            set
            {
                _leg = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
            }
        }

        public double Waistline
        {
            get
            {
                return _waistline;
            }

            set
            {
                _waistline = value;
            }
        }

        public double Arm
        {
            get
            {
                return _arm;
            }

            set
            {
                _arm = value;
            }
        }

        public double Chest
        {
            get
            {
                return _chest;
            }

            set
            {
                _chest = value;
            }
        }

        public double BodyFat
        {
            get
            {
                return _bodyFat;
            }

            set
            {
                _bodyFat = value;
            }
        }

        public int Active
        {
            get
            {
                return _active;
            }

            set
            {
                _active = value;
            }
        }




    }
}