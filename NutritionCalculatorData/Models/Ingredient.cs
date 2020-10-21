using NutritionCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NutritionCalculatorData.Models;

namespace NutritionCalculator
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fats { get; set; }
        public double Saturated_Fats { get; set; }
        public double Trans_Fats { get; set; }
        public double Carbohydrates { get; set; }
        public double Fiber { get; set; }
        public double Sugars { get; set; }
        public double Sodium { get; set; }
        public virtual ICollection<MealIngredient> Meals { get; set; }
    }
}
