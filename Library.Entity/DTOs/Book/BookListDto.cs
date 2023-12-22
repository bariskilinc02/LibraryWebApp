using Library.Entity.DTOs.Authors;
using Library.Entity.DTOs.BookLanguageDTO;
using Library.Entity.DTOs.Category;
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

		public string yazar { get; set; }
		public string tarih { get; set; }
		public string isbn { get; set; }
		public string language_id { get; set; }
		public string category_id { get; set; }


		public List<CategoryDto> AllCategories { get; set; }
		public List<AuthorDto> AllAuthors { get; set; }
		public List<BookLanguageDto> AllLanguages { get; set; }
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
