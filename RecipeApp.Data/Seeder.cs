using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Text;
using System.Threading.Tasks;
using RecipeApp.DataModels;

namespace RecipeApp.Data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context, bool recipes = true, bool categories = true)
        {
            if (categories)     { SeedCategories(context);}
            context.SaveChanges();
            if (recipes)        { SeedRecipe(context );}
        }

        private static void SeedRecipe(ApplicationDbContext context){
            context.Recipes.AddOrUpdate(
                    r => new { r.Title, r.CategoryId },
                    new Recipe()
                    {
                        CategoryId = 1,
                        Title = "Cordon Bleu",
                        Steps = new List<Instruction>() 
                        { 
                            new Instruction() { Detail = "This is how we do it", StepNumber = 1 } 
                        },
                        Time = new TimeSpan(0, 30, 0),
                        Images = new List<Image>() 
                        {
                            new Image() { ImageUrl = "http://wowslider.com/images/demo/box-stack-v/data1/images/stone_tree.jpg"}
                        },
                        Ingredients = new List<Ingredient>()
                        {
                            new Ingredient() { Name ="Bread", Quantity="2", Time = "3", Yield = "20"}
                        }
                    }
                );
        }
        private static void SeedCategories(ApplicationDbContext context){
            context.Categories.AddOrUpdate(
                    c => new { c.Name },
                    new Category() { Name = "Fake Category", Recipes = new List<Recipe>() }
                );
        }

    }
}
