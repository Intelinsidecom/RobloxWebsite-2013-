using System;
using System.Collections.Generic;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Defines the interface for storing emote configurations in a cache
/// </summary>
internal interface IEmoteConfigurationCache
{
	/// <summary>
	/// Clears all related cache entries for the given user Id, if any
	/// </summary>
	/// <param name="userId">The Id of the given user</param>
	void ClearEmoteConfigurationsForUserId(long userId);

	/// <summary>
	/// Deletes the emote configuration for the given user at the given position
	/// </summary>
	/// <param name="userId">The Id of the given user</param>
	/// <param name="position">The position of the emote configuration</param>
	void DeleteEmoteConfigurationByUserIdAndPosition(long userId, byte position);

	/// <summary>
	/// Gets an emote configuration from the Redis cache by the given emote configuration id
	/// If there is a cache miss, the getter is used to fill the cache and the value returned by the getter will be returned by this method
	/// </summary>
	/// <param name="id">The Id of the emote configuration</param>
	/// <param name="emoteConfigurationGetter">Used in the case that a single emote configuration has been missed to fill the cache</param>
	/// <returns>The emote configuration that is associated with the given id, if any</returns>
	IEmoteConfigurationEntity GetEmoteConfiguration(long id, Func<long, IEmoteConfigurationEntity> emoteConfigurationGetter);

	/// <summary>
	/// Gets an emote configuration by the given user Id and position
	/// If no emote configuration in the cache matches the given user Id and position,
	/// this method will check for a cache miss on the user's entire set of emotes and
	/// may use the provided getter methods to fill in the cache
	/// </summary>
	/// <param name="userId">The Id of the given user</param>
	/// <param name="position">The position of the emote configuration</param>
	/// <param name="emoteConfigurationsGetter">Used in the case that the user's entire emote configurations list has been missed to fill the cache</param>
	/// <param name="emoteConfigurationGetter">Used in the case that a single emote configuration has been missed to fill the cache</param>
	/// <returns>The emote configuration that is associated with the given user and position, if any</returns>
	IEmoteConfigurationEntity GetEmoteConfigurationByUserIdAndPosition(long userId, byte position, Func<long, ICollection<IEmoteConfigurationEntity>> emoteConfigurationsGetter, Func<long, IEmoteConfigurationEntity> emoteConfigurationGetter);

	/// <summary>
	/// Gets all the emote configurations for the given user
	/// Will use the provided getter methods in the case of cache misses
	/// </summary>
	/// <param name="userId">The Id of the given user</param>
	/// <param name="emoteConfigurationsGetter">Used in the case that the user's entire emote configurations list has been missed to fill the cache</param>
	/// <param name="emoteConfigurationGetter">Used in the case that a single emote configuration has been missed to fill the cache</param>
	/// <returns></returns>
	ICollection<IEmoteConfigurationEntity> GetEmoteConfigurationsByUserId(long userId, Func<long, ICollection<IEmoteConfigurationEntity>> emoteConfigurationsGetter, Func<long, IEmoteConfigurationEntity> emoteConfigurationGetter);

	/// <summary>
	/// Sets the cached value for a single emote configuration
	/// </summary>
	/// <param name="emoteConfiguration">The emote configuration to save</param>
	void SetEmoteConfiguration(IEmoteConfigurationEntity emoteConfiguration);

	/// <summary>
	/// Sets the cached value for emote configurations for the given user Id
	/// </summary>
	/// <param name="userId">The Id of the given user</param>
	/// <param name="emoteConfigurations">The list of emote configurations</param>
	void SetEmoteConfigurationsForUserId(long userId, IReadOnlyCollection<IEmoteConfigurationEntity> emoteConfigurations);
}
