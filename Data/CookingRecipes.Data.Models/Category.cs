using CookingRecipes.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRecipes.Data.Models
{
    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Recipes = new HashSet<Recipe>();
        }
        public string Name{ get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}
