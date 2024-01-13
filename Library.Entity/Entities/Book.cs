using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.Entities
{
    public class Book : EntityBase
    {
        public Book() 
        {
        }
        public Book(string title, int bookLanguageId, string ıSBN, string pageNumber, int publicationDate, int categoryId, int authorId, int bookCoverId, DateTime? createDate, string? floor, string? locationData)
        {
            Title = title;
            BookLanguageId = bookLanguageId;
            ISBN = ıSBN;
            PageNumber = pageNumber;
            PublicationDate = publicationDate;
            CategoryId = categoryId;
            AuthorId = authorId;
            BookCoverId = bookCoverId;
            CreateDate = createDate;
            Floor = floor;
            LocationInformation = locationData;
        }

		public Book(int id, string title, int bookLanguageId, string ıSBN, string pageNumber, int publicationDate, int categoryId, int authorId, int bookCoverId, DateTime? createDate, string? floor, string? locationData)
		{
            Id = id;
			Title = title;
			BookLanguageId = bookLanguageId;
			ISBN = ıSBN;
			PageNumber = pageNumber;
			PublicationDate = publicationDate;
			CategoryId = categoryId;
			AuthorId = authorId;
			BookCoverId = bookCoverId;
			CreateDate = createDate;
            Floor = floor;
            LocationInformation = locationData;
		}

		public string Title { get; set; }
        public int BookLanguageId { get; set; }
        public BookLanguage Language { get; set; }
        public string ISBN { get; set; }
        public string PageNumber { get; set; }  
        public int PublicationDate { get; set; }
        public int CategoryId { get; set; }
		public Category Category { get; set; }
        public int AuthorId { get; set; }   
        public Author Author { get; set; }
        public int BookCoverId { get; set; }
        public BookCover BookCover { get; set; }
		public Nullable<System.DateTime> CreateDate { get; set; }
        public string? Floor { get; set; }
        public string? LocationInformation { get; set; }
    }
}
