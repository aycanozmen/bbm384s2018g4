using DataAccess;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS
{
    public class UserController
    {
        public static User GetAllUser(string username, string password)
        {
            User user = null;
            using (var connection = Database.GetConnection())
            {
                try
                {
                    var command = new MySqlCommand("SELECT * FROM users WHERE username=@username and password=@password", connection);

                    command.Parameters.Add(new MySqlParameter("username", username));
                    command.Parameters.Add(new MySqlParameter("password", password));
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                             reader.GetString(4), reader.GetString(5), reader.GetString(6),
                                             reader.GetString(7), reader.GetString(8)
                                            );
                        }
                    }
                }
                catch(MySqlException e)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
               
            }
            return user;
        }

        public static bool AddUser(User user)
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

    }
}