using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace PDC.Library.Models
{
    public class HotMeal
    {
        public NutritionInfo nutrition { get; set; }
        public bool veggie { get; set; }
        public List<HotLine> items { get; set; }
    }
}
