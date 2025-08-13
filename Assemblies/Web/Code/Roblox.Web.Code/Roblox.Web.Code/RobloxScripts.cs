using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.Ajax.Utilities;
using Roblox.Web.Code.Properties;
using Roblox.Web.Properties;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Web.Code;

public static class RobloxScripts
{
	private struct CdnLibrary
	{
		public string CdnPath;

		public string LocalPath;

		public string Test;
	}

	private const string _JQueryVersion = "1.7.2";

	private const string _JQueryVersionLatest = "1.11.1";

	private const string _JQueryMigrateVersion = "1.2.1";

	private static readonly ConcurrentDictionary<string, Lazy<string>> _Bundles;

	public static readonly StaticBundleUtils.Bundle BaseScripts;

	public static readonly StaticBundleUtils.Bundle PageScripts;

	public static readonly StaticBundleUtils.Bundle PageEndScripts;

	private static readonly CdnLibrary _JQueryLibrary;

	private static readonly CdnLibrary _JQueryLibraryLatest;

	private static readonly CdnLibrary _JQueryLibraryLatestMigrate;

	private static readonly CdnLibrary _MicrosoftAjax;

	private static bool _IsBundleDetectionEnabled
	{
		get
		{
			if (!Roblox.Web.Code.Properties.Settings.Default.IsJavascriptBundleVerificationEnabled)
			{
				return Roblox.Web.Code.Properties.Settings.Default.IsAllFilesBundleVerificationEnabled;
			}
			return true;
		}
	}

	private static bool _IsJsBundleHasErrorDetectionEnabled => Roblox.Web.Code.Properties.Settings.Default.IsJsBundleHasErrorDetectionEnabled;

	static RobloxScripts()
	{
		_Bundles = new ConcurrentDictionary<string, Lazy<string>>();
		BaseScripts = new StaticBundleUtils.Bundle("BaseScripts");
		PageScripts = new StaticBundleUtils.Bundle("PageScripts");
		PageEndScripts = new StaticBundleUtils.Bundle("PageEndScripts");
		_JQueryLibrary = new CdnLibrary
		{
			LocalPath = "/js/jquery/jquery-1.7.2.min.js",
			CdnPath = "//ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.2.min.js",
			Test = "window.jQuery"
		};
		_JQueryLibraryLatest = new CdnLibrary
		{
			LocalPath = "/js/jquery/jquery-1.11.1.js",
			CdnPath = "//ajax.aspnetcdn.com/ajax/jQuery/jquery-1.11.1.min.js",
			Test = "window.jQuery"
		};
		_JQueryLibraryLatestMigrate = new CdnLibrary
		{
			LocalPath = "/js/jquery/jquery-migrate-1.2.1.js",
			CdnPath = "//ajax.aspnetcdn.com/ajax/jquery.migrate/jquery-migrate-1.2.1.min.js",
			Test = "window.jQuery"
		};
		_MicrosoftAjax = new CdnLibrary
		{
			LocalPath = "/js/Microsoft/MicrosoftAjax.js",
			CdnPath = "//ajax.aspnetcdn.com/ajax/4.0/1/MicrosoftAjax.js",
			Test = "window.Sys"
		};
		StaticBundleUtils.ConfigureFileWatcher("~/js", "*.js", "\\js\\m\\", delegate
		{
			lock (_Bundles)
			{
				_Bundles.Clear();
			}
		});
		StaticBundleUtils.ConfigureFileWatcher("~/viewapp", "*.js", "\\js\\m\\", delegate
		{
			lock (_Bundles)
			{
				_Bundles.Clear();
			}
		});
	}

	private static void AddCdnLibrary(CdnLibrary lib)
	{
		List<CdnLibrary> cdns = GetCdnScripts();
		if (!cdns.Contains(lib))
		{
			cdns.Add(lib);
		}
	}

	public static void AddJQuery()
	{
		if (Roblox.Web.Properties.Settings.Default.jQueryVersionLatest)
		{
			AddJQueryLatest();
		}
		else
		{
			AddCdnLibrary(_JQueryLibrary);
		}
	}

