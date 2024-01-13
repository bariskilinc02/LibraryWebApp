using Library.Entity.DTOs.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class RegisterModel
    {
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Surname")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Password")]
        [Compare("Password", ErrorMessage = "Sifre Uyusmuyor.")]
        public string Password { get; set; }

        [Required]
        [DisplayName("RePassword")]
        [Compare("Password", ErrorMessage = "Sifre Uyusmuyor.")]
        public string RePassword { get; set; }


        public int RoleId { get; set; }
        public List<RoleDto> GetAllRoles()
        {
			List<RoleDto> AllRoles = new List<RoleDto>
			{
				new RoleDto { Id = 1, RoleName = "Super Admin" },
				new RoleDto { Id = 2, RoleName = "Admin" },
				new RoleDto { Id = 3, RoleName = "User" }
			};
			return AllRoles;

		}
    }
}