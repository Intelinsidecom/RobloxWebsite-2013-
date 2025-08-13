using System;
using System.Collections.Generic;
using Roblox.Platform.Membership.Entities;

namespace Roblox.Platform.Membership.Audit;

internal interface IUsersAuditEntryEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntryEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntryEntity" /> with the given ID, or null if none existed.</returns>
	IUsersAuditEntryEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntryEntity" /> with the given characteristics.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntryEntity" /> with the given characteristics, or null if none existed.</returns>
	IUsersAuditEntryEntity GetByPublicId(Guid publicId);

	/// <summary>
	/// Gets individual <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntryEntity">IUsersAuditEntryEntities</see> by their publicIds and return in a collection.
	/// Serves as an alternative to MultiGet due to lack of EntityHelper support.
	/// </summary>
	ICollection<IUsersAuditEntryEntity> SingleGetsByPublicIds(IEnumerable<Guid> publicIds);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Membership.Audit.IUsersAuditEntryEntity" /> based on an <see cref="T:Roblox.Platform.Membership.Entities.IUserEntity" />.
	/// </summary>
	IUsersAuditEntryEntity CreateNew(IUserEntity entity);
}
