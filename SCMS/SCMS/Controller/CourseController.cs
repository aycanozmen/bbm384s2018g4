using DataAccess;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS
{
    public class CourseController
    {
        
        public static bool InsertCourse(Course course)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("INSERT INTO courses(c_name, c_maxquota, c_periodweek, c_durationminute, c_level, c_price,c_equipment,c_information) VALUES(@name,@maxQuota,@periodWeek,@durationMinute,@level,@price,@equipment,@information)", connection);
                command.Parameters.Add(new MySqlParameter("name", course.Name));
                command.Parameters.Add(new MySqlParameter("maxQuota", course.MaxQuota));
                command.Parameters.Add(new MySqlParameter("periodWeek", course.PeriodWeek));
                command.Parameters.Add(new MySqlParameter("durationMinute", course.DurationMinute));
                command.Parameters.Add(new MySqlParameter("level", course.Level));
                command.Parameters.Add(new MySqlParameter("price", course.Price));
                command.Parameters.Add(new MySqlParameter("equipment", course.Equipment));
                command.Parameters.Add(new MySqlParameter("information", course.Information));
                command.Parameters.Add(new MySqlParameter("id", course.Id));
                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }

         
        public static bool UpdateCourse(Course course)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("UPDATE courses SET  c_name=@name,c_maxquota=@maxQuota,c_periodweek=@periodWeek,c_durationminute=@durationMinute,c_level=@level,c_price=@price,c_equipment=@equipment,c_information=@information WHERE c_id=@id", connection);

                command.Parameters.Add(new MySqlParameter("name", course.Name));
                command.Parameters.Add(new MySqlParameter("maxQuota", course.MaxQuota));
                command.Parameters.Add(new MySqlParameter("periodWeek", course.PeriodWeek));
                command.Parameters.Add(new MySqlParameter("durationMinute", course.DurationMinute));
                command.Parameters.Add(new MySqlParameter("level", course.Level));
                command.Parameters.Add(new MySqlParameter("price", course.Price));
                command.Parameters.Add(new MySqlParameter("equipment", course.Equipment));
                command.Parameters.Add(new MySqlParameter("information", course.Information));

                command.Parameters.Add(new MySqlParameter("id", course.Id));

                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }
       

        public static bool DeleteCourse(int id)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {

                var command= new MySqlCommand("DELETE FROM courses WHERE c_id=@Id", connection);
                command.Parameters.Add(new MySqlParameter("Id", id));
                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();


            }
            return result;
        }

    }
}