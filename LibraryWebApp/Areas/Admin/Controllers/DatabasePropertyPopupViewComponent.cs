using Library.Entity.DTOs.Others;
using Library.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApp.Areas.Admin.Controllers
{
    public class DatabasePropertyPopupViewComponent : ViewComponent
    {
        private readonly IUserService userService;

        public DatabasePropertyPopupViewComponent(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync(DatabasePropertiesDto dto)
        {
            return View("Default", dto);
        }
    }
}
