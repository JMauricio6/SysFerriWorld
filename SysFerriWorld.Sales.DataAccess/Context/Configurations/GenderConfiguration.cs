using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Gender");

            builder.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false);
        }
    }
}
