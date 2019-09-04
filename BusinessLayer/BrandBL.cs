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
    public class BrandBL
    {
        BrandDL brandDL = new BrandDL();
        public DataTable GetBrand()
        {
            return brandDL.GetBrandData();
        }
        public int InsertBrand(Brand brand)
        {
            return brandDL.InsertBrandData(brand);
        }
        public int DeleteBrand(Brand brand)
        {
            return brandDL.DeleteBrandData(brand);
        }
    }
}
