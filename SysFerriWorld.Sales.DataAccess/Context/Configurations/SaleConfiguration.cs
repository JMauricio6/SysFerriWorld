using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Sale");

            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.Correlative)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            builder.Property(e => e.DateSale).HasColumnType("datetime");
            builder.Property(e => e.Iva).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.Series)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            builder.Property(e => e.TotalSale).HasColumnType("decimal(18, 0)");

            builder.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.IdCustomer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALE_C");

            builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALE_USER");

            builder.HasOne(d => d.IdVoucherTypeNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.IdVoucherType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALE_VT");
        }
    }
}
