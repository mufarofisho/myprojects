using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["logged"] == null)
        {
            Response.Redirect("index.aspx");
        }
    }
    public static bool IsAllDigits(string s)
    {
        foreach (char c in s)
        {
            if (!Char.IsDigit(c))
                return false;
        }
        return true;
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtev.Text.Trim()))
        {
            lblmsg.Text = "Enter event please";
        }
        
        else if (txtev.Text.Length < 3)
        {
            lblmsg.Text = "Event too short";
        }

        else if (IsAllDigits(txtev.Text) == true)
        {
            lblmsg.Text = "Event cannot be digits only.";
        }
        else
        {
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = "Server=localhost; database=events_db; user id=root; password=";
            mycon.Open();
            MySqlCommand cmd;
            MySqlDataReader dr;
            int cnt;
            string sql = "INSERT INTO events(ev_name,created_by) VALUES(@ev_nam,@cby)";
            string sql2 = "SELECT COUNT(*) FROM events WHERE ev_name=@ev_nam";
            try
            {
                cmd = new MySqlCommand(sql2, mycon);
                cmd.Parameters.AddWithValue("@ev_nam", txtev.Text);
                object aval = cmd.ExecuteScalar();
                cnt = Convert.ToInt32(aval);
                if (cnt > 0)
                {
                    lblsuccess.Text = "";
                    lblmsg.Text = "Event already exists";
                }
                else
                {
                    cmd = new MySqlCommand(sql, mycon);
                    cmd.Parameters.AddWithValue("@ev_nam", txtev.Text);
                    cmd.Parameters.AddWithValue("@cby", Session["logged"]);

                    dr = cmd.ExecuteReader();
                  
                    lblmsg.Text = "";
                    lblsuccess.Text = "EVENT CREATED SUCCESSFULLY";
                    txtev.Text = "";
                  
                    dr.Close();
                    mycon.Dispose();
                }
            }
            catch (Exception ex)
            {
                lblmsg.Text = "System could not connect sucessfully:" + ex;
            }
        }
    }
}