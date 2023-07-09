using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false);
            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.CompanyName)
                .HasMaxLength(150)
                .IsUnicode(false);
            builder.Property(e => e.DocumentNumber)
                .HasMaxLength(11)
                .IsUnicode(false);
            builder.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            builder.Property(e => e.Phone)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            builder.Property(e => e.RetailSector)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Website)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasOne(d => d.IdDocumentTypeNavigation).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.IdDocumentType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPPLIER_DOC");

            builder.HasOne(d => d.IdMunicipalityNavigation).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.IdMunicipality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPPLIER_MUN");
        }
    }
}
