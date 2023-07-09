using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class Product
{
    public int Id { get; set; }

    public int IdCategory { get; set; }

    public int IdBrand { get; set; }

    public int IdTypeMaterial { get; set; }

    public int IdImage { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal? Existence { get; set; }

    public decimal? PriceCost { get; set; }

    public decimal? SalePrice { get; set; }

    public int? StockMinimum { get; set; }

    public int? StockMaximum { get; set; }

    public int? AuditCreateUser { get; set; }

    public DateTime? AuditCreateDate { get; set; }

    public int? AuditUpdateUser { get; set; }

    public DateTime? AuditUpdateDate { get; set; }

    public int? AuditDeleteUser { get; set; }

    public DateTime? AuditDeleteDate { get; set; }

    public int State { get; set; }

    public virtual ICollection<DetailIncome> DetailIncomes { get; set; } = new List<DetailIncome>();

    public virtual Brand IdBrandNavigation { get; set; } = null!;

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Image IdImageNavigation { get; set; } = null!;

    public virtual TypeMaterial IdTypeMaterialNavigation { get; set; } = null!;
}
