using System;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

internal interface ITwoSVSettingsAuditMetadataEntity : IEntity<long>, IAuditMetadata
{
	Guid TwoStepVerificationSettingsAuditEntriesPublicId { get; }

	long UserId { get; }

	new long? ActorUserId { get; }

	byte TwoStepVerificationChangeTypeId { get; }

	bool IsLegacyValue { get; }
}
