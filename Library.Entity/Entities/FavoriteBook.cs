using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.Entities
{
    public class FavoriteBook:EntityBase
    {
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
