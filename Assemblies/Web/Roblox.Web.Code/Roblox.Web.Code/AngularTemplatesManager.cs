using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Roblox.Web.Code.Properties;
using WebMarkupMin.Core;

namespace Roblox.Web.Code;

internal class AngularTemplatesManager
{
	internal readonly ConcurrentDictionary<string, Lazy<string>> Bundles = new ConcurrentDictionary<string, Lazy<string>>();

	private HtmlMinifier _HtmlMinifier;

	private const string _OutputDirectory = "~/js/m/";

	private const string _AppInitFormatStart = "\"use strict\"; angular.module(\"{0}TemplateApp\", []).run(['$templateCache', function($templateCache) {{ ";

	private const string _AppInitFormatEnd = " }]);";

	private const string _TemplateCacheFormat = "$templateCache.put(\"{0}\", \"{1}\");";

	internal Regex _TemplateTagRegex = new Regex("<script [^>]*ng-template[^>]*id=[\"|'](?<id>[a-zA-Z\\-]+)[\"|'][^>]*>(?<html>.*)<\\/script>", RegexOptions.Singleline);

	internal virtual bool MergeTemplates => Settings.Default.MergeAngularTemplates;

	internal virtual bool MinifyTemplates => Settings.Default.MinifyAngularTemplates;

	internal virtual bool PushTemplatesToCdn => Settings.Default.PushAngularTemplatesToCdn;

	internal AngularTemplatesManager()
	{
		_HtmlMinifier = new HtmlMinifier(GetHtmlMinificationSettings());
	}

	private HtmlMinificationSettings GetHtmlMinificationSettings()
	{
		return new HtmlMinificationSettings
		{
			WhitespaceMinificationMode = WhitespaceMinificationMode.Aggressive,
			MinifyAngularBindingExpressions = true
		};
	}

	internal virtual string GetAbsoluteFilePath(string relativeFilePath)
	{
		return HttpContext.Current.Server.MapPath(relativeFilePath);
	}

	internal virtual string ComputeHash(IEnumerable<string> files)
	{
		return StaticBundleUtils.ComputeHashForFiles(files, Settings.Default.AngularTemplateBundleSalt);
	}

	/// <summary>
	/// Given an html template file:
	/// - pull out the angular template id
	/// - remove the wrapping angular script tags so we have the pure html
	/// - remove newlines, so the html can be injected into javascript as a string
	/// </summary>
	/// <param name="content">File contents</param>
	/// <param name="minify"></param>
	/// <param name="templateId">Angular template id, needed for the templateCache key</param>
	/// <returns>Pure html, without newlines</returns>
	internal virtual string ProcessHtmlFile(string content, bool minify, out string templateId)
	{
		templateId = "";
		GroupCollection groups = _TemplateTagRegex.Match(content).Groups;
		templateId = groups["id"].Value;
		string cleanedContent = groups["html"].Value;
		if (minify)
		{
			MarkupMinificationResult result = _HtmlMinifier.Minify(cleanedContent);
			if (result.Errors.Count == 0)
			{
				return result.MinifiedContent.Replace("\"", "\\\"");
			}
			ExceptionHandler.LogException($"Error minifying angular template {templateId}: {GetOutputFromMinifyErrors(result)}");
		}
		return cleanedContent.Replace("\"", "\\\"").RegexReplace("[\\r\\n]+", "");
	}

	/// <summary>
	/// If successful merge: Generates a javascript file that instantiates an angular app (TemplatesApp) and puts the templates into the templatecache
	///
	/// Otherwise returns null
	/// </summary>
	/// <returns>Relative path to the generated file</returns>
	internal virtual BundleCreationResult CreateBundle(string namePrefix, IReadOnlyCollection<string> files, bool minifyFiles, Guid? versionNumber = null)
	{
		try
		{
			string bundleFileName = namePrefix + "_splitApps___" + ComputeHash(files);
			if (versionNumber.HasValue)
			{
				bundleFileName = bundleFileName + "_" + versionNumber.Value;
			}
			if (minifyFiles)
			{
				bundleFileName += "_m";
			}
			string outputFileRelativePath = "~/js/m/" + bundleFileName + ".js";
			string outputFileAbsolutePath = GetAbsoluteFilePath(outputFileRelativePath);
			string bundledContent;
			if (!File.Exists(outputFileAbsolutePath))
			{
				StringBuilder jsFileBuilder = new StringBuilder($"/* Bundle: {bundleFileName} */");
				jsFileBuilder.Append($"\"use strict\"; angular.module(\"{namePrefix}TemplateApp\", []).run(['$templateCache', function($templateCache) {{ ");
				foreach (string relativePath in files)
				{
					string absolutePath = GetAbsoluteFilePath(relativePath);
					if (absolutePath != null)
					{
						string fileContents = File.ReadAllText(absolutePath);
						string templateId = "";
						string processedHtml = ProcessHtmlFile(fileContents, minifyFiles, out templateId);
						jsFileBuilder.Append($"$templateCache.put(\"{templateId}\", \"{processedHtml}\");");
					}
				}
				jsFileBuilder.Append(" }]);");
				bundledContent = jsFileBuilder.ToString();
				File.WriteAllText(outputFileAbsolutePath, bundledContent);
			}
			else
			{
				bundledContent = File.ReadAllText(outputFileAbsolutePath);
			}
			return new BundleCreationResult
			{
				FileName = outputFileRelativePath,
				Contents = bundledContent
			};
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return null;
		}
	}

