using Roblox.Platform.Membership;

namespace Roblox.Platform.XboxLive;

/// <summary>
/// A class for Xbox soothsayer verification
/// </summary>
/// <remarks>
/// This exists so we can test Xbox specific features on a select set
/// of users (like the Microsoft Xbox certification team) before turning the
/// feature on for other users.
/// This is separate from the official Soothsayer roleset.
/// </remarks>
public interface IXboxSoothsayerVerifier
{
	/// <summary>
	/// Determines whether or not an <see cref="T:Roblox.Platform.Membership.IUser" /> is an Xbox soothsayer
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns><c>true</c> if <paramref name="user" /> is an Xbox soothsayer.</returns>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	bool IsSoothsayer(IUser user);
}
