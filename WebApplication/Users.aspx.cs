using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoggedUser"] != null)
            {
                Label_Welcome.Text = "Welcome " + Session["LoggedUser"].ToString();
                
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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);

            connection.Open();
            string checkAdminQuery = "SELECT IsAdmin FROM Student WHERE Username= '" + Session["LoggedUser"] + "'";
            var isAdminCommand = new SqlCommand(checkAdminQuery, connection);
            var isAdmin = Convert.ToBoolean(isAdminCommand.ExecuteScalar());

           
                if (isAdmin == true)
                {
                    Response.Redirect("Admin.aspx");
                }
            else
            {
                Response.Write("You are not identified as admin!");
            }
            
            connection.Close();
        }
    }
}