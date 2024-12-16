

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using ProgectE.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProgectE.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Kontragent>Kontragents { get; set; }
        public DbSet<Order>Orders { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                                
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["connectionStrings"].ConnectionString);          

        }
    }
}