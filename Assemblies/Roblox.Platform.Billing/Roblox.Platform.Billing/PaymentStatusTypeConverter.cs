using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public class PaymentStatusTypeConverter : DomainObjectBase<BillingDomainFactories>, IPaymentStatusTypeConverter, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.SaleStatusTypeConverter" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	public PaymentStatusTypeConverter(BillingDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	public byte GetIdByType(PaymentStatusType paymentStatusType)
	{
		return (base.DomainFactories.SaleStatusTypeEntityFactory.GetByValue(paymentStatusType.ToString()) ?? throw new PlatformDataIntegrityException($"Attempted lookup of unpersisted PaymentStatusType '{paymentStatusType}'")).Id;
	}

	public PaymentStatusType? GetTypeById(byte id)
	{
		ISaleStatusTypeEntity cal = base.DomainFactories.SaleStatusTypeEntityFactory.Get(id);
		if (cal == null)
		{
			return null;
		}
		return (PaymentStatusType)Enum.Parse(typeof(PaymentStatusType), cal.Value);
	}
}
