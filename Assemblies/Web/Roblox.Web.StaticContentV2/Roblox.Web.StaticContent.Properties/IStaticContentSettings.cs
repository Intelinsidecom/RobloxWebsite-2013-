using System.Collections.Generic;
using Roblox.Networking;

namespace Roblox.Web.StaticContent.Properties;

/// <summary>
/// Settings for storing/retrieving static content.
/// </summary>
public interface IStaticContentSettings
{
	/// <summary>
	/// Whether or not to minify the CSS during bundling.
	/// </summary>
	bool MinifyCss { get; }

	/// <summary>
	/// Whether or not the minify JavaScript during bundling.
	/// </summary>
	bool MinifyJavaScript { get; }

	/// <summary>
	/// Whether or not to minify the HTML angular templates during bundling.
	/// </summary>
	bool MinifyAngularTemplates { get; }

	/// <summary>
	/// Whether or not metrics Api usage for bundle detection is enabled for all.
	/// </summary>
	bool IsMetricsApiBundleDetectionForAllEnabled { get; }

	/// <summary>
	/// Whether or not metrics Api usage for bundle detection is enabled for soothsayers.
	/// </summary>
	bool IsMetricsApiBundleDetectionForSoothsayersEnabled { get; }

	/// <summary>
	/// Rollout percentage for using metrics Api to report bundle load metrics.
	/// </summary>
	int MetricsApiBundleDetectionRolloutPercentage { get; }

	/// <summary>
	/// Whether or not static content component suffixes should be based on cookies.
	/// </summary>
	bool IsCookieBasedComponentSuffixEnabled { get; }

	/// <summary>
	/// IP address ranges allowed to view invalidated content.
	/// </summary>
	IReadOnlyCollection<IpAddressRange> IpAddressBypassRanges { get; }

	/// <summary>
	/// Whether or not rendering dependencies of components is enabled.
	/// </summary>
	bool ComponentDependencyLoadingEnabled { get; }
}
