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
       // DeleteCommand="DELETE FROM [manage_news] WHERE [id] = @id" 
       // InsertCommand="INSERT INTO [manage_news] ([tag], [title], [writer_name], [news_image], [writer_image]) VALUES (@tag, @title, @writer_name, @news_image, @writer_image)" 
       // ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
     //   SelectCommand="SELECT [id], [tag], [title], [writer_name], [news_image], [writer_image] FROM [manage_news]" 
        //UpdateCommand="UPDATE [manage_news] SET [tag] = @tag, [title] = @title, [writer_name] = @writer_name, [news_image] = @news_image, [writer_image] = @writer_image WHERE [id] = @id">
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        print();
    }
    public void print()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [tag], [title], [writer_name], [news_image], [writer_image] FROM [manage_news]", con);
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
                FileUpload1.SaveAs(Server.MapPath("~/news_images/" + FileUpload1.FileName));
                FileUpload2.SaveAs(Server.MapPath("~/news_images/" + FileUpload2.FileName));
                SqlCommand cmd = new SqlCommand("INSERT INTO [manage_news] ([tag], [title], [writer_name], [news_image], [writer_image]) VALUES (@tag, @title, @writer_name, @news_image, @writer_image)", con);
                cmd.Parameters.AddWithValue("@tag", TextBox4.Text);
                cmd.Parameters.AddWithValue("@title", TextBox5.Text);
                cmd.Parameters.AddWithValue("@writer_name", TextBox6.Text);
                cmd.Parameters.AddWithValue("@news_image", FileUpload1.FileName);
                cmd.Parameters.AddWithValue("@writer_image",FileUpload2.FileName);
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
                FileUpload1.SaveAs(Server.MapPath("~/news_images/" + FileUpload1.FileName));
                FileUpload2.SaveAs(Server.MapPath("~/news_images/" + FileUpload2.FileName));
                SqlCommand cmd = new SqlCommand("UPDATE [manage_news] SET [tag] = @tag, [title] = @title, [writer_name] = @writer_name, [news_image] = @news_image, [writer_image] = @writer_image WHERE [id] = @id", con);
                cmd.Parameters.AddWithValue("@id", ViewState["service_id"]);
                cmd.Parameters.AddWithValue("@tag", TextBox4.Text);
                cmd.Parameters.AddWithValue("@title", TextBox5.Text);
                cmd.Parameters.AddWithValue("@writer_name",TextBox6.Text);
                cmd.Parameters.AddWithValue("@news_image", FileUpload1.FileName);
                cmd.Parameters.AddWithValue("@writer_image", FileUpload2.FileName);
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

    public void clear()
    {
        TextBox4.Text = string.Empty;
        TextBox5.Text = string.Empty;
        TextBox6.Text = string.Empty;        
        FileUpload1.Attributes.Clear();
        FileUpload2.Attributes.Clear();
        Image2.ImageUrl = string.Empty;
        Image5.ImageUrl = string.Empty;
        RadioButtonList1.ClearSelection();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [tag], [title], [writer_name], [news_image], [writer_image] FROM [manage_news] WHERE id =" + btn.CommandArgument, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        TextBox4.Text = dt.Rows[0][1].ToString();
        TextBox5.Text = dt.Rows[0][2].ToString();
        TextBox6.Text = dt.Rows[0][3].ToString();
        Image2.ImageUrl = "~/news_images/" + dt.Rows[0][4].ToString();
        Image5.ImageUrl = "~/news_images/" + dt.Rows[0][5].ToString();
       // RadioButtonList1.SelectedValue = dt.Rows[0][6].ToString();
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
}