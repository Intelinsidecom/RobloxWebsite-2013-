using System;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

internal interface ITwoStepVerificationSettingsAuditEntryEntityFactory : IAuditEntryEntityFactory<ITwoStepVerificationSettingsAuditEntryEntity>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoStepVerificationSettingsAuditEntryEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoStepVerificationSettingsAuditEntryEntity" /> with the given ID, or null if none existed.</returns>
	ITwoStepVerificationSettingsAuditEntryEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoStepVerificationSettingsAuditEntryEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.Entities.Audit.ITwoStepVerificationSettingsAuditEntryEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	ITwoStepVerificationSettingsAuditEntryEntity GetByPublicId(Guid publicId);

	ITwoStepVerificationSettingsAuditEntryEntity CreateNew(ITwoStepVerificationSettingEntity entity);
}
