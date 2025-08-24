namespace Roblox.Platform.Assets;

/// <summary>
/// Filter Asset text for the given Author.
/// In particular, we're filtering the name and description as if they were in the same "room".
/// </summary>
public interface IAssetTextFilter
{
	/// <summary>
	/// Filter the given name and description as if they were part of the same conversation by the same Author.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Platform.Assets.IAssetTextFilterRequest" /> that wraps the request.</param>
	/// <returns>a <see cref="T:Roblox.Platform.Assets.IAssetTextFilterResult" /> containing the filtered name and description.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">In the case of bad input data</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	IAssetTextFilterResult FilterAssetText(IAssetTextFilterRequest request);

	/// <summary>
	/// Filter the given name and description as if they were part of the same conversation by the same ClientTextAuthor.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Platform.Assets.IAssetTextFilterRequestV2" /> that wraps the request.</param>
	/// <returns>a <see cref="T:Roblox.Platform.Assets.IAssetTextFilterResult" /> containing the filtered name and description.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">In the case of bad input data</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	IAssetTextFilterResult FilterAssetText(IAssetTextFilterRequestV2 request);
}
