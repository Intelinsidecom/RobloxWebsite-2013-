namespace Roblox.Platform.Badges;

/// <summary>
/// Filter Badge text for the given Author.
/// In particular, we're filtering the name and description as if they were in the same "room".
/// </summary>
public interface IBadgeTextFilter
{
	/// <summary>
	/// Filter the given name and description as if they were part of the same conversation by the same Author.
	/// </summary>
	/// <param name="request">The <see cref="!:IAssetTextFilterRequest" /> that wraps the request.</param>
	/// <returns>a <see cref="!:IAssetTextFilterResult" /> containing the filtered name and description.</returns>
	/// <exception cref="!:PlatformArgumentNullException">In the case of bad input data</exception>
	/// <exception cref="!:PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="!:PlatformAssetTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	BadgeTextFilterResult FilterBadgeText(BadgeTextFilterRequest request);
}
