using System;
using System.Collections.Generic;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

internal interface ITwoSVSettingsAuditMetadataEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoSVSettingsAuditMetadataEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoSVSettingsAuditMetadataEntity" /> with the given ID, or null if none existed.</returns>
	ITwoSVSettingsAuditMetadataEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoSVSettingsAuditMetadataEntity" />s by their TODO: Fill in.
	/// </summary>
	/// TODO: Add params
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartTwoSVSettingsAuditMetadataId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// TODO: Add other exceptions
	/// <returns>The page of <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoSVSettingsAuditMetadataEntity" />s.</returns>
	IEnumerable<ITwoSVSettingsAuditMetadataEntity> GetByUserIdEnumerative(long userId, int count, long? exclusiveStartTwoSVSettingsAuditMetadataId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoSVSettingsAuditMetadataEntity" />s by their TODO: Fill in.
	/// </summary>
	/// TODO: Add params
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartTwoSVSettingsAuditMetadataId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// TODO: Add other exceptions
	/// <returns>The page of <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoSVSettingsAuditMetadataEntity" />s.</returns>
	IEnumerable<ITwoSVSettingsAuditMetadataEntity> GetByUserIdAndTwoStepVerificationChangeTypeIdEnumerative(long userId, byte twoStepVerificationChangeTypeId, int count, long? exclusiveStartTwoSVSettingsAuditMetadataId);

	ITwoSVSettingsAuditMetadataEntity CreateNew(IUserIdentifier targetUser, Guid auditEntryPublicId, TwoStepVerificationChangeType changeType, IUserIdentifier actorUser);

	ITwoSVSettingsAuditMetadataEntity CreateLegacyEntry(long targetUserId, Guid auditEntryPublicId, TwoStepVerificationChangeType changeType, int actorUserId);
}
