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
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            da = new SqlDataAdapter("select * from student", con);
            dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}