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
			BookListDto books = new BookListDto();

			var cats = await bookService.GetAllCategories();
			var auts = await bookService.GetAllAuthors();
			var langs = await bookService.GetAllLanguages();

            if (userService.GetCurrentUser().Result != null)
            {
                books.Authanticated = true;

			}
          

			books.AllCategories = cats;
			books.AllAuthors = auts;
			books.AllLanguages = langs;

            books.yazar = "0";
			books.isbn = "";
			books.tarih = "";
			books.language_id = "0";
			books.category_id = "0";

			return View(books);
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

        public async Task<IActionResult> SeachByPage(string keyword, string selectedCategory,string yazar, string tarih, string isbn, string language_id, string category_id, int currentPage = 1)
        {
			if (selectedCategory is null or "")
			{
				selectedCategory = "0";
			}

			Enum.TryParse<BookFieldType>(selectedCategory, out BookFieldType type);

			BookListDto books = await bookService.SearchBookByPageLast(keyword, yazar, tarih, isbn, language_id, category_id, currentPage, 4);
			//BookListDto books = await bookService.SearchBookByPage(keyword, type, currentPage, 10);
			books.keyword = keyword;

			books.currentSearchCategory = selectedCategory;

			var cats = await bookService.GetAllCategories();
			var auts = await bookService.GetAllAuthors();
			var langs = await bookService.GetAllLanguages();

			books.AllCategories = cats;
			books.AllAuthors = auts;
			books.AllLanguages = langs;

            books.yazar = yazar;
            books.isbn = isbn;
            books.tarih = tarih;
            books.language_id = language_id;
            books.category_id = category_id;

			if (userService.GetCurrentUser().Result != null)
			{
				books.Authanticated = true;

			}


			return View("Index", books);
        }
   
        public async Task<IActionResult> FavoriteBooks()
        {
            var books = await bookService.GetAllFavoriteBooksWithId(userService.GetCurrentUser().Result.Id);
            FavoriteBookList booklist = new FavoriteBookList();
            booklist.books = books;
            return View(booklist);
        }

        public async Task<IActionResult> AddMyFavoriteBooks(int bookId, string keyword, string selectedCategory, string yazar, string tarih, string isbn, string language_id, string category_id, int currentPage = 1)
        {
            var userId = userService.GetCurrentUser().Result.Id;
            await bookService.AddBookFavoriteBooks(bookId, userId);

			return RedirectToAction("SeachByPage", "Home", new { keyword = keyword, selectedCategory = selectedCategory, yazar=yazar, tarih = tarih, isbn = isbn, language_id= language_id, category_id = category_id, currentPage = currentPage });
        }

		public async Task<IActionResult> DeleteFromFavoriteBooks(int id)
        {
            await bookService.DeleteBookFavoriteBooks(id,2);

			return RedirectToAction("FavoriteBooks", "Home");
        }
	}
}