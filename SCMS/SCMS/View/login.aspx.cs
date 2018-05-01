using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCMS.View
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtnClick(object sender, EventArgs e)
        {

            User user = new User();
            string username = userName.Value;
            string password = passwordInput.Value;

            user = UserController.GetAllUser(username, password);
   
            if (user != null)
            {
                bool ctrl = false;

                Session["userClass"] = user;

               // ctrl = LoggingController.InsertLog();

                if (true && user.Role == "system manager")
                {
                    //Response.Write("control");
                    Page.Response.Redirect("SysManagerHome.aspx");

                }
            
            }


        }

        }
    }