	public static void AddJQueryLatest()
	{
		AddCdnLibrary(_JQueryLibraryLatest);
		AddCdnLibrary(_JQueryLibraryLatestMigrate);
	}

	public static void AddMicrosoftAjax()
	{
		AddCdnLibrary(_MicrosoftAjax);
	}

	public static void RenderScriptTagsForCdn(StringBuilder sb, string cdnPath, string testJavascriptLoaded, string localPath)
	{
		RenderScriptTag(sb, cdnPath);
		sb.AppendLine("<script type='text/javascript'>" + testJavascriptLoaded + " || document.write(\"<script type='text/javascript' src='" + localPath + "'><\\/script>\")</script>");
	}

	public static void RenderScriptTag(StringBuilder sb, string rawPath, string name = "", bool skipMonitoring = false)
	{
		if (_IsBundleDetectionEnabled)
		{
			bool shouldMonitor = _IsJsBundleHasErrorDetectionEnabled && Roblox.WebsiteSettings.Properties.Settings.Default.MergeJavaScriptFiles && !skipMonitoring;
			sb.AppendLine("<script onerror='Roblox.BundleDetector && Roblox.BundleDetector.reportBundleError(this)' " + (shouldMonitor ? "data-monitor='true' " : " ") + ((shouldMonitor && !string.IsNullOrWhiteSpace(name)) ? $"data-bundlename='{name}' " : " ") + $"type='text/javascript' src='{rawPath}'></script>");
		}
		else
		{
			sb.AppendLine("<script type='text/javascript' src='" + rawPath + "'></script>");
		}
	}

	public static string GetOrCreateBundleFileName(string name, ICollection<string> files, bool minifyFiles, Guid? versionNumber = null)
	{
		StringBuilder keyBuilder = new StringBuilder();
		keyBuilder.Append(name);
		keyBuilder.Append("_");
		if (versionNumber.HasValue)
		{
			keyBuilder.Append(versionNumber.Value);
			keyBuilder.Append("_");
		}
		else if (!string.IsNullOrWhiteSpace(Roblox.Web.Code.Properties.Settings.Default.JavascriptBundleSalt))
		{
			keyBuilder.Append(Roblox.Web.Code.Properties.Settings.Default.JavascriptBundleSalt);
			keyBuilder.Append("_");
		}
		foreach (string file in files)
		{
			keyBuilder.Append(file);
			keyBuilder.Append(',');
		}
		if (minifyFiles)
		{
			keyBuilder.Append("_min");
		}
		string key = keyBuilder.ToString();
		return _Bundles.GetOrAddSafe(key, (string s) => CreateBundle(name, files, minifyFiles, versionNumber)?.FileName);
	}

	public static IEnumerable<string> GetBundledScripts(string name, IEnumerable<string> fileList, Guid? versionNumber = null)
	{
		List<string> list = new List<string>();
		if (fileList == null)
		{
			return list;
		}
		string[] files = fileList.ToArray();
		if (files.Length == 0)
		{
			return list;
		}
		if (Roblox.WebsiteSettings.Properties.Settings.Default.MergeJavaScriptFiles)
		{
			string includedBundleFile = GetOrCreateBundleFileName(name, files, Roblox.WebsiteSettings.Properties.Settings.Default.MinifyJavaScriptFiles, versionNumber);
			if (includedBundleFile != null)
			{
				includedBundleFile = ((!Roblox.WebsiteSettings.Properties.Settings.Default.PushJavaScriptFilesToS3) ? includedBundleFile.Replace("~", "") : StaticContentV1.GetUrl(includedBundleFile));
				list.Add(includedBundleFile);
				return list;
			}
		}
		IEnumerable<string> rawFiles = files.Select((string f) => f.Replace("~", ""));
		list.AddRange(rawFiles);
		return list;
	}

	public static string RenderScriptBundle(string name, IEnumerable<string> fileList)
	{
		IEnumerable<string> bundledScripts = GetBundledScripts(name, fileList);
		StringBuilder sb = new StringBuilder();
		if (!Roblox.WebsiteSettings.Properties.Settings.Default.MergeJavaScriptFiles)
		{
			sb.AppendLine("<!-- Script bundle: " + name + " -->");
		}
		foreach (string filePath in bundledScripts)
		{
			RenderScriptTag(sb, filePath, name);
		}
		return sb.ToString();
	}

