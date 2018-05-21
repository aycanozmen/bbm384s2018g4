using DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SCMS.Controller
{

        public class MemberController
        {
            public static bool InsertMember(Member user)
            {
                bool result = false;
                using (var connection = Database.GetConnection())
                {
                    var command = new MySqlCommand("INSERT INTO users(name, surname, username, password, role, phone,gender,birthdate) VALUES( @name, @surname, @username, @password, @role, @phone, @gender, @birthdate)", connection);

                    command.Parameters.Add(new MySqlParameter("name", user.Name));
                    command.Parameters.Add(new MySqlParameter("surname", user.Surname));
                    command.Parameters.Add(new MySqlParameter("username", user.Username));
                    command.Parameters.Add(new MySqlParameter("password", user.Password));
                    command.Parameters.Add(new MySqlParameter("role", "user"));
                    command.Parameters.Add(new MySqlParameter("phone", user.Phone));
                    command.Parameters.Add(new MySqlParameter("gender", user.Gender));
                    command.Parameters.Add(new MySqlParameter("birthdate", user.BirthDate));
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        result = true;
                    }
                    connection.Close();
                }
                return result;
            }

        public static bool InsertPhysicalProperty(Member user)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("INSERT INTO members (height, weight, waistline, arm, leg, shoulder, chest, bodyFat, active) VALUES( @height, @weight, @waistline, @arm, @leg, @shoulder, @chest, @bodyFat, @active)", connection);

                command.Parameters.Add(new MySqlParameter("height", user.Height));
                command.Parameters.Add(new MySqlParameter("weight", user.Weight));
                command.Parameters.Add(new MySqlParameter("waistline", user.Waistline));
                command.Parameters.Add(new MySqlParameter("arm", user.Arm));
                command.Parameters.Add(new MySqlParameter("leg", user.Leg));
                command.Parameters.Add(new MySqlParameter("shoulder", user.Shoulder));
                command.Parameters.Add(new MySqlParameter("chest", user.Chest));
				command.Parameters.Add(new MySqlParameter("bodyFat", user.BodyFat));
				command.Parameters.Add(new MySqlParameter("active", user.Active));


                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }


        public static bool UpdatePhysicalProperty(Member user)
            {
                bool result = false;
                using (var connection = Database.GetConnection())
                {
                    var command = new MySqlCommand("UPDATE members SET height=@height, weight=@weight, waistline=@waistline, arm=@arm, leg=@leg, shoulder=@shoulder, chest=@chest, bodyFat=@bodyFat, active=@active WHERE user_id=@id", connection);

                command.Parameters.Add(new MySqlParameter("height", user.Height));
                command.Parameters.Add(new MySqlParameter("weight", user.Weight));
                command.Parameters.Add(new MySqlParameter("waistline", user.Waistline));
                command.Parameters.Add(new MySqlParameter("arm", user.Arm));
                command.Parameters.Add(new MySqlParameter("leg", user.Leg));
                command.Parameters.Add(new MySqlParameter("shoulder", user.Shoulder));
                command.Parameters.Add(new MySqlParameter("chest", user.Chest));
				command.Parameters.Add(new MySqlParameter("bodyFat", user.BodyFat));
				command.Parameters.Add(new MySqlParameter("active", user.Active));

                    command.Parameters.Add(new MySqlParameter("id", user.Id));    //??????????????????????????????????

                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        result = true;
                    }
                    connection.Close();
                }
                return result;
            }
        public static bool UpdateAttandanceList(Member user)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("SELECT attendance FROM members WHERE  user_id=@id", connection);
                command.Parameters.Add(new MySqlParameter("id", user.Id));

                MySqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    int attendance = Convert.ToInt32(reader["attendance"]);
                    attendance =attendance+1;
                }
                

                var command2 = new MySqlCommand("UPDATE members SET  attendance=@attendance WHERE user_id=@id", connection);
                command2.Parameters.Add(new MySqlParameter("user_id", user.Id));
                command2.Parameters.Add(new MySqlParameter("attendance", user.Attendance));


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
