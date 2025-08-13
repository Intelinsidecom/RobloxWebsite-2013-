namespace Roblox.Platform.Avatar;

/// <summary>
/// Public representation of avatar scale
/// </summary>
public interface IAvatarScale
{
	/// <summary>
	/// Height scale
	/// </summary>
	decimal Height { get; }

	/// <summary>
	/// Width scale
	/// </summary>
	decimal Width { get; }

	/// <summary>
	/// Head scale
	/// </summary>
	decimal Head { get; }

	/// <summary>
	/// Scale between 50th percentile male and 50th percentile female proportions
	/// </summary>
	decimal Proportion { get; }

	/// <summary>
	/// Scale between base avatar and anthropomorphic avatar
	/// </summary>
	decimal BodyType { get; }

	/// <summary>
	/// Derived field based on width.
	/// </summary>
	decimal Depth { get; }

	/// <summary>
	/// Whether the scale is the default scale for an avatar
	/// </summary>
	bool IsDefault { get; }
}
