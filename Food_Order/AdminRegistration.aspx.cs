using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Order
{
    public partial class AdminRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            var name = txtName.Text;
            var email = txtAddress.Text;
            var password = txtPwd.Text;
            const string STRCONNECTION = @"Data Source=W-H44PY03-0;Initial Catalog=Food_Ordering;User ID=sa;Password=admin";
            const string insertProc = "Insert into tbl_admin values (@name,@email,@password)";
            SqlConnection sqlCon = new SqlConnection(STRCONNECTION);
           
            using (SqlCommand cmd = new SqlCommand(insertProc, sqlCon))
            {
                
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
               
                try
                {
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Response.Write(ex);
                }
                finally
                {
                    if (sqlCon.State != ConnectionState.Closed)
                    {
                        sqlCon.Close();
                    }
                    var url = "Admin.aspx";
                    Response.Redirect(url);
                }
            }
        }
    }
}