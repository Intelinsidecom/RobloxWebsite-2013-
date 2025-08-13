using System;
using System.Collections.Generic;

namespace Roblox.Platform.StaticContent;

/// <summary>
/// Represents a content pack.
/// </summary>
public interface IContentPack
{
	/// <summary>
	/// The id of the content pack.
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The name of the content pack.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// The component the content pack is attached to.
	/// </summary>
	/// <remarks>
	/// Will be <c>null</c> if the component is unknown to the application.
	/// </remarks>
	StaticContentComponent? Component { get; }

	/// <summary>
	/// Whether or not the content pack is enabled.
	/// </summary>
	bool Enabled { get; }

	/// <summary>
	/// Whether or not the content pack is validated.
	/// </summary>
	/// <remarks>
	/// Will be <c>false</c> if the content pack hasn't been enabled (<see cref="P:Roblox.Platform.StaticContent.IContentPack.Enabled" />).
	/// </remarks>
	bool Validated { get; }

	/// <summary>
	/// CSS CDN <see cref="T:System.Uri" />s included in the content pack.
	/// </summary>
	ISet<Uri> CssCdnUrls { get; }

	/// <summary>
	/// JavaScript CDN <see cref="T:System.Uri" />s included in the content pack.
	/// </summary>
	ISet<Uri> JavaScriptCdnUrls { get; }

	/// <summary>
	/// The translation resource namespaces included in the content pack.
	/// </summary>
	ISet<string> TranslationResourceNamespaces { get; }

	/// <summary>
	/// <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />s this content pack is dependent on.
	/// </summary>
	ISet<StaticContentComponent> ComponentDependencies { get; }

	/// <summary>
	/// When the content pack was created.
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// When the content pack was updated.
	/// </summary>
	DateTime Updated { get; }
}
