using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class AccountRecoveryResources_en_us : TranslationResourcesBase, IAccountRecoveryResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "ActionSubmit"
	/// English String: "Submit"
	/// </summary>
	public virtual string ActionSubmit => "Submit";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public virtual string DescriptionResetFollowing => "This will reset the following settings:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public virtual string DescriptionRevertAccount => "You are about to revert your account to a past state.\nTo revert your account you must set a new password.";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public virtual string HeadingAccountRecovery => "Reset Password";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public virtual string HeadingChooseAccount => "Choose an Account";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public virtual string HeadingRevertAccount => "Revert Account";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public virtual string LabelConfirmNewPassword => "Confirm New Password";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public virtual string LabelEmail => "Email";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public virtual string LabelNewPassword => "New Password";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public virtual string LabelPassword => "Password";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public virtual string LabelTwoStepVerification => "Two Step Verification";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public virtual string MessageDisableTwoStepVerification => "This will disable two step verification.";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public virtual string MessageRevertToUnverifiedEmail => "You are reverting your email to an unverified email.";

	public AccountRecoveryResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"ActionSubmit",
				_GetTemplateForActionSubmit()
			},
			{
				"DescriptionResetFollowing",
				_GetTemplateForDescriptionResetFollowing()
			},
			{
				"DescriptionRevertAccount",
				_GetTemplateForDescriptionRevertAccount()
			},
			{
				"HeadingAccountRecovery",
				_GetTemplateForHeadingAccountRecovery()
			},
			{
				"HeadingChooseAccount",
				_GetTemplateForHeadingChooseAccount()
			},
			{
				"HeadingRevertAccount",
				_GetTemplateForHeadingRevertAccount()
			},
			{
				"LabelConfirmNewPassword",
				_GetTemplateForLabelConfirmNewPassword()
			},
			{
				"LabelEmail",
				_GetTemplateForLabelEmail()
			},
			{
				"LabelNewPassword",
				_GetTemplateForLabelNewPassword()
			},
			{
				"LabelPassword",
				_GetTemplateForLabelPassword()
			},
			{
				"LabelTwoStepVerification",
				_GetTemplateForLabelTwoStepVerification()
			},
			{
				"MessageCreateNewPasswordDontUseOldPassword",
				_GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
			},
			{
				"MessageDisableTwoStepVerification",
				_GetTemplateForMessageDisableTwoStepVerification()
			},
			{
				"MessageDontUseOldPassword",
				_GetTemplateForMessageDontUseOldPassword()
			},
			{
				"MessageRevertToUnverifiedEmail",
				_GetTemplateForMessageRevertToUnverifiedEmail()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.AccountRecovery";
	}

	protected virtual string _GetTemplateForActionSubmit()
	{
		return "Submit";
	}

	protected virtual string _GetTemplateForDescriptionResetFollowing()
	{
		return "This will reset the following settings:";
	}

	protected virtual string _GetTemplateForDescriptionRevertAccount()
	{
		return "You are about to revert your account to a past state.\nTo revert your account you must set a new password.";
	}

	protected virtual string _GetTemplateForHeadingAccountRecovery()
	{
		return "Reset Password";
	}

	protected virtual string _GetTemplateForHeadingChooseAccount()
	{
		return "Choose an Account";
	}

	protected virtual string _GetTemplateForHeadingRevertAccount()
	{
		return "Revert Account";
	}

	protected virtual string _GetTemplateForLabelConfirmNewPassword()
	{
		return "Confirm New Password";
	}

	protected virtual string _GetTemplateForLabelEmail()
	{
		return "Email";
	}

	protected virtual string _GetTemplateForLabelNewPassword()
	{
		return "New Password";
	}

	protected virtual string _GetTemplateForLabelPassword()
	{
		return "Password";
	}

	protected virtual string _GetTemplateForLabelTwoStepVerification()
	{
		return "Two Step Verification";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public virtual string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"Create a new password. Do {styleFront}not{styleEnd} use your old password.";
	}

	protected virtual string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "Create a new password. Do {styleFront}not{styleEnd} use your old password.";
	}

	protected virtual string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "This will disable two step verification.";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public virtual string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"Do {styleFront}not{styleEnd} use your old password.";
	}

	protected virtual string _GetTemplateForMessageDontUseOldPassword()
	{
		return "Do {styleFront}not{styleEnd} use your old password.";
	}

	protected virtual string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "You are reverting your email to an unverified email.";
	}
}
