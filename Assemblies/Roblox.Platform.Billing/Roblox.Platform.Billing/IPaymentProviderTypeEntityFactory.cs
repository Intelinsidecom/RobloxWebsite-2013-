using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal interface IPaymentProviderTypeEntityFactory : IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntity" /> with the given ID, or null if none exists.</returns>
	IPaymentProviderTypeEntity Get(byte id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntity" />s.
	/// </summary>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntity" />s.</returns>
	IEnumerable<IPaymentProviderTypeEntity> GetAllPaged(byte startRowIndex, byte maxRows);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntity" />s.
	/// </summary>
	/// <returns>The total number of <see cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntity" />s.</returns>
	byte GetTotal();

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.Billing.IPaymentProviderTypeEntity" /> with the given value, or null if none exists.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///   <paramref name="value" />
	/// </exception>
	IPaymentProviderTypeEntity GetByValue(string value);
}
