using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using Roblox.Common.NetStandard;

namespace Roblox.Common;

public static class Extensions
{
	public enum QueryOperators
	{
		AND,
		OR,
		NOT,
		NEAR
	}

	private const long _TenThousand = 10000L;

	private const long _OneMillion = 1000000L;

	private const long _OneBillion = 1000000000L;

	private const long _OneTrillion = 1000000000000L;

	private static readonly char quote = '"';

	private static readonly char space = ' ';

	private static readonly char[] spaceDelimiter = new char[1] { space };

	private static DateTime unixEpochStartTime = new DateTime(1970, 1, 1);

	public static IEnumerable<T> AsEnumerable<T>(this T item)
	{
		yield return item;
	}

	public static string Convert(this string value, Encoding originalEncoding, Encoding newEncoding)
	{
		byte[] originalBytes = value.GetBytes(originalEncoding);
		byte[] newBytes = Encoding.Convert(originalEncoding, newEncoding, originalBytes);
		return newEncoding.GetString(newBytes);
	}

	public static byte[] GetBytes(this string value)
	{
		ASCIIEncoding asciiEncoding = new ASCIIEncoding();
		return value.GetBytes(asciiEncoding);
	}

	public static byte[] GetBytes(this string value, Encoding encoding)
	{
		return encoding.GetBytes(value);
	}

	public static byte[] ToBinary(this IEnumerable<long> array)
	{
		if (array == null)
		{
			return null;
		}
		int length = array.Count();
		List<byte> arrayStream = new List<byte>(8 * length);
		foreach (long element in array)
		{
			arrayStream.AddRange(BitConverter.GetBytes(element));
		}
		return arrayStream.ToArray();
	}

	public static byte[] ToBinary(this IEnumerable<short> array)
	{
		if (array == null)
		{
			return null;
		}
		int length = array.Count();
		List<byte> arrayStream = new List<byte>(2 * length);
		foreach (short element in array)
		{
			arrayStream.AddRange(BitConverter.GetBytes(element));
		}
		return arrayStream.ToArray();
	}

	public static byte[] ToBinary(this IEnumerable<DateTime> array)
	{
		if (array == null)
		{
			return null;
		}
		int length = array.Count();
		List<byte> arrayStream = new List<byte>(8 * length);
		foreach (DateTime item in array)
		{
			arrayStream.AddRange(BitConverter.GetBytes(item.Ticks));
		}
		return arrayStream.ToArray();
	}

	public static IReadOnlyCollection<long> ToListLong(this byte[] binaryData)
	{
		if (binaryData == null)
		{
			return null;
		}
		int unitSize = 8;
		int length = binaryData.Length / unitSize;
		List<long> longStream = new List<long>(length);
		for (int i = 0; i < length; i++)
		{
			int index = i * unitSize;
			longStream.Add(BitConverter.ToInt64(binaryData, index));
		}
		return longStream;
	}

	public static IReadOnlyCollection<short> ToListShort(this byte[] binaryData)
	{
		if (binaryData == null)
		{
			return null;
		}
		int unitSize = 2;
		int length = binaryData.Length / unitSize;
		List<short> shortStream = new List<short>(length);
		for (int i = 0; i < length; i++)
		{
			int index = i * unitSize;
			shortStream.Add(BitConverter.ToInt16(binaryData, index));
		}
		return shortStream;
	}

	public static IReadOnlyCollection<DateTime> ToListDateTime(this byte[] binaryData)
	{
		if (binaryData == null)
		{
			return null;
		}
		int unitSize = 8;
		int length = binaryData.Length / unitSize;
		List<DateTime> longStream = new List<DateTime>(length);
		for (int i = 0; i < length; i++)
		{
			int index = i * unitSize;
			longStream.Add(new DateTime(BitConverter.ToInt64(binaryData, index)));
		}
		return longStream;
	}

	public static bool IsEven(this int value)
	{
		return value % 2 == 0;
	}

