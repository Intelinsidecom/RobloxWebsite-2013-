using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Roblox.Web.Code.Properties;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Web.Code;

public static class RobloxCSS
{
	private static readonly ConcurrentDictionary<string, Lazy<List<string>>> _FilePathArrays;

	public static readonly StaticBundleUtils.Bundle LeanBaseCSS;

	public static readonly StaticBundleUtils.Bundle PageCSS;

	public static readonly StaticBundleUtils.Bundle StudioCSS;

	public static readonly StaticBundleUtils.Bundle MainCSS;

	private static StaticBundleUtils.Bundle ResetCSS;

	private static readonly ConcurrentDictionary<string, Lazy<string>> _Bundles;

	static RobloxCSS()
	{
		_FilePathArrays = new ConcurrentDictionary<string, Lazy<List<string>>>();
		LeanBaseCSS = new StaticBundleUtils.Bundle("LeanBaseCSS");
		PageCSS = new StaticBundleUtils.Bundle("PageCSS");
		StudioCSS = new StaticBundleUtils.Bundle("StudioCSS");
		MainCSS = new StaticBundleUtils.Bundle("MainCSS");
		_Bundles = new ConcurrentDictionary<string, Lazy<string>>();
		StaticBundleUtils.ConfigureFileWatcher("~/CSS", "*.css", "\\CSS\\m\\", delegate
		{
			lock (typeof(RobloxCSS))
			{
				_FilePathArrays.Clear();
				_Bundles.Clear();
			}
		});
	}

	private static List<string> GetMainBundleFiles(HttpRequest request)
	{
		List<string> list = new List<string>(80);
		list.Add("~/CSS/Base/CSS/Roblox.css");
		list.Add("~/CSS/RBXCommon.css");
		string[] baseFiles = (from f in new DirectoryInfo(request.MapPath("~/CSS/Base/CSS/")).GetFiles("*.css")
			where f.Name.ToLower() != "roblox.css" && f.Name.ToLower() != "styleguide.css"
			select "~/CSS/Base/CSS/" + f.Name).ToArray();
		list.AddRange(baseFiles);
		list.Add(Roblox.Web.Code.Properties.Settings.Default.UseVerificationStyleGuide ? "~/CSS/Test/VerificationStyleGuide.css" : "~/CSS/Base/CSS/StyleGuide.css");
		list.Add("~/CSS/Fonts/SourceSansPro.css");
		return list;
	}

	private static void RenderStylesheetTag(StringBuilder sb, string rawPath, Func<string, string> resolveUrl = null, string name = "")
	{
		string href = rawPath;
		if (resolveUrl != null)
		{
			href = resolveUrl(rawPath);
		}
		string bundleNameAttribute = string.Empty;
		if (!string.IsNullOrWhiteSpace(name))
		{
			bundleNameAttribute = $"data-bundlename='{name}'";
		}
		if (Roblox.Web.Code.Properties.Settings.Default.IsAllFilesBundleVerificationEnabled || Roblox.Web.Code.Properties.Settings.Default.IsCssBundleVerificationEnabled)
		{
			sb.AppendLine($"<link onerror='Roblox.BundleDetector && Roblox.BundleDetector.reportBundleError(this)' rel='stylesheet' {bundleNameAttribute} href='{href}' />");
		}
		else
		{
			sb.AppendLine($"<link rel='stylesheet' {bundleNameAttribute} href='{href}' />");
		}
	}

	/// <summary>
	/// Renders the main bundle.
	/// </summary>
	/// <param name="resolveUrl">A function that when given a path, returns an absolute URL.</param>
	/// <returns></returns>
	public static string RenderMainBundle(Func<string, string> resolveUrl = null)
	{
		HttpRequest request = HttpContext.Current.Request;
		string type = request.Browser.Type;
		string browserType = ((!(type == "IE7")) ? "RegularBrowser" : "IE7");
		string fontSource = "StaticCdn";
		string uniqueBundleKey = browserType + fontSource;
		IList<string> files = _FilePathArrays.GetOrAddSafe(uniqueBundleKey, (string s) => GetMainBundleFiles(request));
		return RenderBundle("MainCSS", files.Concat(MainCSS.ToList()), resolveUrl);
	}

