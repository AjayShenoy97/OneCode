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
    public class AdoptionDL
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public void CloseAndDisposeCon()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public DataTable GetDogData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DogsCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Dog", "Select");
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

        public int InsertDogData(Dogs dog)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DogsCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Dog", "Insert");
                sqlCommand.Parameters.AddWithValue("@DogName", dog.DogName);
                sqlCommand.Parameters.AddWithValue("@Breed", dog.Breed);
                sqlCommand.Parameters.AddWithValue("@Gender", dog.Gender);
                sqlCommand.Parameters.AddWithValue("@DogImage", dog.DogImage);
                sqlCommand.Parameters.AddWithValue("@CreatedDate", dog.CreatedDate.ToLongDateString());
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

        public int UpdateDogData(Dogs dog)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DogsCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Dog", "Update");
                sqlCommand.Parameters.AddWithValue("@DogId", dog.DogId);
                sqlCommand.Parameters.AddWithValue("@DogName", dog.DogName);
                sqlCommand.Parameters.AddWithValue("@Breed", dog.Breed);
                sqlCommand.Parameters.AddWithValue("@Gender", dog.Gender);
                sqlCommand.Parameters.AddWithValue("@DogImage", dog.DogImage);
                sqlCommand.Parameters.AddWithValue("@UpdateDate", dog.UpdateDate.ToLongDateString());
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
        public int DeleteDogData(Dogs dog)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DogsCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Dog", "Delete");
                sqlCommand.Parameters.AddWithValue("@DogId", dog.DogId);
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
