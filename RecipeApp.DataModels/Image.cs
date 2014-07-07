using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeApp.DataModels
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public int RecipeId { get; set; }
    }
}
