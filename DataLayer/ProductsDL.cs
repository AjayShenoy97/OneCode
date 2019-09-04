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
    public class ProductsDL
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public void CloseAndDisposeCon()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public DataTable GetProductData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ProductsCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Product", "Select");
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

        public int InsertProductData(Products products)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ProductsCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Product", "Insert");
                sqlCommand.Parameters.AddWithValue("@ProductName", products.ProductName);
                sqlCommand.Parameters.AddWithValue("@BrandName", products.BrandName);
                sqlCommand.Parameters.AddWithValue("@Stock", products.Stock);
                sqlCommand.Parameters.AddWithValue("@Cost", products.Cost);
                sqlCommand.Parameters.AddWithValue("@ProductImage", products.ProductImage);
                sqlCommand.Parameters.AddWithValue("@CreatedDate", products.CreatedDate.ToLongDateString());
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

        public int UpdateProductData(Products products)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ProductsCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Product", "Update");
                sqlCommand.Parameters.AddWithValue("@ProductId", products.ProductId);
                sqlCommand.Parameters.AddWithValue("@ProductName", products.ProductName);
                sqlCommand.Parameters.AddWithValue("@BrandId", products.BrandName);
                sqlCommand.Parameters.AddWithValue("@Stock", products.Stock);
                sqlCommand.Parameters.AddWithValue("@Cost", products.Cost);
                sqlCommand.Parameters.AddWithValue("@ProductImage", products.ProductImage);
                sqlCommand.Parameters.AddWithValue("@UpdateDate", products.UpdateDate.ToLongDateString());
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
        public int DeleteProductData(Products products)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ProductsCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Product", "Delete");
                sqlCommand.Parameters.AddWithValue("@ProductId", products.ProductId);
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
        public DataTable FilterProductsByBrand(Products product)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("FilterProducts", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Filter", "Brand");
                sqlCommand.Parameters.AddWithValue("@BrandName", product.BrandName);
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
        public DataTable FilterProductByCost(Products product)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("FilterProducts", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Filter", "Cost");
                sqlCommand.Parameters.AddWithValue("@Cost", product.Cost);
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
