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
    public class LoginBL
    {
        LoginDL loginDL = new LoginDL();
        public DataTable CheckCustomer(Customer customer)
        {
            return loginDL.ValidateCustomer(customer);
        }
        public DataTable CheckAdmin(Admin admin)
        {
            return loginDL.ValidateAdmin(admin);
        }
    }
}
