using System;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.AccountPins.Entities.Audit;

/// <summary>
/// A factory to produce <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditEntity">IAccountPinHashesAuditEntities</see>
/// </summary>
internal interface IAccountPinHashesAuditEntityFactory : IDomainFactory<AccountPinsDomainFactories>, IDomainObject<AccountPinsDomainFactories>, IAuditEntryEntityFactory<IAccountPinHashesAuditEntity>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditEntity" /> with the given ID, or null if none existed.</returns>
	IAccountPinHashesAuditEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditEntity" /> with the given public id
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditEntity" /> with the given public id</returns>
	IAccountPinHashesAuditEntity GetByPublicId(Guid publicId);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.AccountPins.Entities.Audit.IAccountPinHashesAuditEntity">audit entity</see> based on an original <see cref="T:Roblox.Platform.AccountPins.Entities.IAccountPinHashEntity">data entity</see>
	/// </summary>
	IAccountPinHashesAuditEntity CreateNew(IAccountPinHashEntity entity);
}
