using Roblox.Platform.Membership;

namespace Roblox.Platform.Marketing;

/// <summary>
/// Provides a common interface for checking whether or not a takeover is enabled.
/// </summary>
public interface ITakeoverEnabledProvider
{
	/// <summary>
	/// Determines whether or not a takeover of the given takeover type is enabled
	/// for the given user in the given country.
	/// </summary>
	/// <param name="takeoverTypeId">The ID of the takeover type.</param>
	/// <param name="user">The user that the takeover would be presented to.</param>
	/// <param name="isApp">Whether or not this is the app.</param>
	/// <param name="userCountryId">The ID of the user's country.</param>
	/// <param name="contentType">The content type to check for.</param>
	/// <param name="contentItemTargetId">The content Id to check for.</param>
	/// <returns>Whether or not a takeover of the given takeover type is enabled for
	/// the given user in the given country.</returns>
	bool TakeoverEnabled(byte takeoverTypeId, IUser user, bool isApp, int? userCountryId, ContentItemType? contentType, long? contentItemTargetId);
}
