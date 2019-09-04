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
    public class AppointmentDL
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        public void CloseAndDisposeCon()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public DataTable GetAppointmentData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("AppointmentCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Appointment", "Select");
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

        public int InsertAppointmentData(Appointment appointment)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("AppointmentCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Appointment", "Insert");
                sqlCommand.Parameters.AddWithValue("@CustId", appointment.CustId);
                sqlCommand.Parameters.AddWithValue("@DogId", appointment.DogId);
                sqlCommand.Parameters.AddWithValue("@AppointmentStatus", appointment.AppointmentStatus);
                sqlCommand.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate.ToLongDateString());
                sqlCommand.Parameters.AddWithValue("@CreatedDate", appointment.CreatedDate.ToLongDateString());
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

        public int UpdateAppointmentData(Appointment appointment)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("AppointmentCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Appointment", "Update");
                sqlCommand.Parameters.AddWithValue("@AppointmentId", appointment.AppointmentId);
                sqlCommand.Parameters.AddWithValue("@CustId", appointment.CustId);
                sqlCommand.Parameters.AddWithValue("@DogId", appointment.DogId);
                sqlCommand.Parameters.AddWithValue("@AppointmentStatus", appointment.AppointmentStatus);
                sqlCommand.Parameters.AddWithValue("@UpdateDate", appointment.UpdateDate.ToLongDateString());
                sqlCommand.Parameters.AddWithValue("@CancelDate", appointment.Canceldate.ToLongDateString());
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
        public int DeleteAppointmentData(Appointment appointment)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("AppointmentCrud", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Appointment", "Delete");
                sqlCommand.Parameters.AddWithValue("@AppointmentId", appointment.AppointmentId);
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
