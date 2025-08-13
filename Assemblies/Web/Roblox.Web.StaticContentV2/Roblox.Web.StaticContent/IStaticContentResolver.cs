using System;
using System.Collections.Generic;
using Roblox.Platform.StaticContent;
using Roblox.StaticContent.Client;

namespace Roblox.Web.StaticContent;

/// <summary>
/// Resolves static content locations.
/// </summary>
public interface IStaticContentResolver
{
	/// <summary>
	/// The absolute <see cref="T:System.Uri" /> of the static content given a <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" /> and <see cref="T:Roblox.StaticContent.Client.StaticContentContentType" />. 
	/// </summary>
	/// <param name="component">The <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />.</param>
	/// <param name="contentType">The <see cref="T:Roblox.StaticContent.Client.StaticContentContentType" />.</param>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
	/// - <paramref name="component" />
	/// - <paramref name="contentType" />
	/// </exception>
	/// <returns>An <see cref="T:System.Collections.Generic.ISet`1" /> of <see cref="T:System.Uri" />s for a specific <see cref="T:Roblox.StaticContent.Client.StaticContentContentType" /> (could be empty if no content is available.)</returns>
	ISet<Uri> GetStaticContentUrls(StaticContentComponent component, StaticContentContentType contentType);

	/// <summary>
	/// Gets the translation resource namespaces associated with a <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />.
	/// </summary>
	/// <param name="component">The <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.ISet`1" /> of the latest translation resource namespaces for the <paramref name="component" /> (could be empty if the component has none.)</returns>
	ISet<string> GetTranslationResourceNamespaces(StaticContentComponent component);

	/// <summary>
	/// Gets the dependent <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" /> for a specified <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />.
	/// </summary>
	/// <param name="component">The <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" /> to get the dependencies of.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.ISet`1" /> of the dependent <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />s.</returns>
	ISet<StaticContentComponent> GetComponentDependencies(StaticContentComponent component);
}
