using System;

namespace Roblox.Platform.Badges;

/// <summary>
/// Badge information
/// </summary>
public class Badge : IBadgeIdentifier
{
	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeIdentifier.Id" />
	public virtual long Id { get; internal set; }

	/// <summary>
	/// The badge name
	/// </summary>
	public virtual string Name { get; internal set; }

	/// <summary>
	/// The badge description
	/// </summary>
	public virtual string Description { get; internal set; }

	/// <summary>
	/// The badge awarder
	/// </summary>
	public virtual IBadgeAwarder Awarder { get; internal set; }

	/// <summary>
	/// The badge Image Asset Id
	/// </summary>
	public virtual long ImageId { get; internal set; }

	/// <summary>
	/// The badge icon
	/// </summary>
	public virtual bool IsEnabled { get; internal set; }

	/// <summary>
	/// When the badge was created
	/// </summary>
	public virtual DateTime Created { get; internal set; }

	/// <summary>
	/// When the badge was updated last time
	/// </summary>
	public virtual DateTime Updated { get; internal set; }
}
