using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoggedUser"] != null)
            {
                Label_Welcome.Text = "Welcome " + Session["LoggedUser"].ToString() + "!";
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["LoggedUser"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}