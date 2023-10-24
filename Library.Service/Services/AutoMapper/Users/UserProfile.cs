using AutoMapper;
using Library.Entity.DTOs.Users;
using Library.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Services.AutoMapper.Users
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, LibraryUser>().ReverseMap();
        }
    }
}
