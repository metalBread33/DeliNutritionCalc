using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDC_Library.Models
{
    internal class NutritionInfo   //Stores the nutritional information for items
    {
        public uint Calories { get; set; }
        public uint Carbs { get; set; }
        public uint Fat { get; set; }
        public uint Protein { get; set; }
        public uint SaturatedFat { get; set; }
        public uint UnSaturatedFat { get; set; }
        public uint Sodium { get; set; }
        public uint Cholesterol { get; set; }

        public NutritionInfo(uint cal, uint carbs, uint fat, uint protein,
            uint satFat, uint uFat, uint sodium, uint cholesterol) 
        {
            Calories = cal;
            Carbs = carbs;
            Fat = fat;
            Protein = protein;
            SaturatedFat = satFat;
            UnSaturatedFat = uFat;
            Sodium = sodium;
            Cholesterol = cholesterol;
        }

        public override string ToString()
        {
            return $"Calories: {Calories}\nCarbs: {Carbs}g\nFat: {Fat}g" +
                $"\n\tSaturated Fat: {SaturatedFat}g\n\tUnsaturated Fat:" +
                $" {UnSaturatedFat}g\nProtein: {Protein}g\nSodium: {Sodium}mg" +
                $"\nCholesterol: {Cholesterol}mg";
        }
    }
}