	public static string RenderAppScriptBundle(string scriptUrl, string name = "", bool skipMonitoring = false)
	{
		if (string.IsNullOrEmpty(scriptUrl))
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		RenderScriptTag(stringBuilder, scriptUrl, name, skipMonitoring);
		return stringBuilder.ToString();
	}

	/// <summary>
	/// Renders a script tag for WebApp JavaScript.
	/// </summary>
	/// <remarks>
	/// Intended to replace <see cref="M:Roblox.Web.Code.RobloxScripts.RenderAppScriptBundle(System.String,System.String,System.Boolean)" /> (used for app sites.)
	/// App sites are being replaced by WebApps.
	/// </remarks>
	/// <param name="cdnUrl">The CDN url.</param>
	/// <param name="webAppComponentName">The WebApp component name.</param>
	/// <returns>The script tag HTML (or <c>null</c> if <paramref name="cdnUrl" /> is <c>null</c>.)</returns>
	public static string RenderWebAppScriptTag(string cdnUrl, string webAppComponentName)
	{
		if (string.IsNullOrWhiteSpace(cdnUrl))
		{
			return null;
		}
		return RenderAppScriptBundle(cdnUrl, webAppComponentName);
	}

	public static string GetScriptBundleCdnPath(string name, IEnumerable<string> fileList)
	{
		if (!Roblox.WebsiteSettings.Properties.Settings.Default.MergeJavaScriptFiles)
		{
			return null;
		}
		return GetBundledScripts(name, fileList).FirstOrDefault();
	}

	public static string RenderModuleConfigs(params string[] externalResources)
	{
		string[] files = Directory.EnumerateFiles(HttpContext.Current.Server.MapPath("~/js/modules"), "*.js", SearchOption.AllDirectories).Select(GetVirtualPath).ToArray();
		if (files.Length == 0 && externalResources.Length == 0)
		{
			return string.Empty;
		}
		bool minifyFiles = Roblox.WebsiteSettings.Properties.Settings.Default.MinifyJavaScriptFiles;
		StringBuilder sb = new StringBuilder();
		sb.Append("<script type='text/javascript'>");
		sb.AppendFormat("Roblox.config.externalResources = [{0}];", string.Join(",", externalResources.Select((string s) => "'" + s + "'")));
		string[] array = files;
		foreach (string file in array)
		{
			StringBuilder moduleNameBuilder = new StringBuilder(file);
			moduleNameBuilder.Replace("~/js/modules/", "");
			moduleNameBuilder.Replace(".js", "");
			moduleNameBuilder.Replace("/", ".");
			string moduleName = moduleNameBuilder.ToString();
			StringBuilder keyBuilder = new StringBuilder();
			keyBuilder.Append(moduleName);
			keyBuilder.Append(file);
			if (minifyFiles)
			{
				keyBuilder.Append("_min");
			}
			string key = keyBuilder.ToString();
			string[] f = new string[1] { file };
			if (Roblox.WebsiteSettings.Properties.Settings.Default.MergeJavaScriptFiles)
			{
				string includedBundleFile = _Bundles.GetOrAddSafe(key, (string s) => CreateBundle(moduleName.Replace(".", "___"), f, minifyFiles)?.FileName);
				if (includedBundleFile != null)
				{
					includedBundleFile = ((!Roblox.WebsiteSettings.Properties.Settings.Default.PushJavaScriptFilesToS3) ? includedBundleFile.Replace("~", "") : StaticContentV1.GetUrl(includedBundleFile));
				}
				sb.AppendFormat("Roblox.config.paths['{0}'] = '{1}';", moduleName, includedBundleFile);
			}
			else
			{
				sb.AppendFormat("Roblox.config.paths['{0}'] = '{1}';", moduleName, file.Replace("~/js", "/js"));
			}
		}
		sb.Append("</script>");
		return sb.ToString();
	}

