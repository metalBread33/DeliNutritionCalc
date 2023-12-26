using PDC.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDC.Library.Models
{
    /*Model class used to store nutrional info for each item. Each class will have
     an instance of NutritionInfo that contains all of the nutrition info*/
    public class NutritionInfo   //Stores the nutritional information for items
    {
        //Variables for Nutrition Information, should be self explanatory
        public float Calories { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Protein { get; set; }
        public float SaturatedFat { get; set; }
        public float TransFat { get; set; }
        public float Sodium { get; set; }
        public float Cholesterol { get; set; }

        public NutritionInfo (TrogSQLEntry entry)
        {
            Calories = entry.Calories;
            Carbs = entry.Carbs;
            Fat = entry.Fat;
            Protein = entry.Protein;
            SaturatedFat = entry.Sodium;
            TransFat = entry.Fat;
            Sodium = entry.Sodium;
            Cholesterol = entry.Cholesterol;
        }

        public override string ToString()
        {
            return $"Calories: {Calories}\nCarbs: {Carbs}g\nFat: {Fat}g" +
                $"\nSaturated Fat: {SaturatedFat}g\nTrans Fat:" +
                $"{TransFat}g\nProtein: {Protein}g\nSodium: {Sodium}mg" +
                $"\nCholesterol: {Cholesterol}mg";
        }
    }
}
