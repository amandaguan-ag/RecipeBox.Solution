namespace RecipeBox.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Description { get; set; }

        // public Recipe(string description)
        // {
        //   Description = description;
        // }
        // public Recipe(string description, int id)
        // {
        //   Description = description;
        //   Id = id;
        // }

        // public override bool Equals(System.Object otherRecipe)
        // {
        //   if (!(otherRecipe is Recipe))
        //   {
        //     return false;
        //   }
        //   else
        //   {
        //     Recipe newRecipe = (Recipe) otherRecipe;
        //     bool idEquality = (this.Id == newRecipe.Id);
        //     bool descriptionEquality = (this.Description == newRecipe.Description);
        //     return (idEquality && descriptionEquality);
        //   }
        // }

        // public void Save()
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

        //   cmd.CommandText = "INSERT INTO items (description) VALUES (@RecipeDescription);";
        //   MySqlParameter param = new MySqlParameter();
        //   param.ParameterName = "@RecipeDescription";
        //   param.Value = this.Description;
        //   cmd.Parameters.Add(param);    
        //   cmd.ExecuteNonQuery();
        //   Id = (int) cmd.LastInsertedId;

        //   conn.Close();
        //   if (conn != null)
        //   {
        //     conn.Dispose();
        //   }
        // }

        // public static Recipe Find(int id)
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();

        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "SELECT * FROM `items` WHERE id = @ThisId;";

        //   MySqlParameter param = new MySqlParameter();
        //   param.ParameterName = "@ThisId";
        //   param.Value = id;
        //   cmd.Parameters.Add(param);

        //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //   int itemId = 0;
        //   string itemDescription = "";
        //   while (rdr.Read())
        //   {
        //     itemId = rdr.GetInt32(0);
        //     itemDescription = rdr.GetString(1);
        //   }
        //   Recipe foundRecipe = new Recipe(itemDescription, itemId);

        //   conn.Close();
        //   if (conn != null)
        //   {
        //     conn.Dispose();
        //   }
        //   return foundRecipe;
        // }

        // public static List<Recipe> GetAll()
        // {
        //   List<Recipe> allRecipes = new List<Recipe> { };
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "SELECT * FROM items;";
        //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //   while (rdr.Read())
        //   {
        //       int itemId = rdr.GetInt32(0);
        //       string itemDescription = rdr.GetString(1);
        //       Recipe newRecipe = new Recipe(itemDescription, itemId);
        //       allRecipes.Add(newRecipe);
        //   }
        //   conn.Close();
        //   if (conn != null)
        //   {
        //       conn.Dispose();
        //   }
        //   return allRecipes;
        // }

        // public static void ClearAll()
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "DELETE FROM items;";
        //   cmd.ExecuteNonQuery();
        //   conn.Close();
        //   if (conn != null)
        //   {
        //    conn.Dispose();
        //   }
        // }
    }
}