namespace CookingRecipes.Services.Data
{
    using System.Linq;

    using CookingRecipes.Data.Common.Repositories;
    using CookingRecipes.Data.Models;
    using CookingRecipes.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private IDeletableEntityRepository<Category> categoriesRepository;
        private IRepository<Image> imagesRepository;
        private IDeletableEntityRepository<Ingredient> ingredientsRepository;
        private IDeletableEntityRepository<Recipe> recipesRepository;

        public GetCountsService(
            IDeletableEntityRepository<Category> categoriesRepository,
            IRepository<Image> imagesRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRepository,
            IDeletableEntityRepository<Recipe> recipesRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.imagesRepository = imagesRepository;
            this.ingredientsRepository = ingredientsRepository;
            this.recipesRepository = recipesRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                CategoriesCount = this.categoriesRepository.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
                RecipesCount = this.recipesRepository.All().Count(),
                IngredientsCount = this.ingredientsRepository.All().Count(),
            };
            return data;
        }
    }
}
