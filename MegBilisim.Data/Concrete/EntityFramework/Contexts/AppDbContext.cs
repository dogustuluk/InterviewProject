using MegBilisim.Data.Concrete.EntityFramework.Mappings;
using MegBilisim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Data.Concrete.EntityFramework.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Dues> Dues { get; set; }
        public DbSet<Electric> Electrics { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Subscribe> Subscribes{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Water> Waters{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-1C9EMR6;Initial Catalog=MegDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new DuesMap());
            modelBuilder.ApplyConfiguration(new ElectricMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new SubscriberMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new WaterMap());
        }
    }
}