	public static string RenderLeanBaseBundle(Func<string, string> resolveUrl = null)
	{
		return RenderBundle("leanbase", LeanBaseCSS, resolveUrl);
	}

	public static string RenderPageBundle(Func<string, string> resolveUrl = null)
	{
		return RenderBundle("page", PageCSS, resolveUrl);
	}

	public static string RenderStudioLayoutBundle(Func<string, string> resolveUrl = null)
	{
		return RenderBundle("studio", StudioCSS, resolveUrl);
	}

	public static string RenderResetCSS(Func<string, string> resolveUrl = null)
	{
		if (ResetCSS != null)
		{
			return RenderBundle("reset", ResetCSS, resolveUrl);
		}
		return string.Empty;
	}

	public static void ApplyResetCSS()
	{
		ResetCSS = new StaticBundleUtils.Bundle("ResetCSS") { "~/CSS/YUIReset.css" };
	}

	/// <summary>
	/// Gets or creates the CSS bundle with the given name and file paths with an optional version number. If the bundle has already been
	/// requested it will not be re-created. When a new bundle is created it is saved on the server and in the temporary store.
	/// </summary>
	/// <param name="name"></param>
	/// <param name="fileList">the paths to the files that will be bundled</param>
	/// <param name="minifyFiles"></param>
	/// <param name="versionNumber"></param>
	/// <returns></returns>
	public static string GetOrCreateBundle(string name, ICollection<string> fileList, bool minifyFiles, Guid? versionNumber = null)
	{
		StringBuilder ksb = new StringBuilder(fileList.Count * 50);
		ksb.Append(name);
		ksb.Append("_");
		foreach (string file in fileList)
		{
			ksb.Append(file);
			ksb.Append(',');
		}
		if (versionNumber.HasValue)
		{
			ksb.Append("_" + versionNumber);
		}
		else if (!string.IsNullOrWhiteSpace(Roblox.Web.Code.Properties.Settings.Default.CssBundleSalt))
		{
			ksb.Append("_" + Roblox.Web.Code.Properties.Settings.Default.CssBundleSalt);
		}
		if (minifyFiles)
		{
			ksb.Append("_min");
		}
		string key = ksb.ToString();
		return _Bundles.GetOrAddSafe(key, (string s) => CreateBundle(name, fileList, minifyFiles, versionNumber)?.FileName);
	}

	public static string RenderAppStyleBundle(string styleUrl)
	{
		StringBuilder stringBuilder = new StringBuilder();
		RenderStylesheetTag(stringBuilder, styleUrl);
		return stringBuilder.ToString();
	}

	/// <summary>
	/// Renders a style (link) tag for WebApp CSS.
	/// </summary>
	/// <remarks>
	/// Intended to replace <see cref="M:Roblox.Web.Code.RobloxCSS.RenderAppStyleBundle(System.String)" /> (used for app sites.)
	/// App sites are being replaced by WebApps.
	/// </remarks>
	/// <param name="cdnUrl">The CDN url.</param>
	/// <param name="webAppComponentName">The WebApp component name.</param>
	/// <returns>The style (link) tag HTML.</returns>
	public static string RenderWebAppStylesheetTag(string cdnUrl, string webAppComponentName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		RenderStylesheetTag(stringBuilder, cdnUrl, null, webAppComponentName);
		return stringBuilder.ToString();
	}

	private static string RenderBundle(string name, IEnumerable<string> fileList, Func<string, string> resolveUrl)
	{
		if (fileList == null)
		{
			return string.Empty;
		}
		string[] files = fileList.ToArray();
		if (files.Length == 0)
		{
			return string.Empty;
		}
		StringBuilder sb = new StringBuilder();
		sb.AppendLine();
		if (!Roblox.WebsiteSettings.Properties.Settings.Default.MergeCSS)
		{
			sb.AppendLine("<!-- CSS bundle: " + name + " -->");
		}
		if (Roblox.WebsiteSettings.Properties.Settings.Default.MergeCSS)
		{
			string includedBundleFile = GetOrCreateBundle(name, files, Roblox.WebsiteSettings.Properties.Settings.Default.MinifyCSS);
			if (includedBundleFile != null)
			{
				string scriptUrl = $"/css/{HttpUtility.UrlEncode(includedBundleFile)}/fetch";
				RenderStylesheetTag(sb, scriptUrl, resolveUrl);
				return sb.ToString();
			}
		}
		string[] array = files;
		for (int i = 0; i < array.Length; i++)
		{
			string rawPath = array[i].Replace("~", "");
			RenderStylesheetTag(sb, rawPath, resolveUrl);
		}
		return sb.ToString();
	}

