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
    public class LoginDL
    {
        string constr= ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        

        public DataTable ValidateCustomer(Customer customer)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(constr);
                SqlCommand sqlCommand = new SqlCommand("ValidateUser", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@User", "Customer");
                sqlCommand.Parameters.AddWithValue("@EmailId", customer.EmailId);
                sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                
            }
        }
        public DataTable ValidateAdmin(Admin admin)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(constr);
                SqlCommand sqlCommand = new SqlCommand("ValidateUser", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@User", "Admin");
                sqlCommand.Parameters.AddWithValue("@EmailId", admin.EmailId);
                sqlCommand.Parameters.AddWithValue("@Password", admin.Password);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
    }
}
