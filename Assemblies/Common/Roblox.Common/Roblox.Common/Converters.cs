using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Roblox.Common;

public class Converters
{
	private static ConcurrentDictionary<Type, FieldInfo[]> Fields = new ConcurrentDictionary<Type, FieldInfo[]>();

	private static ConcurrentDictionary<Type, PropertyInfo[]> Properties = new ConcurrentDictionary<Type, PropertyInfo[]>();

	public static string ConvertIntegersToCSV(int[] integers)
	{
		return string.Join(",", Array.ConvertAll(integers, ConvertIntegerToString));
	}

	private static string ConvertIntegerToString(int integer)
	{
		return integer.ToString();
	}

	public static int[] ConvertCSVToIntegers(string input)
	{
		return Array.ConvertAll(input.Split(','), ConvertStringToInteger);
	}

	public static long[] ConvertCSVToLongs(string input)
	{
		return Array.ConvertAll(input.Split(','), ConvertStringToLong);
	}

	private static int ConvertStringToInteger(string s)
	{
		return int.Parse(s);
	}

	private static long ConvertStringToLong(string s)
	{
		return long.Parse(s);
	}

	public static string ConvertObjectsToCSV<T>(IEnumerable<T> objects, bool appendHeader = true)
	{
		StringBuilder sb = new StringBuilder();
		Type type = typeof(T);
		FieldInfo[] fields = null;
		PropertyInfo[] properties = null;
		if (!Fields.ContainsKey(type))
		{
			fields = type.GetFields();
			Fields.TryAdd(type, type.GetFields());
		}
		else if (!Fields.TryGetValue(type, out fields) || fields == null)
		{
			fields = type.GetFields();
		}
		if (!Properties.ContainsKey(type))
		{
			properties = type.GetProperties();
			Properties.TryAdd(type, type.GetProperties());
		}
		else if (!Properties.TryGetValue(type, out properties) || properties == null)
		{
			properties = type.GetProperties();
		}
		if (appendHeader)
		{
			sb.AppendLine(string.Join(",", fields.Select((FieldInfo f) => f.Name).Union(properties.Select((PropertyInfo p) => p.Name))));
		}
		foreach (T obj in objects)
		{
			List<string> filteredStrings = new List<string>();
			T csvRecord = obj;
			IEnumerable<object> collection = fields.Select((FieldInfo f) => f.GetValue(csvRecord));
			IEnumerable<object> propertyValues = properties.Select((PropertyInfo p) => p.GetValue(csvRecord, null));
			List<object> list = new List<object>(collection);
			list.AddRange(propertyValues);
			foreach (object value in list)
			{
				if (value != null)
				{
					if (value is string)
					{
						filteredStrings.Add(string.Format("\"{0}\"", ((string)value).Replace("\"", "\"\"")));
					}
					else
					{
						filteredStrings.Add(value.ToString());
					}
				}
				else
				{
					filteredStrings.Add("NULL");
				}
			}
			sb.AppendLine(string.Join(",", filteredStrings));
		}
		return sb.ToString();
	}

	public static IEnumerable<byte> DistillOrdinalsFromBitMask(ulong bitMask)
	{
		for (int i = 0; i < 64; i++)
		{
			ulong testMask = (ulong)(1L << i);
			if (testMask <= bitMask)
			{
				if ((testMask & bitMask) == testMask)
				{
					yield return (byte)(i + 1);
				}
				continue;
			}
			break;
		}
	}

	public static IEnumerable<T> EnumToList<T>()
	{
		Type enumType = typeof(T);
		if (enumType.BaseType != typeof(Enum))
		{
			throw new ArgumentException("T must be of type System.Enum");
		}
		Array values = Enum.GetValues(enumType);
		List<T> enumValList = new List<T>(values.Length);
		foreach (int item in values)
		{
			enumValList.Add((T)Enum.Parse(enumType, item.ToString()));
		}
		return enumValList;
	}
}
