using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class Income
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdSupplier { get; set; }

    public int IdVoucherType { get; set; }

    public DateTime EntryDate { get; set; }

    public string Series { get; set; } = null!;

    public string Correlative { get; set; } = null!;

    public decimal? Iva { get; set; }

    public int? AuditCreateUser { get; set; }

    public DateTime? AuditCreateDate { get; set; }

    public int? AuditUpdateUser { get; set; }

    public DateTime? AuditUpdateDate { get; set; }

    public int? AuditDeleteUser { get; set; }

    public DateTime? AuditDeleteDate { get; set; }

    public int State { get; set; }

    public virtual ICollection<DetailIncome> DetailIncomes { get; set; } = new List<DetailIncome>();

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual VoucherType IdVoucherTypeNavigation { get; set; } = null!;
}
