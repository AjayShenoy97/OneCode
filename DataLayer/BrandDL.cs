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
    public class BrandDL
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public void CloseAndDisposeCon()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public DataTable GetBrandData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("BrandCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Brand", "Select");
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

        public int InsertBrandData(Brand brand)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("BrandCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Brand", "Insert");
                sqlCommand.Parameters.AddWithValue("@BrandName", brand.BrandName);
                sqlCommand.Parameters.AddWithValue("@CreatedDate", brand.CreatedDate.ToLongDateString());
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
        public int DeleteBrandData(Brand brand)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("BrandCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Brand", "Delete");
                sqlCommand.Parameters.AddWithValue("@BrandId", brand.BrandId);
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
