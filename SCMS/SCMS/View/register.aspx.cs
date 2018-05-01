using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCMS.View
{
    public partial class register : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        
        protected void RegisterBtnClick(object sender, EventArgs e)
        {
            

            bool ctrl = false;
            User user = new User();
            user.Name = Name.Text;
            user.Surname = Surname.Text;
            user.Username = Uname.Text;
            user.Password = Password.Text;
            user.Phone = Phone.Text;
            user.Gender = Gender.SelectedValue;
            user.BirthDate = BirthDate.Text;
            
            ctrl = UserController.AddUser(user);

            if (ctrl)
            {
                message.Text = "Registered Successfully";
                //Response.Write("control");
                // Page.Response.Redirect("login.aspx");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Registered Successfully...');", true);


            }
        }
    }
}