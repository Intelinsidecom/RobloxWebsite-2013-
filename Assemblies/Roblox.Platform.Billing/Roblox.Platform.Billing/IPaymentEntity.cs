using System;

namespace Roblox.Platform.Billing;

internal interface IPaymentEntity
{
	/// <summary>
	/// Gets the entity's ID.
	/// </summary>
	/// <value>The entity's ID.</value>
	long Id { get; }

	int SaleID { get; set; }

	byte PaymentProviderTypeID { get; set; }

	byte PaymentStatusTypeID { get; set; }

	DateTime PaymentDate { get; set; }

	decimal Amount { get; set; }

	DateTime Created { get; set; }

	DateTime Updated { get; set; }

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
