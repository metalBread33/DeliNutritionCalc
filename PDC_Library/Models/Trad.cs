using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC.Library.Models;

namespace PDC.Library.Models
{
    public class Trad
    {
        public NutritionInfo nutrition { get; set; }
        public decimal weight { get; set; }
        public string name {get; set; }


        public override string ToString()
        {
            return $"{name}\nWeight: {weight} lbs\n{nutrition}";
        }
    }
}
