using System;

namespace Roblox.Platform.Billing;

internal interface ISaleEntity
{
	/// <summary>
	/// Gets the entity's ID.
	/// </summary>
	/// <value>The entity's ID.</value>
	int Id { get; }

	byte SaleStatusTypeId { get; set; }

	long? PurchaserAccountId { get; set; }

	decimal ListPriceTotal { get; set; }

	decimal DiscountedPriceTotal { get; set; }

	decimal? RecurringPrice { get; set; }

	DateTime? RenewalDate { get; set; }

	DateTime Created { get; set; }

	DateTime Updated { get; set; }

	byte? CurrencyTypeId { get; set; }

	/// <summary>
	/// Persists any updates to the entity.
	/// </summary>
	void Update();

	/// <summary>
	/// Deletes the entity from persistence.
	/// </summary>
	void Delete();
}
