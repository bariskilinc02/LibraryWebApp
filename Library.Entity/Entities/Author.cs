using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.Entities
{
	public class Author : EntityBase
	{
		public string AuthorName {  get; set; }
		public ICollection<Book> Books { get; set; }
	}
}
