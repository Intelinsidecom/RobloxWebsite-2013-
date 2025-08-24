using Roblox.Billing;
using Roblox.Platform.Billing.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <summary>
///
/// </summary>
/// <seealso cref="T:Roblox.Platform.Billing.IPaymentStatusTypeEntityFactory" />
internal class PaymentStatusTypeEntityFactory : IPaymentStatusTypeEntityFactory, IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	public BillingDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.PaymentStatusTypeEntityFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	public PaymentStatusTypeEntityFactory(BillingDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IPaymentStatusTypeEntity Get(byte id)
	{
		return CalToCachedMssql(Roblox.Billing.PaymentStatusType.Get(id));
	}

	public IPaymentStatusTypeEntity GetByValue(string value)
	{
		if (value == null)
		{
			throw new PlatformArgumentNullException("value");
		}
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		return CalToCachedMssql(Roblox.Billing.PaymentStatusType.Get(value));
	}

	private static IPaymentStatusTypeEntity CalToCachedMssql(Roblox.Billing.PaymentStatusType cal)
	{
		if (cal != null)
		{
			return new PaymentStatusTypeCachedMssqlEntity
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
