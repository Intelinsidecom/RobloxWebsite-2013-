using System.Collections.Generic;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// A class that contains model for holding information of universe asset media.
/// </summary>
public class UniverseDisplayMediaAssetsForLanguage
{
	/// <summary>
	/// What language the thumbnail media asset Ids are in.
	/// </summary>
	public ILanguageFamily Language { get; set; }

	/// <summary>
	/// The <see cref="T:System.Collections.Generic.IReadOnlyList`1" /> of media asset ids of the thumbnails.
	/// </summary>
	public IReadOnlyList<long> MediaAssetIds { get; set; }

	/// <summary>
	/// The language is source language or not.
	/// </summary>
	public bool IsSourceLanguage { get; set; }
}
