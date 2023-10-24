using Library.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await userService.GetAllUsersAsync();
            return View(users);
        }

    }
}
