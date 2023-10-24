using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.DTOs.Users
{
    public class UserDto
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
