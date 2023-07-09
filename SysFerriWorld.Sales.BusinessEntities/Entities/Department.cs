using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class Department
{
    public int Id { get; set; }

    public int IdCountry { get; set; }

    public string Name { get; set; } = null!;

    public int State { get; set; }

    public virtual ICollection<District> Districts { get; set; } = new List<District>();

    public virtual Country IdCountryNavigation { get; set; } = null!;
}
