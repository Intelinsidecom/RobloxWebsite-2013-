using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.StaticContent.Properties;
using Roblox.Platform.StaticContent.Client;
using Roblox.Web.StaticContent;
using Roblox.Web.StaticContent.Properties;

namespace Roblox.WebAppUploader;

public class WebAppUploader : Roblox.Web.StaticContent.StaticContentUploader
{
	private const string _BundleDetectorMatch = "Roblox.BundleDetector.bundleDetected";

	public WebAppUploader(Roblox.Platform.StaticContent.Client.IStaticContentClient staticContentClient, ILogger logger, Roblox.Web.StaticContent.Properties.IStaticContentSettings webSettings, ISettings platformSettings)
		: base(staticContentClient, webSettings, platformSettings, logger)
	{
	}

	protected override string BundleCss(string bundleName, ICollection<string> fileNames)
	{
		return BundleFiles(bundleName, fileNames, Roblox.Platform.StaticContent.Client.StaticContentContentType.Css);
	}

	protected override string BundleJavaScript(string bundleName, ICollection<string> fileNames)
	{
		return BundleFiles(bundleName, fileNames, Roblox.Platform.StaticContent.Client.StaticContentContentType.JavaScript);
	}

	private string BundleFiles(string bundleName, ICollection<string> fileNames, Roblox.Platform.StaticContent.Client.StaticContentContentType contentType)
	{
		List<string> fileContents = new List<string>();
		foreach (string fileName in fileNames)
		{
			fileContents.Add(File.ReadAllText(fileName));
		}
		if (fileContents.Any() && contentType == Roblox.Platform.StaticContent.Client.StaticContentContentType.JavaScript && !ContainsBundleDetector(fileContents.Last()))
		{
			fileContents.Add($"/* Bundle detector */{Environment.NewLine}window.Roblox && window.Roblox.BundleDetector && window.Roblox.BundleDetector.bundleDetected(\"{bundleName}\");");
		}
		return string.Join($"{Environment.NewLine}{Environment.NewLine}", fileContents);
	}

	private bool ContainsBundleDetector(string fileContents)
	{
		if (string.IsNullOrWhiteSpace(fileContents))
		{
			return false;
		}
		return fileContents.Trim().Split('\n').Last()
			.Contains("Roblox.BundleDetector.bundleDetected");
	}
}
