using System;
using System.Collections.Generic;
using System.Text;
using lab2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<City> CitiesDbset { set; get; }
        public DbSet<Province> ProvincesDbset { set; get; }
    }

}

