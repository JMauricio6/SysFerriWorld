using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class Municipality
{
    public int Id { get; set; }

    public int IdDistrict { get; set; }

    public string Name { get; set; } = null!;

    public int State { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual District IdDistrictNavigation { get; set; } = null!;

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
