using System;
using System.Collections.Generic;
using System.Globalization;
using Amazon.SimpleDB.Model;

namespace Roblox.Amazon;

public class Attributes : AttributesBase
{
	internal readonly List<global::Amazon.SimpleDB.Model.Attribute> list;

	internal Attributes(List<global::Amazon.SimpleDB.Model.Attribute> list)
	{
		this.list = list;
	}

	public Attributes()
	{
		list = new List<global::Amazon.SimpleDB.Model.Attribute>();
	}

	public string GetString(string name)
	{
		foreach (global::Amazon.SimpleDB.Model.Attribute a in list)
		{
			if (a.Name == name)
			{
				return a.Value;
			}
		}
		return null;
	}

	public int? GetInt(string name)
	{
		foreach (global::Amazon.SimpleDB.Model.Attribute a in list)
		{
			if (a.Name == name)
			{
				return int.Parse(a.Value, NumberStyles.HexNumber);
			}
		}
		return null;
	}

	public int GetInt(string name, int defaultValue)
	{
		foreach (global::Amazon.SimpleDB.Model.Attribute a in list)
		{
			if (a.Name == name)
			{
				return int.Parse(a.Value, NumberStyles.HexNumber);
			}
		}
		return defaultValue;
	}

	public string GetIntAsString(string name)
	{
		foreach (global::Amazon.SimpleDB.Model.Attribute a in list)
		{
			if (a.Name == name)
			{
				return int.Parse(a.Value, NumberStyles.HexNumber).ToString();
			}
		}
		return null;
	}

	public DateTime? GetDate(string name)
	{
		foreach (global::Amazon.SimpleDB.Model.Attribute a in list)
		{
			if (a.Name == name)
			{
				return DateTime.Parse(a.Value);
			}
		}
		return null;
	}

	public IEnumerable<string> GetStrings(string name)
	{
		foreach (global::Amazon.SimpleDB.Model.Attribute a in list)
		{
			if (a.Name == name)
			{
				yield return a.Value;
			}
		}
	}

	public override void Add(string name, string value)
	{
		global::Amazon.SimpleDB.Model.Attribute attr = new global::Amazon.SimpleDB.Model.Attribute();
		attr.Name = name;
		attr.Value = value;
		list.Add(attr);
	}

	/// <summary>
	/// Add empty attribute (used for deletion)
	/// </summary>
	public void Add(string name)
	{
		global::Amazon.SimpleDB.Model.Attribute attr = new global::Amazon.SimpleDB.Model.Attribute();
		attr.Name = name;
		list.Add(attr);
	}

	public double GetDouble(string name, double defaultValue)
	{
		foreach (global::Amazon.SimpleDB.Model.Attribute a in list)
		{
			if (a.Name == name)
			{
				return double.Parse(a.Value);
			}
		}
		return defaultValue;
	}

	public double? GetDouble(string name)
	{
		foreach (global::Amazon.SimpleDB.Model.Attribute a in list)
		{
			if (a.Name == name)
			{
				return double.Parse(a.Value);
			}
		}
		return null;
	}
}
