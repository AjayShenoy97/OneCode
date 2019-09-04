using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;
using PropertiesLayer;

namespace BusinessLayer
{
    public class AppointmentBL
    {
        AppointmentDL appointmentDL = new AppointmentDL();
        public DataTable GetAppointment()
        {
            return appointmentDL.GetAppointmentData();
        }
        public int InsertAppointment(Appointment appointment)
        {
            return appointmentDL.InsertAppointmentData(appointment);
        }
        public int UpdateAppointment(Appointment appointment)
        {
            return appointmentDL.UpdateAppointmentData(appointment);
        }
        public int DeleteAppointment(Appointment appointment)
        {
            return appointmentDL.DeleteAppointmentData(appointment);
        }
    }
}
