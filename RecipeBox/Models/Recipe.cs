using System.Collections.Generic;

namespace RecipeBox.Models
{
    public class Recipe
    {
        public string Description { get; set; }
        private static List<Recipe> _instances = new List<Recipe> { };

        public Recipe(string description)
        {
            Description = description;
            _instances.Add(this);
        }

        public static List<Recipe> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}