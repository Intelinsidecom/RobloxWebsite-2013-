using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// An interface for Pin Hasher.
/// </summary>
internal interface IPinHasher
{
	/// <summary>
	/// Hashes the user pin.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="pin">The pin.</param>
	/// <returns></returns>
	string HashUserPin(IUser user, string pin);

	/// <summary>
	/// Checks if the given input matches
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="inputPin">The input pin.</param>
	/// <param name="correctHash">The correct hash.</param>
	/// <returns>True if the pin is correct, false otherwise.</returns>
	bool IsValidateUserPin(IUser user, string inputPin, string correctHash);
}
