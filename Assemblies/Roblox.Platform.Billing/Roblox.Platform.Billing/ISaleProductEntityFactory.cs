using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal interface ISaleProductEntityFactory : IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Creates and persists an <see cref="T:Roblox.Platform.Billing.ISaleProductEntity" />.
	/// </summary>
	/// <param name="saleId">The sale ID.</param>
	/// <param name="productId">The product ID.</param>
	/// <param name="listPrice">The list price.</param>
	/// <param name="discountedPrice">The discounted price.</param>
	/// <param name="recipientAccountId">The recipient account ID.</param>
	/// <param name="recurringPrice">The recurring price.</param>
	/// <param name="currencyTypeId">The currency type ID.</param>
	/// <returns>
	/// The created <see cref="T:Roblox.Platform.Billing.ISaleProductEntity" />.
	/// </returns>
	ISaleProductEntity Create(int saleId, int productId, decimal listPrice, decimal discountedPrice, int? recipientAccountId, decimal? recurringPrice, byte? currencyTypeId);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Billing.ISaleProductEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.ISaleProductEntity" /> with the given ID, or null if none exists.</returns>
	ISaleProductEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Billing.ISaleProductEntity" />s by their sale ID.
	/// </summary>
	/// <param name="saleId">The sale ID.</param>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <returns>
	/// The page of <see cref="T:Roblox.Platform.Billing.ISaleProductEntity" />s.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is less than 1.</exception>
	IEnumerable<ISaleProductEntity> GetBySaleIdPaged(int saleId, long startRowIndex, long maxRows);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Billing.ISaleProductEntity" />s with the given sale ID.
	/// </summary>
	/// <param name="saleId">The sale ID.</param>
	/// <returns>
	/// The total number of <see cref="T:Roblox.Platform.Billing.ISaleProductEntity" />s with the given sale ID.
	/// </returns>
	long GetTotalBySaleId(int saleId);
}
