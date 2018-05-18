using DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMS.Controller
{
    public class PaymentController
    {

        public static bool InsertPayment(Payment payment)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("INSERT INTO payments(payment_type , explanation) VALUES(@type,@exp)", connection);
                command.Parameters.Add(new MySqlParameter("type", payment.Type));
                command.Parameters.Add(new MySqlParameter("exp", payment.Exp));
         
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