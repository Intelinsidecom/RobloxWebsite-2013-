namespace Roblox.Platform.Games;

/// <summary>
///
/// </summary>
public interface IGameAttributes
{
	/// <summary>
	/// The game attributes' universe Id
	/// </summary>
	long UniverseId { get; }

	/// <summary>
	/// The security status of the game (FilteringEnabled across all places)
	/// </summary>
	bool IsSecure { get; }

	/// <summary>
	/// The trusted status of the game (Have we gone out of our way to approve the game?)
	/// </summary>
	bool IsTrusted { get; }

	/// <summary>
	/// Sets <see cref="P:Roblox.Platform.Games.IGameAttributes.IsSecure" />
	/// </summary>
	/// <param name="isSecure">The value for <see cref="P:Roblox.Platform.Games.IGameAttributes.IsSecure" />.</param>
	void SetIsSecure(bool isSecure);

	/// <summary>
	/// Sets <see cref="P:Roblox.Platform.Games.IGameAttributes.IsTrusted" />
	/// </summary>
	/// <param name="isTrusted">The value for <see cref="P:Roblox.Platform.Games.IGameAttributes.IsTrusted" />.</param>
	void SetIsTrusted(bool isTrusted);
}
