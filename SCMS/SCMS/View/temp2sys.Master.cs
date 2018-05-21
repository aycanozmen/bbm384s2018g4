using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCMS.View
{
    public partial class temp2sys : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User session =
            (User)HttpContext.Current.Session["userClass"];
            lblName.Text = session.Name + " " + session.Surname;
            info.Text = session.Name + " " + session.Surname + "-" + session.Username;
            nameSur.Text = session.Name + " " + session.Surname;

        }
        protected void logoutBtn_Click(object sender, EventArgs e)
        {

            Session.Abandon();
            LoggingController.InsertLogout();
            FormsAuthentication.SignOut();
            Response.Redirect("login.aspx");


        }
    }
}