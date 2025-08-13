using System;
using Roblox.DataV2.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Web.ExclusiveStartKeyPaging;

/// <summary>
/// A factory to handle creating, and parsing cursors to and from <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />
/// </summary>
public interface IPagingFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" /> from <paramref name="cursor" />, <paramref name="cursorRecipe" />, <paramref name="count" />, and <paramref name="sortOrder" />
	/// for primitive types only.
	/// </summary>
	/// <typeparam name="TExclusiveStartKey">The type of the exclusive start key.</typeparam>
	/// <param name="cursor">The paging cursor.</param>
	/// <param name="cursorRecipe">The parameter recipe for the cursor hash.</param>
	/// <param name="count">The max rows. Should be contained in set from <see cref="!:ValidCounts" />.</param>
	/// <param name="sortOrder">The <see cref="T:Roblox.DataV2.Core.SortOrder" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" /></returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="cursor" /> is null, whitespace or empty.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="cursor" /> is invalid.</exception>
	IExclusiveStartKeyInfo<TExclusiveStartKey> GetExclusiveStartKeyInfo<TExclusiveStartKey>(string cursor, string cursorRecipe, int count, SortOrder sortOrder) where TExclusiveStartKey : struct, IComparable, IFormattable, IConvertible;

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" /> from <paramref name="cursor" />, <paramref name="cursorRecipe" />, <paramref name="count" />, and <paramref name="sortOrder" />.
	/// Using specified <paramref name="keyStringBuilder" /> to build string representation of the key and <paramref name="exclusiveStartKeyParser" /> 
	/// to initiate entity of <typeparamref name="TExclusiveStartKey" /> type.
	/// </summary>
	/// <typeparam name="TExclusiveStartKey">The type of the exclusive start key.</typeparam>
	/// <param name="cursor">The paging cursor.</param>
	/// <param name="cursorRecipe">The parameter recipe for the cursor hash.</param>
	/// <param name="count">The max rows. Should be contained in set from <see cref="!:ValidCounts" />.</param>
	/// <param name="sortOrder">The <see cref="T:Roblox.DataV2.Core.SortOrder" />.</param>
	/// <param name="keyStringBuilder">Function which builds string representation of provided exclusive start key object of <typeparamref name="TExclusiveStartKey" /> type.</param>
	/// <param name="exclusiveStartKeyParser">Function which initiate exclusive start key object of <typeparamref name="TExclusiveStartKey" /> type with data 
	/// from provided exclusive start key string representation.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" /></returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// The <paramref name="cursor" /> is null, whitespace or empty.
	/// or
	/// <paramref name="keyStringBuilder" /> is null
	/// or
	/// <paramref name="exclusiveStartKeyParser" /> is null
	/// </exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="cursor" /> is invalid.</exception>
	IExclusiveStartKeyInfo<TExclusiveStartKey> GetExclusiveStartKeyInfo<TExclusiveStartKey>(string cursor, string cursorRecipe, int count, SortOrder sortOrder, Func<TExclusiveStartKey, string> keyStringBuilder, Func<string, TExclusiveStartKey> exclusiveStartKeyParser);

	/// <summary>
	/// Builds string cursor that may be used as a parameter in a request for our endpoints for a page of results. 
	/// Default implementation which works only with primitive <typeparamref name="TExclusiveStartKey" /> types . 
	/// </summary>
	/// <param name="exclusiveStartKey">The exclusive start key.</param>
	/// <param name="count">The maximum rows.</param>
	/// <param name="sortOrder"><see cref="T:Roblox.DataV2.Core.SortOrder" /></param>
	/// <param name="direction"><see cref="T:Roblox.Platform.Core.PagingDirection" /></param>
	/// <param name="cursorRecipe">The parameter recipe for the cursor hash.</param>
	/// <returns>Exclusive start key cursor.</returns>
	string GetExclusiveStartKey<TExclusiveStartKey>(TExclusiveStartKey exclusiveStartKey, int count, SortOrder sortOrder, PagingDirection direction, string cursorRecipe) where TExclusiveStartKey : struct, IComparable, IFormattable, IConvertible;

	/// <summary>
	/// Builds string cursor that may be used as a parameter in a request for our endpoints for a page of results. 
	/// Default implementation which works only with primitive <typeparamref name="TExclusiveStartKey" /> types . 
	/// </summary>
	/// <param name="exclusiveStartKey">The exclusive start key.</param>
	/// /// <param name="count">The maximum rows.</param>
	/// <param name="sortOrder"><see cref="T:Roblox.DataV2.Core.SortOrder" /></param>
	/// <param name="direction"><see cref="T:Roblox.Platform.Core.PagingDirection" /></param>
	/// <param name="cursorRecipe">The parameter recipe for the cursor hash.</param>
	/// <param name="exclusiveStartKeyStringBuilder">Function which initiate exclusive start key object of <typeparamref name="TExclusiveStartKey" /> type with data 
	/// from provided exclusive start key string representation.</param>
	/// <returns>Exclusive start key cursor.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// <paramref name="exclusiveStartKey" /> is null.
	/// or
	/// <paramref name="exclusiveStartKeyStringBuilder" /> is null.
	/// </exception>
	string GetExclusiveStartKey<TExclusiveStartKey>(TExclusiveStartKey exclusiveStartKey, int count, SortOrder sortOrder, PagingDirection direction, string cursorRecipe, Func<TExclusiveStartKey, string> exclusiveStartKeyStringBuilder);
}
