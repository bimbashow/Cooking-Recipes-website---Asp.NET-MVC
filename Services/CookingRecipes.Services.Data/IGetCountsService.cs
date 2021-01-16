namespace CookingRecipes.Services.Data
{
    using CookingRecipes.Web.ViewModels.Home;

    public interface IGetCountsService
    {
       IndexViewModel GetCounts();
    }
}
