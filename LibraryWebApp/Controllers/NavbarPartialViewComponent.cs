using Library.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApp.Controllers
{
    public class NavbarPartialViewComponent : ViewComponent
    {
        private readonly IUserService userService;

        public NavbarPartialViewComponent( IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userService.GetCurrentUser();
            ViewBag.CurrentUser = userService.GetCurrentUser();
            return View("Default", user);
        }
    }
}
