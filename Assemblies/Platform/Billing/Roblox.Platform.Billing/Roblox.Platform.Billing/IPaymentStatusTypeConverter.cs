using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public interface IPaymentStatusTypeConverter : IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Gets the ID of a <see cref="T:Roblox.Platform.Billing.PaymentStatusType" />.
	/// </summary>
	/// <param name="paymentStatusType">The <see cref="T:Roblox.Platform.Billing.PaymentStatusType" />.</param>
	/// <returns>The ID of the <see cref="T:Roblox.Platform.Billing.PaymentStatusType" />.</returns>
	byte GetIdByType(PaymentStatusType paymentStatusType);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Billing.PaymentStatusType" /> with the given ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.PaymentStatusType" /> with the given ID, or null if none exists.</returns>
	PaymentStatusType? GetTypeById(byte id);
}
