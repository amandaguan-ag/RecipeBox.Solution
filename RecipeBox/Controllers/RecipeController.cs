using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;

namespace RecipeBox.Controllers
{
    public class RecipesController : Controller
    {

        [HttpGet("/recipes")]
        public ActionResult Index()
        {
            List<Recipe> allRecipes = Recipe.GetAll();
            return View(allRecipes);
        }

        [HttpGet("/recipes/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/recipes")]
        public ActionResult Create(string description)
        {
            Recipe myRecipe = new Recipe(description);
            return RedirectToAction("Index");
        }

        [HttpPost("/recipes/delete")]
        public ActionResult DeleteAll()
        {
            Recipe.ClearAll();
            return View();
        }

    }
}