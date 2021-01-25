namespace CookingRecipes.Services.Data
{
    using CookingRecipes.Web.ViewModels.Recipes;
    using System.Threading.Tasks;

    public interface IRecipesService
    {
        Task CreateAsync(CreateRecipeInputModel input); 
    }
}
