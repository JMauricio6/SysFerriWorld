using System;
using System.Collections.Generic;

namespace SysFerriWorld.Sales.BusinessEntities.Entities;

public partial class DetailIncome
{
    public int Id { get; set; }

    public int IdIncome { get; set; }

    public int IdProduct { get; set; }

    public decimal? BuyPrice { get; set; }

    public decimal? SalePrice { get; set; }

    public int? StockCurrent { get; set; }

    public DateTime DateProduction { get; set; }

    public DateTime ExpirationDate { get; set; }

    public int? AuditCreateUser { get; set; }

    public DateTime? AuditCreateDate { get; set; }

    public int? AuditUpdateUser { get; set; }

    public DateTime? AuditUpdateDate { get; set; }

    public int? AuditDeleteUser { get; set; }

    public DateTime? AuditDeleteDate { get; set; }

    public int State { get; set; }

    public virtual Income IdIncomeNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
