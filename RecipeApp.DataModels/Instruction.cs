using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeApp.DataModels
{
    public class Instruction
    {
        public int Id { get; set; }
        public int StepNumber { get; set; }
        public string Detail { get; set; }

        public int RecipeId { get; set; }
    }
}
