using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFerriWorld.Sales.BusinessEntities.Entities;

namespace SysFerriWorld.Sales.DataAccess.Context.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Address)
                 .HasMaxLength(500)
                 .IsUnicode(false);
            builder.Property(e => e.AuditCreateDate).HasColumnType("datetime");
            builder.Property(e => e.AuditDeleteDate).HasColumnType("datetime");
            builder.Property(e => e.AuditUpdateDate).HasColumnType("datetime");
            builder.Property(e => e.DateBirth).HasColumnType("datetime");
            builder.Property(e => e.Duinumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DUINumber");
            builder.Property(e => e.LastName)
                .HasMaxLength(60)
                .IsUnicode(false);
            builder.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false);
            builder.Property(e => e.Phone)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();

            builder.HasOne(d => d.IdGenderNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdGender)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMP_GENDER");

            builder.HasOne(d => d.IdMunicipalityNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdMunicipality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMP_MUN");

            builder.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMP_ROL");
        }
    }
}
