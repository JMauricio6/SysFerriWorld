using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class MunicipalityConfiguration : IEntityTypeConfiguration<Municipality>
    {
        public void Configure(EntityTypeBuilder<Municipality> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.IdDistrictNavigation).WithMany(p => p.Municipalities)
                .HasForeignKey(d => d.IdDistrict)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MUNI_DIS");
        }
    }
}
