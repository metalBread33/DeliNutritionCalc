using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC.Library.Models;

namespace PDC.Library.Services
{
    public class TradServices
    {
        private static TradServices? _instance;
        public static TradServices current
        {
            get
            {
                if (_instance == null)
                    _instance = new TradServices();
                return _instance;
            }

        }

        //Used to calculate the nutitional info of traditional items
        public void calcNutrition(Trad trad)
        {
            NutritionInfo updated;
            //Convert lbs to oz
            float ounces = trad.Weight * 16;
           
            //Divide oz by  serving size
            float servings = ounces / trad.ServingSize;
            //Swap trad info and updated info

            NutritionInfoServices.current.MultiplyByServings(servings,
                trad.Nutrition);
        }
    }
}
