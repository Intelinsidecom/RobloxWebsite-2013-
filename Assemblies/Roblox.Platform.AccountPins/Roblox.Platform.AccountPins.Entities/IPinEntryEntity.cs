using System;

namespace Roblox.Platform.AccountPins.Entities;

/// <summary>
/// An interface to hold a PinEntry entity.
/// </summary>
public interface IPinEntryEntity
{
	/// <summary>
	/// Gets or sets the account pin hash identifier.
	/// </summary>
	/// <value>The pin hash identifier.</value>
	long PinHashId { get; set; }

	/// <summary>
	/// Gets or sets the account identifier.
	/// </summary>
	/// <value>
	/// The account identifier.
	/// </value>
	long AccountId { get; set; }

	/// <summary>
	/// Gets or sets the session string.
	/// </summary>
	/// <value>
	/// The session string.
	/// </value>
	string SessionString { get; set; }

	/// <summary>
	/// Gets the created datetime.
	/// </summary>
	/// <value>
	/// The created datetime.
	/// </value>
	DateTime Created { get; }

	/// <summary>
	/// Deletes this instance of <see cref="T:Roblox.Platform.AccountPins.Entities.IPinEntryEntity" />.
	/// </summary>
	void Delete();
}
