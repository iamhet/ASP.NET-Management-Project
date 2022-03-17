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
     
       // ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" 
       // DeleteCommand="DELETE FROM [manage_doctor] WHERE [id] = @id" 
       // InsertCommand="INSERT INTO [manage_doctor] ([doctor_name], [speciality], [image], [status]) VALUES (@doctor_name, @speciality, @image, @status)" 
       // ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
      //  SelectCommand="SELECT [id], [doctor_name], [speciality], [image], [status] FROM [manage_doctor]" 
      //  UpdateCommand="UPDATE [manage_doctor] SET [doctor_name] = @doctor_name, [speciality] = @speciality, [image] = @image, [status] = @status WHERE [id] = @id">
       
    protected void Page_Load(object sender, EventArgs e)
    {
        print();
    }
    public void print()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [doctor_name], [speciality], [image], [status] FROM [manage_doctor]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Button1.Text == "Submit")
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/uploads/" + FileUpload1.FileName));
                SqlCommand cmd = new SqlCommand("INSERT INTO [manage_doctor] ([doctor_name], [speciality], [image], [status]) VALUES (@doctor_name, @speciality, @image, @status)", con);
                cmd.Parameters.AddWithValue("@doctor_name", TextBox4.Text);
                cmd.Parameters.AddWithValue("@speciality", TextBox5.Text);
                cmd.Parameters.AddWithValue("@image", FileUpload1.FileName);
                cmd.Parameters.AddWithValue("@status", RadioButtonList1.SelectedValue);
                con.Open();
                int s = cmd.ExecuteNonQuery();
                con.Close();
                if (s == 1)
                {
                    clear();
                    print();
                }
                else
                {
                    clear();
                    print();
                }
            }
        }
        else
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/uploads/" + FileUpload1.FileName));
                SqlCommand cmd = new SqlCommand("UPDATE [manage_doctor] SET [doctor_name] = @doctor_name, [speciality] = @speciality, [image] = @image, [status] = @status WHERE [id] = @id", con);
                cmd.Parameters.AddWithValue("@id", ViewState["service_id"]);
                cmd.Parameters.AddWithValue("@doctor_name", TextBox4.Text);
                cmd.Parameters.AddWithValue("@speciality", TextBox5.Text);
                cmd.Parameters.AddWithValue("@image", FileUpload1.FileName);
                cmd.Parameters.AddWithValue("@status", RadioButtonList1.SelectedValue);
                con.Open();
                int s = cmd.ExecuteNonQuery();
                con.Close();
                if (s == 1)
                {
                    clear();
                    print();
                }
                else
                {
                    clear();
                    print();
                }
            }
            
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [doctor_name], [speciality], [image], [status] FROM [manage_doctor] WHERE id =" + btn.CommandArgument, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        TextBox4.Text = dt.Rows[0][1].ToString();
        TextBox5.Text = dt.Rows[0][2].ToString();
        Image2.ImageUrl = "~/uploads/" + dt.Rows[0][3].ToString();
        RadioButtonList1.SelectedValue = dt.Rows[0][4].ToString();
        ViewState["service_id"] = btn.CommandArgument;
        Button1.Text = "Update";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        SqlCommand cmd = new SqlCommand("DELETE FROM [manage_doctor] WHERE [id] = @id", con);
        cmd.Parameters.AddWithValue("@id", btn.CommandArgument);
        con.Open();
        int s = cmd.ExecuteNonQuery();
        con.Close();
        if (s == 1)
        {
            clear();
            print();
        }
        else
        {
            clear();
            print();
        }
    }
    public void clear()
    {
        TextBox4.Text = string.Empty;
        TextBox5.Text = string.Empty;
        FileUpload1.Attributes.Clear();
        Image2.ImageUrl = string.Empty;
        RadioButtonList1.ClearSelection();
    }
}