using System.Runtime.Serialization;
using Roblox.DataV2.Core;

namespace Roblox.Paging;

/// <summary>
/// Cursor information for exclusive start key based cursors.
/// </summary>
/// <typeparam name="T">The key type.</typeparam>
[DataContract]
public class ExclusiveStartKeyCursor<T> : CursorBase
{
	/// <summary>
	/// The exclusive start key value.
	/// </summary>
	[DataMember(Name = "key")]
	public T Key { get; set; }

	/// <summary>
	/// The <see cref="P:Roblox.Paging.ExclusiveStartKeyCursor`1.SortOrder" />.
	/// </summary>
	[DataMember(Name = "sortOrder")]
	public SortOrder SortOrder { get; set; }

	/// <summary>
	/// The direction the cursor is facing.
	/// </summary>
	[DataMember(Name = "pagingDirection")]
	public CursorPagingDirection PagingDirection { get; set; }
}
