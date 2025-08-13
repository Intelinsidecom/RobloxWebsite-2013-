namespace Roblox.Platform.Authentication;

/// <summary>
/// Provides a common interface for accessing data regarding an <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" />.
/// </summary>
internal interface IFacebookAccountDataAccessor
{
	/// <summary>
	/// Saves an <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" />.
	/// </summary>
	/// <param name="facebookAccount">The <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> to save.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="facebookAccount" /> is null.</exception>
	void Save(IFacebookAccount facebookAccount);

	/// <summary>
	/// Invalidates an <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" />.
	/// </summary>
	/// <param name="facebookAccount">The <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> to invalidate.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="facebookAccount" /> is null.</exception>
	void Invalidate(IFacebookAccount facebookAccount);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> by looking up its <paramref name="id" />.
	/// </summary>
	/// <param name="id">The id to look up.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> for this <paramref name="id" />, or null if not found.</returns>
	IFacebookAccount Get(int id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> by looking up its <paramref name="accountId" />.
	/// </summary>
	/// <param name="accountId">The account id to look up.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> for this <paramref name="accountId" />, or null if not found.</returns>
	IFacebookAccount GetByAccountId(long accountId);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> by looking up its <paramref name="facebookId" />.
	/// </summary>
	/// <param name="facebookId">The Facebook id to look up.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.IFacebookAccount" /> for this <paramref name="facebookId" />, or null if not found.</returns>
	IFacebookAccount GetByFacebookId(ulong facebookId);

	/// <summary>
	/// Deletes the entities associated with the given account. Intended to be used by the Right to be Forgotten feature.
	/// </summary>
	/// <param name="accountId">The roblox accountId whose associated facebook accounts we want to forget</param>
	void Forget(long accountId);
}
