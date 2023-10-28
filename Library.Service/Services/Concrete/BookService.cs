using Library.Data.UnitOfWorks;
using Library.Entity.Entities;
using Library.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Services.Concrete
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Book>> GetAllBooks()
        {
            return await unitOfWork.GetRepository<Book>().GetAllAsync();
        }
        public async Task<Book> GetBookWithId(int id)
        {
            return await unitOfWork.GetRepository<Book>().GetAsync(x => x.Id == id);
        }

        public async Task<List<Book>> SearchAnyBook(string keyword, BookFieldType bookFieldType)
        {
            Expression<Func<Book, bool>> filter = bookFieldType switch
            {
                BookFieldType.All => x => x.Title.Contains(keyword) || x.ISBN.Contains(keyword),
                BookFieldType.Title => x => x.Title.Contains(keyword),
                BookFieldType.ISBN => x => x.ISBN.Contains(keyword),
                _ => x => x.Title.Contains(keyword) // Varsayılan olarak Title alanında arama yap
            };
     
            return await unitOfWork.GetRepository<Book>().GetAllAsync(filter);
            //return await unitOfWork.GetRepository<Book>().GetAsync(x => x.Title.Contains(keyword) || x.ISBN.Contains(keyword));
        }


    }
}
