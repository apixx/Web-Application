using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString)) { 

                string checkUser = "SELECT COUNT(*) FROM STUDENT WHERE Username= '" + TextBoxUsername.Text + "'";
                var command = new SqlCommand(checkUser, connection);

                int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
                if(temp == 1)
                {
                    Response.Write("User already exists");
                }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString)) { 

                string insertQuery = "INSERT INTO Student (Username, Email, Password, Name, Address) values (@usern, @email, @password, @name, @address)";
                var command = new SqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@usern", TextBoxUsername.Text);
                command.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                command.Parameters.AddWithValue("@password", TextBoxPassword.Text);
                command.Parameters.AddWithValue("@name", TextBoxName.Text);
                command.Parameters.AddWithValue("@address", TextBoxAddress.Text);

                command.ExecuteNonQuery();
                Response.Write("Registration is Successful!");
                Response.Redirect("Login.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}