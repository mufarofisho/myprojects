using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


public partial class view_events : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        if (Session["logged"] == null)
        {
            Response.Redirect("index.aspx");
        }
       
string MyConString = "SERVER=localhost;" +
                "DATABASE=events_db;" +
                "UID=root;" +
                "PASSWORD=;";


MySqlConnection connection = new MySqlConnection(MyConString);
MySqlCommand command = connection.CreateCommand();


connection.Open();


 string cmdtText = "SELECT ev_name AS Event_Name, created_by AS Created_By FROM `events`";
        MySqlCommand cmde = new MySqlCommand(cmdtText, connection);
        MySqlDataAdapter da = new MySqlDataAdapter(cmde);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

connection.Close();
    }
}