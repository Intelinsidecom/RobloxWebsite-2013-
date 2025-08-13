using System;
using System.Collections.Generic;

namespace Roblox.Platform.Membership.Commands.Audit;

internal interface IAccountsAuditMetadataEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditMetadataEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditMetadataEntity" /> with the given ID, or null if none existed.</returns>
	IAccountsAuditMetadataEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditMetadataEntity" />s by their AccountsAuditChangeType id and user id.
	/// </summary>
	/// <param name="accountsChangeTypeId">Id of the AccountsChangeType</param>
	/// <param name="userId">Id of the user whose account changed</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:System.ArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditMetadataEntity" />s.</returns>
	ICollection<IAccountsAuditMetadataEntity> GetByAccountsChangeTypeIdAndUserIdEnumerative(byte accountsChangeTypeId, long userId, int count, long? exclusiveStartId = null);

	/// <summary>
	/// Creates a new audit metadata entry for the given user.
	/// </summary>
	/// <param name="targetUser">User whose account changed</param>
	/// <param name="auditEntryPublicId"></param>
	/// <param name="typeId">Change type id</param>
	/// <param name="actorUserId">Who changed the account (user themselves, CS agent, or processor-as-Roblox)</param>
	/// <returns>The newly created <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditMetadataEntity" /></returns>
	IAccountsAuditMetadataEntity Create(IUser targetUser, Guid auditEntryPublicId, AccountsAuditChangeType typeId, long? actorUserId);
}
