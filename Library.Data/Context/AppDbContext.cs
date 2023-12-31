﻿using Library.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim,AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        //Sql data connection base
        public AppDbContext() 
        { 
        
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        //Add all your tables here
        //Table classes in Library.Entity library
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
