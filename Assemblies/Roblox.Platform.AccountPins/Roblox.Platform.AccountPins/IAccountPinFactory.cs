using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// Load and Create PINs for an account.
/// </summary>
public interface IAccountPinFactory
{
	/// <summary>
	/// Gets whether the account has a pin enabled or not. Checks for the config settings before looking up the database for a pin hash.
	/// This does not take into consideration whether the flood checks have been passed.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>
	/// True if the account has a pin enabled, false otherwise.
	/// </returns>
	IAccountPin GetValidAccountPin(IUser user);

	/// <summary>
	/// Creates the <see cref="T:Roblox.Platform.AccountPins.IAccountPin" /> for the specified user.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="pin">The pin.</param>
	/// <param name="actorUserIdentity">The identifier of the user performing the action.</param>
	/// <returns>
	/// A new <see cref="T:Roblox.Platform.AccountPins.IAccountPin" />.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the user is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the user does not have account id
	/// or
	/// pin is in wrong format.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformUnverifiedEmailAddressException">Thrown if the passed in user does not have a verified email.</exception>
	IAccountPin Create(IUser user, string pin, IUserIdentifier actorUserIdentity);
}
