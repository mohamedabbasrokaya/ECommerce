using EcomerceDAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceDAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }



        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<payment> payments { get; set; }
    }
}
   

