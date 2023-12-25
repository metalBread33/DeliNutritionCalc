using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC.Database;
using PDC.Library.Models;

namespace PDC.Library.Models
{
    /*Model class for traditional items (sliced meats and cheeses)*/
    public class Trad
    {
        public NutritionInfo Nutrition { get; set; }
        public float Weight { get; set; }
        public string ItemName { get; set; }
        public int ServingSize { get; set; }

        public Trad(TrogSQLEntry trog, float weight) 
        {
            Nutrition = new NutritionInfo(trog);
            ItemName = trog.Name;
            Weight = weight;
            ServingSize = trog.ServingSize;
        }

        public override string ToString()
        {
            return $"{ItemName}\n{Nutrition}\n{Weight}\n{ServingSize}";
        }
    }

}