	public static void SaveToTemporaryStore(string key, string content)
	{
		try
		{
			if (!FilesManager.Singleton.TemporaryStoreManager.Exists(key))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(content);
				FilesManager.Singleton.TemporaryStoreManager.Upload(key, bytes);
				byte[] verificationBytes = FilesManager.Singleton.TemporaryStoreManager.Download(key);
				if (!bytes.SequenceEqual(verificationBytes))
				{
					throw new Exception("Failed verification of CSS upload to the the temporary store! Filename: " + key);
				}
			}
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException("Unable to store CSS to temporary store");
			ExceptionHandler.LogException(ex);
		}
	}

	public static string LoadFromTemporaryStore(string key)
	{
		byte[] bytes = FilesManager.Singleton.TemporaryStoreManager.Download(key);
		if (bytes == null || bytes.Length == 0)
		{
			throw new Exception("Unable to get static file content from TemporaryStore");
		}
		return Encoding.UTF8.GetString(bytes);
	}

	public static BundleCreationResult CreateBundle(string namePrefix, ICollection<string> files, bool minifyFiles, Guid? versionNumber = null)
	{
		try
		{
			string bundleFileName = namePrefix + "___" + StaticBundleUtils.ComputeHashForFiles(files, Roblox.Web.Code.Properties.Settings.Default.CssBundleSalt);
			if (versionNumber.HasValue)
			{
				bundleFileName = bundleFileName + "_" + versionNumber.Value;
			}
			if (minifyFiles)
			{
				bundleFileName += "_m";
			}
			string hashFileName = bundleFileName + ".md5";
			bundleFileName += ".css";
			string cssStorePath = "~/CSS/m/";
			Directory.CreateDirectory(HttpContext.Current.Server.MapPath(cssStorePath));
			string outputFileRelativePath = cssStorePath + bundleFileName;
			string outputFileAbsolutePath = HttpContext.Current.Server.MapPath(outputFileRelativePath);
			string outputFileHashAbsolutePath = HttpContext.Current.Server.MapPath(cssStorePath + hashFileName);
			bool fileHashMissing = Roblox.WebsiteSettings.Properties.Settings.Default.VerifyTemporaryStoreCSSHash && !File.Exists(outputFileHashAbsolutePath);
			string compressedBundle = null;
			if (!File.Exists(outputFileAbsolutePath) || fileHashMissing)
			{
				StringBuilder sb = new StringBuilder();
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
					sb.Append("/* ");
					sb.Append(relativePath);
					sb.Append(" */");
					sb.AppendLine();
					if (minifyFiles)
					{
						if (absolutePath.EndsWith(".min.css"))
						{
							sb.Append(uncompressedContent);
						}
						else
						{
							string minifiedContent = CssMinifyExtensions.CssMinify(uncompressedContent);
							sb.Append(minifiedContent);
						}
					}
					else
					{
						sb.Append(uncompressedContent);
					}
					sb.AppendLine();
				}
				compressedBundle = sb.ToString();
				File.WriteAllText(outputFileAbsolutePath, compressedBundle);
				if (Roblox.WebsiteSettings.Properties.Settings.Default.VerifyTemporaryStoreCSSHash)
				{
					string fileHash = HashFunctions.ComputeMd5HashString(compressedBundle);
					File.WriteAllText(outputFileHashAbsolutePath, fileHash);
				}
			}
			compressedBundle = File.ReadAllText(outputFileAbsolutePath);
			SaveToTemporaryStore(bundleFileName, compressedBundle);
			if (Roblox.WebsiteSettings.Properties.Settings.Default.VerifyTemporaryStoreCSSHash)
			{
				string bundleHash = File.ReadAllText(outputFileHashAbsolutePath);
				SaveToTemporaryStore(hashFileName, bundleHash);
			}
			return new BundleCreationResult
			{
				FileName = bundleFileName,
				Contents = compressedBundle
			};
		}
		catch (Exception ex2)
		{
			ExceptionHandler.LogException(ex2);
			return null;
		}
	}
}
