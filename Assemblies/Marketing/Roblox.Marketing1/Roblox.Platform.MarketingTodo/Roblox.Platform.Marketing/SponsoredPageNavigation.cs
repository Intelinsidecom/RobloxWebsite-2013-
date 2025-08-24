namespace Roblox.Platform.Marketing;

/// <inheritdoc cref="T:Roblox.Platform.Marketing.ISponsoredPageNavigation" />
internal class SponsoredPageNavigation : ISponsoredPageNavigation
{
	/// <inheritdoc cref="P:Roblox.Platform.Marketing.ISponsoredPageNavigation.Name" />
	public string Name { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Marketing.ISponsoredPageNavigation.Title" />
	public string Title { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Marketing.ISponsoredPageNavigation.LogoImageHash" />
	public string LogoImageHash { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Marketing.ISponsoredPageNavigation.PageType" />
	public string PageType { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Marketing.ISponsoredPageNavigation.PagePath" />
	public string PagePath { get; set; }
}
