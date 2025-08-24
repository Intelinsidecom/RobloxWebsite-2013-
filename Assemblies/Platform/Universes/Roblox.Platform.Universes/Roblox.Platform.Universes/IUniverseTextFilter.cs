namespace Roblox.Platform.Universes;

/// <summary>
/// Filter Universe text for the given Author.
/// In particular, we're filtering the name and description as if they were in the same "room".
/// </summary>
public interface IUniverseTextFilter
{
	/// <summary>
	/// Filter the given name and description as if they were part of the same conversation by the same Author.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Platform.Universes.IUniverseTextFilterRequest" /> that wraps the request.</param>
	/// <returns>a <see cref="T:Roblox.Platform.Universes.IUniverseTextFilterResult" /> containing the filtered name and description.</returns>
	/// <exception cref="T:System.ArgumentNullException">In the case of bad input data</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Universes.PlatformUniverseTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	IUniverseTextFilterResult FilterUniverseText(IUniverseTextFilterRequest request);
}
