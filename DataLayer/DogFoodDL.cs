using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PropertiesLayer;

namespace DataLayer
{
    public class DogFoodDL
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public void CloseAndDisposeCon()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public DataTable GetFoodData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DogFoodCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@DogFood", "Select");
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                CloseAndDisposeCon();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseAndDisposeCon();
            }

        }

        public int InsertFoodData(DogFood dogFood)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DogFoodCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@DogFood", "Insert");
                sqlCommand.Parameters.AddWithValue("@FoodName", dogFood.FoodName);
                sqlCommand.Parameters.AddWithValue("@Quantity", dogFood.Quantity);
                sqlCommand.Parameters.AddWithValue("@BrandName", dogFood.BrandName);
                sqlCommand.Parameters.AddWithValue("@Stock", dogFood.Stock);
                sqlCommand.Parameters.AddWithValue("@Cost", dogFood.Cost);
                sqlCommand.Parameters.AddWithValue("@ProductImage", dogFood.FoodImage);
                sqlCommand.Parameters.AddWithValue("@CreatedDate", dogFood.CreatedDate.ToLongDateString());
                sqlConnection.Open();
                int dataInserted = sqlCommand.ExecuteNonQuery();
                CloseAndDisposeCon();
                return dataInserted;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseAndDisposeCon();
            }
        }

        public int UpdateFoodData(DogFood dogFood)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DogFoodCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@DogFood", "Update");
                sqlCommand.Parameters.AddWithValue("@FoodId", dogFood.FoodId);
                sqlCommand.Parameters.AddWithValue("@FoodName", dogFood.FoodName);
                sqlCommand.Parameters.AddWithValue("@Quantity", dogFood.Quantity);
                sqlCommand.Parameters.AddWithValue("@BrandName", dogFood.BrandName);
                sqlCommand.Parameters.AddWithValue("@Stock", dogFood.Stock);
                sqlCommand.Parameters.AddWithValue("@Cost", dogFood.Cost);
                sqlCommand.Parameters.AddWithValue("@ProductImage", dogFood.FoodImage);
                sqlCommand.Parameters.AddWithValue("@UpdateDate", dogFood.UpdateDate.ToLongDateString());
                sqlConnection.Open();
                int dataUpdated = sqlCommand.ExecuteNonQuery();
                CloseAndDisposeCon();
                return dataUpdated;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseAndDisposeCon();
            }
        }
        public int DeleteFoodData(DogFood dogFood)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DogFoodCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@DogFood", "Delete");
                sqlCommand.Parameters.AddWithValue("@FoodId", dogFood.FoodId);
                sqlConnection.Open();
                int dataDeleted = sqlCommand.ExecuteNonQuery();
                CloseAndDisposeCon();
                return dataDeleted;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseAndDisposeCon();
            }
        }
        public DataTable FilterFoodByBrand(DogFood dogFood)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("FilterDogFood", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Filter", "Brand");
                sqlCommand.Parameters.AddWithValue("@BrandName", dogFood.BrandName);
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                CloseAndDisposeCon();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseAndDisposeCon();
            }
        }
        public DataTable FilterFoodByCost(DogFood dogFood)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("FilterDogFood", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Filter", "Cost");
                sqlCommand.Parameters.AddWithValue("@Cost", dogFood.Cost);
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                CloseAndDisposeCon();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseAndDisposeCon();
            }
        }
        public DataTable FilterFoodByQuantity(DogFood dogFood)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("FilterDogFood", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Filter", "Quantity");
                sqlCommand.Parameters.AddWithValue("@Quantity", dogFood.Quantity);
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                CloseAndDisposeCon();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseAndDisposeCon();
            }
        }
    }
}
