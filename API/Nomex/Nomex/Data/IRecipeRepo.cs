using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex.Data
{
    public interface IRecipeRepo
    {
        bool SaveChanges();
        IEnumerable<Recipe> GetAllRecipesByUserId(int userId);
        Recipe GetRecipeById(int id);
        void CreateRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(Recipe recipe);
    }
}
