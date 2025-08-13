using System;

namespace Roblox.Platform.Billing;

internal interface IPaymentProviderTypeEntity
{
	/// <summary>
	/// Gets the entity's ID.
	/// </summary>
	/// <value>The entity's ID.</value>
	byte Id { get; }

	string Value { get; set; }

	bool SupportsRecurringCharges { get; set; }

	DateTime Created { get; set; }

	DateTime Updated { get; set; }

	/// <summary>
	/// Persists any updates to the entity.
	/// </summary>
	void Update();

	/// <summary>
	/// Deletes the entity from persistence.
	/// </summary>
	void Delete();
}
