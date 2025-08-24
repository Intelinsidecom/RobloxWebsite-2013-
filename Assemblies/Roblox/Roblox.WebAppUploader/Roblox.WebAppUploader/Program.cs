using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Roblox.Configuration;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.Platform.StaticContent;
using Roblox.Platform.StaticContent.Properties;
using Roblox.StaticContent.Client;
using Roblox.Web.StaticContent;
using Roblox.Web.StaticContent.Properties;
using Roblox.WebAppUploader.Properties;

namespace Roblox.WebAppUploader;

public class Program
{
	private readonly ILogger _Logger;

	private readonly IStaticContentUploader _StaticContentUploader;

	private readonly IStaticContentClient _StaticContentClient;

	private readonly ISettings _StaticContentSettings;

	private const string _DefaultImagesDirectory = "dist/images";

	private const string _DefaultSourceMapsDirectory = "dist/js";

	public Program(ILogger logger, Func<string> apiKeyGetter, string staticContentServiceEndpoint)
	{
		if (apiKeyGetter == null)
		{
			throw new ArgumentNullException("apiKeyGetter");
		}
		_Logger = logger ?? throw new ArgumentNullException("logger");
		Roblox.WebAppUploader.Properties.Settings staticContentClientSettings = Roblox.WebAppUploader.Properties.Settings.Default;
		if (!string.IsNullOrWhiteSpace(staticContentServiceEndpoint))
		{
			staticContentClientSettings.Endpoint = staticContentServiceEndpoint;
		}
		CounterRegistry counterRegistry = new CounterRegistry();
		StaticContentClient staticContentClient = new StaticContentClient(new HttpClientBuilder(staticContentClientSettings, counterRegistry, apiKeyGetter), staticContentClientSettings);
		StaticContentPlatformSettings platformSettings = new StaticContentPlatformSettings
		{
			ComponentSuffix = GetComponentSuffix()
		};
		_StaticContentClient = staticContentClient;
		_StaticContentSettings = platformSettings;
		_StaticContentUploader = new WebAppUploader(staticContentClient, logger, Roblox.Web.StaticContent.Properties.Settings.Default, platformSettings);
	}

	public static void Main(string[] args)
	{
		ConsoleLogger logger = new ConsoleLogger(() => LogLevel.Verbose);
		ConfigurationLogging.OverrideDefaultConfigurationLogging(delegate(string e)
		{
			logger.Error(e);
		}, delegate
		{
		}, delegate
		{
		});
		if (!args.Any() || !File.Exists(args[0]))
		{
			logger.Error("First argument required to be configuration json file.\nJson expected to contain \"components\" array with \"ComponentConfiguration\" objects inside.\ne.g. {\"components\":[ {\"name\": \"ApiDocumentation\", \"files\": [\"css/dist/apiDocumentationBundle.css\", \"js/dist/apiDocumentationTemplates.js\", \"js/dist/apiDocumentationBundle.js\"] } ]}");
			Environment.Exit(1);
		}
		WebAppUploaderConfiguration webAppUploaderConfiguration;
		try
		{
			webAppUploaderConfiguration = JsonConvert.DeserializeObject<WebAppUploaderConfiguration>(File.ReadAllText(args[0]));
		}
		catch (Exception e2)
		{
			logger.Error($"Failed to parse configuration json.\n{e2}");
			Environment.Exit(1);
			return;
		}
		if (!webAppUploaderConfiguration.Components.Any())
		{
			logger.Warning("No component configurations found in configuration json.\nMake sure \"components\" array has at least one valid configuration item.");
			return;
		}
		string apiKeyString;
		if (Guid.TryParse(webAppUploaderConfiguration.ApiKey, out var apiKey))
		{
			apiKeyString = apiKey.ToString();
		}
		else
		{
			apiKeyString = Roblox.WebAppUploader.Properties.Settings.Default.ApiKey;
		}
		Func<string> apiKeyGetter = () => apiKeyString;
		if (string.IsNullOrWhiteSpace(apiKeyGetter()))
		{
			logger.Error("No ApiKey specified, please check Roblox.WebAppUploader.Properties.Settings.");
			Environment.Exit(1);
		}
		Program program = new Program(logger, apiKeyGetter, webAppUploaderConfiguration.StaticContentServiceEndpoint);
		string imageDir = (string.IsNullOrWhiteSpace(webAppUploaderConfiguration.ImagesDirectory) ? "dist/images" : webAppUploaderConfiguration.ImagesDirectory);
		if (Directory.Exists(imageDir))
		{
			program.UploadImages(imageDir);
		}
		else
		{
			logger.Verbose("No image directory found.");
		}
		string sourceMapDir = (string.IsNullOrWhiteSpace(webAppUploaderConfiguration.SourceMapsDirectory) ? "dist/js" : webAppUploaderConfiguration.SourceMapsDirectory);
		if (Directory.Exists(sourceMapDir))
		{
			program.UploadSourceMaps(sourceMapDir);
		}
		else
		{
			logger.Verbose("No source maps directory found.");
		}
		foreach (ComponentConfiguration componentConfiguration in webAppUploaderConfiguration.Components)
		{
			if (Enum.TryParse<StaticContentComponent>(componentConfiguration.Name, ignoreCase: true, out var component))
			{
				string contentPackName;
				if (string.IsNullOrWhiteSpace(webAppUploaderConfiguration.ContentPackName))
				{
					string componentSuffix = GetComponentSuffix();
					contentPackName = ((!string.IsNullOrWhiteSpace(componentSuffix)) ? $"Custom version of {component} (from {componentSuffix}) {DateTime.Now.ToLongDateString()}" : $"Unnamed content pack for {component} {DateTime.Now.ToLongDateString()}");
				}
				else
				{
					contentPackName = webAppUploaderConfiguration.ContentPackName;
				}
				HashSet<string> translationResourceNamespaces = new HashSet<string>(componentConfiguration.TranslationResourceNamespaces ?? new string[0]);
				ISet<string> componentDependencies = componentConfiguration.ComponentDependencies ?? new HashSet<string>();
				program.Run(component, contentPackName, componentConfiguration.Files, translationResourceNamespaces, componentDependencies);
				continue;
			}
			logger.Error(string.Format("Component name in configuration does not match value in {0}.\n\tName: {1}", "StaticContentComponent", componentConfiguration.Name));
			Environment.Exit(1);
			break;
		}
	}

