using System;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Represents a configuration of a specified emote to a position
/// </summary>
[Serializable]
public class EmoteConfiguration
{
	/// <summary>
	/// The emote asset id
	/// </summary>
	public long AssetId { get; }

	/// <summary>
	/// The position of the equipped emote
	/// </summary>
	public byte Position { get; }

	internal EmoteConfiguration(IEmoteConfigurationEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		AssetId = entity.AssetId;
		Position = entity.Position;
	}
}
