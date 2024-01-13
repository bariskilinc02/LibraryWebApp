using AutoMapper;
using Library.Data.UnitOfWorks;
using Library.Entity.DTOs.Authors;
using Library.Entity.DTOs.Book;
using Library.Entity.DTOs.BookLanguageDTO;
using Library.Entity.DTOs.Category;
using Library.Entity.Entities;
using Library.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library.Service.Services.Concrete
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

		public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
			this.mapper = mapper;
		}



        public async Task<BookListDto> GetAllBooks()
        {
            List<Book> books = await unitOfWork.GetRepository<Book>().GetAllAsync();
            var map = mapper.Map<List<BookDto>>(books);

            return new BookListDto
            {
                books = map,
                totalPage = 0,
                keyword = "",
                currentPage = 0
			};
        }

		public async Task<BookListDto> GetAllBooksByPage(int currentPage, int pageSize = 10)
		{
			List<Book> books = await unitOfWork.GetRepository<Book>().GetAllAsync(null,x => x.Category, x => x.Author, x => x.BookCover);
			var map = mapper.Map<List<BookDto>>(books);

			int totalPageCount = (int)Math.Ceiling(((float)books.Count() / (float)pageSize));

			var boundedBooks = map.OrderBy(a => a.Title).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

			return new BookListDto
            {
                keyword = "",
                books = boundedBooks,
                currentPage = currentPage,
                totalPage = totalPageCount
			};
		}



        public async Task<BookDto> GetBookWithId(int id)
        {
            Book book = await unitOfWork.GetRepository<Book>().GetAsync(x => x.Id == id, x => x.Category, x => x.Author, x => x.BookCover);
            var map = mapper.Map<BookDto>(book);
            return map;
        }

        public async Task<List<BookDto>> SearchAnyBook(string keyword, BookFieldType bookFieldType)
        {
            Expression<Func<Book, bool>> filter = bookFieldType switch
            {
                BookFieldType.All => x => x.Title.Contains(keyword) || x.ISBN.Contains(keyword),
                BookFieldType.Title => x => x.Title.Contains(keyword),
				BookFieldType.ISBN => x => x.ISBN.Contains(keyword),
				BookFieldType.PublicationYear => x => x.PublicationDate.ToString().Contains(keyword),
				_ => x => x.Title.Contains(keyword) // Varsayılan olarak Title alanında arama yap
            };
     
            var books = await unitOfWork.GetRepository<Book>().GetAllAsync(filter, x => x.Category, x=>x.Author, x => x.BookCover);
            var map = mapper.Map<List<BookDto>>(books);
            return map;
            //return await unitOfWork.GetRepository<Book>().GetAsync(x => x.Title.Contains(keyword) || x.ISBN.Contains(keyword));
        }

        public async Task<BookListDto> SearchBookByPage(string keyword, BookFieldType bookFieldType, int currentPage = 1, int pageSize = 10)
        {
            var books = await SearchAnyBook(keyword, bookFieldType);
            var boundedBooks = books.OrderBy(a => a.Title).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

			int totalPageCount = (int)Math.Ceiling((decimal)((float)books.Count() / (float)pageSize));

			return new BookListDto
            {
                keyword = keyword,
				books = boundedBooks,
                currentPage = currentPage,
                totalPage = totalPageCount
			};
        }

		public async Task<BookListDto> SearchBookByPageLast(string keyword,string yazar, string tarih, string isbn, string language_id, string category_id, int currentPage = 1, int pageSize = 10)
		{
			bool isYazar = int.TryParse(yazar, out var newYazarId);
			bool isIsbn = !(isbn == "" || isbn == null);
			bool isTarih = int.TryParse(tarih, out var newTarihId);
			bool isCategory = int.TryParse(category_id, out var newCategoryId);
			bool isLanguage = int.TryParse(language_id, out var newLanguageId);

      
            if (newCategoryId == 0)
            {
                isCategory = false;

			}

			if (newLanguageId == 0)
			{
				isLanguage = false;

			}

			if (newYazarId == 0)
			{
				isYazar = false;

			}


			Expression<Func<Book, bool>> filter = x => 
            (keyword != null ? x.Title.Contains(keyword): !x.Title.Equals(null))
            && (isIsbn ? x.ISBN.Contains(isbn) : !x.ISBN.Equals(null))
			&& (isYazar ? x.AuthorId.Equals(newYazarId) : !x.AuthorId.Equals(null))
			&& (isTarih ? x.PublicationDate.Equals(newTarihId) : !x.PublicationDate.Equals(null))
			&& (isLanguage ? x.BookLanguageId.Equals(newLanguageId) : !x.BookLanguageId.Equals(null))
            && (isCategory ? x.CategoryId.Equals(newCategoryId) : !x.CategoryId.Equals(null)); 
            
            
            /*x.CategoryId.Equals(int.Parse(category_id));*/


			//   && x.ISBN.Contains(isbn)
			//&& x.PublicationDate.Equals(int.Parse(tarih))

			var mybooks = await unitOfWork.GetRepository<Book>().GetAllAsync(filter, x => x.Category, x => x.Author, x => x.BookCover);
			var map = mapper.Map<List<BookDto>>(mybooks);


            var books = map;
			var boundedBooks = books.OrderBy(a => a.Title).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            int totalPageCount = (int)Math.Ceiling((decimal)((float)books.Count() / (float)pageSize)); //(int)(books.Count() / pageSize);
			return new BookListDto
			{
				keyword = keyword,
				books = boundedBooks,
				currentPage = currentPage,
				totalPage = totalPageCount
			};
		}
		/*
        public async Task<BookListDto> SearchByPagingAsync(string keyword, BookFieldType bookFieldType, int currentPage = 1, int pageSize = 10)
        {
            var books = await SearchAnyBook(keyword, bookFieldType);
            var boundedBooks = books.OrderBy(a => a.Title).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            return new BookListDto
            {
                books = boundedBooks
            };
        }
        */

		#region Helpers

		public async Task<List<CategoryDto>> GetAllCategories()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync();
            var map = mapper.Map<List<CategoryDto>>(categories);

            return map;
        }

        public async Task<List<AuthorDto>> GetAllAuthors()
        {
            var categories = await unitOfWork.GetRepository<Author>().GetAllAsync();
            var map = mapper.Map<List<Entity.DTOs.Authors.AuthorDto>>(categories);

            return map;
        }

        public async Task<List<BookLanguageDto>> GetAllLanguages()
        {
            var languages = await unitOfWork.GetRepository<BookLanguage>().GetAllAsync();
            var map = mapper.Map<List<BookLanguageDto>>(languages);

            return map;
        }

        public async Task CreateBookAsync(AddBookDto bookDto)
        {
            var newBook = new Book(bookDto.Title, bookDto.BookLanguageId, bookDto.ISBN, bookDto.PageNumber, bookDto.PublicationDate, bookDto.CategoryId, bookDto.AuthorId, bookDto.BookCoverId, bookDto.CreateDate, bookDto.Floor, bookDto.LocationInformation);
            await unitOfWork.GetRepository<Book>().AddAsync(newBook);
            await unitOfWork.SaveAsync();
        }

		public async Task UpdateBookAsync(AddBookDto bookDto)
		{
			var newBook = new Book(bookDto.Id,bookDto.Title, bookDto.BookLanguageId, bookDto.ISBN, bookDto.PageNumber, bookDto.PublicationDate, bookDto.CategoryId, bookDto.AuthorId, bookDto.BookCoverId, bookDto.CreateDate,bookDto.Floor, bookDto.LocationInformation);
			await unitOfWork.GetRepository<Book>().UpdateAsync(newBook);
			await unitOfWork.SaveAsync();
		}

		public async Task DeleteBookAsync(int id)
		{
			var book = await unitOfWork.GetRepository<Book>().GetById(id);
			await unitOfWork.GetRepository<Book>().DeleteAsync(book);
			await unitOfWork.SaveAsync();
		}

		#endregion

		#region Overrides

		public async Task ChangeExistCategory(int id, string newValue)
        {
            var category = await unitOfWork.GetRepository<Category>().GetById(id);
            category.CategoryName = newValue;
            await unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await unitOfWork.SaveAsync();
        }


        public async Task AddNewCategory(string newValue)
        {
            var category = new Category { CategoryName = newValue };
            await unitOfWork.GetRepository<Category>().AddAsync(category);
            await unitOfWork.SaveAsync();
        }

        public async Task ChangeExistAuthor(int id, string newValue)
        {
            var category = await unitOfWork.GetRepository<Author>().GetById(id);
            category.AuthorName = newValue;
            await unitOfWork.GetRepository<Author>().UpdateAsync(category);
            await unitOfWork.SaveAsync();
        }

        public async Task AddNewAuthor(string newValue)
        {
            var category = new Author { AuthorName = newValue };
            await unitOfWork.GetRepository<Author>().AddAsync(category);
            await unitOfWork.SaveAsync();
        }


        public async Task<List<FavoriteBook>> GetAllFavoriteBooksWithId(int id)
        {

            var books = await unitOfWork.GetRepository<FavoriteBook>().GetAllAsync(x =>x.UserId == id, x => x.Book, x => x.User, x => x.Book.Category, x => x.Book.BookCover, x => x.Book.Author, x => x.Book.Language);
            var map = mapper.Map<List<FavoriteBook>>(books);
            return map;
        }

        public async Task AddBookFavoriteBooks(int bookId, int userId)
        {
            FavoriteBook favoriteBook = new FavoriteBook();

            favoriteBook.UserId = userId;
            favoriteBook.BookId = bookId;
			await unitOfWork.GetRepository<FavoriteBook>().AddAsync(favoriteBook);
			await unitOfWork.SaveAsync();
		}

		public async Task DeleteBookFavoriteBooks(int bookId, int userId)
		{
			var book = await unitOfWork.GetRepository<FavoriteBook>().GetById(bookId);
			await unitOfWork.GetRepository<FavoriteBook>().DeleteAsync(book);
			await unitOfWork.SaveAsync();
		}

		#endregion

	}
}
