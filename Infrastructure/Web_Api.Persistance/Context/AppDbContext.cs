using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api.Domain.Entities;

namespace Web_Api.Persistance.Context
{
    public class AppDbContext:DbContext//EFCore kütüphanesi
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) : base(options) 
        { 
            
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
