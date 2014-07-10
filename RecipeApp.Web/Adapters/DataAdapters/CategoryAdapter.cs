using RecipeApp.DataModels;
using RecipeApp.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RecipeApp.Data;

namespace RecipeApp.Web.Adapters.DataAdapters
{
    public class CategoryAdapter : ICategoryAdapter
    {
        public List<Category> GetCategories()
        {
            List<Category> model;

            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Categories
                            .Include("Recipes.Images")
                            .Include("Recipes.Steps")
                            .Include("Recipes.Ingredients")
                            .ToList();
            }

            return model;
        }
    }
}