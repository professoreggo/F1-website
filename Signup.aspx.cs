using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase_1_project
{
    public partial class Login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)


        {

            if (TextBox3.Text != TextBox4.Text)
            {
                lblmsg.Text = "Passwords do not match.";
                return;
            }

           
            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                String query = "INSERT INTO Members(Username, Email, Password,favteam) VALUES(@Username, @Email, @Password,@favteam)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Username", TextBox1.Text);
                command.Parameters.AddWithValue("@Email", TextBox2.Text);
                command.Parameters.AddWithValue("@Password", TextBox3.Text);
                command.Parameters.AddWithValue("@favteam", DropDownList1.SelectedValue);
                connection.Open();

                int result = command.ExecuteNonQuery();

                if (result < 0)
                {

                    lblmsg.Text = "Sign up failed, Please try again ";

                }

                else
                {
                    Response.Redirect("~/Signin.aspx");
                }

                connection.Close();
            }
            

            catch (SqlException err)
            {
                if (err.Number == 2627 || err.Number == 2601)
                {
                    lblmsg.Text = "Please enter your information or, The username or email has already been used. Please try a different one.";
                }
                else
                {
                    
                    lblmsg.Text = "An error occurred during sign up. Please try again later.";
                }
            }

            catch (Exception ex)
            {
                lblmsg.Text = "An error occurred: " + ex.Message + "Please reload the page and try again";
            }
            }

        
        }

    

    }
