using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC.Library.Models;

namespace PDC.Library.Services
{
    public class NutritionInfoServices
    {
        static private NutritionInfoServices? _instance;
        
        static public NutritionInfoServices current
        {
            get
            {
                if (_instance == null)
                    _instance = new NutritionInfoServices();
                return _instance;
            }
        }

        //Used for multiplying all nutitional info by number of servings
        public void MultiplyByServings(float numServings, 
            NutritionInfo nutInfo)
        {
            nutInfo.Calories *= numServings;
            nutInfo.Carbs *= numServings;
            nutInfo.Fat *= numServings;
            nutInfo.Protein *= numServings;
            nutInfo.SaturatedFat *= numServings;
            nutInfo.TransFat *= numServings;
            nutInfo.Sodium *= numServings;
            nutInfo.Cholesterol *= numServings;
        }
    }
}
