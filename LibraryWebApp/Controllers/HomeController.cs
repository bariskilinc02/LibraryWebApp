using Library.Service.Services;
using Library.Service.Services.Abstraction;
using LibraryWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Library.Entity.DTOs.Book;

namespace LibraryWebApp.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService userService;
        private readonly IBookService bookService;

        public HomeController(ILogger<HomeController> logger, IUserService userService, IBookService bookService)
        {
            _logger = logger;
            this.userService = userService;
            this.bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            //var users = await userService.GetAllUsersAsync();
            //var currentUser = await userService.GetCurrentUser();
            //if (currentUser != null)
            //{
            //    Debug.WriteLine(currentUser.Email);
            //}
            //else
            //{
            //    Debug.WriteLine("no user");
            //}
            return View(/*users*/);
        }

        public IActionResult _Authentication(RegisterModel model)
        {
            return PartialView("_Authentication", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Search(string keyword, string field)
        {
            Enum.TryParse<BookFieldType>(field, out BookFieldType type);

            var books = await bookService.SearchAnyBook(keyword, BookFieldType.All);

            return View("Index",books);
        }

        public async Task<IActionResult> SeachByPage(string keyword, string selectedCategory, int currentPage = 1)
        {
			if (selectedCategory is null or "")
			{
				selectedCategory = "0";
			}

			Enum.TryParse<BookFieldType>(selectedCategory, out BookFieldType type);

			BookListDto books = await bookService.SearchBookByPage(keyword, type, currentPage, 10);
            books.keyword = keyword;

			books.currentSearchCategory = selectedCategory;

			return View("Index", books);
        }
    }
}