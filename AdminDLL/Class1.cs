using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdminDLL
{
    //Entity class representing the tbl_food table in database
    public class Food
    {
        public int Food_Id { get; set; }
        public string Food_Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
    public interface IFoodManager
    {
        //Crud operations methods for admin
        void AddNewFood(string name, int price, string image, int count);
        void UpdateFood(Food food);
        List<Food> GetAllFood();
        void DeleteFood(string name);

    }
    public class FoodManager : IFoodManager
    {
        //#region CONSTANTS AND READ ONLY
        //static readonly string STRCONNECTION = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        const string STRCONNECTION = @"Data Source=W-H44PY03-0;Initial Catalog=Food_Ordering;User ID=sa;Password=admin";
        const string insertProc = "Insert_Food";
        const string updateProc = "UpdateFood";
        const string selectProc = "Select * from tbl_food";
        const string deleteStatement = "DELETE FROM tbl_food WHERE food_name = @foodName";

        //#endregion

        static SqlConnection sqlCon = new SqlConnection(STRCONNECTION);
        public void AddNewFood(string name, int price, string image, int count)
        {
            int generatedId = 0;
            using (SqlCommand cmd = new SqlCommand(insertProc, sqlCon))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@count", count);
                cmd.Parameters.AddWithValue("@Id", generatedId);
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
                    throw new FoodManagerException("Adding the food has Failed", ex);
                }
                finally
                {
                    if (sqlCon.State != ConnectionState.Closed)
                    {
                        sqlCon.Close();
                    }
                }

            }
        }
        public void DeleteFood(string name)
        {
            using (SqlCommand cmd = new SqlCommand(deleteStatement, sqlCon))
            {
                cmd.Parameters.AddWithValue("@foodName", name);
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
                    throw new FoodManagerException("Deleting the food has Failed", ex);
                }
                finally
                {
                    if (sqlCon.State != ConnectionState.Closed)
                    {
                        sqlCon.Close();
                    }
                }
            }
        }

        public List<Food> GetAllFood()
        {
            List<Food> employees = new List<Food>();
            using (SqlCommand cmd = new SqlCommand(selectProc, sqlCon))
            {
                //cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                    }
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var food = new Food
                        {

                            Food_Name = Convert.ToString(reader["food_name"]),
                            Food_Id = Convert.ToInt32(reader[0]),
                            Image = Convert.ToString(reader["food_image"]),
                            Price = Convert.ToInt32(reader["food_price"]),
                            Count = Convert.ToInt32(reader["ItemCount"])
                        };
                        employees.Add(food);
                    }
                }
                catch (SqlException ex)
                {
                    throw new FoodManagerException("Failed to get the Employees, See Inner Exceptions for details", ex);
                }
                finally
                {
                    if (sqlCon.State != ConnectionState.Closed)
                    {
                        sqlCon.Close();
                    }
                }

                return employees;
            }
        }
        public void UpdateFood(Food food)
        {

            using (SqlCommand cmd = new SqlCommand(updateProc, sqlCon))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", food.Food_Name);
                cmd.Parameters.AddWithValue("@image", food.Image);
                cmd.Parameters.AddWithValue("@Id", food.Food_Id);
                cmd.Parameters.AddWithValue("@price", food.Price);
                cmd.Parameters.AddWithValue("@count", food.Count);
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
                    throw new FoodManagerException("Updating the food has Failed", ex);
                }
                finally
                {
                    if (sqlCon.State != ConnectionState.Closed)
                    {
                        sqlCon.Close();
                    }
                }

            }
        }

    }

    [Serializable]
    internal class FoodManagerException : Exception
    {
        public FoodManagerException()
        {
        }

        public FoodManagerException(string message) : base(message)
        {
        }

        public FoodManagerException(string message, Exception innerException) : base(message, innerException)
        {
        }



    }
    public static class DataFactory
    {
        public static IFoodManager GetFoodManager() => new FoodManager();
    }
}