	internal string GetOrCreateBundleFileName(string name, IReadOnlyCollection<string> fileList, Guid? versionNumber = null)
	{
		StringBuilder keyBuilder = new StringBuilder();
		keyBuilder.Append(name);
		keyBuilder.Append("_");
		if (versionNumber.HasValue)
		{
			keyBuilder.Append(versionNumber.Value);
			keyBuilder.Append("_");
		}
		else if (!string.IsNullOrWhiteSpace(Settings.Default.AngularTemplateBundleSalt))
		{
			keyBuilder.Append(Settings.Default.AngularTemplateBundleSalt);
			keyBuilder.Append("_");
		}
		foreach (string file in fileList)
		{
			keyBuilder.Append(file);
			keyBuilder.Append(',');
		}
		bool minify = MinifyTemplates;
		if (minify)
		{
			keyBuilder.Append("_min");
		}
		string key = keyBuilder.ToString();
		return Bundles.GetOrAddSafe(key, (string s) => CreateBundle(name, fileList, minify, versionNumber)?.FileName);
	}

	/// <summary>
	/// If bundle already exists, returns the file name of the already generated file. If bundle does not exist, creates the bundle and returns
	/// the file path of the newly generated file.
	/// </summary>
	/// <param name="name">Bundle name</param>
	/// <param name="fileList">List of files we need in that bundle. Relative paths.</param>
	/// <param name="merged">Were the files successfully merged</param>
	/// <returns>If merge was successful, we expect to return a single js file. If merge was not successful, we return the original fileList. Relative file paths.</returns>
	internal virtual IReadOnlyCollection<string> GetBundledTemplates(string name, IReadOnlyCollection<string> fileList, out bool merged, Guid? versionNumber = null)
	{
		merged = false;
		List<string> list = new List<string>();
		if (fileList == null || fileList.Count == 0)
		{
			return list;
		}
		string bundledFile = GetOrCreateBundleFileName(name, fileList, versionNumber);
		if (bundledFile != null)
		{
			merged = true;
			bundledFile = ((!PushTemplatesToCdn) ? bundledFile.Replace("~", "") : StaticContentV1.GetUrl(bundledFile));
			list.Add(bundledFile);
			return list;
		}
		return fileList;
	}

	/// <summary>
	/// Outputs a readable string about any minification errors.
	/// </summary>
	private string GetOutputFromMinifyErrors(MarkupMinificationResult minificationResult)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (MinificationErrorInfo error in minificationResult.Errors)
		{
			stringBuilder.AppendLine();
			stringBuilder.AppendLine($"Minify error: {error.Message}");
			stringBuilder.AppendLine("Source fragment:");
			stringBuilder.AppendLine(error.SourceFragment);
		}
		return stringBuilder.ToString();
	}

	/// <summary>
	/// Reads the file provided and appends the file contents to the stringbuilder.
	/// </summary>
	private void RenderTemplatesToDOM(StringBuilder htmlSb, string rawPath)
	{
		try
		{
			string absolutePath = GetAbsoluteFilePath(rawPath);
			if (File.Exists(absolutePath))
			{
				string fileContents = File.ReadAllText(absolutePath);
				htmlSb.AppendLine(fileContents);
			}
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}

	/// <summary>
	/// Formats a $templateCache.put call for each template (that we expect to be printed into the DOM via another part of code).
	/// This method is used if we are not merging templates into a single file.
	/// </summary>
	/// <param name="fileList">List of local html template files</param>
	/// <returns>A string of javascript, which is one $templateCache.put call for each template.</returns>
	internal string AddToTemplateCacheFromDOM(IReadOnlyCollection<string> fileList)
	{
		List<string> templateCacheLines = new List<string>();
		foreach (string file in fileList)
		{
			string absolutePath = GetAbsoluteFilePath(file);
			if (File.Exists(absolutePath))
			{
				string fileContents = File.ReadAllText(absolutePath);
				string templateId = _TemplateTagRegex.Match(fileContents).Groups["id"].Value;
				string line = $"$templateCache.put('{templateId}', $('#{templateId}').html());";
				templateCacheLines.Add(line);
			}
		}
		return string.Join(" ", templateCacheLines);
	}

	/// <summary>
	/// Attempts to bundle the list of templates, and formats the result into the appropriate html tags to be printed out in a page.
	/// </summary>
	/// <param name="name"></param>
	/// <param name="fileList"></param>
	/// <returns>The html that needs to be printed into the page. If template merging was successful, this will be a single javascript script
	/// tag, linking to a generated js file. If template merging was not successful, this will be a javascript script tag followed by the html
	/// templates wrapped in angular script tags.</returns>
	internal string RenderTemplateBundle(string name, IReadOnlyCollection<string> fileList)
	{
		bool merged = false;
		StringBuilder templateHtml = new StringBuilder();
		IReadOnlyCollection<string> finalFiles = ((!MergeTemplates) ? fileList : GetBundledTemplates(name, fileList, out merged));
		if (merged)
		{
			foreach (string filePath2 in finalFiles)
			{
				templateHtml.Append($"<script type=\"text/javascript\" src=\"{filePath2}\"></script>");
			}
		}
		else
		{
			templateHtml.AppendLine("<!-- Template bundle: " + name + " -->");
			templateHtml.AppendLine("<script type=\"text/javascript\">");
			templateHtml.AppendLine($"\"use strict\"; angular.module(\"{name}TemplateApp\", []).run(['$templateCache', function($templateCache) {{ ");
			templateHtml.AppendLine(AddToTemplateCacheFromDOM(finalFiles));
			templateHtml.AppendLine(" }]);");
			templateHtml.AppendLine("</script>");
			foreach (string filePath in finalFiles)
			{
				RenderTemplatesToDOM(templateHtml, filePath);
			}
		}
		return templateHtml.ToString();
	}
}
