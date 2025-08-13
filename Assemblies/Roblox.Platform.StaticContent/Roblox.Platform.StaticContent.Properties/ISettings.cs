using System;

namespace Roblox.Platform.StaticContent.Properties;

/// <summary>
/// Settings for StaticContent.
/// </summary>
public interface ISettings
{
	/// <summary>
	/// The temporary cache expiration for reading static content from <see cref="T:Roblox.StaticContent.Client.IStaticContentClient" />.
	/// </summary>
	TimeSpan StaticContentCacheExpiry { get; }

	/// <summary>
	/// The durable cache expiration for reading static content from <see cref="T:Roblox.StaticContent.Client.IStaticContentClient" />.
	/// </summary>
	TimeSpan StaticContentDurableCacheExpiry { get; }

	/// <summary>
	/// A suffix attached to retrievals of static content.
	/// </summary>
	/// <remarks>
	/// Indended purpose: Allow multiple engineers to work on the same WebApp at the same time.
	/// A new component will be created and uploaded to based on this suffix.
	/// If the suffix is null, whitespace, or the content it's tied to is over <see cref="P:Roblox.Platform.StaticContent.Properties.ISettings.ComponentSuffixMaxAge" />
	/// will default to site content.
	/// </remarks>
	string ComponentSuffix { get; }

	/// <summary>
	/// The maximum time content is allowed to be used after uploaded with a specified <see cref="P:Roblox.Platform.StaticContent.Properties.ISettings.ComponentSuffix" />.
	/// </summary>
	/// <remarks>
	/// The idea by putting a cap on the custom content is that the engineer will not get stuck on a version of the
	/// content indefinitely.
	/// If they haven't worked on the content in over this timespan they will be able to use the latest content.
	/// </remarks>
	TimeSpan ComponentSuffixMaxAge { get; }
}
