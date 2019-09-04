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
    public class FoodOrderDL
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public void CloseAndDisposeCon()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public DataTable GetFoodOrderData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ProductOrderCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ProductOrder", "Select");
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

        public int InsertFoodOrderData(FoodOrder foodOrder)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("FoodOrderCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FoodOrder", "Insert");
                sqlCommand.Parameters.AddWithValue("@FoodOrderId", foodOrder.FoodOrderId);
                sqlCommand.Parameters.AddWithValue("@CustId", foodOrder.CustId);
                sqlCommand.Parameters.AddWithValue("@FoodId", foodOrder.FoodId);
                sqlCommand.Parameters.AddWithValue("@FoodOrderStatus", foodOrder.FoodOrderStatus);
                sqlCommand.Parameters.AddWithValue("@FoodOrderDate", foodOrder.FoodOrderDate.ToLongDateString());
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

        public int UpdateFoodOrderData(FoodOrder foodOrder)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("FoodOrderCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FoodOrder", "Update");
                sqlCommand.Parameters.AddWithValue("@CustId", foodOrder.CustId);
                sqlCommand.Parameters.AddWithValue("@FoodId", foodOrder.FoodId);
                sqlCommand.Parameters.AddWithValue("@FoodOrderStatus", foodOrder.FoodOrderStatus);
                sqlCommand.Parameters.AddWithValue("@CancelDate", foodOrder.CancelDate.ToLongDateString());
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
        public int DeleteFoodOrderData(FoodOrder foodOrder)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("FoodOrderCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FoodOrder", "Delete");
                sqlCommand.Parameters.AddWithValue("@FoodOrderId", foodOrder.FoodOrderId);
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
    }
}
