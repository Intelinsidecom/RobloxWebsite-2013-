using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Platform.Billing.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <summary>
///
/// </summary>
/// <seealso cref="T:Roblox.Platform.Billing.ISaleEntityFactory" />
internal class SaleEntityFactory : ISaleEntityFactory, IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	public BillingDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.SaleEntityFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	public SaleEntityFactory(BillingDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public ISaleEntity Get(int id)
	{
		return CalToCachedMssql(Roblox.Billing.Sale.Get(id));
	}

	public IEnumerable<ISaleEntity> GetByPurchaserAccountIdPaged(int? purchaserAccountId, int startRowIndex, int maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return Roblox.Billing.Sale.GetSalesByPurchaserAccountIDPaged(purchaserAccountId, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public int GetTotalByPurchaserAccountId(int? purchaserAccountId)
	{
		return Roblox.Billing.Sale.GetTotalNumberOfSalesByPurchaseAccountID(purchaserAccountId);
	}

	public IEnumerable<ISaleEntity> GetBySaleStatusTypeIdAndPurchaserAccountIdPaged(byte saleStatusTypeId, int? purchaserAccountId, int startRowIndex, int maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return Roblox.Billing.Sale.GetSalesByPurchaserAndStatus_Paged(purchaserAccountId, saleStatusTypeId, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public int GetTotalBySaleStatusTypeIdAndPurchaserAccountId(byte saleStatusTypeId, int? purchaserAccountId)
	{
		return Roblox.Billing.Sale.GetTotalNumberOfSalesBySaleStatusTypeIdAndPurchaserAccountId(saleStatusTypeId, purchaserAccountId);
	}

	public IEnumerable<int> GetIdsWhereUpForRenewal()
	{
		return Roblox.Billing.Sale.GetSaleIDsUpForRenewal();
	}

	public ISaleEntity Create(byte saleStatusTypeId, int? purchaserAccountId, decimal listPriceTotal, decimal discountedPriceTotal, decimal? recurringPrice, DateTime? renewalDate, byte platformTypeId, byte? currencyTypeId)
	{
		Roblox.Billing.Sale sale = Roblox.Billing.Sale.CreateNew(saleStatusTypeId, purchaserAccountId, listPriceTotal, discountedPriceTotal, recurringPrice, renewalDate, platformTypeId, currencyTypeId);
		sale.Save();
		return CalToCachedMssql(sale);
	}

	private static ISaleEntity CalToCachedMssql(Roblox.Billing.Sale cal)
	{
		if (cal != null)
		{
			return new SaleCachedMssqlEntity
			{
				Id = cal.ID,
				SaleStatusTypeId = cal.SaleStatusTypeID,
				PurchaserAccountId = cal.PurchaserAccountID,
				ListPriceTotal = cal.ListPriceTotal,
				DiscountedPriceTotal = cal.DiscountedPriceTotal,
				RecurringPrice = cal.RecurringPrice,
				RenewalDate = cal.RenewalDate,
				Created = cal.Created,
				Updated = cal.Updated,
				CurrencyTypeId = cal.CurrencyTypeID
			};
		}
		return null;
	}
}
