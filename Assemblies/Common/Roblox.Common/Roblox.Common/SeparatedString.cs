using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Roblox.Common;

public class SeparatedString<TEnum> where TEnum : struct, IConvertible
{
	public string String { get; private set; }

	private char Separator { get; set; }

	public SeparatedString(string stringToSeparate, char separator = ',')
	{
		if (!typeof(TEnum).IsEnum)
		{
			throw new ArgumentException("Must use an enum type");
		}
		String = stringToSeparate;
		Separator = separator;
	}

	public IEnumerable<TEnum> ParseToEnumerable()
	{
		if (!TryParseToEnumerable(out var result))
		{
			throw new FormatException("String was not valid for this enum");
		}
		return result;
	}

	public IEnumerable<TEnum> SafeParseToEnumerable()
	{
		TryParseToEnumerable(out var result);
		return result;
	}

	/// <summary>
	/// Converts the <see cref="T:Roblox.Common.SeparatedString`1" /> to an IEnumerable of an enum based on the given separator. Discards invalid values. 
	/// </summary>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the enum type is not an enum.</exception>
	public bool TryParseToEnumerable(out IEnumerable<TEnum> validEnums)
	{
		validEnums = new List<TEnum>();
		if (string.IsNullOrEmpty(String))
		{
			return true;
		}
		IEnumerable<TEnum> enumerable = Enum.GetValues(typeof(TEnum)).OfType<TEnum>();
		List<long> listOfLongs = new List<long>();
		List<string> listOfValues = new List<string>();
		foreach (TEnum value in enumerable)
		{
			listOfLongs.Add(value.ToInt64(new NumberFormatInfo()));
			listOfValues.Add(value.ToString());
		}
		List<string> splitString = String.Split(Separator).ToList();
		validEnums = (from csv in splitString.Where(delegate(string csv)
			{
				if (long.TryParse(csv, out var result) && listOfLongs.Contains(result))
				{
					return true;
				}
				return listOfValues.Contains(csv.Trim()) ? true : false;
			})
			select (TEnum)Enum.Parse(typeof(TEnum), csv)).ToList();
		return validEnums.Count() == splitString.Count();
	}
}
