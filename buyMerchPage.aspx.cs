using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase_1_project
{
    public partial class buyMerchPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='alpine'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                 number = 0;
            }
            else 
            {
                 total = Label15.Text;
                 number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='astonmartin'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='mercedes'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='haas'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='stake'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='mclaren'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='redbull'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='ferrari'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='williams'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number - 1 WHERE MerchName ='rbvisa'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int number;
            string total;
            if (Label15.Text == "")
            {
                number = 0;
            }
            else
            {
                total = Label15.Text;
                number = int.Parse(total);
            }
            number++;
            total = number.ToString();
            Label15.Text = total;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Label15.Text = "";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
           
        }
    }
}