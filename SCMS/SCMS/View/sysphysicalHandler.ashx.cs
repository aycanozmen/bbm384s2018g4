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
    /// Summary description for sysphysicalHandler
    /// </summary>
    public class sysphysicalHandler : IHttpHandler
    {
        public static List<Member> getAllCourse()
        {
            List<Member> course = new List<Member>();

            using (var connection = Database.GetConnection())
            {
                var command = new MySqlCommand("SELECT * FROM users,members WHERE users.id=members.userid", connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Member crs = new Member();
                        crs.Id = Convert.ToInt32(reader["id"]);
                        crs.Name = reader["name"].ToString();
                        crs.Surname = reader["surname"].ToString();
                        crs.Username = reader["username"].ToString();
                        crs.Height = Convert.ToDouble(reader["height"]);
                        crs.Weight = Convert.ToDouble(reader["weight"]);
                        crs.Waistline = Convert.ToDouble(reader["waistline"]);
                        crs.Arm = Convert.ToDouble(reader["arm"]);
                        crs.Leg = Convert.ToDouble(reader["leg"]);
                        crs.Shoulder = Convert.ToDouble(reader["shoulder"]);
                        crs.Chest = Convert.ToDouble(reader["chest"]);
                        crs.BodyFat = Convert.ToDouble(reader["bodyFat"]);
              

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
                List<Member> crs = new List<Member>();
                crs = getAllCourse();
                JavaScriptSerializer js = new JavaScriptSerializer();
                context.Response.Write(js.Serialize(crs));
            }

            else if (fnc == "deleteRow")
            {
                int id = Convert.ToInt32(context.Request["courseID"]);
                bool isOk = CourseController.DeleteCourse(id);
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
                try
                {
                    Course course = new Course();
                    course.Id = Convert.ToInt32(context.Request["courseID"]);
                    course.Name = Convert.ToString(context.Request["name"]);
                    course.MaxQuota = Convert.ToInt32(context.Request["maxQuota"]);
                    course.PeriodWeek = Convert.ToInt32(context.Request["periodWeek"]);
                    course.DurationMinute = Convert.ToInt32(context.Request["durationMinute"]);
                    course.Level = Convert.ToInt32(context.Request["level"]);
                    course.Price = Convert.ToInt32(context.Request["price"]);
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

                catch (Exception ex)
                {
                    string message = "";
                    message = "Did not perform add action.";
                    context.Response.Write(message);
                }


            }
            else if (fnc == "editRow")
            {
                try
                {
                    Member course = new Member();
                    course.Id = Convert.ToInt32(context.Request["courseID"]);

                    course.Height = Convert.ToDouble(context.Request["name"]);
                    course.Weight = Convert.ToDouble(context.Request["maxQuota"]);
                    course.Waistline = Convert.ToDouble(context.Request["periodWeek"]);
                    course.Arm = Convert.ToDouble(context.Request["durationMinute"]);
                    course.Leg = Convert.ToDouble(context.Request["level"]);
                    course.Shoulder = Convert.ToDouble(context.Request["price"]);
                    course.Chest = Convert.ToDouble(context.Request["equipment"]);
                    course.BodyFat = Convert.ToDouble(context.Request["information"]);

                    bool isOk = MemberController.UpdatePhysicalProperty(course);

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

                catch (Exception ex)
                {
                    string message = "";
                    message = "Did not perform update action..";
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