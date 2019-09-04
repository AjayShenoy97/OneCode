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
    public class ProductsBL
    {
        ProductsDL productsDL = new ProductsDL();
        public DataTable GetProduct()
        {
            return productsDL.GetProductData();
        }
        public int InsertProduct(Products products)
        {
            return productsDL.InsertProductData(products);
        }
        public int UpdateProduct(Products products)
        {
            return productsDL.UpdateProductData(products);
        }
        public int DeleteProduct(Products products)
        {
            return productsDL.DeleteProductData(products);
        }
        public DataTable ProductsByBrand(Products products)
        {
            return productsDL.FilterProductsByBrand(products);
        }
        public DataTable ProductsByCost(Products products)
        {
            return productsDL.FilterProductByCost(products);
        }
    }
}
