using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.Entities
{
    public class Book : EntityBase
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public string ISBN { get; set; }
        public string PageNumber { get; set; }  
        public int PublicationDate { get; set; }
        public int CategoryId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
