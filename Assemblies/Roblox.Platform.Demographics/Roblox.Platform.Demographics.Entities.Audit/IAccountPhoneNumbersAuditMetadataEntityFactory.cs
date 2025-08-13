using System;
using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Demographics.Entities.Audit;

internal interface IAccountPhoneNumbersAuditMetadataEntityFactory : IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditMetadataEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditMetadataEntity" /> with the given ID, or null if none existed.</returns>
	IAccountPhoneNumbersAuditMetadataEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditMetadataEntity" />s by the userId, ordered by id descending
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditMetadataEntity" />s.</returns>
	IEnumerable<IAccountPhoneNumbersAuditMetadataEntity> GetByUserIdEnumerative(long userId, int count, long? exclusiveStartAccountPhoneNumbersAuditMetadataId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditMetadataEntity" />s by their user id and change type id
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditMetadataEntity" />s.</returns>
	IEnumerable<IAccountPhoneNumbersAuditMetadataEntity> GetByUserIdAndAccountPhoneNumbersChangeTypeIdEnumerative(long userId, byte accountPhoneNumbersChangeTypeId, int count, long? exclusiveStartAccountPhoneNumbersAuditMetadataId);

	IAccountPhoneNumbersAuditMetadataEntity CreateNew(IUserIdentifier targetUser, Guid auditEntryPublicId, AccountPhoneNumberChangeTypes changeType, IUserIdentifier actorUser);
}
