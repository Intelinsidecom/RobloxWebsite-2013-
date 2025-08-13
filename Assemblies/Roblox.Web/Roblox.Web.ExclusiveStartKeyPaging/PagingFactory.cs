using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Roblox.DataV2.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Web.ExclusiveStartKeyPaging;

/// <summary>
/// A factory to handle creating, and parsing cursors to and from <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />
/// </summary>
/// <seealso cref="T:Roblox.Web.ExclusiveStartKeyPaging.IPagingFactory" />
public class PagingFactory : IPagingFactory
{
	private readonly Func<string> _GetPagingSalt;

	private const char _CursorPartsSeparator = '_';

	private string PagingSalt => _GetPagingSalt();

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.ExclusiveStartKeyPaging.PagingFactory" /> class.
	/// </summary>
	/// <param name="pagingSalt">The function to get the paging salt.</param>
	public PagingFactory(Func<string> pagingSalt)
	{
		if (pagingSalt == null)
		{
			throw new ArgumentNullException("pagingSalt");
		}
		_GetPagingSalt = pagingSalt;
	}

	public IExclusiveStartKeyInfo<TExclusiveStartKey> GetExclusiveStartKeyInfo<TExclusiveStartKey>(string cursor, string cursorRecipe, int count, SortOrder sortOrder) where TExclusiveStartKey : struct, IComparable, IFormattable, IConvertible
	{
		return GetExclusiveStartKeyInfo(cursor, cursorRecipe, count, sortOrder, PrimitiveKeyStringDefaultBuilder, PrimitiveExclusiveStartKeyParser<TExclusiveStartKey>);
	}

	public IExclusiveStartKeyInfo<TExclusiveStartKey> GetExclusiveStartKeyInfo<TExclusiveStartKey>(string cursor, string cursorRecipe, int count, SortOrder sortOrder, Func<TExclusiveStartKey, string> keyStringBuilder, Func<string, TExclusiveStartKey> exclusiveStartKeyParser)
	{
		if (string.IsNullOrWhiteSpace(cursor))
		{
			throw new ArgumentNullException(string.Format("{0} is null or whitespace", "cursor"));
		}
		string[] splitCursor = cursor.Split('_');
		if (splitCursor.Length != 3)
		{
			throw new ArgumentException(string.Format("{0} is invalid", "cursor"));
		}
		TExclusiveStartKey exclusiveStartKey;
		try
		{
			exclusiveStartKey = exclusiveStartKeyParser(HttpUtility.UrlDecode(splitCursor[0]));
		}
		catch (Exception ex)
		{
			throw new ArgumentException(string.Format("{0}: failed to parse exclusive start key", "cursor"), ex);
		}
		if (!int.TryParse(splitCursor[1], out var directionId))
		{
			throw new ArgumentException(string.Format("{0}: failed to parse PagingDirection", "cursor"));
		}
		PagingDirection direction = (PagingDirection)directionId;
		if (!cursor.Equals(GetExclusiveStartKey(exclusiveStartKey, count, sortOrder, direction, cursorRecipe, keyStringBuilder)))
		{
			throw new ArgumentException(string.Format("{0}: failed to match hash", "cursor"));
		}
		return new ExclusiveStartKeyInfo<TExclusiveStartKey>(exclusiveStartKey, sortOrder, direction, count);
	}

	public string GetExclusiveStartKey<TExclusiveStartKey>(TExclusiveStartKey exclusiveStartKey, int count, SortOrder sortOrder, PagingDirection direction, string cursorRecipe) where TExclusiveStartKey : struct, IComparable, IFormattable, IConvertible
	{
		return GetExclusiveStartKey(exclusiveStartKey, count, sortOrder, direction, cursorRecipe, PrimitiveKeyStringDefaultBuilder);
	}

	public string GetExclusiveStartKey<TExclusiveStartKey>(TExclusiveStartKey exclusiveStartKey, int count, SortOrder sortOrder, PagingDirection direction, string cursorRecipe, Func<TExclusiveStartKey, string> exclusiveStartKeyStringBuilder)
	{
		if (exclusiveStartKey == null)
		{
			throw new ArgumentNullException("exclusiveStartKey");
		}
		if (exclusiveStartKeyStringBuilder == null)
		{
			throw new ArgumentNullException("exclusiveStartKeyStringBuilder");
		}
		string exclusiveStartKeyString = exclusiveStartKeyStringBuilder(exclusiveStartKey);
		if (string.IsNullOrWhiteSpace(exclusiveStartKeyString))
		{
			throw new ArgumentException(string.Format("Specified {0} returned invalid ExclusiveStartKey string for specified {1}.", "exclusiveStartKeyStringBuilder", "exclusiveStartKey") + "ExclusiveStartKey string must be a non-empty string.");
		}
		if (exclusiveStartKeyString.Contains('_'))
		{
			throw new ArgumentException(string.Format("Specified {0} returned ExclusiveStartKey which contains reserved symbol: {1}. ", "exclusiveStartKeyStringBuilder", '_') + string.Format("Please, change {0} to not to use {1}.", "exclusiveStartKeyStringBuilder", '_'));
		}
		string cursorKey = $"{HttpUtility.UrlEncode(exclusiveStartKeyString)}{'_'}{(int)direction}";
		string bakedKey = $"{cursorKey}{'_'}{PagingSalt}{'_'}{count}{'_'}{(int)sortOrder}{'_'}{cursorRecipe}";
		byte[] array = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(bakedKey));
		StringBuilder checksum = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			checksum.Append(b.ToString("x2"));
		}
		return $"{cursorKey}_{checksum}";
	}

	private static string PrimitiveKeyStringDefaultBuilder<TExclusiveStartKey>(TExclusiveStartKey exclusiveStartKey) where TExclusiveStartKey : struct, IComparable, IFormattable, IConvertible
	{
		return exclusiveStartKey.ToString();
	}

	private static TExclusiveStartKey PrimitiveExclusiveStartKeyParser<TExclusiveStartKey>(string keyString) where TExclusiveStartKey : struct, IComparable, IFormattable, IConvertible
	{
		return (TExclusiveStartKey)Convert.ChangeType(keyString, typeof(TExclusiveStartKey));
	}
}
