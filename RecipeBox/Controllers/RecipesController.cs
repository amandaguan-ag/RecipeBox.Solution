using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;

namespace RecipeBox.Controllers
{
    public class RecipesController : Controller
    {

        [HttpGet("/categories/{categoryId}/recipes/new")]
        public ActionResult New(int categoryId)
        {
            Category category = Category.Find(categoryId);
            return View(category);
        }

        [HttpGet("/categories/{categoryId}/recipes/{recipeId}")]
        public ActionResult Show(int categoryId, int recipeId)
        {
            Recipe recipe = Recipe.Find(recipeId);
            Category category = Category.Find(categoryId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("recipe", recipe);
            model.Add("category", category);
            return View(model);
        }
    }
}