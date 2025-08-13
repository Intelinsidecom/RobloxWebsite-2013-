using System;
using System.Collections.Generic;

namespace Roblox.Platform.Membership.Audit;

internal interface IUsersAuditEntriesMetaDataEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntriesMetaDataEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntriesMetaDataEntity" /> with the given ID, or null if none existed.</returns>
	IUsersAuditEntriesMetaDataEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntriesMetaDataEntity" />s of a given user and <see cref="T:Roblox.Platform.Membership.UsersAuditEntryMetaDataType" />.
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntriesMetaDataEntity" />s.</returns>
	ICollection<IUsersAuditEntriesMetaDataEntity> GetByUserIdAndUsersAuditEntriesMetaDataTypeIdEnumerative(long userId, byte usersAuditEntriesMetaDataTypeId, int count, long exclusiveStartUsersAuditEntriesMetaDataId);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntriesMetaDataEntity" />.
	/// </summary>
	IUsersAuditEntriesMetaDataEntity CreateNew(IUser targetUser, Guid auditEntryPublicId, UsersAuditEntryMetaDataType typeId, long actorUserId);

	/// <summary>
	/// Creates a <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntriesMetaDataEntity" /> for an audit entry for a past change where certain meta data are not available.
	/// </summary>
	IUsersAuditEntriesMetaDataEntity CreateLegacyEntry(IUser targetUser, Guid auditEntryPublicId, UsersAuditEntryMetaDataType typeId, long userId);
}
