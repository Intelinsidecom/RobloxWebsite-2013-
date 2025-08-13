using System;

namespace Roblox.Captcha.Entities;

/// <summary>
/// Represents a record indicating that an actor has passed an action that's protected by Captcha.
/// </summary>
internal interface ISuccess
{
	byte ActionTypeId { get; set; }

	string Identifier { get; set; }

	DateTime TimeStamp { get; set; }

	/// <summary>
	/// Saves the <see cref="T:Roblox.Captcha.Entities.ISuccess" />.
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">Thrown if the <see cref="T:Roblox.Captcha.Entities.ISuccess" /> could not be saved in its current state.</exception>
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Thrown if the operation is not currently available.</exception>
	void Save();

	/// <summary>
	/// Deletes the <see cref="T:Roblox.Captcha.Entities.ISuccess" />.
	/// </summary>
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Thrown if the operation is not currently available.</exception>
	void Delete();
}
