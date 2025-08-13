using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Platform.Billing.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <summary>
///
/// </summary>
/// <seealso cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntityFactory" />
internal class PaymentProviderTypeEntityFactory : IPaymentProviderTypeEntityFactory, IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	public BillingDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.PaymentProviderTypeEntityFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	public PaymentProviderTypeEntityFactory(BillingDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IPaymentProviderTypeEntity Get(byte id)
	{
		return CalToCachedMssql(Roblox.Billing.PaymentProviderType.Get(id));
	}

	public IEnumerable<IPaymentProviderTypeEntity> GetAllPaged(byte startRowIndex, byte maxRows)
	{
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "maxRows"));
		}
		return Roblox.Billing.PaymentProviderType.GetPaymentProviderTypesPaged(startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public byte GetTotal()
	{
		return Roblox.Billing.PaymentProviderType.GetTotalNumberOfPaymentProviderTypes();
	}

	public IPaymentProviderTypeEntity GetByValue(string value)
	{
		if (value == null)
		{
			throw new PlatformArgumentNullException("value");
		}
		return CalToCachedMssql(Roblox.Billing.PaymentProviderType.Get(value));
	}

	private static IPaymentProviderTypeEntity CalToCachedMssql(Roblox.Billing.PaymentProviderType cal)
	{
		if (cal != null)
		{
			return new PaymentProviderTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				SupportsRecurringCharges = cal.SupportsRecurringCharges,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
