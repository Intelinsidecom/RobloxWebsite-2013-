using System;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Entities;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// An <see cref="T:Roblox.Platform.Membership.IUser" />'s 2SV configuration.
/// </summary>
internal interface ITwoStepVerificationSetting
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> that the preferences belong to.
	/// </summary>
	IUserIdentifier UserIdentifier { get; }

	/// <summary>
	/// Whether or not 2SV is enabled.
	/// </summary>
	bool IsEnabled { get; set; }

	/// <summary>
	/// Type of media through which 2SV codes will be sent.
	/// </summary>
	TwoStepVerificationMediaType MediaType { get; set; }

	/// <summary>
	/// Event fired immediately before changes to this <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" /> become permanent.
	/// </summary>
	event Action<ITwoStepVerificationSettingEntity> OnPreChange;

	/// <summary>
	/// Event fired immediately after changes to this <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" /> become permanent.
	/// </summary>
	/// <remarks>
	/// The first argument is the entity before the save, the second argument is the entity after the save.
	/// </remarks>
	event Action<ITwoStepVerificationSettingEntity, ITwoStepVerificationSettingEntity> OnPostChange;

	/// <summary>
	/// Saves this <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" />
	/// </summary>
	void Save();

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSettingDTO" /> from this <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" />
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSettingDTO" /></returns>
	TwoStepVerificationSettingDTO ToDTO();
}
