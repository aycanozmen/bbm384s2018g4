using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS
{
    public class Course
    {
        int _id;
        string _name;
        int _maxQuota;
        int _periodWeek;
        int _durationMinute;
        string _level;
        string _information;
        string _equipment;
        string _price;

        public Course()
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

        public int MaxQuota
        {
            get
            {
                return _maxQuota;
            }

            set
            {
                _maxQuota = value;
            }
        }

        public int PeriodWeek
        {
            get
            {
                return _periodWeek;
            }

            set
            {
                _periodWeek = value;
            }
        }

        public int DurationMinute
        {
            get
            {
                return _durationMinute;
            }

            set
            {
                _durationMinute = value;
            }
        }

        public string Level
        {
            get
            {
                return _level;
            }

            set
            {
                _level = value;
            }
        }

        public string Information
        {
            get
            {
                return _information;
            }

            set
            {
                _information = value;
            }
        }

        public string Equipment
        {
            get
            {
                return _equipment;
            }

            set
            {
                _equipment = value;
            }
        }

        public string Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
    }
}