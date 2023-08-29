﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC.Library.Models;

namespace PDC.Library.Services
{
    public class NutritionInfoServices
    {
        public NutritionInfoServices() { }

        public void UpdateInfo (uint cal, uint carbs, uint fat, uint protein,
            uint satFat, uint uFat, uint sodium, uint cholesterol,
            NutritionInfo info)
        {
            info.Calories = cal;
            info.Carbs = carbs;
            info.Fat = fat;
            info.Protein = protein;
            info.SaturatedFat= satFat;
            info.UnSaturatedFat= uFat;
            info.Sodium = sodium;
            info.Cholesterol = cholesterol;
        }
    }
}
