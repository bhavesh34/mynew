using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
    SqlCommand cm;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cm = new SqlCommand("insert into student values(@name,@fname)", con);
        
        con.Open();
        cm.Parameters.AddWithValue("@fname", TextBox2.Text);
        cm.Parameters.AddWithValue("@name", TextBox1.Text);
        cm.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Default2.aspx");

    }
}