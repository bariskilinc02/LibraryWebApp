using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUser> AppUsers { get; set; }
    }
}
