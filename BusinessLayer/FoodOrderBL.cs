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
    public class FoodOrderBL
    {
        FoodOrderDL foodOrderDL = new FoodOrderDL();
        public DataTable GetFoodOrder()
        {
            return foodOrderDL.GetFoodOrderData();
        }
        public int InsertFoodOrder(FoodOrder foodOrder)
        {
            return foodOrderDL.InsertFoodOrderData(foodOrder);
        }
        public int UpdateFoodOrder(FoodOrder foodOrder)
        {
            return foodOrderDL.UpdateFoodOrderData(foodOrder);
        }
        public int DeleteFoodOrder(FoodOrder foodOrder)
        {
            return foodOrderDL.DeleteFoodOrderData(foodOrder);
        }
    }
}
