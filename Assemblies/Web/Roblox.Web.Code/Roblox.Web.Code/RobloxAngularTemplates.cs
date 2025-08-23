using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roblox.Web.Code;

public static class RobloxAngularTemplates
{
	public static readonly StaticBundleUtils.Bundle BaseTemplates;

	public static readonly StaticBundleUtils.Bundle PageTemplates;

	internal static AngularTemplatesManager Manager { get; }

	static RobloxAngularTemplates()
	{
		BaseTemplates = new StaticBundleUtils.Bundle("BaseTemplates");
		PageTemplates = new StaticBundleUtils.Bundle("PageTemplates");
		Manager = new AngularTemplatesManager();
		StaticBundleUtils.ConfigureFileWatcher("~/viewapp", "*.html", "\\js\\m\\", delegate
		{
			lock (Manager.Bundles)
			{
				Manager.Bundles.Clear();
			}
		});
	}

	public static string RenderBaseTemplateBundle()
	{
		ReadOnlyCollection<string> templates = new ReadOnlyCollection<string>(BaseTemplates.ToArray());
		return Manager.RenderTemplateBundle("base", templates);
	}

	public static string RenderPageTemplateBundle()
	{
		ReadOnlyCollection<string> templates = new ReadOnlyCollection<string>(PageTemplates.ToArray());
		return Manager.RenderTemplateBundle("page", templates);
	}

	public static IEnumerable<string> GetBundledTemplates(string namePrefix, IReadOnlyCollection<string> files, Guid? versionNumber = null)
	{
		bool merged = false;
		return Manager.GetBundledTemplates(namePrefix, files, out merged, versionNumber);
	}

	public static string CreateBundle(string namePrefix, IReadOnlyCollection<string> files, bool minifyFiles)
	{
		return Manager.CreateBundle(namePrefix, files, minifyFiles).FileName;
	}
}
