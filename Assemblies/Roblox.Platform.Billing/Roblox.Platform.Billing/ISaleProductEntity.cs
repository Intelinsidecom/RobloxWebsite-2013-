using System;

namespace Roblox.Platform.Billing;

internal interface ISaleProductEntity
{
	/// <summary>
	/// Gets the entity's ID.
	/// </summary>
	/// <value>The entity's ID.</value>
	long Id { get; }

	int SaleID { get; set; }

	int ProductID { get; set; }

	decimal ListPrice { get; set; }

	decimal DiscountedPrice { get; set; }

	long? RecipientAccountID { get; set; }

	DateTime Created { get; set; }

	DateTime Updated { get; set; }

	decimal? RecurringPrice { get; set; }

	byte? CurrencyTypeID { get; set; }

	/// <summary>
	/// Persists any updates to the entity.
	/// </summary>
	void Update();

	/// <summary>
	/// Deletes the entity from persistence.
	/// </summary>
	void Delete();
}
