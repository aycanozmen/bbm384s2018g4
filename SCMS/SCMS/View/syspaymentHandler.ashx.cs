using DataAccess;
using MySql.Data.MySqlClient;
using SCMS.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace SCMS.View
{
    /// <summary>
    /// Summary description for syspaymentHandler
    /// </summary>
    public class syspaymentHandler : IHttpHandler
    {

        public static List<Payment> getAllPayment()
        {
            List<Payment> payment = new List<Payment>();

            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("SELECT * FROM payments", connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Payment pymnt = new Payment();
                        pymnt.Id = Convert.ToInt32(reader["id"]);
                        pymnt.Type = reader["payment_type"].ToString();
                        pymnt.Exp = reader["explanation"].ToString();


                        payment.Add(pymnt);

                    }
                }
                connection.Close();
            }

            return payment;

        }
        public void ProcessRequest(HttpContext context)
        {
            string fnc = (string)context.Request["fnc"];


            if (fnc == "getTable")
            {
                List<Payment> payment = new List<Payment>();
                payment = getAllPayment();
                JavaScriptSerializer js = new JavaScriptSerializer();
                context.Response.Write(js.Serialize(payment));
            }

            else if (fnc == "deleteRow")
            {
                int id = Convert.ToInt32(context.Request["paymentID"]);
                bool isOk = PaymentController.DeletePayment(id);
                string message = "";
                if (isOk)
                {
                    message = "Deleted.";
                }
                else
                {
                    message = "Did not perform delete action.";
                }
                context.Response.Write(message);
            }
            else if (fnc == "newPayment")
            {
                try
                {
                    Payment pymnt = new Payment();
                    pymnt.Id = Convert.ToInt32(context.Request["id"]);
                    pymnt.Type = Convert.ToString(context.Request["payment_type"]);
                    pymnt.Exp = Convert.ToString(context.Request["explanation"]);


                    bool isOk = PaymentController.InsertPayment(pymnt);

                    string message = "";
                    if (isOk)
                    {
                        message = "Added.";
                    }
                    else
                    {
                        message = "Did not perform add action.";
                    }
                    context.Response.Write(message);
                }

                catch (Exception ex)
                {
                    string message = "";
                    message = "Did not perform add action.";
                    context.Response.Write(message);
                }


            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}