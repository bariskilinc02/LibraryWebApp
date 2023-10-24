using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Services.Abstraction
{
    public interface IUserService
    {
        Task<List<AppUser>> GetAllUsersAsync();
        Task<AppUser> GetCurrentUser();
    }
}
