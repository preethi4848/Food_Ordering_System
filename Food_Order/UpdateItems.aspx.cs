using AdminDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Order
{
    public partial class UpdateItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    var Id = int.Parse(FoodId.Text);
                    var F_name = Name.Text;
                    var image_url = image.Text;
                    var Food_price = int.Parse(price.Text);
                    var count = int.Parse(Count.Text);
                    Food food = new Food
                    {
                        Food_Id = Id,
                        Food_Name = F_name,
                        Image = image_url,
                        Price = Food_price,
                        Count = count
                    };
                    var com = DataFactory.GetFoodManager();
                    com.UpdateFood(food);
                    Response.Write("Food updated successfull");
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}