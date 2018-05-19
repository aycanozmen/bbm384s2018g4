using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class BranchManagerController
    {
        
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
    }
}
