using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Order
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             string STRCONNECTION = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
             var conn = new SqlConnection(STRCONNECTION);
            conn.Open();
             string checkuser = "select count(*) from tbl_admin where ad_name ='" + txtName.Text +"'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string passWordQuery = "select ad_password from tbl_admin where ad_name ='" + txtName.Text + "'";
                SqlCommand passWordCommand = new SqlCommand(passWordQuery, conn);
                string password = passWordCommand.ExecuteScalar().ToString().Replace(" ","");
                if (password == txtPwd.Text)
                {
                    var url = "Admin.aspx";
                    Response.Redirect(url);
                }
                else
                    Response.Write("Password is wrong");


            }
            else
                Response.Write("User name doesnot exist");

        }
    }
}