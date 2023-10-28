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
        Task<List<Book>> GetAllBooks();
        Task<Book> GetBookWithId(int id);
        Task<List<Book>> SearchAnyBook(string keyword, BookFieldType bookFieldType);
    }
}
