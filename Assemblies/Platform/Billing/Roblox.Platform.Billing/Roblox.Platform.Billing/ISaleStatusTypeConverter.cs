using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public interface ISaleStatusTypeConverter : IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Gets the ID of a <see cref="T:Roblox.Platform.Billing.SaleStatusType" />.
	/// </summary>
	/// <param name="saleStatusType">The <see cref="T:Roblox.Platform.Billing.SaleStatusType" />.</param>
	/// <returns>The ID of the <see cref="T:Roblox.Platform.Billing.SaleStatusType" />.</returns>
	byte GetIdByType(SaleStatusType saleStatusType);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Billing.SaleStatusType" /> with the given ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.SaleStatusType" /> with the given ID, or null if none exists.</returns>
	SaleStatusType? GetTypeById(byte id);
}
