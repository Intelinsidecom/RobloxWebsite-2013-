using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Roblox.Configuration;

public class FileBasedSettingsOverrideHelper
{
	public static Dictionary<string, object> ReadOverriddenSettingsFromFilePath(string fileName, Action<string, object[]> errorLogger = null)
	{
		if (string.IsNullOrWhiteSpace(fileName))
		{
			return null;
		}
		string fileContent = null;
		FileStream fileStream = null;
		StreamReader streamReader = null;
		try
		{
			fileStream = File.Open(fileName, FileMode.Open);
			streamReader = new StreamReader(fileStream);
			fileContent = streamReader.ReadToEnd();
		}
		catch (Exception arg)
		{
			errorLogger?.Invoke($"Unable to read file :{fileName} Exception: {arg}", new object[0]);
			return null;
		}
		finally
		{
			streamReader?.Dispose();
			fileStream?.Dispose();
		}
		return ReadOverriddenSettingsFromFileContent(fileContent, errorLogger);
	}

	public static Dictionary<string, object> ReadOverriddenSettingsFromFileContent(string fileContent, Action<string, object[]> errorLogger = null, Action<string, object[]> informationLogger = null)
	{
		if (string.IsNullOrWhiteSpace(fileContent))
		{
			return null;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		try
		{
			foreach (XElement item in XDocument.Parse(fileContent).Descendants("setting"))
			{
				if (!(item.Parent?.Name != null))
				{
					continue;
				}
				string text = string.Format("{0}.{1}", item.Parent.Name, item.Attribute("name")?.Value);
				string text2 = item.Attribute("serializeAs")?.Value;
				if (!string.IsNullOrEmpty(text2))
				{
					if (!string.IsNullOrEmpty(item.Descendants("value").First().Value))
					{
						Type type = Type.GetType(text2);
						if (type != null)
						{
							object obj = Convert.ChangeType(item.Descendants("value").First().Value, type);
							informationLogger?.Invoke($"Reading file based setting-Name:{text} with value:{obj}", new object[0]);
							dictionary[text] = obj;
						}
						else
						{
							errorLogger?.Invoke($"File based override setting:{text} has Invalid type (serializeAs) :{text2}", new object[0]);
						}
					}
					else
					{
						errorLogger?.Invoke($"File based override does not contain a value for setting name:{text}", new object[0]);
					}
				}
				else
				{
					errorLogger?.Invoke($"File based override setting:{text} 'serializeAs' attribute not provided. Skipping", new object[0]);
				}
			}
			return dictionary;
		}
		catch (Exception arg)
		{
			errorLogger?.Invoke($"There was an exception while reading file-based override settings. FileContents:{fileContent} Exception:{arg}", new object[0]);
			return null;
		}
	}
}
