using Library.Entity.DTOs.Authors;
using Library.Entity.DTOs.Book;
using Library.Entity.DTOs.BookLanguageDTO;
using Library.Entity.DTOs.Category;
using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Services.Abstraction
{
    public interface IBookService
    {
        Task<BookListDto> GetAllBooks();
		Task<BookListDto> GetAllBooksByPage(int currentPage, int pageSize = 10);
		Task<BookDto> GetBookWithId(int id);
        Task<List<BookDto>> SearchAnyBook(string keyword, BookFieldType bookFieldType);
        Task<BookListDto> SearchBookByPage(string keyword, BookFieldType bookFieldType, int currentPage, int pageSize = 10);
        Task CreateBookAsync(AddBookDto bookDto);
		Task UpdateBookAsync(AddBookDto bookDto);
		Task DeleteBookAsync(int id);
		#region Helper

		Task<List<CategoryDto>> GetAllCategories();
        Task<List<AuthorDto>> GetAllAuthors();
        Task<List<BookLanguageDto>> GetAllLanguages();

        #endregion

        #region Category Overrides

        Task ChangeExistCategory(int id, string newValue);

        Task AddNewCategory(string newValue);

        #endregion


        #region Category Overrides

        Task ChangeExistAuthor(int id, string newValue);

        Task AddNewAuthor(string newValue);

        #endregion
    }
}
