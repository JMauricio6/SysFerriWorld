using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class IncomeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Income");

            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.Correlative)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            builder.Property(e => e.EntryDate).HasColumnType("datetime");
            builder.Property(e => e.Iva).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.Series)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();

            builder.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.IdSupplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INCOME_SUPPLIER");

            builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INCOME_USER");

            builder.HasOne(d => d.IdVoucherTypeNavigation).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.IdVoucherType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INCOME_VT");
        }
    }
}
