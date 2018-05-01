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
    /// Summary description for sysbranchHandler
    /// </summary>
    public class sysbranchHandler : IHttpHandler
    {
        public static List<Branch> getAllBranch()
        {
            List<Branch> branch = new List<Branch>();

            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("SELECT b_id,b_name,b_city,b_district,b_street,b_phone FROM branches", connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Branch br = new Branch();
                        br.Id = Convert.ToInt32(reader["b_id"]);
                        br.Name = reader["b_name"].ToString();
                        br.City = (reader["b_city"]).ToString();
                        br.District = reader["b_district"].ToString();
                        br.Street = reader["b_street"].ToString();
                        br.Phone = reader["b_phone"].ToString();

                        branch.Add(br);

                    }
                }
                connection.Close();
            }

            return branch;

        }
        public void ProcessRequest(HttpContext context)
        {
            string fnc = (string)context.Request["fnc"];


            if (fnc == "getTable")
            {
                List<Branch> branch = new List<Branch>();
                branch = getAllBranch();
                JavaScriptSerializer js = new JavaScriptSerializer();
                context.Response.Write(js.Serialize(branch));
            }

            else if (fnc == "deleteRow")
            {
                int id = Convert.ToInt32(context.Request["branchID"]);
                bool isOk = BranchController.DeleteBranch(id);
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
            else if (fnc == "newBranch")
            {
                Branch branch = new Branch();
                branch.Id = Convert.ToInt32(context.Request["branchID"]);
                branch.Name = Convert.ToString(context.Request["name"]);
                branch.City = Convert.ToString(context.Request["city"]);
                branch.District = Convert.ToString(context.Request["district"]);
                branch.Street = Convert.ToString(context.Request["street"]);
                branch.Phone = Convert.ToString(context.Request["phone"]);

                bool isOk = BranchController.InsertBranch(branch);
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
            else if (fnc == "editRow")
            {
                Branch branch = new Branch();
                branch.Id = Convert.ToInt32(context.Request["branchID"]);
                branch.Name = Convert.ToString(context.Request["name"]);
                branch.City = Convert.ToString(context.Request["city"]);
                branch.District = Convert.ToString(context.Request["district"]);
                branch.Street = Convert.ToString(context.Request["street"]);
                branch.Phone = Convert.ToString(context.Request["phone"]);

                bool isOk = BranchController.UpdateBranch(branch);
                string message = "";
                if (isOk)
                {
                    message = "Updated.";
                }
                else
                {
                    message = "Did not perform update action..";
                }
                context.Response.Write(message);
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