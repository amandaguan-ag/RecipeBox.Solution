using System.Collections.Generic;

namespace RecipeBox.Models
{
    public class Category
    {
        private static List<Category> _instances = new List<Category> { };
        public string Name { get; set; }
        public int Id { get; }
        public List<Recipe> Recipes { get; set; }

        public Category(string categoryName)
        {
            Name = categoryName;
            _instances.Add(this);
            Id = _instances.Count;
            Recipes = new List<Recipe> { };
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Category> GetAll()
        {
            return _instances;
        }

        public static Category Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}