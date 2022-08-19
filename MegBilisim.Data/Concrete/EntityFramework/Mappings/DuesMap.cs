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
    public class DuesMap : IEntityTypeConfiguration<Dues>
    {
        public void Configure(EntityTypeBuilder<Dues> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.HasMany<Subscribe>(d => d.Subscribes).WithOne(s => s.Dues).HasForeignKey(d => d.DuesId); //kontrol et.
            builder.Property(w => w.IsDeleted).IsRequired();
            builder.Property(w => w.CounterStatus).IsRequired();
            builder.Property(w => w.CreatedByName).IsRequired();
            builder.Property(w => w.CreatedDate).IsRequired();
            builder.Property(w => w.ModifiedByName).IsRequired();
            builder.Property(w => w.Note).IsRequired();
            builder.Property(w => w.Note).HasMaxLength(70);
            builder.Property(w => w.PaymentDate).IsRequired();
            builder.Property(w => w.PaymentTotal).IsRequired();
            builder.ToTable("DuesInvoices");
        }
    }
}
