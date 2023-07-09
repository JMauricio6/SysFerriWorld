using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class Supplier
{
    public int Id { get; set; }

    public int IdDocumentType { get; set; }

    public int IdMunicipality { get; set; }

    public string Name { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string RetailSector { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string? Website { get; set; }

    public int? AuditCreateUser { get; set; }

    public DateTime? AuditCreateDate { get; set; }

    public int? AuditUpdateUser { get; set; }

    public DateTime? AuditUpdateDate { get; set; }

    public int? AuditDeleteUser { get; set; }

    public DateTime? AuditDeleteDate { get; set; }

    public int State { get; set; }

    public virtual DocumentType IdDocumentTypeNavigation { get; set; } = null!;

    public virtual Municipality IdMunicipalityNavigation { get; set; } = null!;

    public virtual ICollection<Income> Incomes { get; set; } = new List<Income>();
}
