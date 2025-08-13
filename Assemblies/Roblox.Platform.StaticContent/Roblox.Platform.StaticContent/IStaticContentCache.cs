using System;
using System.Collections.Generic;

namespace Roblox.Platform.StaticContent;

/// <summary>
/// A class to get or set <see cref="!:IStaticContent" /> in a cache.
/// </summary>
/// <typeparam name="T">The type of content to be cached.</typeparam>
internal interface IStaticContentCache<T>
{
	/// <summary>
	/// Gets or sets a page of static content from a cache.
	/// </summary>
	/// <remarks>
	/// Order of operations:
	/// - Check temporary cache for page of content.
	/// - If no page of content exists in the temporary cache <paramref name="rawPageGetter" /> is called.
	/// - If <paramref name="rawPageGetter" /> retrieval is successful store result in durable cache and return value.
	/// - If <paramref name="rawPageGetter" /> is unsuccessful check durable cache for entry.
	/// - If durable cache contains entry return it, otherwise throw exception from <paramref name="rawPageGetter" />.
	/// </remarks>
	/// <param name="cacheKey">The cache key the page of content will be under.</param>
	/// <param name="rawPageGetter">The function to retrieve a new page of content.</param>
	/// <returns>The page of content.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawPageGetter" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="cacheKey" /> is null or whitespace.</exception>
	ICollection<T> GetCachedPage(string cacheKey, Func<ICollection<T>> rawPageGetter);
}
