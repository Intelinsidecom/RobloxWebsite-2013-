using System.Collections.Specialized;
using System.Threading.Tasks;
using Roblox.Platform.Membership;

namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for a client that makes requests to Gigya's REST API
/// </summary>
public interface IGigyaClient
{
	/// <summary>
	/// Logs the user out of Gigya in a background thread.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> that needs to be logged out.</param>
	Task<bool> LogoutInBackground(IUser user);

	/// <summary>
	/// Logs the user out of Gigya.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> that needs to be logged out.</param>
	/// <returns></returns>
	bool Logout(IUser user);

	/// <summary>
	/// Notifies Gigya that a user has logged in and validates the signature on Gigya's response.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> we want to log in to Gigya.</param>
	/// <param name="currentUid">The current UID as determined by Gigya's JavaScript API. If this UID does not match the expected UID, we log currentUid out of Gigya.</param>
	/// <param name="isNewUser">If the <see cref="T:Roblox.Platform.Membership.IUser" /> that is passed in is a new Gigya user or an existing Gigya user</param>
	/// <returns>An <see cref="T:Roblox.Gigya.IGigyaNotifyLoginResponse" /> that contains the response from Gigya.</returns>
	/// <remarks>This method must be called synchronously and the cookie described in the response must be set client-side.</remarks>
	/// <remarks>This method does not validate the UID signature in Gigya's response unless IsGigyaNotifyLoginResponseValidationEnabled is set true.</remarks>
	IGigyaNotifyLoginResponse NotifyLogin(IUser user, string currentUid, bool isNewUser);

	/// <summary>
	/// We call this when we register a new user through a social site using Gigya. It replaces Gigya's auto-generated random ID with our own generated one.
	/// </summary>
	/// <param name="user">The new <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="temporaryGigyaUid">The temporary ID assigned by Gigya.</param>
	/// <returns>A <see cref="T:Roblox.Gigya.IGigyaNotifyRegistrationResponse" /> containing the response from Gigya.</returns>
	IGigyaNotifyRegistrationResponse NotifyRegistration(IUser user, string temporaryGigyaUid);

	/// <summary>
	/// Retrieves a user's provider information, e.g. profileURL and identity. Does not retrieve session info; use GetSessionInfo for that./&gt; 
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> for whom to get information.</param>
	/// <returns>An <see cref="T:Roblox.Gigya.IGigyaUserInfoResponse" /> containing the respones from Gigya.</returns>
	/// <remarks>This method does not validate the UID signature in Gigya's response unless IsGigyaGetUserInfoResponseValidationEnabled is set true.</remarks>
	IGigyaUserInfoResponse GetUserInfo(IUser user);

	/// <summary>
	/// Retrieves a user's provider information, e.g. profileURL and identity. Does not retrieve session info; use GetSessionInfo for that./&gt; 
	/// </summary>
	/// <param name="gigyaUID">A user's uid for whom to get information.</param>
	/// <returns>An <see cref="T:Roblox.Gigya.IGigyaUserInfoResponse" /> containing the respones from Gigya.</returns>
	/// <remarks>This method does not validate the UID signature in Gigya's response unless IsGigyaGetUserInfoResponseValidationEnabled is set true.</remarks>
	IGigyaUserInfoResponse GetUserInfo(string gigyaUID);

	/// <summary>
	/// Retrieves an <see cref="T:Roblox.Platform.Membership.IUser" />'s session data for a given social network, including the authToken.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> for whom to get session info.</param>
	/// <param name="provider">The <see cref="T:Roblox.Gigya.GigyaProviderType" /> for which to get session info.</param>
	/// <returns>An <see cref="T:Roblox.Gigya.IGigyaSessionInfoResponse" /> containing the response from Gigya.</returns>
	IGigyaSessionInfoResponse GetSessionInfo(IUser user, GigyaProviderType provider);

	/// <summary>
	/// Takes a list of data from <paramref name="nameValueCollection" /> and constructs an <see cref="T:Roblox.Gigya.IGigyaUser" />.
	/// </summary>
	/// <param name="nameValueCollection">A collection that contains Gigya data from a Gigya Login call.</param>
	/// <returns>The <see cref="T:Roblox.Gigya.IGigyaUser" />.</returns>
	IGigyaUser HandlePostLoginResponse(NameValueCollection nameValueCollection);

	/// <summary>
	/// Removes a user's Gigya connection to a given provider.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose connection is to be removed.</param>
	/// <param name="provider">The <see cref="T:Roblox.Gigya.GigyaProviderType" /> for the social network.</param>
	void RemoveConnection(IUser user, GigyaProviderType provider);

	/// <summary>
	/// Removes a user's account from the Gigya database, used by right to be forgotten feature.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose account is to be removed.</param>
	void DeleteAccount(IUser user);
}
