using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeApp.DataModels
{
    public class Recipe
    {
        public Recipe()
        {
            this.Images         = new List<Image>();
            this.Steps          = new List<Instruction>();
            this.Ingredients    = new List<Ingredient>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string Title { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Instruction> Steps { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public TimeSpan Time { get; set; }
    }
}
