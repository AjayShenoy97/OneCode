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
    public class ProductOrderDL
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public void CloseAndDisposeCon()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public DataTable GetProductOrderData()
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

        public int InsertProductOrderData(ProductOrder productOrder)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ProductOrderCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ProductOrder", "Insert");
                sqlCommand.Parameters.AddWithValue("@CustId", productOrder.CustId);
                sqlCommand.Parameters.AddWithValue("@ProductId", productOrder.ProductId);
                sqlCommand.Parameters.AddWithValue("@ProductOrderStatus", productOrder.ProductOrderStatus);
                sqlCommand.Parameters.AddWithValue("@ProductOrderDate", productOrder.ProductOrderDate.ToLongDateString());
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

        public int UpdateProductOrderData(ProductOrder productOrder)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ProductOrderCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ProductOrder", "Update");
                sqlCommand.Parameters.AddWithValue("@ProductOderId", productOrder.ProductOderId);
                sqlCommand.Parameters.AddWithValue("@CustId", productOrder.CustId);
                sqlCommand.Parameters.AddWithValue("@ProductId", productOrder.ProductId);
                sqlCommand.Parameters.AddWithValue("@ProductOrderStatus", productOrder.ProductOrderStatus);
                sqlCommand.Parameters.AddWithValue("@CancelDate", productOrder.CancelDate.ToLongDateString());
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
        public int DeleteProductOrderData(ProductOrder productOrder)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ProductOrderCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ProductOrder", "Delete");
                sqlCommand.Parameters.AddWithValue("@ProductOrderId", productOrder.ProductOderId);
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
