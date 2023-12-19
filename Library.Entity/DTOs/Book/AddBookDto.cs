using Library.Entity.DTOs.Authors;
using Library.Entity.DTOs.BookLanguageDTO;
using Library.Entity.DTOs.Category;
using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.DTOs.Book
{
	public class AddBookDto
	{
		public int Id { get; set; }
		public string Title { get; set; }
        public int BookLanguageId { get; set; }
        public BookLanguage Language { get; set; }
        public string ISBN { get; set; }
		public string PageNumber { get; set; }
		public int PublicationDate { get; set; }
		public int CategoryId { get; set; }
		public CategoryDto Category { get; set; }
		public int AuthorId { get; set; }
		public Author Author { get; set; }
		public int BookCoverId { get; set; }
		public BookCover BookCover { get; set; }
		public Nullable<System.DateTime> CreateDate { get; set; }



        public List<CategoryDto> AllCategories { get; set; }
        public List<AuthorDto> AllAuthors { get; set; }
        public List<BookLanguageDto> AllLanguages { get; set; }

		public int IsAdded { get; set; } //0 = null, 1 = true, 2 = false
    }
}
