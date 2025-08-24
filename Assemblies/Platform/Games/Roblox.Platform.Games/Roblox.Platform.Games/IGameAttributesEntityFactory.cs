using System.Collections.Generic;
using Roblox.DataV2.Core;
using Roblox.Platform.Core;

namespace Roblox.Platform.Games;

internal interface IGameAttributesEntityFactory : IDomainFactory<GamesDomainFactories>, IDomainObject<GamesDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" /> with the given ID, or null if none existed.</returns>
	IGameAttributesEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" /> with the given universe Id.
	/// </summary>
	/// <param name="universeId">The universe Id.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Invalid <paramref name="universeId" />.</exception>
	IGameAttributesEntity GetByUniverseId(long universeId);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" /> with the given universe Id.
	/// </summary>
	/// <param name="universeId">The universe Id.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Invalid <paramref name="universeId" />.</exception>
	IGameAttributesEntity GetOrCreate(long universeId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" />s by their IsTrusted field.
	/// </summary>
	/// <param name="isTrusted">The IsTrusted state of the <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" />s to return.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartUniverseId">The exclusive start universe Id.</param>
	/// <param name="sortOrder">The sort order of the results.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Games.IGameAttributesEntity" />s.</returns>
	IEnumerable<IGameAttributesEntity> GetByIsTrustedEnumerative(bool isTrusted, long exclusiveStartUniverseId, int count, SortOrder sortOrder);
}
