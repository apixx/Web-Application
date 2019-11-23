using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedUser"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Users.aspx");
        }
    }
}