using Roblox.DataV2.Core;

namespace Roblox.Platform.Core.ExclusiveStartPaging;

/// <summary>
/// A model containing information needed for interaction with start key based paging methods.
/// </summary>
/// <typeparam name="TExclusiveStartKey">The type of the exclusive start ID.</typeparam>
public interface IExclusiveStartKeyInfo<TExclusiveStartKey>
{
	/// <summary>
	/// Gets the sort order.
	/// </summary>
	SortOrder SortOrder { get; }

	/// <summary>
	/// Gets the paging direction.
	/// </summary>
	PagingDirection PagingDirection { get; }

	/// <summary>
	/// Page size.
	/// </summary>
	int Count { get; }

	/// <summary>
	/// Tries to get exclusive start key.
	/// </summary>
	/// <param name="exclusiveStartKey">The exclusive start key value.</param>
	/// <returns>True if an exclusive start key was specified, otherwise false.</returns>
	bool TryGetExclusiveStartKey(out TExclusiveStartKey exclusiveStartKey);
}
