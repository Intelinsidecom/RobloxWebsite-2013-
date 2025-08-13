using System.Collections.Generic;
using Roblox.Platform.StaticContent;

namespace Roblox.Web.StaticContent;

/// <summary>
/// Responsible for bundling content and uploading it with Roblox.StaticContent.Service.
/// </summary>
public interface IStaticContentUploader
{
	/// <summary>
	/// Bundles content from an <see cref="T:Roblox.Web.StaticContent.IStaticContentBundles" /> and registers it with Roblox.StaticContent.Service
	/// </summary>
	/// <param name="component">The <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" /> the bundle is for.</param>
	/// <param name="contentPackName">The name of the content pack being created for the bundles.</param>
	/// <param name="bundles">The <see cref="T:Roblox.Web.StaticContent.IStaticContentBundles" />.</param>
	/// <param name="componentDependencies">A set of component names <paramref name="component" /> is dependent on.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="bundles" /></exception>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException"><paramref name="component" /></exception>
	void RegisterBundles(StaticContentComponent component, string contentPackName, IStaticContentBundles bundles, ISet<string> componentDependencies);

	/// <summary>
	/// Uploads image from an <see cref="T:System.Collections.Generic.ISet`1" /> and registers it with Roblox.StaticContent.Service.
	/// </summary>
	/// <param name="images">The <see cref="T:System.Collections.Generic.ISet`1" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="images" /></exception>
	void RegisterImages(ISet<string> images);

	/// <summary>
	/// Uploads source map from an <see cref="T:System.Collections.Generic.ISet`1" /> and registers it with Roblox.StaticContent.Service.
	/// </summary>
	/// <param name="sourceMaps">The <see cref="T:System.Collections.Generic.ISet`1" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="sourceMaps" /></exception>
	void RegisterSourceMaps(ISet<string> sourceMaps);
}
