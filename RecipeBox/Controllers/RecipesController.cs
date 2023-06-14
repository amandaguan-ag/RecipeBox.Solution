using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ToDoListContext _db;

        public RecipesController(ToDoListContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Recipe> model = _db.Recipes.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Recipe recipe)
        {
            _db.Recipes.Add(recipe);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Recipe thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
            return View(thisRecipe);
        }
    }
}