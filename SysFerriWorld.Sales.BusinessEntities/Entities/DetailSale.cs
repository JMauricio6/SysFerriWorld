using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class DetailSale
{
    public int Id { get; set; }

    public int IdSale { get; set; }

    public int? Quantity { get; set; }

    public decimal? PriceCost { get; set; }

    public decimal? SalePrice { get; set; }

    public decimal? SubTotalSale { get; set; }

    public decimal? Discount { get; set; }

    public int? AuditCreateUser { get; set; }

    public DateTime? AuditCreateDate { get; set; }

    public int? AuditUpdateUser { get; set; }

    public DateTime? AuditUpdateDate { get; set; }

    public int? AuditDeleteUser { get; set; }

    public DateTime? AuditDeleteDate { get; set; }

    public int State { get; set; }

    public virtual Sale IdSaleNavigation { get; set; } = null!;
}
