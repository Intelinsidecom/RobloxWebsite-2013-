using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <summary>
///
/// </summary>
/// <seealso cref="T:Roblox.Platform.Billing.ISaleFactory" />
public class SaleFactory : ISaleFactory, IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	public BillingDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.SaleFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// <paramref name="domainFactories" />
	/// </exception>
	public SaleFactory(BillingDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public ISale Get(int id)
	{
		ISaleEntity saleEntity = DomainFactories.SaleEntityFactory.Get(id);
		return EntityToPlatformSale(saleEntity);
	}

	public IEnumerable<int> GetSaleIdsWhereUpForRenewal()
	{
		return DomainFactories.SaleEntityFactory.GetIdsWhereUpForRenewal();
	}

	private ISale EntityToPlatformSale(ISaleEntity saleEntity)
	{
		if (saleEntity == null)
		{
			return null;
		}
		SaleStatusType? saleStatusType = new SaleStatusTypeConverter(DomainFactories).GetTypeById(saleEntity.SaleStatusTypeId);
		if (!saleStatusType.HasValue)
		{
			throw new PlatformDataIntegrityException($"Sale entity with ID {saleEntity.Id} has SaleStatusTypeID {saleEntity.SaleStatusTypeId} with no corresponding SaleStatusType");
		}
		return new Sale(DomainFactories, saleEntity.Id, saleStatusType.Value, saleEntity.PurchaserAccountId, saleEntity.ListPriceTotal, saleEntity.DiscountedPriceTotal, saleEntity.RecurringPrice, saleEntity.RenewalDate, saleEntity.Created, saleEntity.Updated, saleEntity.CurrencyTypeId);
	}
}