	public static bool IsOdd(this int value)
	{
		return !value.IsEven();
	}

	public static int[] IndexesOf(this string s, char value)
	{
		List<int> positions = new List<int>();
		for (int position = s.IndexOf(value); position > -1; position = s.IndexOf(value, position + 1))
		{
			positions.Add(position);
		}
		return positions.ToArray();
	}

	public static string ParsedSubString(this string text, string startToken, string endToken, bool startWithLastOccurrence)
	{
		return text.ParsedSubString(startToken, endToken, includeStartToken: false, includeEndToken: false, startWithLastOccurrence);
	}

	public static string ParsedSubString(this string text, string startToken, string endToken)
	{
		return text.ParsedSubString(startToken, endToken, includeStartToken: false, includeEndToken: false, startWithLastOccurrence: false);
	}

	public static string ParsedSubString(this string text, string startToken, string endToken, bool includeStartToken, bool includeEndToken, bool startWithLastOccurrence)
	{
		int posStartToken = ((!startWithLastOccurrence) ? text.ToLower().IndexOf(startToken.ToLower()) : text.ToLower().LastIndexOf(startToken.ToLower()));
		posStartToken = ((posStartToken >= 0) ? (posStartToken + ((!includeStartToken) ? startToken.Length : 0)) : 0);
		text = text.Substring(posStartToken);
		int posEndToken = text.ToLower().IndexOf(endToken.ToLower());
		posEndToken = ((posEndToken >= 0) ? (posEndToken + (includeEndToken ? endToken.Length : 0)) : text.Length);
		return text.Substring(0, posEndToken);
	}

	/// <summary>
	/// An integer range with Min and Max barriers.
	///
	/// If the minimum is greater than the maximum,
	/// range represents the range going up from Min to int.maxvalue
	/// unioned with the range going from int.minvalue to Max
	/// </summary>
	public static bool Contains(this Range range, int number)
	{
		if (range.Min <= range.Max)
		{
			if (range.Max >= number)
			{
				return number >= range.Min;
			}
			return false;
		}
		if (range.Min > number)
		{
			return number <= range.Max;
		}
		return true;
	}

	public static string TrimAll(this string original)
	{
		return DoTrimAll(original, 2);
	}

	public static string TrimAllRight(this string original)
	{
		return DoTrimAll(original, 1);
	}

	public static string TrimAllLeft(this string original)
	{
		return DoTrimAll(original, 0);
	}

	private static string DoTrimAll(string original, int type)
	{
		int end = original.Length - 1;
		int start = 0;
		if (type != 1)
		{
			for (; start < original.Length && IsWhiteSpace(original[start]); start++)
			{
			}
		}
		if (type != 0)
		{
			while (end >= start && IsWhiteSpace(original[end]))
			{
				end--;
			}
		}
		int length = end - start + 1;
		if (length == original.Length)
		{
			return original;
		}
		if (length == 0)
		{
			return string.Empty;
		}
		return original.Substring(start, length);
	}

	private static bool IsWhiteSpace(char c)
	{
		char[] arr = new char[5] { '\u200b', '\ufeff', '\u202f', '\u180e', '\u205f' };
		if (!char.IsWhiteSpace(c))
		{
			return arr.Contains(c);
		}
		return true;
	}

	public static string ToQuery(this string query)
	{
		return query.ToQuery(QueryOperators.AND);
	}

