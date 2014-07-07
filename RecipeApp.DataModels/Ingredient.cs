using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeApp.DataModels
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Yield { get; set; }
        public string Time { get; set; }

        public int RecipeId { get; set; }
    }
}
