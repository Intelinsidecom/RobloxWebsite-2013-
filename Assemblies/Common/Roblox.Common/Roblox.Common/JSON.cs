namespace Roblox.Common;

public static class JSON
{
	public static string WriteError(string message)
	{
		return $"{{\"Error\" : \"{message}\"}}";
	}

	public static string WriteProperty(string propertyName, string propertyValue)
	{
		return $"{{\"{propertyName}\" : \"{propertyValue}\"}}";
	}

	public static string AddListToJSONObject(string jsonString, string propertyName, string propertyValue)
	{
		if (!jsonString.Contains("{") && !jsonString.Contains("}") && !jsonString.Contains("[") && !jsonString.Contains("]"))
		{
			jsonString = "{" + jsonString + "}";
		}
		bool isListForm = false;
		if (jsonString.StartsWith("[") && jsonString.EndsWith("]"))
		{
			isListForm = true;
			jsonString = jsonString.Remove(0, 1);
			jsonString = jsonString.Remove(jsonString.Length - 1);
		}
		string newProp = $"\"{propertyName}\" : {propertyValue}";
		if (!isListForm)
		{
			jsonString = jsonString.Remove(jsonString.Length - 1);
			if (jsonString.Length != 1)
			{
				jsonString += ",";
			}
			jsonString = jsonString + newProp + "}";
		}
		else
		{
			if (jsonString.Length != 0)
			{
				jsonString += ",";
			}
			jsonString += newProp;
		}
		if (isListForm)
		{
			jsonString = "[" + jsonString + "]";
		}
		return jsonString;
	}

	public static string AddObjectToJSONObject(string jsonString, string propertyName, string propertyValue)
	{
		if (!jsonString.Contains("{") && !jsonString.Contains("}") && !jsonString.Contains("[") && !jsonString.Contains("]"))
		{
			jsonString = "{" + jsonString + "}";
		}
		bool isListForm = false;
		if (jsonString.StartsWith("[") && jsonString.EndsWith("]"))
		{
			isListForm = true;
			jsonString = jsonString.Remove(0, 1);
			jsonString = jsonString.Remove(jsonString.Length - 1);
		}
		string newProp = $"\"{propertyName}\" : {propertyValue}";
		if (!isListForm)
		{
			jsonString = jsonString.Remove(jsonString.Length - 1);
			if (jsonString.Length != 1)
			{
				jsonString += ",";
			}
			jsonString = jsonString + newProp + "}";
		}
		else
		{
			if (jsonString.Length != 0)
			{
				jsonString += ",";
			}
			jsonString += newProp;
		}
		if (isListForm)
		{
			jsonString = "[" + jsonString + "]";
		}
		return jsonString;
	}

	public static string AddPropertyToJSONObject(string jsonString, string propertyName, string propertyValue)
	{
		if (!jsonString.Contains("{") && !jsonString.Contains("}") && !jsonString.Contains("[") && !jsonString.Contains("]"))
		{
			jsonString = "{" + jsonString + "}";
		}
		bool isListForm = false;
		if (jsonString.StartsWith("[") && jsonString.EndsWith("]"))
		{
			isListForm = true;
			jsonString = jsonString.Remove(0, 1);
			jsonString = jsonString.Remove(jsonString.Length - 1);
		}
		string newProp = $"\"{propertyName}\" : \"{propertyValue}\"";
		if (!isListForm)
		{
			jsonString = jsonString.Remove(jsonString.Length - 1);
			if (jsonString.Length != 1)
			{
				jsonString += ",";
			}
			jsonString = jsonString + newProp + "}";
		}
		else
		{
			if (jsonString.Length != 0)
			{
				jsonString += ",";
			}
			jsonString += newProp;
		}
		if (isListForm)
		{
			jsonString = "[" + jsonString + "]";
		}
		return jsonString;
	}
}
