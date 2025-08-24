using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal interface ISaleStatusTypeEntityFactory : IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Billing.ISaleStatusTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.ISaleStatusTypeEntity" /> with the given ID, or null if none exists.</returns>
	ISaleStatusTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Billing.ISaleStatusTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.Billing.ISaleStatusTypeEntity" /> with the given value, or null if none exists.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="value" /></exception>
	ISaleStatusTypeEntity GetByValue(string value);
}
