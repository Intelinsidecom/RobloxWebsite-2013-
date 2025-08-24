using System.Collections.Generic;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// A public interface producing <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSettingsAuditCompositeEntry">ITwoStepVerificationSettingsAuditCompositeEntries</see>
/// </summary>
public interface ITwoStepVerificationSettingsAuditCompositeEntryFactory
{
	/// <summary>
	/// Obtains full audit information on a user's TwoStepVerificationSetting changes
	/// </summary>
	ICollection<ITwoStepVerificationSettingsAuditCompositeEntry> GetAllHistory(long userId, byte count, long? exclusiveStartId = null);

	/// <summary>
	/// Obtains audit information on a user's isEnabled changes.
	/// </summary>
	ICollection<ITwoStepVerificationSettingsAuditCompositeEntry> GetEnableDisableHistory(long userId, byte count, long? exclusiveStartId = null);

	/// <summary>
	/// Obtains audit information on a user's media type changes.
	/// </summary>
	ICollection<ITwoStepVerificationSettingsAuditCompositeEntry> GetMediaTypeHistory(long userId, byte count, long? exclusiveStartId = null);
}
