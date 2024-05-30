using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase_1_project
{
    public partial class manageProfileaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                string userName = "";
                if (Request.Cookies["user"] != null)
                {
                    userName = Request.Cookies["user"].Values["userName"];
                }

                ViewState["user"] = userName;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";

                string strSelect = "SELECT * FROM Members WHERE Username='" + userName + "'";

                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                SqlDataReader reader;

                con.Open();
                reader = cmdSelect.ExecuteReader();


                if (reader.Read())
                {
                    tb1.Text = reader.GetValue(1).ToString();
                    TextBox3.Text = reader.GetValue(3).ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tb1.Enabled = true;
            TextBox3.Enabled = true;
            DropDownList1.Enabled = true;
            save.Visible = true;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";

            string userName = "";
            userName = (string)ViewState["user"];

            string strUpdate = "Update Members SET username='" + tb1.Text + "',"
                + "password='" + TextBox3.Text + "' ,"
                + " favteam='" + DropDownList1.SelectedValue + "' WHERE Username ='" + userName + "'";

            SqlCommand cmdUpdate = new SqlCommand(strUpdate, con);

            con.Open();
            cmdUpdate.ExecuteNonQuery();



            Label5.Text = "your account has been successfully updated!!";

        }
    }

  
    
}