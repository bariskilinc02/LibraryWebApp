﻿using Library.Entity.DTOs.Book;
using Library.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Library.Entity.Entities;
using static System.Reflection.Metadata.BlobBuilder;
using Library.Data.UnitOfWorks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Library.Entity.DTOs.Others;
using System.Diagnostics;

namespace LibraryWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EditController : Controller
    {
        private readonly IUserService userService;
        private readonly IBookService bookService;

        public EditController(IUserService userService, IBookService bookService) 
        {
            this.userService = userService;
            this.bookService = bookService;
        }


		#region EditBooks
		public async Task<IActionResult> EditBooks()
		{
			BookListDto books = await bookService.GetAllBooks();
			return View(books);
		}

		public async Task<IActionResult> SearchInEditBooks(int page = 1)
		{
			BookListDto books = await bookService.GetAllBooksByPage(page);
			return View("EditBooks", books);
		}

        #endregion

        #region Add Book

        public async Task<IActionResult> AddBook()
		{
			 AddBookDto addBookDto = new AddBookDto();

			var cats = await bookService.GetAllCategories();
            var auts = await bookService.GetAllAuthors();
            var langs = await bookService.GetAllLanguages();

            //addBookDto.CategoryId = 1;
            addBookDto.BookCoverId = 1;
			addBookDto.IsAdded = 0;
            addBookDto.AllCategories = cats;
			addBookDto.AllAuthors = auts;
			addBookDto.AllLanguages = langs;

			addBookDto.CreateDate = DateTime.Now;
			addBookDto.PublicationDate = 2000;

            return View("AddBook",addBookDto);
		}
        [HttpPost]
        public async Task<IActionResult> SendBook(AddBookDto book)
		{
            book.IsAdded = 0;
            book.BookCoverId = 1;

            var cats = await bookService.GetAllCategories();
            var auts = await bookService.GetAllAuthors();
            var langs = await bookService.GetAllLanguages();

            book.AllCategories = cats;
            book.AllAuthors = auts;
            book.AllLanguages = langs;


            if (book.ISBN.Length != 13)
			{
				book.IsAdded = 2;
			}
			else
			{
                await bookService.CreateBookAsync(book);
                book.IsAdded = 1;
            }

            return View("AddBook", book);
        }



        #endregion

        #region Database Properties

        public async Task<IActionResult> DatabaseProperties()
        {
            var cats = await bookService.GetAllCategories();
            var auts = await bookService.GetAllAuthors();
            var langs = await bookService.GetAllLanguages();

            DatabasePropertiesDto propertiesDto = new DatabasePropertiesDto();

            propertiesDto.AllCategories = cats;
            propertiesDto.AllAuthors = auts;
            propertiesDto.AllBookLanguages = langs;
            propertiesDto.DatabasePropertiesEditDto = new DatabasePropertiesEditDto();
            propertiesDto.DatabasePropertiesEditDto.testText = "dwadwad";

            return View(propertiesDto);

        }

        #endregion

        #region Database Property Update

        [HttpPost]
        public async Task<IActionResult> UpdateExistingCategory(int id, string value)
        {
            await bookService.ChangeExistCategory(id, value);

            return RedirectToAction("DatabaseProperties");
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCategory(string categoryName)
        {
            await bookService.AddNewCategory(categoryName);

            return RedirectToAction("DatabaseProperties");
        }


        [HttpPost]
        public async Task<IActionResult> UpdateExistingAuthor(int id, string value)
        {
            await bookService.ChangeExistAuthor(id, value);

            return RedirectToAction("DatabaseProperties");
        }

        [HttpPost]
        public async Task<IActionResult> AddNewAuthor(string authorName)
        {
            await bookService.AddNewAuthor(authorName);

            return RedirectToAction("DatabaseProperties");
        }



        #endregion

    }
}