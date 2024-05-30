using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase_1_project
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string selectquery = "SELECT number FROM Merchi ";
            SqlCommand cmd = new SqlCommand(selectquery,con);
            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            int labelIndex = 0;
            while (reader.Read())
            {
                int number = reader.GetInt32(0); // Get the value of the 'number' column

                // Dynamically set the label text based on the index
                switch (labelIndex)
                {
                    case 0:
                        Label24.Text = number.ToString();
                        break;
                    case 1:
                        Label15.Text = number.ToString();
                        break;
                    case 2:
                        Label16.Text = number.ToString();
                        break;
                    case 3:
                        Label17.Text = number.ToString();
                        break;
                    case 4:
                        Label18.Text = number.ToString();
                        break;
                    case 5:
                        Label19.Text = number.ToString();
                        break;
                    case 6:
                        Label20.Text = number.ToString();
                        break;
                    case 7:
                        Label21.Text = number.ToString();
                        break;
                    case 8:
                        Label22.Text = number.ToString();
                        break;
                    case 9:
                        Label23.Text = number.ToString();
                        break;



                    default:
                        // If there are more than 10 rows, additional handling can be added here
                        break;
                }

                labelIndex++;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'"+TextBox1.Text+ "' WHERE MerchName ='alpine'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='alpine'";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label24.Text = number.ToString();
                TextBox1.Text = "";
            }
            con.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox2.Text + "' WHERE MerchName ='astonmartin'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='astonmartin'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label15.Text = number.ToString();
                TextBox2.Text = "";
            }
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox3.Text + "' WHERE MerchName ='ferrari'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='ferrari'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label16.Text = number.ToString();
                TextBox3.Text = "";
            }
            con.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox4.Text + "' WHERE MerchName ='haas'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='haas'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label17.Text = number.ToString();
                TextBox4.Text = "";
            }
            con.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox5.Text + "' WHERE MerchName ='mclaren'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='mclaren'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label18.Text = number.ToString();
                TextBox5.Text = "";
            }
            con.Close();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox6.Text + "' WHERE MerchName ='mercedes'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='mercedes'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label19.Text = number.ToString();
                TextBox6.Text = "";
            }
            con.Close();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox7.Text + "' WHERE MerchName ='rbvisa'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='rbvisa'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label20.Text = number.ToString();
                TextBox7.Text = "";
            }
            con.Close();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox8.Text + "' WHERE MerchName ='redbull'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='redbull'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label21.Text = number.ToString();
                TextBox8.Text = "";
            }
            con.Close();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox9.Text + "' WHERE MerchName ='stake'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='stake'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label22.Text = number.ToString();
                TextBox9.Text = "";
            }
            con.Close();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB1.mdf;Integrated Security=True";
            string query = "UPDATE Merchi SET number = number +'" + TextBox10.Text + "' WHERE MerchName ='williams'";
            string selectquery = "SELECT number FROM Merchi WHERE MerchName ='williams'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand selectcmd = new SqlCommand(selectquery, con);

            SqlDataReader reader;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            reader = selectcmd.ExecuteReader();
            if (reader.Read())
            {
                int number = reader.GetInt32(0);
                Label23.Text = number.ToString();
                TextBox10.Text = "";
            }
            con.Close();
        }
    }
}