using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal interface IEmoteConfigurationEntityFactory : IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Avatar.IEmoteConfigurationEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IEmoteConfigurationEntity" /> with the given ID, or null if none existed.</returns>
	IEmoteConfigurationEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Avatar.IEmoteConfigurationEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// <param name="userId">The user id</param>
	/// <param name="position">The emote position</param>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IEmoteConfigurationEntity" /></returns>
	IEmoteConfigurationEntity GetByUserIdAndPosition(long userId, byte position);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Avatar.IEmoteConfigurationEntity" />s by their TODO: Fill in.
	/// </summary>
	/// TODO: Add params
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartPosition">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// TODO: Add other exceptions
	/// <returns>The page of <see cref="T:Roblox.Platform.Avatar.IEmoteConfigurationEntity" />s.</returns>
	ICollection<IEmoteConfigurationEntity> GetByUserIdEnumerative(long userId, int count, byte? exclusiveStartPosition = null);

	/// <summary>
	/// Deletes a user's emote configuration at the desired position
	/// </summary>
	/// <param name="userId">The user id</param>
	/// <param name="position">The emote position</param>
	void Delete(long userId, byte position);

	/// <summary>
	/// Creates or Updates a <see cref="T:Roblox.Platform.Avatar.IEmoteConfigurationEntity" /> by user Id and position
	/// </summary>
	/// <param name="userId">The user id</param>
	/// <param name="assetId">The emote asset id</param>
	/// <param name="position">The desired position</param>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IEmoteConfigurationEntity" /></returns>
	IEmoteConfigurationEntity CreateOrUpdate(long userId, long assetId, byte position);
}
