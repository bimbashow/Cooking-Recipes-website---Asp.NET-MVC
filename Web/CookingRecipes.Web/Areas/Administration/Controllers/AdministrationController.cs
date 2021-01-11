namespace CookingRecipes.Web.Areas.Administration.Controllers
{
    using CookingRecipes.Common;
    using CookingRecipes.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
