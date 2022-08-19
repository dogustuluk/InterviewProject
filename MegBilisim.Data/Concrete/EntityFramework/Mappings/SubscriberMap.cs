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
    public class SubscriberMap : IEntityTypeConfiguration<Subscribe>
    {
        public void Configure(EntityTypeBuilder<Subscribe> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.HasOne<Company>(s => s.Company).WithMany(c => c.Subscriptions).HasForeignKey(s => s.CompanyId);
            builder.HasOne<Dues>(s => s.Dues).WithMany(d => d.Subscribes).HasForeignKey(s => s.DuesId);
            builder.HasOne<Electric>(s => s.Electric).WithMany(e => e.Subscribes).HasForeignKey(s => s.ElectricId);
            builder.HasOne<Water>(s => s.Water).WithMany(w => w.Subscribes).HasForeignKey(s => s.WaterId);
            builder.ToTable("Subscribers");
        }
    }
}
