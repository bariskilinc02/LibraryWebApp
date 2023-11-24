using AutoMapper;
using Library.Entity.DTOs.Book;
using Library.Entity.DTOs.Category;
using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.AutoMapper.Books
{
	public class BookProfile : Profile
	{
		public BookProfile()
		{
			CreateMap<BookDto, Book>().ReverseMap();
		}
	}
}
