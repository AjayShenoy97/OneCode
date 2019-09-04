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
    public class RegistrationDL
    {

        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public void CloseAndDisposeCon()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public DataTable GetCustomerData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("CustomerCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Customer", "Select");
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

        public int InsertCustomerData(Customer customer)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("CustomerCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Customer", "Insert");
                sqlCommand.Parameters.AddWithValue("@CustName", customer.CustName);
                sqlCommand.Parameters.AddWithValue("@Contact", customer.Contact);
                sqlCommand.Parameters.AddWithValue("@Landmark", customer.Landmark);
                sqlCommand.Parameters.AddWithValue("@City", customer.City);
                sqlCommand.Parameters.AddWithValue("@Pincode", customer.Pincode);
                sqlCommand.Parameters.AddWithValue("@State", customer.State);
                sqlCommand.Parameters.AddWithValue("@EmailId", customer.EmailId);
                sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
                sqlCommand.Parameters.AddWithValue("@CreatedDate", customer.CreatedDate.ToLongDateString());
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

        public int UpdateCustomerData(Customer customer)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("CustomerCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Customer", "Update");
                sqlCommand.Parameters.AddWithValue("@CustId", customer.CustId);
                sqlCommand.Parameters.AddWithValue("@CustName", customer.CustName);
                sqlCommand.Parameters.AddWithValue("@Contact", customer.Contact);
                sqlCommand.Parameters.AddWithValue("@Landmark", customer.Landmark);
                sqlCommand.Parameters.AddWithValue("@City", customer.City);
                sqlCommand.Parameters.AddWithValue("@Pincode", customer.Pincode);
                sqlCommand.Parameters.AddWithValue("@State", customer.State);
                sqlCommand.Parameters.AddWithValue("@EmailId", customer.EmailId);
                sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
                sqlCommand.Parameters.AddWithValue("@UpdateDate", customer.UpdateDate.ToLongDateString());
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
        public int DeleteCustomerData(Customer customer)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("CustomerCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Customer", "Delete");
                sqlCommand.Parameters.AddWithValue("@CustId", customer.CustId);
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
