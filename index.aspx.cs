using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.HtmlControls;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class index : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Clear();
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        MySqlConnection mycon = new MySqlConnection();
        mycon.ConnectionString = "Server=localhost; database=events_db; user id=root; password=";
        mycon.Open();
        MySqlCommand cmd;

        int cnt;

        string sql = "SELECT COUNT(*) FROM users WHERE username=@usr AND password=@pass";
        try
        {
            cmd = new MySqlCommand(sql, mycon);
            cmd.Parameters.AddWithValue("@usr", txtusr.Text);
            cmd.Parameters.AddWithValue("@pass", txtpwd.Text);         
            object aval = cmd.ExecuteScalar();
            cnt = Convert.ToInt32(aval);
            if (cnt == 0)
            {
                lblmsg.Text = "Invalid login";
            }
          
                else
                {
                    Session["logged"]= txtusr.Text;
                    Response.Redirect("home.aspx");
                }
        }
        catch (Exception)
        {
            lblmsg.Text = "Sorry could not connect to database";
        }

    }
}