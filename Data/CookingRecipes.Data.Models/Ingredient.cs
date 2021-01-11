using CookingRecipes.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRecipes.Data.Models
{
    public class Ingredient : BaseDeletableModel<int>
    {
        public Ingredient()
        {
            this.Recipes = new HashSet<RecipeIngredient>();
        }
        public string Name { get; set; }

        public virtual ICollection<RecipeIngredient> Recipes { get; set; }
    }
}
