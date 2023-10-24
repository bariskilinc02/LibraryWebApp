using Library.Entity.Entities;
using Library.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Library.Service.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Library.Service.Services.Concrete
{
    public class UserService: IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<AppUser> userManager;

        public UserService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
        }    

        public async Task<List<AppUser>> GetAllUsersAsync()
        {
            return await userManager.Users.ToListAsync();
            //return await unitOfWork.GetRepository<AppUser>().GetAllAsync();
        }

        public async Task<AppUser> GetCurrentUser()
        {
            var emailCookie = httpContextAccessor.HttpContext.User.GetLoggedInEmail();
            emailCookie = emailCookie ?? "";
            return await userManager.FindByEmailAsync(emailCookie);
            //return await unitOfWork.GetRepository<AppUser>().GetByEmail(httpContextAccessor.HttpContext.User.GetLoggedInEmail());
        }
    }
}
