using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class DetailIncomeConfiguration : IEntityTypeConfiguration<DetailIncome>
    {
        public void Configure(EntityTypeBuilder<DetailIncome> builder)
        {
            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.BuyPrice).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.DateProduction).HasColumnType("datetime");
            builder.Property(e => e.ExpirationDate).HasColumnType("datetime");
            builder.Property(e => e.SalePrice).HasColumnType("decimal(18, 0)");

            builder.HasOne(d => d.IdIncomeNavigation).WithMany(p => p.DetailIncomes)
                .HasForeignKey(d => d.IdIncome)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_INCOME_I");

            builder.HasOne(d => d.IdProductNavigation).WithMany(p => p.DetailIncomes)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_INCOME_PRODUCT");
        }
    }
}
