using System;
using Roblox.Marketing;
using Roblox.Platform.Marketing.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Marketing;

public class ShowLowValueUserAdChecker
{
	private readonly ITakeoverEnabledProvider _TakeoverEnabledProvider;

	public ShowLowValueUserAdChecker()
	{
	}

	public ShowLowValueUserAdChecker(ITakeoverEnabledProvider takeoverEnabledProvider)
	{
		_TakeoverEnabledProvider = takeoverEnabledProvider;
	}

	/// <summary>
	/// Determines whether or not a user sees low value user ads on the home page.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="userCountryId">The country that the user is in.</param>
	/// <param name="isApp">Whether or not the user is in the app.</param>
	/// <returns>Whether or not a user sees low value user ads on the home page.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <see cref="!:user" /> is null.</exception>
	public bool UserSeesHomeLowValueUserAds(IUser user, int? userCountryId, bool isApp)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!IsHomeTakeoverSpecialEnabled(user, userCountryId, isApp))
		{
			return false;
		}
		if (!IsHomeSpecialLowValueTakeoverVisibleForAllUsers())
		{
			return UserIsPersistentLowValueUser(user);
		}
		return true;
	}

	/// <summary>
	/// Determines whether or not special takeovers are enabled on the home page for a user.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="userCountryId">The country that the user is in.</param>
	/// <param name="isApp">Whether or not the user is using the app.</param>
	/// <returns>Whether or not special takeovers are enabled on the home page for the user.</returns>
	protected virtual bool IsHomeTakeoverSpecialEnabled(IUser user, int? userCountryId, bool isApp)
	{
		return _TakeoverEnabledProvider.TakeoverEnabled(TakeoverType.MyHomeTakeoverSpecial.ID, user, isApp, userCountryId, null, null);
	}

	/// <summary>
	/// Determines whether home special low value takeover is visible for all users.
	/// </summary>
	/// <returns><c>true</c> if home special low value takeover visible for all users; otherwise, <c>false</c>.</returns>
	protected virtual bool IsHomeSpecialLowValueTakeoverVisibleForAllUsers()
	{
		return Settings.Default.IsHomeSpecialLowValueTakeoverVisibleForAllUsers;
	}

	/// <summary>
	/// Determines whether or not a user is a persistent low value user.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <returns>Whether or not the user is a persistent low value user.</returns>
	protected virtual bool UserIsPersistentLowValueUser(IUser user)
	{
		return PersistentLowValueUser.GetByUserID(user.Id) != null;
	}
}
