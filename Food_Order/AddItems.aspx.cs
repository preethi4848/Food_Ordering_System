using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminDLL;

namespace Food_Order
{
    public partial class AddItems : System.Web.UI.Page
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
                    var Food_name = Name.Text;
                    var image_url = image.Text;
                    var Food_price = int.Parse(price.Text);
                    var Item_Count = int.Parse(Count.Text);
                    var com = DataFactory.GetFoodManager();
                    com.AddNewFood(Food_name, Food_price,image_url,Item_Count );
                    Response.Write("Food added successfull");
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}