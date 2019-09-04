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
    public class RegistrationBL
    {
        RegistrationDL registrationDL = new RegistrationDL();
        public DataTable GetData()
        {
            return registrationDL.GetCustomerData();
        }
        public int InsertData(Customer customer)
        {
            return registrationDL.InsertCustomerData(customer);
        }
        public int UpdateData(Customer customer)
        {
            return registrationDL.UpdateCustomerData(customer);
        }
        public int DeleteData(Customer customer)
        {
            return registrationDL.DeleteCustomerData(customer);
        }
    }
}
