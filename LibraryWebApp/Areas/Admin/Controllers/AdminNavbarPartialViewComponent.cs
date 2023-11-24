using Library.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApp.Areas.Admin.Controllers
{
    public class AdminNavbarPartialViewComponent : ViewComponent
    {
        private readonly IUserService userService;

        public AdminNavbarPartialViewComponent(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userService.GetCurrentUser();

            return View("Default", user);
        }
    }
}
