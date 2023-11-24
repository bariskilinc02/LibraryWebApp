using AutoMapper;
using Library.Entity.DTOs.Authors;
using Library.Entity.DTOs.Book;
using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.AutoMapper.Authors
{
	public class AuthorProfile : Profile
	{
		public AuthorProfile()
		{
            CreateMap<Entity.DTOs.Authors.AuthorDto, Author>().ReverseMap();
		}
	}
}
