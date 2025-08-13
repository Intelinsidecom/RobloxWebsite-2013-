using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal class Sale : DomainObjectBase<BillingDomainFactories, int>, ISale, IDomainObject<BillingDomainFactories, int>, IDomainObject<BillingDomainFactories>, IDomainObjectIdentifier<int>, IEquatable<IDomainObject<BillingDomainFactories, int>>
{
	public SaleStatusType SaleStatusType { get; }

	public long? PurchaserAccountId { get; }

	public decimal ListPriceTotal { get; }

	public decimal DiscountedPriceTotal { get; }

	public decimal? RecurringPrice { get; }

	public DateTime? RenewalDate { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public byte? CurrencyTypeId { get; }

	internal Sale(BillingDomainFactories domainFactories, int id, SaleStatusType saleStatusType, long? purchaserAccountId, decimal listPriceTotal, decimal discountedPriceTotal, decimal? recurringPrice, DateTime? renewalDate, DateTime created, DateTime updated, byte? currencyTypeId)
		: base(domainFactories)
	{
		base.Id = id;
		SaleStatusType = saleStatusType;
		PurchaserAccountId = purchaserAccountId;
		ListPriceTotal = listPriceTotal;
		DiscountedPriceTotal = discountedPriceTotal;
		RecurringPrice = recurringPrice;
		RenewalDate = renewalDate;
		Created = created;
		Updated = updated;
		CurrencyTypeId = currencyTypeId;
	}

	public override bool Equals(IDomainObject<BillingDomainFactories, int> other)
	{
		if (other is ISale)
		{
			return base.Id.Equals(other.Id);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return 13 * 7 + base.Id.GetHashCode();
	}
}
