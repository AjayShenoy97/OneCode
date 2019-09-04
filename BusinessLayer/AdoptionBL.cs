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
    public class AdoptionBL
    {
        AdoptionDL adoptionDL = new AdoptionDL();
        public DataTable GetDog()
        {
            return adoptionDL.GetDogData();
        }
        public int InsertDog(Dogs dog)
        {
            return adoptionDL.InsertDogData(dog);
        }
        public int UpdateDog(Dogs dog)
        {
            return adoptionDL.UpdateDogData(dog);
        }
        public int DeleteDog(Dogs dog)
        {
            return adoptionDL.DeleteDogData(dog);
        }
    }
}
