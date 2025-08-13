using System;
using System.Collections.Generic;

namespace Roblox.Platform.Avatar;

public interface IEmoteConfigurationFactory
{
	/// <summary>
	/// Methods to set emote configuration on specific position
	/// </summary>
	void SetEmoteConfiguration(long userId, long assetId, byte position);

	/// <summary>
	/// Methods to set multiple emote configurations with on specific positions
	/// If any of the emotes is unowned during the process, return it as invalid emote
	/// </summary>
	IEnumerable<Tuple<long, byte>> SetEmoteConfigurations(long userId, IEnumerable<Tuple<long, byte>> emotes);

	/// <summary>
	/// Methods to delete emote configuration on specific position
	/// </summary>
	void DeleteEmoteConfiguration(long userId, byte position);

	/// <summary>
	/// Methods to delete multiple emote configurations on specific positions
	/// </summary>
	void DeleteEmoteConfigurations(long userId, IEnumerable<byte> positions);

	/// <summary>
	/// Methods to get all emote configurations on specific user
	/// </summary>
	List<EmoteConfiguration> GetAllEmoteConfigurations(long userId);
}
