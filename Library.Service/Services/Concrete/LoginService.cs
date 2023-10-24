using Library.Data.UnitOfWorks;
using Library.Entity.Entities;
using Library.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Services.Concrete
{
    public class LoginService : ILoginService
    {
        private readonly IUnitOfWork unitOfWork;

        public LoginService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<LibraryUser> GetAllUsersAsync()
        {
            return await unitOfWork.GetRepository<LibraryUser>().GetAsync();
        }
    }
}
