namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_zh_cn : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "添加电子邮件";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "添加电子邮件";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "立即添加电子邮件";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "立即添加";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "添加家长电子邮件";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "立即添加家长电子邮件";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "添加手机号码";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "立即添加手机号码";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "关闭";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "确认电子邮件";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "编辑手机号码";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "好";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "重新发送验证码";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "提交";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "验证";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "验证电子邮件";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "验证手机";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "添加家长电子邮件";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "添加电子邮件";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "防止你的账号被锁定！";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "别忘了确认！";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "发生错误";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "让好友更容易找到你！";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "来领取免费帽子吧！";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public override string HeadingSuccess => "成功";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public override string HeadingVerifyEmail => "验证电子邮件";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "添加手机号码";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "电子邮件地址";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "发生错误";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "电子邮件无效";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "手机号码无效";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "没有电子邮件？";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "没有手机？";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "没有收到？";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "或";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "家长电子邮件地址";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Roblox 帐户密码";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "手机号码";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "使用电子邮件保证你的帐户安全！";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "使用家长的电子邮件以保证你的帐户安全！";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "使用手机号码保证你的帐户安全！";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "重新发送电子邮件";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "验证你的电子邮件以保证你的帐户安全！";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "验证你家长的电子邮件以保证你的帐户安全！";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Roblox 帐户密码";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "加载国家列表时发生错误";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "请添加你的电子邮件，我们将送你一顶免费的帽子，你也会避免以后出现帐户锁定的情况！";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "请添加家长的电子邮件以获得一顶免费帽子，确保你不会被锁在帐户之外！";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "请输入你的电子邮件地址。我们会发送链接以完成验证。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "请输入你家长的电子邮件地址，我们会发送链接以完成验证。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "请在你的帐户添加电子邮件地址，确保始终能够访问你的 Roblox 帐户。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "请在你的帐户添加你家长的电子邮件地址，确保始终能够访问你的 Roblox 帐户。";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "请在你的帐户添加手机号码，避免以后出现帐户锁定的情况。";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "请添加你的手机号码，我们将送你一顶免费的帽子，你也会避免以后出现帐户锁定的情况！";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "请确认你的国家代码，并输入你的电话号码。我们会发送短信以完成验证。（注意：发送短信时可能会产生通信费用）";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "别忘了确认你家长的电子邮件地址，获得免费帽子！";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "别忘了确认你家长的电子邮件地址，获得免费帽子！";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "请在你的帐户添加手机号码，让好友更容易找到你！";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "你的手机号码已确认。恭喜你获得免费的帽子！";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "手机号码已添加成功！";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "验证链接已发送至你的电子邮件 - 请验证电子邮件以保证帐户安全。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "请验证你的电子邮件地址，确保始终能够访问你的 Roblox 帐户。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "请验证你家长的电子邮件地址，确保始终能够访问你的 Roblox 帐户。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "验证链接已发送至你家长的电子邮件 - 请验证你家长的电子邮件以保证帐户安全。";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "验证链接已发送至你的电子邮件。请验证电子邮件以保证帐户安全。你随时可以访问“设置”>“帐户信息”以修改你的帐户。";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "发生错误。请稍后重试。";

	public ContactUpsellResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "添加电子邮件";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "添加电子邮件";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "立即添加电子邮件";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "立即添加";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "添加家长电子邮件";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "立即添加家长电子邮件";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "添加手机号码";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "立即添加手机号码";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "确认电子邮件";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "编辑手机号码";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "好";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "重新发送验证码";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "验证";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "验证电子邮件";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "验证手机";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "添加家长电子邮件";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "添加电子邮件";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "防止你的账号被锁定！";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "别忘了确认！";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "发生错误";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "让好友更容易找到你！";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "来领取免费帽子吧！";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "验证电子邮件";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "添加手机号码";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"输入验证码（{number} 位）";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "输入验证码（{number} 位）";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "电子邮件地址";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "发生错误";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "电子邮件无效";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "手机号码无效";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "没有电子邮件？";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "没有手机？";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "没有收到？";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "或";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "家长电子邮件地址";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Roblox 帐户密码";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "手机号码";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "使用电子邮件保证你的帐户安全！";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "使用家长的电子邮件以保证你的帐户安全！";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "使用手机号码保证你的帐户安全！";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "重新发送电子邮件";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "验证你的电子邮件以保证你的帐户安全！";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "验证你家长的电子邮件以保证你的帐户安全！";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Roblox 帐户密码";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "加载国家列表时发生错误";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "请添加你的电子邮件，我们将送你一顶免费的帽子，你也会避免以后出现帐户锁定的情况！";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "请添加家长的电子邮件以获得一顶免费帽子，确保你不会被锁在帐户之外！";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "请输入你的电子邮件地址。我们会发送链接以完成验证。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "请输入你家长的电子邮件地址，我们会发送链接以完成验证。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "请在你的帐户添加电子邮件地址，确保始终能够访问你的 Roblox 帐户。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "请在你的帐户添加你家长的电子邮件地址，确保始终能够访问你的 Roblox 帐户。";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "请在你的帐户添加手机号码，避免以后出现帐户锁定的情况。";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "请添加你的手机号码，我们将送你一顶免费的帽子，你也会避免以后出现帐户锁定的情况！";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "请确认你的国家代码，并输入你的电话号码。我们会发送短信以完成验证。（注意：发送短信时可能会产生通信费用）";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "别忘了确认你家长的电子邮件地址，获得免费帽子！";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "别忘了确认你家长的电子邮件地址，获得免费帽子！";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "请在你的帐户添加手机号码，让好友更容易找到你！";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"请输入发送至 {phoneNumber} 短信中的验证码";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "请输入发送至 {phoneNumber} 短信中的验证码";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "你的手机号码已确认。恭喜你获得免费的帽子！";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "手机号码已添加成功！";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "验证链接已发送至你的电子邮件 - 请验证电子邮件以保证帐户安全。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "请验证你的电子邮件地址，确保始终能够访问你的 Roblox 帐户。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "请验证你家长的电子邮件地址，确保始终能够访问你的 Roblox 帐户。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "验证链接已发送至你家长的电子邮件 - 请验证你家长的电子邮件以保证帐户安全。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "验证链接已发送至你的电子邮件。请验证电子邮件以保证帐户安全。你随时可以访问“设置”>“帐户信息”以修改你的帐户。";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "发生错误。请稍后重试。";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"验证码必须是 {number} 位数";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "验证码必须是 {number} 位数";
	}
}
