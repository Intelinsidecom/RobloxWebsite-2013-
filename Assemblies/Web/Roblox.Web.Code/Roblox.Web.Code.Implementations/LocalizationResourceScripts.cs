using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using Roblox.TranslationResources;
using Roblox.Web.Code.Interfaces;

namespace Roblox.Web.Code.Implementations;

public class LocalizationResourceScripts : ILocalizationResourceScripts
{
	private readonly ConcurrentDictionary<string, Lazy<string>> _LanguageResources = new ConcurrentDictionary<string, Lazy<string>>();

	private readonly string _FilePath;

	private static readonly JsonSerializer _JsonSerializer = new JsonSerializer
	{
		Formatting = Formatting.Indented
	};

	public LocalizationResourceScripts(string filePath)
	{
		_FilePath = filePath;
	}

	public string GetScriptFileForResource(ITranslationResources resource)
	{
		string nameSpace = resource.GetType().Namespace?.Replace(".", "_");
		string name = resource.GetType().Name;
		string state = resource.State.ToString().ToLower();
		string key = $"{nameSpace}_{name}_{state}";
		string jsNameSpace = resource.GetFullContentNamespaceName();
		string oldJsNameSpace = resource.GetType().Name.Split('_')[0];
		return _LanguageResources.GetOrAddSafe(key, (string s) => CreateResourceScript(jsNameSpace, oldJsNameSpace, resource.GetAllKeys(), key, _FilePath));
	}

	private string CreateResourceScript(string nameSpace, string oldNameSpace, IReadOnlyDictionary<string, string> resource, string key, string filePath)
	{
		string relativePath = filePath + key + ".js";
		string outputFileAbsolutePath = HttpContext.Current.Server.MapPath(relativePath);
		StringBuilder sb = new StringBuilder();
		sb.AppendLine("var Roblox = Roblox || {};");
		sb.AppendLine("Roblox.Lang = Roblox.Lang || {};");
		try
		{
			string jsonObject = GetSerializedLanguageResources(resource);
			sb.AppendLine($"Roblox.Lang['{nameSpace}'] = {jsonObject};");
			sb.AppendLine($"Roblox.Lang['{oldNameSpace}'] = Roblox.Lang['{nameSpace}'];");
			File.WriteAllText(outputFileAbsolutePath, sb.ToString());
			return relativePath;
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return null;
		}
	}

	private static string GetSerializedLanguageResources(IReadOnlyDictionary<string, string> resource)
	{
		using StringWriter stringWriter = new StringWriter();
		_JsonSerializer.Serialize(stringWriter, resource);
		return stringWriter.ToString();
	}
}