	public static string ToQuery(this string query, QueryOperators defaultOperator)
	{
		string defaultOp = $" {defaultOperator} ";
		string searchQuery = "";
		if (!string.IsNullOrEmpty(query.Trim()))
		{
			string searchTerm = "";
			char quote = '"';
			char space = ' ';
			List<string> searchTerms = new List<string>();
			bool foundPhrase = false;
			query = Regex.Replace(query.Trim(), "\\s{2,}", space.ToString());
			char[] characters = query.ToCharArray();
			for (int j = 0; j < query.Length; j++)
			{
				char character = characters[j];
				searchTerm += character;
				if (character.Equals(quote))
				{
					foundPhrase = !foundPhrase;
				}
				if (foundPhrase)
				{
					continue;
				}
				if (character.Equals(quote))
				{
					AddSearchTerm(searchTerm, ref searchTerms, defaultOperator);
					searchTerm = "";
				}
				if (character.Equals(space))
				{
					if (!string.IsNullOrEmpty(searchTerm.Trim()))
					{
						AddSearchTerm(searchTerm, ref searchTerms, defaultOperator);
					}
					searchTerm = "";
				}
			}
			if (searchTerm != "" && (!IsQueryOperator(searchTerm) || searchTerm.Equals(")")))
			{
				AddSearchTerm(searchTerm, ref searchTerms, defaultOperator);
			}
			if (!IsQueryOperator(searchTerms[0]))
			{
				searchQuery = searchTerms[0];
			}
			for (int i = 1; i < searchTerms.Count; i++)
			{
				if (!IsQueryOperator(searchTerms[i]) && !IsQueryOperator(searchTerms[i - 1]) && !searchTerms[i].Trim().Equals(")"))
				{
					searchQuery += defaultOp;
				}
				if (searchTerms[i].ToUpper() == QueryOperators.NOT.ToString() && !IsQueryOperator(searchTerms[i - 1]))
				{
					searchQuery += defaultOp;
				}
				searchQuery = searchQuery + " " + searchTerms[i];
			}
			searchQuery = Regex.Replace(searchQuery.Trim(), "\\s{2,}", space.ToString());
		}
		return searchQuery;
	}

	private static bool IsQueryOperator(string s)
	{
		s = s.Trim().ToLower();
		string[] names = Enum.GetNames(typeof(QueryOperators));
		foreach (string op in names)
		{
			if (s == op.ToLower())
			{
				return true;
			}
		}
		if (s == "(" || s == ")")
		{
			return true;
		}
		return false;
	}

	private static string AddQuotesToSearchTerm(string searchTerm)
	{
		char quote = '"';
		char openParenthesis = '(';
		char closeParenthesis = ')';
		searchTerm = searchTerm.Trim();
		if (!IsQueryOperator(searchTerm))
		{
			if (searchTerm[0] == quote)
			{
				if (searchTerm[searchTerm.Length - 1] != quote)
				{
					searchTerm += quote;
				}
			}
			else
			{
				searchTerm = ((searchTerm[0] != openParenthesis) ? (quote + searchTerm) : (openParenthesis + AddQuotesToSearchTerm(searchTerm.Substring(1))));
				if (searchTerm[searchTerm.Length - 1] == closeParenthesis)
				{
					searchTerm = AddQuotesToSearchTerm(searchTerm.Substring(0, searchTerm.Length - 1)) + closeParenthesis;
				}
				else if (searchTerm[searchTerm.Length - 1] != quote)
				{
					searchTerm += quote;
				}
			}
		}
		return searchTerm;
	}

	private static void AddSearchTerm(string searchTerm, ref List<string> searchTerms, QueryOperators defaultOperator)
	{
		int indexOfQuote = searchTerm.IndexOf(quote);
		searchTerm = Regex.Replace(searchTerm, "^(\\&{1,}|\\+{1,})", " and ");
		searchTerm = Regex.Replace(searchTerm, "^(\\|{1,})", " or ");
		searchTerm = Regex.Replace(searchTerm, "^(\\~{1,})", " near ");
		searchTerm = Regex.Replace(searchTerm, "^(\\-{1,}|\\!{1,})", $" {defaultOperator} not ");
		searchTerm = Regex.Replace(searchTerm.Trim(), "\\s+", space.ToString());
		int searchBoundary = searchTerm.Length;
		if (searchTerm.Contains(quote.ToString()))
		{
			searchBoundary = indexOfQuote;
		}
		if (searchTerm.Substring(0, searchBoundary).Contains(space.ToString()))
		{
			string[] array = searchTerm.Substring(0, searchBoundary).Split(spaceDelimiter, StringSplitOptions.RemoveEmptyEntries);
			foreach (string s in array)
			{
				searchTerms.Add(AddQuotesToSearchTerm(s));
			}
			if (searchBoundary < searchTerm.Length)
			{
				searchTerms.Add(AddQuotesToSearchTerm(searchTerm.Substring(searchBoundary)));
			}
		}
		else
		{
			searchTerms.Add(AddQuotesToSearchTerm(searchTerm));
		}
	}

