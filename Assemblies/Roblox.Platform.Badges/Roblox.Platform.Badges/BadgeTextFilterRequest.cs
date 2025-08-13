using Roblox.TextFilter.Client;

namespace Roblox.Platform.Badges;

/// <summary>
/// Badge text filter request.
/// </summary>
public class BadgeTextFilterRequest
{
	/// <summary>
	/// Badge description
	/// </summary>
	public virtual string Description { get; set; }

	/// <summary>
	/// Badge name
	/// </summary>
	public virtual string Name { get; set; }

	/// <summary>
	/// Badge Text author
	/// </summary>
	public virtual IClientTextAuthor TextAuthor { get; set; }
}
