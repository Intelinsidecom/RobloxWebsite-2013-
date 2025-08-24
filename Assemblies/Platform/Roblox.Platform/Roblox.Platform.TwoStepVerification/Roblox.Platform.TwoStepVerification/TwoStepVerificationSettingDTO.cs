using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

public class TwoStepVerificationSettingDTO
{
	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.UserIdentifier" />
	public IUserIdentifier UserIdentifier { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.IsEnabled" />
	public bool IsEnabled { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.MediaType" />
	public TwoStepVerificationMediaType MediaType { get; set; }
}
