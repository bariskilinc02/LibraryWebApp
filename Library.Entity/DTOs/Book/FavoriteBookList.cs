using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.DTOs.Book
{
    public class FavoriteBookList
    {
        public List<FavoriteBook> books { get; set; }
    }
}
