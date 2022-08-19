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
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.HasOne<User>(c => c.User).WithMany(u => u.Companies).HasForeignKey(c => c.UserId);
            builder.Property(c => c.CompanyName).IsRequired();
            builder.Property(c => c.CompanyName).HasMaxLength(255);
            builder.Property(c => c.Phone).HasMaxLength(17);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(100);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.HasIndex(c => c.Email).IsUnique();
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(17);
            builder.Property(c => c.Email).HasMaxLength(128);
            builder.Property(c => c.Password).IsRequired();
            builder.Property(c => c.Password).HasMaxLength(50);
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.ToTable("Companies");
        }
    }
}
