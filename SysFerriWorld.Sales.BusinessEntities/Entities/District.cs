using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class District
{
    public int Id { get; set; }

    public int IdDepartament { get; set; }

    public string Name { get; set; } = null!;

    public int State { get; set; }

    public virtual Department IdDepartamentNavigation { get; set; } = null!;

    public virtual ICollection<Municipality> Municipalities { get; set; } = new List<Municipality>();
}
