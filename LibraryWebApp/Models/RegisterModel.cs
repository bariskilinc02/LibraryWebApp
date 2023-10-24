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
        public string Name {  get; set; }

        [Required]
        [DisplayName("Surname")]
        public string Surname{ get; set; }

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
        [Compare("Password", ErrorMessage ="Sifre Uyusmuyor.")]
        public string RePassword { get; set; }

    }
}