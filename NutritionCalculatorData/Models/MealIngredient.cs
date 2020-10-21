using NutritionCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionCalculatorData.Models
{
    public class MealIngredient
    {
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
