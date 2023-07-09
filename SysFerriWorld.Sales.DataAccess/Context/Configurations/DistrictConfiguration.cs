using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.IdDepartamentNavigation).WithMany(p => p.Districts)
                .HasForeignKey(d => d.IdDepartament)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIS_DEP");
        }
    }
}
