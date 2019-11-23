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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            connection.Open();

            string checkUser = "SELECT COUNT(*) FROM STUDENT WHERE Username= '" + TextBoxUsername.Text + "'";
            var command = new SqlCommand(checkUser, connection);

            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();

            if (temp == 1)
            {
                connection.Open();
                string checkPasswordQuery = "SELECT Password FROM Student WHERE Username= '" + TextBoxUsername.Text + "'";
                var passwordCommand = new SqlCommand(checkPasswordQuery, connection);
                string password = passwordCommand.ExecuteScalar().ToString().Replace(" ", "");

                connection.Close();
                connection.Open();
                string checkAdminQuery = "SELECT IsAdmin FROM Student WHERE Username= '" + TextBoxUsername.Text + "'";
                var isAdminCommand = new SqlCommand(checkAdminQuery, connection);
                var isAdmin = Convert.ToBoolean(isAdminCommand.ExecuteScalar());

                if (password == TextBoxPassword.Text)
                {
                    Session["LoggedUser"] = TextBoxUsername.Text;
                    Response.Write("Password is correct");
                    if (isAdmin == true)
                    {
                        Response.Redirect("Admin.aspx");
                    }
                    Response.Redirect("Users.aspx");
                }
                else
                {
                    Response.Write("Password is incorrect");

                }
                connection.Close();
            }
            else
            {
                Response.Write("There is no User with Username: " + TextBoxUsername.Text);
            }

        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}