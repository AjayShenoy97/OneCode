using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PropertiesLayer;
using BusinessLayer;

namespace PetEcommerce
{
    public partial class Login : System.Web.UI.Page
    {
        Customer customer = new Customer();
            LoginBL loginBL = new LoginBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            customer.EmailId = txtEmailId.Text;
            customer.Password = txtPassword.Value;
            loginBL.CheckCustomer(customer);
            DataTable dt = new DataTable();
            dt = loginBL.CheckCustomer(customer);
            if (dt.Rows.Count == 1)
            {
                Response.Redirect("https://www.google.co.in/webhp?hl=en&sa=X&ved=0ahUKEwi5s-XqwLTkAhX44nMBHSKWBP4QPAgH");
            }
            else
                Response.Redirect("HomePage.aspx");
        }
    }
}