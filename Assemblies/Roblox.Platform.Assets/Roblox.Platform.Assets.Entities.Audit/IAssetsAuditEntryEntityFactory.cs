using System;
using Roblox.DataAccess;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets.Entities.Audit;

internal interface IAssetsAuditEntryEntityFactory : IAuditEntryEntityFactory<IAssetsAuditEntryEntity>, IDomainFactory<AssetDomainFactories>, IDomainObject<AssetDomainFactories>
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetsAuditEntryEntity" /> based on the records in the <see cref="T:Roblox.DataAccess.AssetDAL" /> object.
	/// This is an unusual jump of abstraction layers, due to the intermediate BLL (=CAL) layer not mirrioring the underlying data structure.
	/// </summary>
	IAssetsAuditEntryEntity Create(AssetDAL dalObject);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetsAuditEntryEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetsAuditEntryEntity" /> with the given ID, or null if none existed.</returns>
	IAssetsAuditEntryEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetsAuditEntryEntity" /> with the given (public) GUID
	/// </summary>
	IAssetsAuditEntryEntity GetByPublicId(Guid publicId);
}
