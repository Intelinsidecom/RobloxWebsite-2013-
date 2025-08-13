using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public interface ISale : IDomainObject<BillingDomainFactories, int>, IDomainObject<BillingDomainFactories>, IDomainObjectIdentifier<int>, IEquatable<IDomainObject<BillingDomainFactories, int>>
{
	SaleStatusType SaleStatusType { get; }

	long? PurchaserAccountId { get; }

	decimal ListPriceTotal { get; }

	decimal DiscountedPriceTotal { get; }

	decimal? RecurringPrice { get; }

	DateTime? RenewalDate { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	byte? CurrencyTypeId { get; }
}
