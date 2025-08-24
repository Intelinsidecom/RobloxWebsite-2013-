using Roblox.Billing;
using Roblox.Platform.Billing.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <summary>
///
/// </summary>
/// <seealso cref="T:Roblox.Platform.Billing.ISaleStatusTypeEntityFactory" />
internal class SaleStatusTypeEntityFactory : ISaleStatusTypeEntityFactory, IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	public BillingDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.SaleStatusTypeEntityFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	public SaleStatusTypeEntityFactory(BillingDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public ISaleStatusTypeEntity Get(byte id)
	{
		return CalToCachedMssql(Roblox.Billing.SaleStatusType.Get(id));
	}

	public ISaleStatusTypeEntity GetByValue(string value)
	{
		if (value == null)
		{
			throw new PlatformArgumentNullException("value");
		}
		return CalToCachedMssql(Roblox.Billing.SaleStatusType.Get(value));
	}

	private static ISaleStatusTypeEntity CalToCachedMssql(Roblox.Billing.SaleStatusType cal)
	{
		if (cal != null)
		{
			return new SaleStatusTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
