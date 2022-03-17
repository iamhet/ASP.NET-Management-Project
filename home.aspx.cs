using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [doctor_name], [speciality], [image], [status] FROM [manage_doctor]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        Repeater1.DataSource = dt;
        Repeater1.DataBind();

    }
}