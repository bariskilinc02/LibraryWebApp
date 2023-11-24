using AutoMapper;
using Library.Entity.DTOs.Book;
using Library.Entity.DTOs.BookLanguageDTO;
using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.AutoMapper.BookLanguages
{
    public class BookLanguageProfile : Profile
    {
        public BookLanguageProfile()
        {
            CreateMap<BookLanguageDto, BookLanguage>().ReverseMap();
        }
    }
}
