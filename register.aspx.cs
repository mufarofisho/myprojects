using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtusr.Text.Trim()))
        {
            lblmsg.Text = "Enter username please";
        }
        else if (String.IsNullOrEmpty(txtpwd.Text.Trim()))
        {
            lblmsg.Text = "Enter password please";
        }
        else if (String.IsNullOrEmpty(txtcon.Text.Trim()))
        {
            lblmsg.Text = "Confirm password please";
        }
       
        else if (txtpwd.Text.Length < 6)
        {
            lblmsg.Text = "Passowrd should be at least 6 Characters";
        }
        else if (txtusr.Text.Length < 3)
        {
            lblmsg.Text = "Username too short";
        }
        
        else if (txtpwd.Text != txtcon.Text)
        {
            lblmsg.Text = "Password not matching";
        }
        else
        {
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = "Server=localhost; database=events_db; user id=root; password=";
            mycon.Open();
            MySqlCommand cmd;
            MySqlDataReader dr;
            int cnt;
            string sql = "INSERT INTO users(username,password) VALUES(@usr,@pss)";
            string sql2 = "SELECT COUNT(*) FROM users WHERE username=@usr";
            try
            {
                cmd = new MySqlCommand(sql2, mycon);
                cmd.Parameters.AddWithValue("@usr", txtusr.Text);
                object aval = cmd.ExecuteScalar();
                cnt = Convert.ToInt32(aval);
                if (cnt > 0)
                {
                    lblmsg.Text = "Sorry username already exists";
                }
                else
                {
                    cmd = new MySqlCommand(sql, mycon);
                    cmd.Parameters.AddWithValue("@usr", txtusr.Text);
                    cmd.Parameters.AddWithValue("@pss", txtpwd.Text);
              
                    dr = cmd.ExecuteReader();
                    dr.Close();

                    lblmsg.Text = "";
                    lblsuccess.Text = "ACCOUNT CREATED SUCCESSFULLY";
                    txtusr.Text = "";
                    txtpwd.Text = "";
                    txtcon.Text = "";   
                    dr.Close();
                    mycon.Dispose();
                }
            }
            catch (Exception)
            {
                lblmsg.Text = "Sorry error in connnection";
            }
        }
    }
}