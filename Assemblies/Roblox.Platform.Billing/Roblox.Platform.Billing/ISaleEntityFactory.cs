using System;
using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal interface ISaleEntityFactory : IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Creates and persists an <see cref="T:Roblox.Platform.Billing.ISaleEntity" />.
	/// </summary>
	/// <param name="saleStatusTypeId">The sale status type ID.</param>
	/// <param name="purchaserAccountId">The purchaser account ID or null if not purchased by an account.</param>
	/// <param name="listPriceTotal">The list price total.</param>
	/// <param name="discountedPriceTotal">The discounted price total.</param>
	/// <param name="recurringPrice">The recurring price.</param>
	/// <param name="renewalDate">The renewal date.</param>
	/// <param name="platformTypeId">The platform type ID.</param>
	/// <param name="currencyTypeId">The currency type ID.</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.Billing.ISaleEntity" />.
	/// </returns>
	ISaleEntity Create(byte saleStatusTypeId, int? purchaserAccountId, decimal listPriceTotal, decimal discountedPriceTotal, decimal? recurringPrice, DateTime? renewalDate, byte platformTypeId, byte? currencyTypeId);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Billing.ISaleEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.ISaleEntity" /> with the given ID, or null if none exists.</returns>
	ISaleEntity Get(int id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Billing.ISaleEntity" />s by their purchaser account ID.
	/// </summary>
	/// <param name="purchaserAccountId">The account ID of the purchaser.</param>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Billing.ISaleEntity" />s.</returns>
	IEnumerable<ISaleEntity> GetByPurchaserAccountIdPaged(int? purchaserAccountId, int startRowIndex, int maxRows);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Billing.ISaleEntity" />s with the given purchaser account ID.
	/// </summary>
	/// <param name="purchaserAccountId">The account ID of the purchaser.</param>
	/// <returns>
	/// The total number of <see cref="T:Roblox.Platform.Billing.ISaleEntity" />s with the given purchaser account ID.
	/// </returns>
	int GetTotalByPurchaserAccountId(int? purchaserAccountId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Billing.ISaleEntity" />s by their sale status type ID and purchaser account ID.
	/// </summary>
	/// <param name="purchaserAccountId">The account ID of the purchaser.</param>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <param name="saleStatusTypeId">The ID of the sale status type.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is negative.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Billing.ISaleEntity" />s.</returns>
	IEnumerable<ISaleEntity> GetBySaleStatusTypeIdAndPurchaserAccountIdPaged(byte saleStatusTypeId, int? purchaserAccountId, int startRowIndex, int maxRows);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Billing.ISaleEntity" />s with the given sale status type ID and purchaser account ID.
	/// </summary>
	/// <param name="saleStatusTypeId">The sale status type ID.</param>
	/// <param name="purchaserAccountId">The account ID of the purchaser.</param>
	/// <returns>
	/// The total number of <see cref="T:Roblox.Platform.Billing.ISaleEntity" />s with the given sale status type ID and purchaser account ID.
	/// </returns>
	int GetTotalBySaleStatusTypeIdAndPurchaserAccountId(byte saleStatusTypeId, int? purchaserAccountId);

	/// <summary>
	/// Gets the IDs of any sales that are up for renewal.
	/// </summary>
	/// <returns>The IDs of any sales that are up for renewal.</returns>
	IEnumerable<int> GetIdsWhereUpForRenewal();
}
