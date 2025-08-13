using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.StaticContent;
using Roblox.Platform.StaticContent.Properties;
using Roblox.StaticContent.Client;
using Roblox.Web.Code;
using Roblox.Web.StaticContent.Properties;

namespace Roblox.Web.StaticContent;

/// <inheritdoc cref="T:Roblox.Web.StaticContent.IStaticContentUploader" />
public class StaticContentUploader : IStaticContentUploader
{
	private readonly IStaticContentClient _StaticContentClient;

	private readonly IStaticContentSettings _StaticContentSettings;

	private readonly ISettings _PlatformSettings;

	private readonly ILogger _Logger;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.StaticContent.StaticContentUploader" />.
	/// </summary>
	/// <param name="staticContentClient">An <see cref="T:Roblox.StaticContent.Client.IStaticContentClient" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="staticContentClient" />
	/// - <paramref name="logger" />
	/// </exception>
	public StaticContentUploader(IStaticContentClient staticContentClient, ILogger logger)
		: this(staticContentClient, Roblox.Web.StaticContent.Properties.Settings.Default, Roblox.Platform.StaticContent.Properties.Settings.Default, logger)
	{
	}

	internal StaticContentUploader(IStaticContentClient staticContentClient, IStaticContentSettings staticContentSettings, ISettings platformSettings, ILogger logger)
	{
		_StaticContentClient = staticContentClient ?? throw new ArgumentNullException("staticContentClient");
		_StaticContentSettings = staticContentSettings ?? throw new ArgumentNullException("staticContentSettings");
		_PlatformSettings = platformSettings ?? throw new ArgumentNullException("platformSettings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <inheritdoc cref="M:Roblox.Web.StaticContent.IStaticContentUploader.RegisterBundles(Roblox.Platform.StaticContent.StaticContentComponent,System.String,Roblox.Web.StaticContent.IStaticContentBundles,System.Collections.Generic.ISet{System.String})" />
	public void RegisterBundles(StaticContentComponent component, string contentPackName, IStaticContentBundles bundles, ISet<string> componentDependencies)
	{
		if (bundles == null)
		{
			throw new ArgumentNullException("bundles");
		}
		if (componentDependencies == null)
		{
			throw new ArgumentNullException("componentDependencies");
		}
		if (!Enum.IsDefined(typeof(StaticContentComponent), component))
		{
			throw new InvalidEnumArgumentException("component", (int)component, typeof(StaticContentComponent));
		}
		if (string.IsNullOrWhiteSpace(contentPackName))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "contentPackName");
		}
		string bundleName = component.ToString();
		string cssBundle = string.Empty;
		if (bundles.CssFileNames.Any())
		{
			cssBundle = BundleCss(bundleName, bundles.CssFileNames);
		}
		List<string> javascriptBundles = new List<string>();
		if (bundles.AngularTemplateFileNames.Any())
		{
			string templateModulePrefix = bundleName.Substring(0, 1).ToLower() + bundleName.Substring(1) + "Html";
			BundleCreationResult bundle2 = RobloxAngularTemplates.Manager.CreateBundle(templateModulePrefix, bundles.AngularTemplateFileNames.ToList(), _StaticContentSettings.MinifyAngularTemplates);
			if (!string.IsNullOrWhiteSpace(bundle2?.Contents))
			{
				javascriptBundles.Add(bundle2.Contents);
			}
		}
		if (bundles.JavaScriptFileNames.Any())
		{
			string bundle = BundleJavaScript(bundleName, bundles.JavaScriptFileNames);
			if (!string.IsNullOrWhiteSpace(bundle))
			{
				javascriptBundles.Add(bundle);
			}
		}
		string javascriptBundle = string.Join($"{Environment.NewLine}{Environment.NewLine}", javascriptBundles);
		UploadContentPack(contentPackName, component.ToString(), javascriptBundle, cssBundle, bundles.TranslationResourceNamespaces.ToArray(), componentDependencies, _PlatformSettings.ComponentSuffix);
	}

