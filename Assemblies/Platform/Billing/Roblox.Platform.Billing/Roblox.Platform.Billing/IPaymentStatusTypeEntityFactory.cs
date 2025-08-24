using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal interface IPaymentStatusTypeEntityFactory : IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Billing.IPaymentStatusTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.IPaymentStatusTypeEntity" /> with the given ID, or null if none exists.</returns>
	IPaymentStatusTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Billing.IPaymentStatusTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.Billing.IPaymentStatusTypeEntity" /> with the given , or null if none exists.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="value" /></exception>
	IPaymentStatusTypeEntity GetByValue(string value);
}
