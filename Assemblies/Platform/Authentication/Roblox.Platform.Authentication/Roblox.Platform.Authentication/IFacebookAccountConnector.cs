using System;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Provides a common interface for connecting accounts to Facebook.
/// </summary>
public interface IFacebookAccountConnector
{
	/// <summary>
	/// The event to fire when a Facebook account is disconnected from a Roblox account
	/// </summary>
	event Action<long> OnFacebookAccountDisconnected;

	/// <summary>
	/// Adds a connection for the given <paramref name="accountId" /> to it's respective <paramref name="facebookId" />.
	/// </summary>
	/// <remarks>
	/// This function will return true if the connection already exists.  You do not have to check this prior to execution.
	/// It will also attempt to remove the any existing connection for <paramref name="facebookId" /> 
	/// </remarks>
	/// <param name="accountId">The account id to link.</param>
	/// <param name="facebookId">The Facebook id to link.</param>
	/// <returns>True if successfully linked, false otherwise.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if this account is already linked to a different Facebook id</exception>
	bool Connect(long accountId, ulong facebookId);

	/// <summary>
	/// Disconnects an <paramref name="accountId" /> from any Facebook id it may be connected to.
	/// </summary>
	/// <remarks>
	/// This will fail in the event that Facebook is a user's only means of authentication and cannot be disconnected.  In the event
	/// that the account is not currently linked to a Facebook, this will return true.
	/// </remarks>
	/// <param name="accountId">The account id to disconnect.</param>
	/// <param name="force">If set to true, this will disconnect the account(s) EVEN IF the account has no other authentication method. Intended to be used with the Right to be Forgotten feature.</param>
	/// <returns>False if the given <paramref name="accountId" /> is still linked to a Facebook, true otherwise.</returns>
	bool Disconnect(long accountId, bool force = false);

	/// <summary>
	/// For the given <paramref name="accountId" />, get the connected <see cref="T:Roblox.Platform.Authentication.IFacebookAccountIdentifier" />.
	/// </summary>
	/// <param name="accountId">Roblox AccountId</param>
	/// <returns>An <see cref="T:Roblox.Platform.Authentication.IFacebookAccountIdentifier" /> if connected, null otherwise.</returns>
	IFacebookAccountIdentifier GetConnectedFacebookAccountIdentifier(long accountId);

	/// <summary>
	/// For the given <paramref name="facebookId" />, get the connected <see cref="T:Roblox.Platform.Authentication.IFacebookAccountIdentifier" />.
	/// </summary>
	/// <param name="facebookId">Facebook Id</param>
	/// <returns>An <see cref="T:Roblox.Platform.Authentication.IFacebookAccountIdentifier" /> if connected, null otherwise.</returns>
	IFacebookAccountIdentifier GetConnectedFacebookAccountIdentifier(ulong facebookId);

	/// <summary>
	/// For the given <paramref name="accountId" />, get the connected <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" />.
	/// </summary>
	/// <param name="accountId">Roblox AccountId</param>
	/// <returns>An <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> if connected, null otherwise.</returns>
	IFacebookAccount GetConnectedFacebookAccount(long accountId);

	/// <summary>
	/// This method DELETES the associated entities, EVEN IF there is no other authentication method for the account. Intended to be used only with the Right to be Forgotten feature.
	/// </summary>
	/// <param name="accountId">The account id to forget.</param>
	void Forget(long accountId);
}
