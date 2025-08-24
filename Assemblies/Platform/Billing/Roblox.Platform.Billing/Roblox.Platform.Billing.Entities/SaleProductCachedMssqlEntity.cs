using System;
using Roblox.Billing;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing.Entities;

internal class SaleProductCachedMssqlEntity : ISaleProductEntity
{
	public long Id { get; set; }

	public int SaleID { get; set; }

	public int ProductID { get; set; }

	public decimal ListPrice { get; set; }

	public decimal DiscountedPrice { get; set; }

	public long? RecipientAccountID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public decimal? RecurringPrice { get; set; }

	public byte? CurrencyTypeID { get; set; }

	public void Update()
	{
		SaleProduct cal = SaleProduct.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Attempted update on unpersisted entity");
		}
		cal.SaleID = SaleID;
		cal.ProductID = ProductID;
		cal.ListPrice = ListPrice;
		cal.DiscountedPrice = DiscountedPrice;
		cal.RecipientAccountID = RecipientAccountID;
		cal.Created = Created;
		cal.Updated = Updated;
		cal.RecurringPrice = RecurringPrice;
		cal.CurrencyTypeID = CurrencyTypeID;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		SaleProduct.Get(Id)?.Delete();
	}
}
