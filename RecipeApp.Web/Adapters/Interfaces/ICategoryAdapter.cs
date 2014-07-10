using RecipeApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Web.Adapters.Interfaces
{
    public interface ICategoryAdapter
    {
        List<Category> GetCategories();
    }
}