	public void Run(StaticContentComponent component, string contentPackName, ICollection<string> fileNames, ISet<string> translationResourceNamespaces, ISet<string> componentDependencies)
	{
		_Logger.Verbose(string.Format("Running {0}...\n\tName: {1}\n\tComponent: {2}\n\tFiles:\n\t\t{3}", typeof(Program).Namespace, contentPackName, component, string.Join("\n\t\t", fileNames)));
		List<string> invalidFileNames = fileNames.Where((string f) => !File.Exists(f)).ToList();
		if (invalidFileNames.Any())
		{
			_Logger.Error(string.Format("Invalid files:\n\t{0}", string.Join("\n\t", invalidFileNames)));
			Environment.Exit(1);
		}
		bool isDuplicate = false;
		StaticContentBundles staticContentBundles = new StaticContentBundles();
		staticContentBundles.TranslationResourceNamespaces.UnionWith(translationResourceNamespaces);
		staticContentBundles.CssFileNames.UnionWith(fileNames.Where((string f) => f.EndsWith(".css")));
		staticContentBundles.JavaScriptFileNames.UnionWith(fileNames.Where((string f) => f.EndsWith(".js")));
		_Logger.Verbose(string.Format("Bundling CSS files:\n\t{0}", string.Join("\n\t", staticContentBundles.CssFileNames)));
		_Logger.Verbose(string.Format("Bundling JavaScript files:\n\t{0}", string.Join("\n\t", staticContentBundles.JavaScriptFileNames)));
		if (string.IsNullOrWhiteSpace(_StaticContentSettings.ComponentSuffix))
		{
			try
			{
				isDuplicate = _StaticContentClient.GetContentPacks(component.ToString(), null, null, SortOrder.Desc, null, 1).FirstOrDefault()?.Name == contentPackName;
			}
			catch (Exception e)
			{
				_Logger.Warning($"Failed to check duplication status\n\t{component}\n{e}");
			}
		}
		if (isDuplicate)
		{
			_Logger.Verbose($"Content pack not uploaded - detected duplicated based on git hash ({contentPackName})");
		}
		else
		{
			_StaticContentUploader.RegisterBundles(component, contentPackName, staticContentBundles, componentDependencies);
		}
	}

	private static string GetComponentSuffix()
	{
		return null;
	}

	public void UploadImages(string dirName)
	{
		HashSet<string> imageFileNames = new HashSet<string>((from f in Directory.GetFiles(dirName)
			where Regex.IsMatch(f, "\\.(png|jp(e?)g|svg|webp|gif)$")
			select f).Distinct());
		_Logger.Verbose(string.Format("Uploading Image files:\n\t{0}", string.Join("\n\t", imageFileNames)));
		try
		{
			_StaticContentUploader.RegisterImages(imageFileNames);
		}
		catch (Exception e)
		{
			_Logger.Error($"Failed to Upload Images: {e.Message}");
			Environment.Exit(1);
		}
	}

	public void UploadSourceMaps(string dirName)
	{
		HashSet<string> sourceMapFileNames = new HashSet<string>((from f in Directory.GetFiles(dirName)
			where Regex.IsMatch(f, "\\.(map)$")
			select f).Distinct());
		_Logger.Verbose(string.Format("Uploading sourcemap files:\n\t{0}", string.Join("\n\t", sourceMapFileNames)));
		try
		{
			_StaticContentUploader.RegisterSourceMaps(sourceMapFileNames);
		}
		catch (Exception e)
		{
			_Logger.Error($"Failed to Upload Source Maps: {e.Message}");
			Environment.Exit(1);
		}
	}
}
