using System;
using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal interface IPaymentEntityFactory : IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Billing.IPaymentEntity" /> with the given properties.
	/// </summary>
	/// <param name="saleId">The sale ID.</param>
	/// <param name="paymentProviderTypeId">The payment provider type ID.</param>
	/// <param name="paymentStatusTypeId">The payment status type ID.</param>
	/// <param name="paymentDate">The payment date.</param>
	/// <param name="amount">The payment amount.</param>
	/// <param name="currencyTypeId">The currency type ID.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.Billing.IPaymentEntity" />.</returns>
	IPaymentEntity Create(int saleId, byte paymentProviderTypeId, byte paymentStatusTypeId, DateTime paymentDate, decimal amount, byte? currencyTypeId);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Billing.IPaymentEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.IPaymentEntity" /> with the given ID, or null if none exists.</returns>
	IPaymentEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Billing.IPaymentEntity" />s by their sale ID.
	/// </summary>
	/// <param name="saleId">The sale ID.</param>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is negative.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Billing.IPaymentEntity" />s.</returns>
	IEnumerable<IPaymentEntity> GetBySaleIdPaged(int saleId, long startRowIndex, long maxRows);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Billing.IPaymentEntity" />s with the given sale ID.
	/// </summary>
	/// <param name="saleId">The sale ID.</param>
	/// <returns>
	/// The total number of <see cref="T:Roblox.Platform.Billing.IPaymentEntity" />s with the given sale ID.
	/// </returns>
	long GetTotalBySaleId(int saleId);
}
