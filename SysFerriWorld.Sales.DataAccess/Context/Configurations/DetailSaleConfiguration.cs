using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class DetailSaleConfiguration : IEntityTypeConfiguration<DetailSale>
    {
        public void Configure(EntityTypeBuilder<DetailSale> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_DetailSale");

            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.PriceCost).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.SalePrice).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.SubTotalSale).HasColumnType("decimal(18, 0)");

            builder.HasOne(d => d.IdSaleNavigation).WithMany(p => p.DetailSales)
                .HasForeignKey(d => d.IdSale)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALE");
        }
    }
}
