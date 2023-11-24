using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entity.Entities;
using Library.Entity.DTOs.Category;
using Library.Entity.DTOs.Authors;
using Library.Entity.DTOs.BookLanguageDTO;

namespace Library.Entity.DTOs.Others
{
    public class DatabasePropertiesDto
    {
        public List<CategoryDto> AllCategories { get; set; }
        public List<AuthorDto> AllAuthors { get; set; }
        public List<BookLanguageDto> AllBookLanguages { get; set; }

        public DatabasePropertiesEditDto DatabasePropertiesEditDto { get; set; }
    }
}
