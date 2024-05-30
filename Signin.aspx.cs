using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase_1_project
{
    public partial class Signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                msglbl2.Text = "You must enter your username and password.";
                return;
            }

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";

                SqlConnection connection = new SqlConnection(connectionString);


                string query = "SELECT Username FROM Members WHERE Username='" + TextBox1.Text + "'AND Password='" + TextBox2.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Username", TextBox1.Text);
                command.Parameters.AddWithValue("@Password", TextBox2.Text);

                connection.Open();


                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (reader.Read())
                    {
                        HttpCookie cookie = new HttpCookie("user");
                        cookie.Values.Add("username", TextBox1.Text);
                        cookie.Values.Add("password", TextBox2.Text);
                        cookie.Expires = DateTime.Now.AddDays(2);
                        Response.Cookies.Add(cookie);
                        if (TextBox1.Text == "admin")

                            Response.Redirect("~/adminhome.aspx"); // Redirect to a home page or dashboard
                        else
                            Response.Redirect("~/HtmlPage.html");

                    }

                    else
                    {
                        msglbl2.Text = "Username or password is incorrect. Please try again.";
                    }

                }
                connection.Close();
            }

            catch (SqlException err)
            {

                msglbl2.Text = "An error occurred during sign in. Please try again later. Error: " + err.Message;
            }
            catch (Exception ex)
            {
                msglbl2.Text = "An error occurred: " + ex.Message + " Please reload the page and try again.";
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/HtmlPage.html");
        }
    }
}
