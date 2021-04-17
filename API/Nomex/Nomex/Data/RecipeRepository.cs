using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex.Data
{
    public class RecipeRepository : IRecipeRepo
    {
        private readonly NomexContext _context;

        public RecipeRepository(NomexContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Recipe> GetAllRecipesByUserId(int userId)
        {
            return _context.Recipes.ToList().Where(c => c.UserId == userId);
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.Recipes.FirstOrDefault(c => c.Id == id);
        }

        public void CreateRecipe(Recipe recipe)
        {
            if (recipe == null)
                throw new ArgumentNullException(nameof(recipe));
            _context.Recipes.Add(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            //nothing
        }

        public void DeleteRecipe(Recipe recipe)
        {
            if (recipe == null)
                throw new ArgumentNullException(nameof(recipe));
            _context.Recipes.Remove(recipe);
        }
    }
}
