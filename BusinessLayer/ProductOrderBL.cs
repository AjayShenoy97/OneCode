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
    public class ProductOrderBL
    {
        ProductOrderDL productOrderDL = new ProductOrderDL();
        public DataTable GetProductOrder()
        {
            return productOrderDL.GetProductOrderData();
        }
        public int InsertProductOrder(ProductOrder productOrder)
        {
            return productOrderDL.InsertProductOrderData(productOrder);
        }
        public int UpdateProductOrder(ProductOrder productOrder)
        {
            return productOrderDL.UpdateProductOrderData(productOrder);
        }
        public int DeleteProductOrder(ProductOrder productOrder)
        {
            return productOrderDL.DeleteProductOrderData(productOrder);
        }
    }
}
