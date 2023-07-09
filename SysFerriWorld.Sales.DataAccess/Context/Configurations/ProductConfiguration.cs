using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Product");

            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Existence).HasColumnType("decimal(5, 4)");
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.PriceCost).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.SalePrice).HasColumnType("decimal(18, 0)");

            builder.HasOne(d => d.IdBrandNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdBrand)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_BRAND");

            builder.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_CAT");

            builder.HasOne(d => d.IdImageNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdImage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_IMG");

            builder.HasOne(d => d.IdTypeMaterialNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_MATERIAL");
        }
    }
}
