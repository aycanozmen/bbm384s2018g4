using DataAccess;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS
{
    public class LoggingController
    {
        public static bool InsertLog()
        {
            User session =
            (User)HttpContext.Current.Session["userClass"];

            bool result = false;
            using (var connection = Database.GetConnection())
            {

                var command = new MySqlCommand("INSERT INTO logging(userid,logindate) VALUES(@userId,@logindate)", connection);
                command.Parameters.Add(new MySqlParameter("userId", session.Id));
                command.Parameters.Add(new MySqlParameter("logindate", DateTime.UtcNow));
                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }
        public static bool InsertLogout()
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                User session =
                (User)HttpContext.Current.Session["userClass"];

                var command = new MySqlCommand("UPDATE logging SET logoutdate=@logoutdate WHERE userid=@Id and logoutdate IS NULL ", connection);

                command.Parameters.Add(new MySqlParameter("Id", session.Id));
                command.Parameters.Add(new MySqlParameter("logoutdate", DateTime.UtcNow));
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