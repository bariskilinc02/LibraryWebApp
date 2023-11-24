using Library.Entity.Entities;
using Library.Service.Services.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public HomeController(IUserService userService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await userService.GetCurrentUser();
            return View(user);
        }

        [HttpPost]
        [Authorize]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminLogin(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, password, true, false);

                    if (result.Succeeded)
                    {
                        Debug.WriteLine("succeded");
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        Debug.WriteLine("no succeded");
                        ModelState.AddModelError("", "E-mail or password is wrong");
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    Debug.WriteLine("zort");
                    ModelState.AddModelError("", "E-mail or password is wrong");
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                Debug.WriteLine("critical error");
            }

            Debug.WriteLine("login run");


            ModelState.AddModelError("", "E-mail or password is wrong");
            return RedirectToAction("Index", "Home");
        }

    }
}
