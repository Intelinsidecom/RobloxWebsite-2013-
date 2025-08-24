using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.StaticContent;

/// <summary>
/// A factory for creating and returning <see cref="!:IStaticContent" />.
/// </summary>
public interface IStaticContentFactory
{
	/// <summary>
	/// Gets a page of content packs.
	/// </summary>
	/// <remarks>
	/// If <paramref name="enabled" /> is passed <paramref name="validated" /> must also be passed.
	/// Both are required for filtering.
	///
	/// <paramref name="useCache" /> should be passed as <c>true</c> anytime
	/// we do not need the latest results from the Roblox.StaticContent.Service.
	///
	/// This cache protects Roblox.StaticContent.Service from being hit too hard, and
	/// if Roblox.StaticContent.Service is unavailable it will protect the website from
	/// not being able to load critical data like the CSS and JavaScript CDN locations.
	/// </remarks>
	/// <param name="componentName">The component name for the content pack.</param>
	/// <param name="exclusiveStartKey">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <param name="useCache">Whether or not to load the content packs from a cache when available.</param>
	/// <param name="enabled">Whether or not the content packs must be enabled.</param>
	/// <param name="validated">Whether or not the content packs must be validated.</param>
	/// <returns>The page of content packs.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="exclusiveStartKey" /></exception>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="componentName" /> is <c>null</c> or whitespace.
	/// - Only one of <paramref name="validated" /> or <paramref name="enabled" /> are passed.
	/// </exception>
	IPlatformPageResponse<long, IContentPack> GetContentPacks(string componentName, IExclusiveStartKeyInfo<long> exclusiveStartKey, bool useCache, bool? enabled = null, bool? validated = null);
}
