namespace Roblox.TranslationResources.Authentication;

public interface IAccountRecoveryResources : ITranslationResources
{
	/// <summary>
	/// Key: "ActionSubmit"
	/// English String: "Submit"
	/// </summary>
	string ActionSubmit { get; }

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	string DescriptionResetFollowing { get; }

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	string DescriptionRevertAccount { get; }

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	string HeadingAccountRecovery { get; }

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	string HeadingChooseAccount { get; }

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	string HeadingRevertAccount { get; }

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	string LabelConfirmNewPassword { get; }

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	string LabelEmail { get; }

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	string LabelNewPassword { get; }

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	string LabelPassword { get; }

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	string LabelTwoStepVerification { get; }

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	string MessageDisableTwoStepVerification { get; }

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	string MessageRevertToUnverifiedEmail { get; }

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd);

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	string MessageDontUseOldPassword(string styleFront, string styleEnd);
}
