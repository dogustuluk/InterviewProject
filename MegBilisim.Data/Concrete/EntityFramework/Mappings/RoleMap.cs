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
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Description).IsRequired();
            builder.Property(r => r.Description).HasMaxLength(150);
            builder.Property(r => r.Name).IsRequired();
            builder.Property(r => r.Name).HasMaxLength(60);
            builder.ToTable("Roles");

            builder.HasData(new Role
            {
                Id = 1,
                Name = "Admin",
                Description = "InitialCreate"
            });

        }
    }
}
