using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.DTOs.Book
{
    public class BookListDto
    {
        public string keyword { get; set; }
        public List<BookDto> books { get; set; }
        public int totalPage { get; set; }
        public int currentPage { get; set; }
		public string currentSearchCategory { get; set; }
		public List<SearchCategory> searchCategories { get; set; }
        //public BookListDto(List<BookDto> books)
        //{
        //    this.books = books;
        //}
    }

    public class SearchCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
