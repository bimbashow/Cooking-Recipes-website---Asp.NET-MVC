using CookingRecipes.Data.Common.Models;
using System;

namespace CookingRecipes.Data.Models
{
    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int RecipeId { get; set; } 

        public virtual Recipe Recipe { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public string Extension { get; set; }
    }
}
