using System;
using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AccountPins.Entities.Audit;

internal interface IAccountPinHashesAuditMetadataEntityFactory : IDomainFactory<AccountPinsDomainFactories>, IDomainObject<AccountPinsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditMetadataEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditMetadataEntity" /> with the given ID, or null if none existed.</returns>
	IAccountPinHashesAuditMetadataEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditMetadataEntity" />s by their userId and accountPinChangeTypeId
	/// </summary>
	/// <param name="userId">The user id</param>
	/// <param name="accountPinChangeTypeId">The account pin change type id</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditMetadataEntity" />s.</returns>
	IEnumerable<IAccountPinHashesAuditMetadataEntity> GetByUserIdAndAccountPinChangeTypeIdEnumerative(long userId, byte accountPinChangeTypeId, int count, long? exclusiveStartId = null);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditMetadataEntity" />s by their user id.
	/// </summary>
	/// <param name="userId">The user id</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditMetadataEntity" />s.</returns>
	IEnumerable<IAccountPinHashesAuditMetadataEntity> GetByUserIdEnumerative(long userId, int count, long? exclusiveStartId = null);

	/// <summary>
	/// Creates a new entity associating the provided metadata with an audit entry
	/// </summary>
	IAccountPinHashesAuditMetadataEntity CreateNew(IUserIdentifier targetUser, Guid auditEntryPublicId, AccountPinChangeType changeType, IUserIdentifier actorUser);
}
