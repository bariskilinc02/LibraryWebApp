using AutoMapper;
using Library.Entity.DTOs.Book;
using Library.Entity.DTOs.BookCovers;
using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.AutoMapper.BookCoverPath
{
	public class BookCoverProfile : Profile
	{
		public BookCoverProfile()
		{
			CreateMap<BookCoverDto, BookCover>().ReverseMap();
		}
	}
}
