using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Order
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var url = "AddItems.aspx";
            Response.Redirect(url);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var url = "DeleteItem.aspx";
            Response.Redirect(url);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var url = "UpdateItems.aspx";
            Response.Redirect(url);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var url = "ViewFoodItems.aspx";
            Response.Redirect(url);
        }
    }
}