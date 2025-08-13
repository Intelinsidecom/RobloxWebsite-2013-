using System.Collections.Generic;

namespace Roblox.Web.StaticContent;

/// <summary>
/// A collection of files for different types of content to be bundled.
/// </summary>
public interface IStaticContentBundles
{
	/// <summary>
	/// CSS files to be uploaded.
	/// </summary>
	ISet<string> CssFileNames { get; }

	/// <summary>
	/// JavaScript files to be uploaded.
	/// </summary>
	ISet<string> JavaScriptFileNames { get; }

	/// <summary>
	/// Angular HTML template files to be uploaded.
	/// </summary>
	ISet<string> AngularTemplateFileNames { get; }

	/// <summary>
	/// The translation resource namespaces to include with the bundles.
	/// </summary>
	ISet<string> TranslationResourceNamespaces { get; }
}
