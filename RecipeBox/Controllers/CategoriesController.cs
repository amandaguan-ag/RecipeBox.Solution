using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;

namespace RecipeBox.Controllers
{
    public class CategoriesController : Controller
    {

        [HttpGet("/categories")]
        public ActionResult Index()
        {
            List<Category> allCategories = Category.GetAll();
            return View(allCategories);
        }

        [HttpGet("/categories/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/categories")]
        public ActionResult Create(string categoryName)
        {
            Category newCategory = new Category(categoryName);
            return RedirectToAction("Index");
        }

        [HttpGet("/categories/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Category selectedCategory = Category.Find(id);
            List<Recipe> categoryRecipes = selectedCategory.Recipes;
            model.Add("category", selectedCategory);
            model.Add("recipes", categoryRecipes);
            return View(model);
        }


        // This one creates new Recipes within a given Category, not new Categories:

        [HttpPost("/categories/{categoryId}/recipes")]
        public ActionResult Create(int categoryId, string recipeDescription)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Category foundCategory = Category.Find(categoryId);
            Recipe newRecipe = new Recipe(recipeDescription);
            foundCategory.AddRecipe(newRecipe);
            List<Recipe> categoryRecipes = foundCategory.Recipes;
            model.Add("recipes", categoryRecipes);
            model.Add("category", foundCategory);
            return View("Show", model);
        }

    }
}