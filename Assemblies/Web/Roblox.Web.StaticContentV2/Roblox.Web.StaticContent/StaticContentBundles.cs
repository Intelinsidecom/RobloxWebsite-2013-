using System.Collections.Generic;

namespace Roblox.Web.StaticContent;

/// <inheritdoc cref="T:Roblox.Web.StaticContent.IStaticContentBundles" />
public class StaticContentBundles : IStaticContentBundles
{
	/// <inheritdoc cref="P:Roblox.Web.StaticContent.IStaticContentBundles.CssFileNames" />
	public ISet<string> CssFileNames { get; }

	/// <inheritdoc cref="P:Roblox.Web.StaticContent.IStaticContentBundles.JavaScriptFileNames" />
	public ISet<string> JavaScriptFileNames { get; }

	/// <inheritdoc cref="P:Roblox.Web.StaticContent.IStaticContentBundles.AngularTemplateFileNames" />
	public ISet<string> AngularTemplateFileNames { get; }

	/// <inheritdoc cref="P:Roblox.Web.StaticContent.IStaticContentBundles.TranslationResourceNamespaces" />
	public ISet<string> TranslationResourceNamespaces { get; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.StaticContent.StaticContentBundles" />.
	/// </summary>
	public StaticContentBundles()
	{
		CssFileNames = new HashSet<string>();
		JavaScriptFileNames = new HashSet<string>();
		AngularTemplateFileNames = new HashSet<string>();
		TranslationResourceNamespaces = new HashSet<string>();
	}
}
