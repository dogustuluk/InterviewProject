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
    public class WaterMap : IEntityTypeConfiguration<Water>
    {
        public void Configure(EntityTypeBuilder<Water> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Id).ValueGeneratedOnAdd();
            builder.HasMany<Subscribe>(w => w.Subscribes).WithOne(s => s.Water).HasForeignKey(w => w.WaterId); //kontrol et.
            builder.Property(w => w.IsDeleted).IsRequired();
            builder.Property(w => w.CounterStatus).IsRequired();
            builder.Property(w => w.CounterNo).IsRequired();
            builder.Property(w => w.CreatedByName).IsRequired();
            builder.Property(w => w.CreatedDate).IsRequired();
            builder.Property(w => w.FirstIndex).IsRequired();
            builder.Property(w => w.FirstReadingDate).IsRequired();
            builder.Property(w => w.LastIndex).IsRequired();
            builder.Property(w => w.ModifiedByName).IsRequired();
            builder.Property(w => w.Note).IsRequired();
            builder.Property(w => w.Note).HasMaxLength(70);
            builder.Property(w => w.PaymentDate).IsRequired();
            builder.Property(w => w.PaymentTotal).IsRequired();
            builder.Property(w => w.ReaderCode).IsRequired();
            builder.Property(w => w.ReaderCode).HasMaxLength(5);
            builder.ToTable("WaterInvoices");
        }
    }
}
