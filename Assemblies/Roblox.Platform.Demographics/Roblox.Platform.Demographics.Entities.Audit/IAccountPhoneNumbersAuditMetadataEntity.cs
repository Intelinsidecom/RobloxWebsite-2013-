using System;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Demographics.Entities.Audit;

internal interface IAccountPhoneNumbersAuditMetadataEntity : IEntity<long>, IAuditMetadata
{
	Guid AccountPhoneNumbersAuditEntriesPublicId { get; }

	long UserId { get; }

	new long? ActorUserId { get; }

	byte AccountPhoneNumbersChangeTypeId { get; }

	bool IsLegacyValue { get; }
}