	/// <inheritdoc cref="M:Roblox.Web.StaticContent.IStaticContentUploader.RegisterImages(System.Collections.Generic.ISet{System.String})" />
	public void RegisterImages(ISet<string> images)
	{
		if (images == null)
		{
			throw new ArgumentNullException("images");
		}
		foreach (string imageFile in images)
		{
			byte[] content = File.ReadAllBytes(imageFile);
			UploadImage(Path.GetFileName(imageFile), content);
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.StaticContent.IStaticContentUploader.RegisterSourceMaps(System.Collections.Generic.ISet{System.String})" />
	public void RegisterSourceMaps(ISet<string> sourceMaps)
	{
		if (sourceMaps == null)
		{
			throw new ArgumentNullException("sourceMaps");
		}
		foreach (string sourceMapFile in sourceMaps)
		{
			string content = File.ReadAllText(sourceMapFile);
			UploadSourceMaps(Path.GetFileName(sourceMapFile), content);
		}
	}

	/// <summary>
	/// Responsible for combining all the CSS files and returning the bundled content.
	/// </summary>
	/// <param name="bundleName">The name of the CSS bundle.</param>
	/// <param name="fileNames">The CSS files.</param>
	/// <returns>The merged/bundled contents.</returns>
	protected virtual string BundleCss(string bundleName, ICollection<string> fileNames)
	{
		return RobloxCSS.CreateBundle(bundleName, fileNames, _StaticContentSettings.MinifyCss)?.Contents;
	}

	/// <summary>
	/// Responsible for combining all the JavaScript files and returning the bundled content.
	/// </summary>
	/// <param name="bundleName">The name of the JavaScript bundle.</param>
	/// <param name="fileNames">The JavaScript files.</param>
	/// <returns>The merged/bundled contents.</returns>
	protected virtual string BundleJavaScript(string bundleName, ICollection<string> fileNames)
	{
		return RobloxScripts.CreateBundle(bundleName, fileNames, _StaticContentSettings.MinifyJavaScript)?.Contents;
	}

	private void UploadContentPack(string name, string componentName, string javaScriptContent, string cssContent, string[] translationResourceNamespaces, ISet<string> componentDependencies, string componentSuffix)
	{
		string contentPackInfo = $"\n\tName: {name}";
		contentPackInfo += $"\n\tJavaScript length: {javaScriptContent?.Length}";
		contentPackInfo += $"\n\tCSS length: {cssContent?.Length}";
		contentPackInfo += $"\n\tTranslation Resource Namespaces ({translationResourceNamespaces.Length})";
		foreach (string translationResourceNamespace in translationResourceNamespaces)
		{
			contentPackInfo += $"\n\t\t{translationResourceNamespace}";
		}
		contentPackInfo += $"\n\tComponent Dependencies ({componentDependencies.Count})";
		foreach (string componentDependency in componentDependencies)
		{
			contentPackInfo += $"\n\t\t{componentDependency}";
		}
		if (string.IsNullOrWhiteSpace(javaScriptContent) && string.IsNullOrWhiteSpace(cssContent) && !translationResourceNamespaces.Any())
		{
			_Logger.Warning("Content pack empty (not uploaded.)");
			return;
		}
		try
		{
			StaticContentResult contentPackCreationResult = ((!string.IsNullOrWhiteSpace(componentSuffix)) ? _StaticContentClient.CreateDevelopmentContentPack(componentSuffix, componentName, cssContent, javaScriptContent, translationResourceNamespaces, componentDependencies.ToArray()) : _StaticContentClient.CreateContentPack(name, componentName, cssContent, javaScriptContent, translationResourceNamespaces, componentDependencies.ToArray()));
			if (contentPackCreationResult == StaticContentResult.Created)
			{
				_Logger.Verbose($"Content pack created.{contentPackInfo}");
			}
			else
			{
				_Logger.Warning($"Unknown content pack creation result: {contentPackCreationResult}{contentPackInfo}");
			}
		}
		catch (Exception e)
		{
			_Logger.Error($"Failed to create content pack.{contentPackInfo}\n{e}");
		}
	}

	private void UploadImage(string fileName, byte[] contents)
	{
		switch (_StaticContentClient.UploadImage(fileName, contents).Result)
		{
		case StaticContentResult.Duplicate:
			_Logger.Verbose($"Image not uploaded because it already exists. {fileName}");
			break;
		case StaticContentResult.Created:
			_Logger.Verbose($"Image uploaded. {fileName}");
			break;
		}
	}

	private void UploadSourceMaps(string filename, string contents)
	{
		switch (_StaticContentClient.UploadSourceMap(filename, contents).Result)
		{
		case StaticContentResult.Duplicate:
			_Logger.Verbose($"Source Map not uploaded because it already exists. {filename}");
			break;
		case StaticContentResult.Created:
			_Logger.Verbose($"Source Map uploaded. {filename}");
			break;
		}
	}
}
