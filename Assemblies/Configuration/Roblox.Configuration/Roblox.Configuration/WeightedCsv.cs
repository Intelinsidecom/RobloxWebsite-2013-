using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;

namespace Roblox.Configuration;

[TypeConverter(typeof(WeightedCsvConverter))]
[SettingsSerializeAs(SettingsSerializeAs.Xml)]
public class WeightedCsv
{
	public string Source { get; }

	public IReadOnlyCollection<WeightedValue> WeightedValues { get; }

	public string GetDescription()
	{
		IReadOnlyCollection<WeightedValue> weightedValues = WeightedValues;
		if (weightedValues == null || weightedValues.Count == 0)
		{
			return "Empty list of values.";
		}
		int num = 0;
		foreach (WeightedValue item in weightedValues)
		{
			num += item.Weight;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < weightedValues.Count; i++)
		{
			string value = weightedValues.ElementAt(i).Value;
			string arg = ((num == 0) ? "NaN" : $"{(double)weightedValues.ElementAt(i).Weight / (double)num:0%}");
			list.Add($"{value}:{arg}");
		}
		return string.Join(",", list);
	}

	public WeightedCsv(string weightedCsv)
	{
		Source = weightedCsv;
		WeightedValues = (IReadOnlyCollection<WeightedValue>)(object)ParseConfiguration(weightedCsv);
	}

	private WeightedValue[] ParseConfiguration(string weightedCsv)
	{
		if (string.IsNullOrEmpty(weightedCsv))
		{
			return new WeightedValue[0];
		}
		return weightedCsv.Split(new char[1] { ',' }).Select(ParseEntry).ToArray();
	}

	private WeightedValue ParseEntry(string weightedValue)
	{
		Match match = null;
		try
		{
			match = Regex.Match(weightedValue, "^(.*):([0-9]+)$");
		}
		catch (Exception arg)
		{
			throw new WeightedCsvParseException($"Error in parsing entry: \"{weightedValue}\" - {arg}");
		}
		if (match == null || !match.Success)
		{
			throw new WeightedCsvParseException($"Entry did not contain value or weight: \"{weightedValue}\"");
		}
		string value = match.Groups[1].Value;
		if (!int.TryParse(match.Groups[2].Value, out var result))
		{
			throw new WeightedCsvParseException($"Entry did not contain weight: \"{weightedValue}\"");
		}
		if (result < 0)
		{
			throw new WeightedCsvParseException($"The weight must be a non-negative number: \"{weightedValue}\"");
		}
		return new WeightedValue(value, result);
	}
}
