using DataAccess;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace SCMS
{
    /// <summary>
    /// Summary description for syscourseHandler
    /// </summary>
    public class syscourseHandler : IHttpHandler
    {

        public static List<Course> getAllCourse()
        {
            List<Course> course = new List<Course>();

            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("SELECT C_ID,C_name,C_maxQuota,C_durationMinute,C_periodWeek,C_price,C_equipment,C_level,C_information FROM courses", connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Course crs = new Course();
                        crs.Id = Convert.ToInt32(reader["C_ID"]);
                        crs.Name = reader["C_name"].ToString();
                        crs.MaxQuota = Convert.ToInt32(reader["C_maxQuota"]);
                        crs.DurationMinute = Convert.ToInt32(reader["C_durationMinute"]);
                        crs.PeriodWeek = Convert.ToInt32(reader["C_periodWeek"]);
                        crs.Price = (reader["C_price"]).ToString();
                        crs.Equipment = reader["C_equipment"].ToString();
                        crs.Level = reader["C_level"].ToString();
                        crs.Information = reader["C_information"].ToString();
                       
                        course.Add(crs);

                    }
                }
                connection.Close();
            }

            return course;

        }
        public void ProcessRequest(HttpContext context)
        {
            string fnc = (string)context.Request["fnc"];


            if (fnc == "getTable")
            {
                List<Course> crs = new List<Course>();
                crs = getAllCourse();
                JavaScriptSerializer js = new JavaScriptSerializer();
                context.Response.Write(js.Serialize(crs));
            }
           
            else if (fnc == "deleteRow")
            {
                int id = Convert.ToInt32(context.Request["courseID"]);
                bool isOk =CourseController.DeleteCourse(id);
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
           else if (fnc == "newCourse")
           {
                Course course = new Course();
                course.Id = Convert.ToInt32(context.Request["courseID"]);
                course.Name = Convert.ToString(context.Request["name"]);
                course.MaxQuota = Convert.ToInt32(context.Request["maxQuota"]);
                course.PeriodWeek = Convert.ToInt32(context.Request["periodWeek"]);
                course.DurationMinute = Convert.ToInt32(context.Request["durationMinute"]);
                course.Level = Convert.ToString(context.Request["level"]);
                course.Price = Convert.ToString(context.Request["price"]);
                course.Equipment = Convert.ToString(context.Request["equipment"]);
                course.Information = Convert.ToString(context.Request["information"]);

                bool isOk = CourseController.InsertCourse(course);
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
               Course course = new Course();
               course.Id = Convert.ToInt32(context.Request["courseID"]);
               course.Name = Convert.ToString(context.Request["name"]);
               course.MaxQuota = Convert.ToInt32(context.Request["maxQuota"]);
               course.PeriodWeek = Convert.ToInt32(context.Request["periodWeek"]);
               course.DurationMinute = Convert.ToInt32(context.Request["durationMinute"]);
               course.Level = Convert.ToString(context.Request["level"]);
               course.Price = Convert.ToString(context.Request["price"]);
               course.Equipment = Convert.ToString(context.Request["equipment"]);
               course.Information = Convert.ToString(context.Request["information"]);

               bool isOk = CourseController.UpdateCourse(course);
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