	public static string ToDescription(this Enum value)
	{
		DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
		if (attributes != null && attributes.Length != 0)
		{
			return attributes[0].Description;
		}
		return value.ToString();
	}

	/// <summary>
	/// Get the desired attribute for a given enum value
	/// </summary>
	/// <typeparam name="TAttribute">The desired attribute type</typeparam>
	/// <param name="value">The enum value</param>
	/// <returns>The desired attribute</returns>
	public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
	{
		Type type = value.GetType();
		string name = Enum.GetName(type, value);
		return type.GetField(name).GetCustomAttributes(inherit: false).OfType<TAttribute>()
			.SingleOrDefault();
	}

	/// <summary>
	/// Parses a string to enum type, only if the value is in the enum definition.
	/// </summary>
	/// <typeparam name="T">The Enum type.</typeparam>
	/// <param name="value">The given string value.</param>
	/// <param name="ignoreCase">Whether to ignore case when parsing. Default to ignore.</param>
	/// <returns>The converted enum if it is in the enum definition, otherwise null.</returns>
	public static T? ToEnum<T>(this string value, bool ignoreCase = true) where T : struct
	{
		if (Enum.TryParse<T>(value, ignoreCase, out var result) && Enum.IsDefined(typeof(T), result))
		{
			return result;
		}
		return null;
	}

	public static bool UnorderedEqual<T>(this ICollection<T> list, ICollection<T> listToCompare)
	{
		if (list.Count != listToCompare.Count)
		{
			return false;
		}
		Dictionary<T, int> d = new Dictionary<T, int>();
		foreach (T item in list)
		{
			if (d.TryGetValue(item, out var c2))
			{
				d[item] = c2 + 1;
			}
			else
			{
				d.Add(item, 1);
			}
		}
		foreach (T item2 in listToCompare)
		{
			if (d.TryGetValue(item2, out var c))
			{
				if (c == 0)
				{
					return false;
				}
				d[item2] = c - 1;
				continue;
			}
			return false;
		}
		foreach (int value in d.Values)
		{
			if (value != 0)
			{
				return false;
			}
		}
		return true;
	}

	public static IEnumerable<T> AsRandom<T>(this IList<T> list)
	{
		int[] indexes = Enumerable.Range(0, list.Count).ToArray();
		Random rando = new Random();
		int i = 0;
		while (i < list.Count)
		{
			int position = rando.Next(i, list.Count);
			yield return list[indexes[position]];
			indexes[position] = indexes[i];
			int num = i + 1;
			i = num;
		}
	}

