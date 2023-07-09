using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? AuditCreateUser { get; set; }

    public DateTime? AuditCreateDate { get; set; }

    public int? AuditUpdateUser { get; set; }

    public DateTime? AuditUpdateDate { get; set; }

    public int? AuditDeleteUser { get; set; }

    public DateTime? AuditDeleteDate { get; set; }

    public int State { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
