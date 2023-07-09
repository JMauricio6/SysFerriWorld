using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class TypeMaterialConfiguration : IEntityTypeConfiguration<TypeMaterial>
    {
        public void Configure(EntityTypeBuilder<TypeMaterial> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_TypeMaterial");

            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
