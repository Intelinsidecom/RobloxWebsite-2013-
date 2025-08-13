using System;
using Roblox.Billing;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing.Entities;

internal class SaleCachedMssqlEntity : ISaleEntity
{
	public int Id { get; set; }

	public byte SaleStatusTypeId { get; set; }

	public long? PurchaserAccountId { get; set; }

	public decimal ListPriceTotal { get; set; }

	public decimal DiscountedPriceTotal { get; set; }

	public decimal? RecurringPrice { get; set; }

	public DateTime? RenewalDate { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte? CurrencyTypeId { get; set; }

	public void Update()
	{
		Roblox.Billing.Sale cal = Roblox.Billing.Sale.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Attempted update on unpersisted entity");
		}
		cal.SaleStatusTypeID = SaleStatusTypeId;
		cal.PurchaserAccountID = PurchaserAccountId;
		cal.ListPriceTotal = ListPriceTotal;
		cal.DiscountedPriceTotal = DiscountedPriceTotal;
		cal.RecurringPrice = RecurringPrice;
		cal.RenewalDate = RenewalDate;
		cal.CurrencyTypeID = CurrencyTypeId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		Roblox.Billing.Sale.Get(Id)?.Delete();
	}
}
