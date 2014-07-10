using RecipeApp.DataModels;
using RecipeApp.Web.Adapters.DataAdapters;
using RecipeApp.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RecipeApp.Web.Controllers.API
{
    public class CategoryController : ApiController
    {
        ICategoryAdapter db;

        public CategoryController()
        {
            db = new CategoryAdapter();
        }

        public CategoryController(ICategoryAdapter _db)
        {
            db = _db;
        }

        // GET: api/Category
        public IEnumerable<Category> Get()
        {
            return db.GetCategories();
        }

        // GET: api/Category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
