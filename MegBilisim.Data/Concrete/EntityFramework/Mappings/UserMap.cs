using MegBilisim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasMany<Company>(u => u.Companies).WithOne(c => c.User).HasForeignKey(u => u.SubscriberId); //kontrol et.
            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
            builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedByName).HasMaxLength(100);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.ModifiedByName).IsRequired();
            builder.Property(u => u.ModifiedDate).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(128);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasMaxLength(50);
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.Surname).HasMaxLength(50);
            builder.Property(u => u.Surname).HasMaxLength(50);
            builder.ToTable("Users");


            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                Name = "Doğuş",
                Surname = "Tuluk",               
                Email = "dogus@gmail.com",                
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                PasswordHash = Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500")
            });
        }
    }
}
