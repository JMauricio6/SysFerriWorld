using Microsoft.EntityFrameworkCore;
using SysFerriWorld.Sales.BusinessEntities.Entities;
using System.Reflection;

namespace SysFerriWorld.Sales.DataAccess.Context;

public partial class FerriWorldDbContext : DbContext
{
    public FerriWorldDbContext()
    {
    }

    public FerriWorldDbContext(DbContextOptions<FerriWorldDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DetailIncome> DetailIncomes { get; set; }

    public virtual DbSet<DetailSale> DetailSales { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Income> Incomes { get; set; }

    public virtual DbSet<Municipality> Municipalities { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TypeMaterial> TypeMaterials { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VoucherType> VoucherTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Collation:Relational", "Modern_Spanish_CI_AS");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
