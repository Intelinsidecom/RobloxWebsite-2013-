using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Platform.Billing.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <summary>
///
/// </summary>
/// <seealso cref="T:Roblox.Platform.Billing.ISaleProductEntityFactory" />
internal class SaleProductEntityFactory : ISaleProductEntityFactory, IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	public BillingDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.SaleProductEntityFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	public SaleProductEntityFactory(BillingDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public ISaleProductEntity Get(long id)
	{
		return CalToCachedMssql(SaleProduct.Get(id));
	}

	public IEnumerable<ISaleProductEntity> GetBySaleIdPaged(int saleId, long startRowIndex, long maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return SaleProduct.GetSaleProductsBySaleIDPaged(saleId, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public long GetTotalBySaleId(int saleId)
	{
		return SaleProduct.GetTotalNumberOfSaleProductsBySaleID(saleId);
	}

	public ISaleProductEntity Create(int saleid, int productid, decimal listprice, decimal discountedprice, int? recipientaccountid, decimal? recurringprice, byte? currencyTypeId)
	{
		SaleProduct saleProduct = new SaleProduct();
		saleProduct.DiscountedPrice = discountedprice;
		saleProduct.ListPrice = listprice;
		saleProduct.ProductID = productid;
		saleProduct.CurrencyTypeID = currencyTypeId;
		saleProduct.RecipientAccountID = recipientaccountid;
		saleProduct.RecurringPrice = recurringprice;
		saleProduct.SaleID = saleid;
		saleProduct.Save();
		return CalToCachedMssql(saleProduct);
	}

	private static ISaleProductEntity CalToCachedMssql(SaleProduct cal)
	{
		if (cal != null)
		{
			return new SaleProductCachedMssqlEntity
			{
				Id = cal.ID,
				SaleID = cal.SaleID,
				ProductID = cal.ProductID,
				ListPrice = cal.ListPrice,
				DiscountedPrice = cal.DiscountedPrice,
				RecipientAccountID = cal.RecipientAccountID,
				Created = cal.Created,
				Updated = cal.Updated,
				RecurringPrice = cal.RecurringPrice,
				CurrencyTypeID = cal.CurrencyTypeID
			};
		}
		return null;
	}
}
