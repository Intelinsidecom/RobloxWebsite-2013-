using System;
using System.Collections.Generic;

namespace Roblox.Common;

/// <summary>
/// Converts a delimiter separated string to an IEnumerable&lt;T&gt;
/// Cannot be used for Enum types
/// Trims whitespace from the start and end of all values
/// Returns an empty list if passed an empty string
/// </summary>
/// <typeparam name="T"></typeparam>
public class StringTokenizer<T>
{
	private readonly string _StringToSeparate;

	private readonly char _Separator;

	public StringTokenizer(string stringToSeparate, char separator = ',')
	{
		if (typeof(T).IsEnum)
		{
			throw new ArgumentException("Cannot use an enum type");
		}
		_StringToSeparate = stringToSeparate;
		_Separator = separator;
	}

	/// <summary>
	/// Converts the <see cref="T:System.String" /> to an IEnumerable&lt;T&gt; based on the given separator. Throws errors on invalid values.
	/// </summary>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentException">Thrown when an item in the string can't be cast to &lt;T&gt;</exception>
	public IEnumerable<T> Parse()
	{
		List<T> validItems = new List<T>();
		string[] array = _StringToSeparate.Trim().Split(_Separator);
		foreach (string str in array)
		{
			try
			{
				if (str.Trim() != string.Empty)
				{
					T item = (T)Convert.ChangeType(str.Trim(), typeof(T));
					validItems.Add(item);
				}
			}
			catch (Exception ex)
			{
				throw new ArgumentException($"Item '{str}' in separated string could not be cast to type '{typeof(T).FullName}'", ex);
			}
		}
		return validItems;
	}
}
