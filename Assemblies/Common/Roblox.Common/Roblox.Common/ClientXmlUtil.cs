using System.Collections.Generic;

namespace Roblox.Common;

public static class ClientXmlUtil
{
	public static string GenerateXmlTable(ICollection<KeyValuePair<object, object>> entries)
	{
		string xml = "<Value><Table>";
		foreach (KeyValuePair<object, object> pair in entries)
		{
			xml += $"<Entry><Key>{pair.Key}</Key><Value>{pair.Value}</Value></Entry>";
		}
		return xml + "</Table></Value>";
	}

	public static string GenerateXmlList(ICollection<object> entries)
	{
		string xml = "<List>";
		foreach (object entry in entries)
		{
			xml += $"<Value>{entry}</Value>";
		}
		return xml + "</List>";
	}

	public static string GenerateXmlBool(bool value)
	{
		return string.Format("<Value Type=\"boolean\">{0}</Value>", value ? "true" : "false");
	}

	public static string GenerateXmlString(string value)
	{
		return $"<Value>{value}</Value>";
	}

	public static string GenerateXmlInteger(int value)
	{
		return $"<Value Type=\"integer\">{value}</Value>";
	}

	public static string GenerateXmlDouble(double value)
	{
		return $"<Value Type=\"number\">{value}</Value>";
	}
}
