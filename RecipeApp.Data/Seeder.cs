using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context, 
            bool images = true, bool ingredients = true, bool instructions = true, bool recipes = true, bool categories = true, bool user = true)
        {
            if (categories)     { SeedCategories(context);}
            if (recipes)        { SeedRecipe(context );}
            if (ingredients)    { SeedIngredients(context); }
            if (instructions)   { SeedInstruction(context); }
            if (images)         { SeedImages(context); }

        }

        private static void SeedImages(ApplicationDbContext context){}
        private static void SeedIngredients(ApplicationDbContext context){}
        private static void SeedInstruction(ApplicationDbContext context){}
        private static void SeedRecipe(ApplicationDbContext context){}
        private static void SeedCategories(ApplicationDbContext context){}

    }
}
