using System;

namespace Roblox.Amazon;

public abstract class AttributesBase
{
	public static string ToString(DateTime dateTime)
	{
		return dateTime.ToString("s");
	}

	public static string ToString(float value)
	{
		return value.ToString("000000000.000000000");
	}

	public static string ToString(double value)
	{
		return value.ToString("000000000.000000000");
	}

	public static string ToString(int value)
	{
		return value.ToString("X8");
	}

	public static string ToString(bool value)
	{
		if (!value)
		{
			return "False";
		}
		return "True";
	}

	public static string ToString(long value)
	{
		return value.ToString("X16");
	}

	public void Add(string name, long value)
	{
		Add(name, ToString(value));
	}

	public void AddIfPositive(string name, float value)
	{
		if (value >= 0f)
		{
			Add(name, ToString(value));
		}
	}

	public void AddIfPositive(string name, double value)
	{
		if (value >= 0.0)
		{
			Add(name, ToString(value));
		}
	}

	public void Add(string name, bool value)
	{
		Add(name, ToString(value));
	}

	public void Add(string name, int value)
	{
		Add(name, ToString(value));
	}

	public void Add(string name, DateTime value)
	{
		Add(name, ToString(value));
	}

	public abstract void Add(string name, string value);
}
