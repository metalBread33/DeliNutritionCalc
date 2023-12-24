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
        public float Calories { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Protein { get; set; }
        public float SaturatedFat { get; set; }
        public float TransFat { get; set; }
        public float Sodium { get; set; }
        public float Cholesterol { get; set; }

        public NutritionInfo(float cal, float carbs, float fat, float protein,
            float satFat, float tFat, float sodium, float cholesterol) 
        {
            Calories = cal;
            Carbs = carbs;
            Fat = fat;
            Protein = protein;
            SaturatedFat = satFat;
            TransFat = tFat;
            Sodium = sodium;
            Cholesterol = cholesterol;
        }

        public NutritionInfo() 
        {
            Calories = 0; Carbs = 0; Fat = 0; Protein = 0; SaturatedFat = 0;
            TransFat = 0; Sodium = 0; Cholesterol = 0;
        }

        public override string ToString()
        {
            return $"Calories: {Calories}\nCarbs: {Carbs}g\nFat: {Fat}g" +
                $"\n\tSaturated Fat: {SaturatedFat}g\nTrans Fat:" +
                $" {TransFat}g\nProtein: {Protein}g\nSodium: {Sodium}mg" +
                $"\nCholesterol: {Cholesterol}mg";
        }
    }
}
