using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class User
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public string? Mail { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? RestorePassword { get; set; }

    public bool? Confirmation { get; set; }

    public string? Token { get; set; }

    public int? AuditCreateUser { get; set; }

    public DateTime? AuditCreateDate { get; set; }

    public int? AuditUpdateUser { get; set; }

    public DateTime? AuditUpdateDate { get; set; }

    public int? AuditDeleteUser { get; set; }

    public DateTime? AuditDeleteDate { get; set; }

    public int State { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Income> Incomes { get; set; } = new List<Income>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
