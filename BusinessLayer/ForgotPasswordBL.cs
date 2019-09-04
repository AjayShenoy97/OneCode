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
    public class ForgotPasswordBL
    {
        ForgotPasswordDL forgotPasswordDL = new ForgotPasswordDL();
        public DataTable GetPassword(Customer customer)
        {
            return forgotPasswordDL.ForgotPassword(customer);
        }
    }
}
