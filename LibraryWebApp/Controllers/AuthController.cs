﻿using Library.Entity.Entities;
using LibraryWebApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryWebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult _Authentication(RegisterModel model)
        {
            return PartialView("_Authentication", model);
        }

        [HttpPost]
        [Authorize]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {

            if(ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                    if(result.Succeeded)
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

            //FormsAuthentication.Authenticate(model.Email, model.Password);
            //FormsAuthentication.SetAuthCookie(model.Email, model.RememberMe);

            Debug.WriteLine("login run");

            //var user = _userManager.Find(model.Email, model.Password);
            //if (user != null)
            //{
            //    var authManager = HttpContext.GetOwinContext().Authentication;
            //    var identityClaims = _userManager.CreateIdentity(user, "ApplicationCookie");

            //    var authProperties = new AuthenticationProperties();
            //    authProperties.IsPersistent = true;
            //    authManager.SignIn(authProperties, identityClaims);
            //}
            ModelState.AddModelError("", "E-mail or password is wrong");
            return RedirectToAction("Index", "Home");
            //return PartialView("_LoginPartial", model);
        }

        public ActionResult Register() {

            return NoContent();
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        } 
    }
}
