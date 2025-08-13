using Roblox.DataV2.Core;

namespace Roblox.Platform.Core.ExclusiveStartPaging;

/// <inheritdoc cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />
public class ExclusiveStartKeyInfo<TExclusiveStartKey> : IExclusiveStartKeyInfo<TExclusiveStartKey>
{
	/// <inheritdoc cref="P:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1.SortOrder" />
	public SortOrder SortOrder { get; }

	/// <inheritdoc cref="P:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1.PagingDirection" />
	public PagingDirection PagingDirection { get; }

	/// <inheritdoc cref="P:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1.Count" />
	public int Count { get; }

	private ExclusiveStartKeyContainer<TExclusiveStartKey> ExclusiveStartKeyContainer { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.ExclusiveStartKeyInfo`1" /> class.
	/// </summary>
	/// <param name="exclusiveStartKey">The exclusive start key.</param>
	/// <param name="count">The count.</param>
	public ExclusiveStartKeyInfo(TExclusiveStartKey exclusiveStartKey, int count)
	{
		ExclusiveStartKeyContainer = new ExclusiveStartKeyContainer<TExclusiveStartKey>(exclusiveStartKey);
		Count = count;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.ExclusiveStartKeyInfo`1" /> class.
	/// </summary>
	/// <param name="sortOrder">The sort order.</param>
	/// <param name="pagingDirection">The paging direction.</param>
	/// <param name="count">The count.</param>
	public ExclusiveStartKeyInfo(SortOrder sortOrder, PagingDirection pagingDirection, int count)
	{
		SortOrder = sortOrder;
		PagingDirection = pagingDirection;
		Count = count;
		ExclusiveStartKeyContainer = null;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.ExclusiveStartKeyInfo`1" /> class with specified exclusive start key.
	/// </summary>
	/// <param name="exclusiveStartKey">The exclusive start key.</param>
	/// <param name="sortOrder">The sort order.</param>
	/// <param name="pagingDirection">The paging direction.</param>
	/// <param name="count">The count.</param>
	public ExclusiveStartKeyInfo(TExclusiveStartKey exclusiveStartKey, SortOrder sortOrder, PagingDirection pagingDirection, int count)
	{
		SortOrder = sortOrder;
		PagingDirection = pagingDirection;
		Count = count;
		ExclusiveStartKeyContainer = new ExclusiveStartKeyContainer<TExclusiveStartKey>(exclusiveStartKey);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1.TryGetExclusiveStartKey(`0@)" />
	public bool TryGetExclusiveStartKey(out TExclusiveStartKey exclusiveStartKey)
	{
		if (ExclusiveStartKeyContainer != null)
		{
			exclusiveStartKey = ExclusiveStartKeyContainer.ExclusiveStartKey;
			return true;
		}
		exclusiveStartKey = default(TExclusiveStartKey);
		return false;
	}
}
