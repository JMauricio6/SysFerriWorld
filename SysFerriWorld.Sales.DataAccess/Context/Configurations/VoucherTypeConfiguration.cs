using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class VoucherTypeConfiguration : IEntityTypeConfiguration<VoucherType>
    {
        public void Configure(EntityTypeBuilder<VoucherType> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_VoucherType");

            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.NameType)
                .HasMaxLength(15)
                .IsUnicode(false);
        }
    }
}
