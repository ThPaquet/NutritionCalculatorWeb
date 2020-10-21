using Microsoft.EntityFrameworkCore;
using NutritionCalculator;
using NutritionCalculatorData.Models;

namespace NutritionCalculatorData
{
    public class NutritionCalculatorContext : DbContext
    {
        public NutritionCalculatorContext(DbContextOptions<NutritionCalculatorContext> options)
            : base(options)
        {

        }


        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealIngredient> MealIngredients {get; set;}

        public NutritionCalculatorContext()
        {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealIngredient>()
                .HasKey(bi => new { bi.IngredientId, bi.MealId });

            modelBuilder.Entity<MealIngredient>()
                .HasOne(bi => bi.Ingredient)
                .WithMany(i => i.Meals)
                .HasForeignKey(bc => bc.IngredientId);
            modelBuilder.Entity<MealIngredient>()
                .HasOne(bi => bi.Meal)
                .WithMany(m => m.Ingredients)
                .HasForeignKey(bi => bi.MealId);

        }

    }
}

