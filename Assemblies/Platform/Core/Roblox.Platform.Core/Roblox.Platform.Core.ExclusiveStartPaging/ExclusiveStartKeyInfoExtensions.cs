using System;
using Roblox.DataV2.Core;

namespace Roblox.Platform.Core.ExclusiveStartPaging;

public static class ExclusiveStartKeyInfoExtensions
{
	/// <summary>
	/// Gets sort order to be used when requesting from the database.
	/// If the direction is backwards we want to return the reversed sort order.
	/// </summary>
	/// <returns></returns>
	public static SortOrder GetDatabaseRequestSortOrder<TId>(this IExclusiveStartKeyInfo<TId> exclusiveStartKeyInfo)
	{
		if (exclusiveStartKeyInfo.PagingDirection.Equals(PagingDirection.Backward))
		{
			if (!exclusiveStartKeyInfo.SortOrder.Equals(SortOrder.Asc))
			{
				return SortOrder.Asc;
			}
			return SortOrder.Desc;
		}
		return exclusiveStartKeyInfo.SortOrder;
	}

	/// <summary>
	/// Gets the exclusive start key from an <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />
	/// If TryGet fails, returns null.
	/// </summary>
	/// <typeparam name="TId">The exclusive start key type.</typeparam>
	/// <param name="exclusiveStartKeyInfo">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <returns><see cref="T:System.Nullable" /> <typeparamref name="TId" /></returns>
	public static TId? GetNullableExclusiveStartKey<TId>(this IExclusiveStartKeyInfo<TId> exclusiveStartKeyInfo) where TId : struct, IComparable, IFormattable, IConvertible
	{
		if (!exclusiveStartKeyInfo.TryGetExclusiveStartKey(out var exclusiveStartKey))
		{
			return null;
		}
		return exclusiveStartKey;
	}

	/// <summary>
	/// Gets a non-nullable exclusive start id for basic data types.
	/// The default exclusive start id based on the <see cref="T:Roblox.DataV2.Core.SortOrder" /> of <paramref name="exclusiveStartKeyInfo" />.
	/// If ascending will always be 0. If descending will be the max value of the datatype.
	/// </summary>
	/// <typeparam name="TId">The exclusive start key type.</typeparam>
	/// <param name="exclusiveStartKeyInfo">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <returns>Non-nullable exclusive start key.</returns>
	public static TId GetDefaultExclusiveStartId<TId>(this IExclusiveStartKeyInfo<TId> exclusiveStartKeyInfo) where TId : struct, IComparable, IFormattable, IConvertible
	{
		if (exclusiveStartKeyInfo.TryGetExclusiveStartKey(out var exclusiveStartKey))
		{
			return exclusiveStartKey;
		}
		if (exclusiveStartKeyInfo.GetDatabaseRequestSortOrder().Equals(SortOrder.Asc))
		{
			return default(TId);
		}
		return (TId)typeof(TId).GetField("MaxValue").GetValue(null);
	}
}
