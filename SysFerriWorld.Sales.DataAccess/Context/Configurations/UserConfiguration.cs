using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_User");

            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.Login)
                .HasMaxLength(25)
                .IsUnicode(false);
            builder.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Password)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            builder.Property(e => e.Token)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasOne(d => d.Employee).WithMany(p => p.Users)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_USER_EMPL");
        }
    }
}
