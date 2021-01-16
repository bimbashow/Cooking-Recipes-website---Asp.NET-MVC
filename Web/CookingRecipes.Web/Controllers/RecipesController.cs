﻿namespace CookingRecipes.Web.Controllers
{
    using CookingRecipes.Web.ViewModels.Recipes;
    using Microsoft.AspNetCore.Mvc;

    public class RecipesController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateRecipeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            // TODO: Create recipe using service method
            // TODO: Redirect to recipe info page
            return this.Redirect("/");
        }
    }
}
