using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            SqlCommand cmd = new SqlCommand("INSERT INTO [users] ([fullname],[email],[password]) VALUES (@fullname,@email,@password)", con);
            cmd.Parameters.AddWithValue("@fullname", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@password", TextBox1.Text.Trim());
            con.Open();
            int s = cmd.ExecuteNonQuery();
            if (s == 1)
            {
                Session["email"] = TextBox4.Text;
                Response.Redirect("~/default.aspx");
            }
            con.Close();
        
    }
}