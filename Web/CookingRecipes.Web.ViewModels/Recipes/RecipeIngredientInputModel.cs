namespace CookingRecipes.Web.ViewModels.Recipes
{
    using System.ComponentModel.DataAnnotations;

    public class RecipeIngredientInputModel
    {
        [MinLength(3)]
        public string IngredientName { get; set; }

        [MinLength(3)]
        public string Quantity { get; set; }
    }
}
