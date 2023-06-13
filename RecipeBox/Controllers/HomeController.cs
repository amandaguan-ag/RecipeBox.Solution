using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;

namespace RecipeBox.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            Recipe starterRecipe = new Recipe("Add first recipe to To Do List");
            return View(starterRecipe);
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
            return View("Index", myRecipe);
        }

    }
}