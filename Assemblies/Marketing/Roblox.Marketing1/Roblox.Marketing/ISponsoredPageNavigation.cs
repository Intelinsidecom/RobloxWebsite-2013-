namespace Roblox.Platform.Marketing;

/// <summary>
/// An interface for a SponsoredPage navigation.
/// </summary>
public interface ISponsoredPageNavigation
{
	/// <summary>
	/// Gets the name of the sponsored page.
	/// </summary>
	/// <value>
	/// The name of the sponsored page.
	/// </value>
	string Name { get; }

	/// <summary>
	/// Gets the title of the sponsored page.
	/// </summary>
	/// <value>
	/// The title of the sponsored page.
	/// </value>
	string Title { get; }

	/// <summary>
	/// Gets the logo image hash of the sponsored page.
	/// </summary>
	/// <value>
	/// The logo image hash of the sponsored page.
	/// </value>
	string LogoImageHash { get; }

	/// <summary>
	/// Gets the type of the sponsored page.
	/// </summary>
	/// <value>
	/// The type of the sponsored page. Could only be "Event" or "Sponsored"
	/// </value>
	string PageType { get; }

	/// <summary>
	/// Gets the path of the sponsored page.
	/// </summary>
	/// <value>
	/// The path of the sponsored page.
	/// </value>
	string PagePath { get; }
}
