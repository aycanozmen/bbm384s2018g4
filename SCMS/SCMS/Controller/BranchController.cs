using DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class BranchController
    {



        public static bool InsertBranch(Branch branch)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("INSERT INTO branches(b_name,b_city,b_district,b_street,b_phone) VALUES(@name,@city,@district,@street,@phone)", connection);
                command.Parameters.Add(new MySqlParameter("name", branch.Name));
                command.Parameters.Add(new MySqlParameter("city", branch.City));
                command.Parameters.Add(new MySqlParameter("district", branch.District));
                command.Parameters.Add(new MySqlParameter("street", branch.Street));
                command.Parameters.Add(new MySqlParameter("phone", branch.Phone));
              
                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }


        public static bool UpdateBranch(Branch branch)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("UPDATE branches SET  b_name=@name,b_city=@city,b_district=@district,b_street=@street,b_phone=@phone WHERE b_id=@id", connection);

                command.Parameters.Add(new MySqlParameter("name", branch.Name));
                command.Parameters.Add(new MySqlParameter("city", branch.City));
                command.Parameters.Add(new MySqlParameter("district", branch.District));
                command.Parameters.Add(new MySqlParameter("street", branch.Street));
                command.Parameters.Add(new MySqlParameter("phone", branch.Phone));

                command.Parameters.Add(new MySqlParameter("id", branch.Id));

                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }


        public static bool DeleteBranch(int id)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {

                var command = new MySqlCommand("DELETE FROM branches WHERE b_id=@Id", connection);
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