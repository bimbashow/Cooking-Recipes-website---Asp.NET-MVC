﻿namespace CookingRecipes.Web.Controllers
{
    using System.Threading.Tasks;

    using CookingRecipes.Services.Data;
    using CookingRecipes.Web.ViewModels.Recipes;
    using Microsoft.AspNetCore.Mvc;

    public class RecipesController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly IRecipesService recipesService;

        public RecipesController(
            ICategoriesService categoriesService,
            IRecipesService recipesService)
        {
            this.categoriesService = categoriesService;
            this.recipesService = recipesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateRecipeInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRecipeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            await this.recipesService.CreateAsync(input);

            // TODO: Redirect to recipe info page
            return this.Redirect("/");
        }
    }
}
