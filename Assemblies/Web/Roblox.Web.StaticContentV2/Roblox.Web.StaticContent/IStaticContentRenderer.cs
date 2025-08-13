using Roblox.Platform.StaticContent;
using Roblox.StaticContent.Client;

namespace Roblox.Web.StaticContent;

/// <summary>
/// Responsible for rendering static content.
/// </summary>
public interface IStaticContentRenderer
{
	/// <summary>
	/// Builds the HTML tags for a <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" /> for a <see cref="T:Roblox.StaticContent.Client.StaticContentContentType" />.
	/// </summary>
	/// <remarks>
	/// When called multiple times in the span of a single request for the same component
	/// the additional calls will return empty string (assuming the content has already been rendered on the page previously).
	///
	/// This call will also contain html tags for any registered dependencies of <paramref name="component" />.
	/// </remarks>
	/// <param name="component">The <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />.</param>
	/// <param name="contentType">The <see cref="T:Roblox.StaticContent.Client.StaticContentContentType" />.</param>
	/// <returns>The HTML tag string.</returns>
	string GetContentHtmlTags(StaticContentComponent component, StaticContentContentType contentType);

	/// <summary>
	/// Adds the <see cref="T:Roblox.TranslationResources.ITranslationResources" /> to the page for that are included with an <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />.
	/// </summary>
	/// <param name="component">The <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />.</param>
	void AddTranslationResources(StaticContentComponent component);
}