	/// <summary>
	/// Produces the set intersection between two sequences by using the specified function comparer.
	/// </summary>
	/// <typeparam name="TSource">The collection items type.</typeparam>
	/// <param name="first">The first collection.</param>
	/// <param name="second">The second collection.</param>
	/// <param name="comparer">The comparer function.</param>
	/// <returns>Returns a collection with the elements that are in both  
	/// collections according to the comparer function.
	/// </returns>
	public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, Func<TSource, TSource, bool> comparer)
	{
		return first.Intersect(second, new LambdaComparer<TSource>(comparer));
	}

	[Obsolete("Use a proper JSON serializer")]
	public static string ToJSON<TSource>(this IEnumerable<TSource> source) where TSource : class
	{
		string response = "[";
		foreach (TSource obj in source)
		{
			response = response + obj.ToJSON() + ",";
		}
		response = response.TrimEnd(',');
		return response + "]";
	}

	[Obsolete("Use a proper JSON serializer")]
	public static string ToJSON<T>(this T obj) where T : class
	{
		DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
		using MemoryStream stream = new MemoryStream();
		serializer.WriteObject((Stream)stream, (object)obj);
		return Encoding.Default.GetString(stream.ToArray());
	}

	[Obsolete("Use a proper JSON serializer")]
	public static T FromJSON<T>(this string json) where T : class
	{
		using MemoryStream stream = new MemoryStream(Encoding.Unicode.GetBytes(json));
		return new DataContractJsonSerializer(typeof(T)).ReadObject((Stream)stream) as T;
	}

	public static string AbbreviateNumber(this long value, long abbreviationThreshold = 10000L, byte extraTrimCharacters = 0, int digitAfterDecimalPlace = 0)
	{
		if (value == 0L)
		{
			return "0";
		}
		if (value < abbreviationThreshold)
		{
			return value.ToString("#,###");
		}
		string append = "T+";
		int trimCharacters = 12;
		if (value < 1000000)
		{
			append = "K+";
			trimCharacters = 3;
		}
		else if (value < 1000000000)
		{
			append = "M+";
			trimCharacters = 6;
		}
		else if (value < 1000000000000L)
		{
			append = "B+";
			trimCharacters = 9;
		}
		trimCharacters += extraTrimCharacters;
		string balanceString = value.ToString(CultureInfo.InvariantCulture);
		int beforeDecimalPlaceLength = balanceString.Length - trimCharacters;
		string afterDecimalPlace = ((digitAfterDecimalPlace == 0) ? "" : ("." + balanceString.Substring(beforeDecimalPlaceLength, digitAfterDecimalPlace)));
		return balanceString.Substring(0, beforeDecimalPlaceLength) + afterDecimalPlace + append;
	}

	public static string FormatNumber(this long balance)
	{
		if (balance != 0L)
		{
			return balance.ToString("#,###");
		}
		return "0";
	}

	public static string FormatNumber(this int balance)
	{
		return ((long)balance).FormatNumber();
	}

	public static DateTime FromUnixEpochMilliseconds(this double milliseconds)
	{
		return unixEpochStartTime.AddMilliseconds(milliseconds);
	}

	public static DateTime FromUnixEpochMilliseconds(this long milliseconds)
	{
		return unixEpochStartTime.AddMilliseconds(milliseconds);
	}

	public static TimeSpan ToUnixEpochTime(this DateTime time)
	{
		return time - unixEpochStartTime;
	}

	/// <summary>
	/// <para>Truncates a <see cref="T:System.DateTime" /> to a specified resolution.</para>
	/// <para>A convenient source for resolution is TimeSpan.TicksPerXXXX constants.</para>
	/// </summary>
	/// <remarks>http://stackoverflow.com/questions/1004698/how-to-truncate-milliseconds-off-of-a-net-datetime</remarks>
	/// <param name="date">The <see cref="T:System.DateTime" /> object to truncate</param>
	/// <param name="resolution">e.g. to round to nearest second, TimeSpan.TicksPerSecond</param>
	/// <returns>Truncated <see cref="T:System.DateTime" /></returns>
	private static DateTime Truncate(this DateTime date, long resolution)
	{
		return new DateTime(date.Ticks - date.Ticks % resolution, date.Kind);
	}

	/// <summary>
	/// Truncates the milliseconds on a <see cref="T:System.DateTime" />
	/// </summary>
	/// <param name="date">The <see cref="T:System.DateTime" /> to truncate.</param>
	/// <returns>The <see cref="T:System.DateTime" /> without milliseconds</returns>
	public static DateTime WithoutMilliseconds(this DateTime date)
	{
		return date.Truncate(10000000L);
	}
}
