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
    public class DogFoodBL
    {
        DogFoodDL dogFoodDL = new DogFoodDL();
        public DataTable GetFood()
        {
            return dogFoodDL.GetFoodData();
        }
        public int InsertFood(DogFood dogFood)
        {
            return dogFoodDL.InsertFoodData(dogFood);
        }
        public int UpdateFood(DogFood dogFood)
        {
            return dogFoodDL.UpdateFoodData(dogFood);
        }
        public int DeleteFood(DogFood dogFood)
        {
            return dogFoodDL.DeleteFoodData(dogFood);
        }
        public DataTable FoodByBrand(DogFood dogFood)
        {
            return dogFoodDL.FilterFoodByBrand(dogFood);
        }
        public DataTable FoodByCost(DogFood dogFood)
        {
            return dogFoodDL.FilterFoodByCost(dogFood);
        }
        public DataTable FoodByQuantity(DogFood dogFood)
        {
            return dogFoodDL.FilterFoodByQuantity(dogFood);
        }
    }
}
