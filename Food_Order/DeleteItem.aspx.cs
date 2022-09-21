using AdminDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Order
{
    public partial class DeleteItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    var food_Name = FoodName.Text;
                    var com = DataFactory.GetFoodManager();
                    com.DeleteFood(food_Name);
                    Response.Write("Food Deletion successfull");
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}