using System;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Demographics.Entities.Audit;

internal interface IAccountPhoneNumbersAuditEntryEntityFactory : IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>, IAuditEntryEntityFactory<IAccountPhoneNumbersAuditEntryEntity>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditEntryEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditEntryEntity" /> with the given ID, or null if none existed.</returns>
	IAccountPhoneNumbersAuditEntryEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditEntryEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditEntryEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IAccountPhoneNumbersAuditEntryEntity GetByPublicId(Guid publicId);

	IAccountPhoneNumbersAuditEntryEntity CreateNew(IAccountPhoneNumberEntity entity);
}
