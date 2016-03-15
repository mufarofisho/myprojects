using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;

public partial class join : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["logged"] == null)
        {
            Response.Redirect("index.aspx");
        }
        var connectionString = "SERVER=localhost;" +
                "DATABASE=events_db;" +
                "UID=root;" +
                "PASSWORD=;";

       
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "SELECT ev_name FROM events";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                       EventList.Items.Add(reader.GetString("ev_name"));
                    }
                }
            }
        }
    }
    protected void btnJoin_Click(object sender, EventArgs e)
    {
      
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = "Server=localhost; database=events_db; user id=root; password=";
            mycon.Open();
            MySqlCommand cmd;
            MySqlDataReader dr;
            int cnt;
            string sql = "INSERT INTO members(ev_name,member) VALUES(@ev_nam,@member)";
            string sql2 = "SELECT COUNT(*) FROM members WHERE ev_name=@ev_nam AND member=@member";
            try
            {   
                cmd = new MySqlCommand(sql2, mycon);
                cmd.Parameters.AddWithValue("@ev_nam", EventList.Text);
                cmd.Parameters.AddWithValue("@member", Session["logged"]);
                object aval = cmd.ExecuteScalar();
                cnt = Convert.ToInt32(aval);
                if (cnt > 0)
                {
                    lblsuccess.Text = "";
                    lblmsg.Text = "You have already joined this event";
                }
                else
                {
                    cmd = new MySqlCommand(sql, mycon);
                    cmd.Parameters.AddWithValue("@ev_nam", EventList.Text);
                    cmd.Parameters.AddWithValue("@member", Session["logged"]);

                    dr = cmd.ExecuteReader();

                    lblmsg.Text = "";
                    lblsuccess.Text = "EVENT JOINED SUCCESSFULLY";            
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