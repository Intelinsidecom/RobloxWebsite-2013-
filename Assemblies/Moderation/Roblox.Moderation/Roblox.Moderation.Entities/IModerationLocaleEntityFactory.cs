using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Moderation.Entities;

internal interface IModerationLocaleEntityFactory : IDomainFactory<ModerationDomainFactories>, IDomainObject<ModerationDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Moderation.Entities.IModerationLocaleEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Moderation.Entities.IModerationLocaleEntity" /> with the given ID, or null if none existed.</returns>
	IModerationLocaleEntity Get(int id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Moderation.Entities.IModerationLocaleEntity" /> with the given supportedLocaleId
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Moderation.Entities.IModerationLocaleEntity" /> with the given supportedLocaleId, or null if none existed.</returns>
	IModerationLocaleEntity GetBySupportedLocaleId(int supportedLocaleId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Moderation.Entities.IModerationLocaleEntity" />s by their isActive
	/// </summary>
	/// <param name="isActive">isActive</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Moderation.Entities.IModerationLocaleEntity" />s.</returns>
	IEnumerable<IModerationLocaleEntity> GetByIsActiveEnumerative(bool isActive, int count, int exclusiveStartId = 0);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Moderation.Entities.IModerationLocaleEntity" /> with the given SupportedLocaleId. Default value for IsActive is false.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Moderation.Entities.IModerationLocaleEntity" /></returns>
	IModerationLocaleEntity GetOrCreate(int supportedLocaleId);
}
