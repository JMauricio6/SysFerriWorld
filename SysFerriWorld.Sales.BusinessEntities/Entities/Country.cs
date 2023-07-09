using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int State { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
