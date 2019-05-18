using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class BranchManagerController
    {
        
        public static bool InsertUser(BranchManager user)
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

        public static bool InsertBranchManager(BranchManager user)
        {

            bool result = false;

            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("INSERT INTO branch_managers (user_id, b_name) VALUES ((SELECT MAX(id) FROM users), @name)", connection);
                command.Parameters.Add(new MySqlParameter("name", user.BranchName));

                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();

            }

            return result;

        }
        
         public static bool DeleteBranchManager(int id)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {

                var command = new MySqlCommand("DELETE FROM branchmanager WHERE b_id=@Id", connection);
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
        
        
        public static bool UpdateBranchManager(BranchManager user)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("UPDATE users SET name=@name, surname=@surname, username=@username, password=@password, role=@role, phone=@phone, gender=@gender, birthdate=@birthdate WHERE id=@id", connection);
                var command2 = new MySqlCommand("UPDATE branch_managers SET b_name=@name  WHERE user_id=@id", connection);

                command.Parameters.Add(new MySqlParameter("name", user.Name));
                command.Parameters.Add(new MySqlParameter("surname", user.Surname));
                command.Parameters.Add(new MySqlParameter("username", user.Username));
                command.Parameters.Add(new MySqlParameter("password", user.Password));
                command.Parameters.Add(new MySqlParameter("role", "user"));
                command.Parameters.Add(new MySqlParameter("phone", user.Phone));
                command.Parameters.Add(new MySqlParameter("gender", user.Gender));
                command.Parameters.Add(new MySqlParameter("birthdate", user.BirthDate));
                command.Parameters.Add(new MySqlParameter("user_id", user.Id));
                command2.Parameters.Add(new MySqlParameter("user_id", user.Id));
                command2.Parameters.Add(new MySqlParameter("b_name", user.BranchName));

                connection.Open();
                if (command.ExecuteNonQuery() != -1 && command2.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }
    }
}
