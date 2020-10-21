using NutritionCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionCalculatorData.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MealIngredient> Ingredients { get; set; }
    }
}
