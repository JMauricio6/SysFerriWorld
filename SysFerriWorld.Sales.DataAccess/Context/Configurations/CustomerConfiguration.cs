using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false);
            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.DateBirth).HasColumnType("datetime");
            builder.Property(e => e.DocumentNumber)
                .HasMaxLength(9)
                .IsUnicode(false);
            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Phone)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();

            builder.HasOne(d => d.IdDocumentTypeNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.IdDocumentType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_DOC");

            builder.HasOne(d => d.IdGenderNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.IdGender)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_GENDER");

            builder.HasOne(d => d.IdMunicipalityNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.IdMunicipality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_MUN");
        }
    }
}
