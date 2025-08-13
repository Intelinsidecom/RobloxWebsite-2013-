using System;
using System.Collections.Generic;
using Roblox.Platform.Membership.Entities;

namespace Roblox.Platform.Membership.Commands.Audit;

internal interface IAccountsAuditEntryEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditEntryEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditEntryEntity" /> with the given ID, or null if none existed.</returns>
	IAccountsAuditEntryEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditEntryEntity" /> with the given public id
	/// </summary>
	/// <param name="publicId">the public id</param>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditEntryEntity" /> with the given public id, or null if none existed.</returns>
	IAccountsAuditEntryEntity GetByPublicId(Guid publicId);

	/// <summary>
	/// Gets individual <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditEntryEntity" /> by their publicIds and return in a collection.
	/// Serves as an alternative to MultiGet due to lack of EntityHelper support.
	/// </summary>
	ICollection<IAccountsAuditEntryEntity> SingleGetsByPublicIds(IEnumerable<Guid> publicIds);

	/// <summary>
	/// Creates a new audit entry for the given account.
	/// </summary>
	/// <param name="entity"></param>
	/// <returns>The newly created <see cref="T:Roblox.Platform.Membership.Commands.Audit.IAccountsAuditEntryEntity" /></returns>
	IAccountsAuditEntryEntity Create(IAccountEntity entity);
}
