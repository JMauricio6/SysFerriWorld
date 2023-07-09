using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.Property)
                .HasMaxLength(15)
                .IsUnicode(false);
            builder.Property(e => e.Resource)
                .HasMaxLength(15)
                .IsUnicode(false);
            builder.Property(e => e.Value)
                .HasMaxLength(15)
                .IsUnicode(false);
        }
    }
}