	public static string RenderCdnScripts()
	{
		List<CdnLibrary> cdnScripts = GetCdnScripts();
		StringBuilder sb = new StringBuilder();
		foreach (CdnLibrary s in cdnScripts)
		{
			if (Roblox.WebsiteSettings.Properties.Settings.Default.UseCdnForJavaScriptLibraries)
			{
				RenderScriptTagsForCdn(sb, s.CdnPath, s.Test, s.LocalPath);
			}
			else
			{
				RenderScriptTag(sb, s.LocalPath);
			}
		}
		return sb.ToString();
	}

	private static string GetVirtualPath(string physicalPath)
	{
		string rootPath = HttpContext.Current.Server.MapPath("~/");
		return physicalPath.Replace(rootPath, "~/").Replace("\\", "/");
	}

	/// <summary>
	/// Generates the minified file that is stored on the web server, before it is uploaded to S3/the CDN.
	/// Generally you want to use RenderScriptBundle or GetBundledScripts; this method is only provided for 
	/// rare cases where the JS must be served from a roblox.com domain.
	/// </summary>
	/// <param name="namePrefix">The name of the bundle.</param>
	/// <param name="files">The list of filepaths to bundle.</param>
	/// <param name="minifyFiles">Whether to minify the files.</param>
	/// <returns>The relative path of the bundled JS.</returns>
	public static BundleCreationResult CreateBundle(string namePrefix, ICollection<string> files, bool minifyFiles, Guid? versionNumber = null)
	{
		try
		{
			string bundleFileName = namePrefix + "___" + StaticBundleUtils.ComputeHashForFiles(files, Roblox.Web.Code.Properties.Settings.Default.JavascriptBundleSalt);
			if (versionNumber.HasValue)
			{
				bundleFileName = bundleFileName + "_" + versionNumber.Value;
			}
			Console.WriteLine("test --" + bundleFileName);
			if (minifyFiles)
			{
				bundleFileName += "_m";
			}
			string outputFileRelativePath = "~/js/m/" + bundleFileName + ".js";
			string outputFileAbsolutePath = HttpContext.Current.Server.MapPath(outputFileRelativePath);
			string bundleContents;
			if (!File.Exists(outputFileAbsolutePath))
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(";// bundle: ");
				sb.AppendLine(bundleFileName);
				sb.Append(";// files: ");
				sb.AppendLine(string.Join(", ", files.Select((string f) => f.Replace("~/js/", ""))));
				foreach (string relativePath in files)
				{
					string absolutePath = HttpContext.Current.Server.MapPath(relativePath);
					if (absolutePath == null)
					{
						continue;
					}
					string uncompressedContent = "";
					try
					{
						uncompressedContent = File.ReadAllText(absolutePath);
					}
					catch (FileNotFoundException ex)
					{
						ExceptionHandler.LogException(ex);
						continue;
					}
					sb.AppendLine();
					sb.Append(";// ");
					sb.AppendLine(relativePath.Replace("~/js/", ""));
					if (minifyFiles)
					{
						if (absolutePath.EndsWith(".min.js"))
						{
							sb.Append(uncompressedContent);
						}
						else
						{
							string contentToWrite = new Minifier().MinifyJavaScript(uncompressedContent, new CodeSettings
							{
								TermSemicolons = true
							});
							sb.Append(contentToWrite);
						}
					}
					else
					{
						sb.Append(uncompressedContent);
					}
					sb.AppendLine();
				}
				if (_IsJsBundleHasErrorDetectionEnabled)
				{
					sb.AppendLine();
					sb.Append(";//Bundle detector");
					sb.AppendLine();
					sb.Append($"Roblox && Roblox.BundleDetector && Roblox.BundleDetector.bundleDetected('{namePrefix}');");
				}
				bundleContents = sb.ToString();
				File.WriteAllText(outputFileAbsolutePath, bundleContents);
			}
			else
			{
				bundleContents = File.ReadAllText(outputFileAbsolutePath);
			}
			return new BundleCreationResult
			{
				FileName = outputFileRelativePath,
				Contents = bundleContents
			};
		}
		catch (Exception ex2)
		{
			ExceptionHandler.LogException(ex2);
			return null;
		}
	}

	private static List<CdnLibrary> GetCdnScripts()
	{
		return StaticBundleUtils.GetRequestScopedVariable<List<CdnLibrary>>("CdnScripts");
	}
}
