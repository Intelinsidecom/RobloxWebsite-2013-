namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_zh_tw : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "新增電子郵件地址";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "新增電子郵件地址";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "現在新增電子郵件地址";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "現在新增";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "新增家長的電子郵件地址";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "現在新增家長的電子郵件地址";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "新增手機號碼";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "現在新增手機號碼";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "關閉";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "確認電子郵件";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "編輯手機號碼";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "確定";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "重新傳送驗證碼";

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
	public override string ActionVerify => "驗證";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "驗證電子郵件地址";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "驗證手機";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "新增家長的電子郵件地址";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "新增電子郵件地址";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "確保自己可以登入帳號！";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "別忘了確認！";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "發生錯誤";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "讓好友更容易找到您！";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "領取免費帽子！";

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
	public override string HeadingVerifyEmail => "驗證電子郵件地址";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "AddPhone";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "電子郵件地址";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "發生錯誤";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "電子郵件地址無效";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "手機號碼無效";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "沒有電子郵件地址？";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "沒有手機？";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "沒有收到？";

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
	public override string LabelParentsEmailPlaceholder => "家長的電子郵件地址";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Roblox 帳號密碼";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "手機號碼";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "新增電子郵件地址，保護您的帳號！";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "新增您的家長的電子郵件地址，保護您的帳號！";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "以手機號碼保護您的帳戶！";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "重新傳送電子郵件";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "驗證您的電子郵件地址，保護您的帳號！";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "驗證您的家長的電子郵件地址，保護您的帳號！";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Roblox 帳號密碼";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "載入國家清單時發生錯誤";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "請新增您的電子郵件地址，我們將送您一頂帽子，您也可以避免往後無法進入帳號的情況！";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "請新增您的家長的電子郵件地址，我們將送您一頂帽子，您也可以避免往後無法進入帳號的情況！";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "請輸入您的電子郵件地址，我們會傳送連結完成驗證。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "請輸入您的家長的電子郵件地址，我們會傳送連結完成驗證。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "請在您的帳號新增電子郵件地址，確保您可以永遠存取您的 Roblox 帳號。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "請在您的帳號新增您的家長的電子郵件地址，確保您可以永遠存取您的 Roblox 帳號。";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "請在您的帳號新增手機號碼，避免往後無法進入帳號的情況。";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "請新增您的手機號碼，我們將送您一頂帽子，您也可以避免往後無法進入帳號的情況！";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "請確認您的國碼，並輸入您的手機號碼。我們會傳送一則簡訊以完成驗證。（注意：可能會收取簡訊費用）";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "記得確認您的電子郵件地址，獲得免費帽子！";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "記得確認您的家長的電子郵件地址，獲得免費帽子！";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "請在您的帳號新增手機號碼，讓您的好友找得到您！";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "已確認您的手機號碼。恭喜您獲得免費的帽子！";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "已成功新增手機號碼。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "驗證連結已傳送到您的電子郵件地址，請驗證您的電子郵件以保護您的帳號。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "請驗證您的電子郵件地址，確保您永遠可以存取您的 Roblox 帳號。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "請驗證您的家長的電子郵件地址，確保您永遠可以存取您的 Roblox 帳號。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "驗證連結已傳送到您的家長的電子郵件地址，請驗證您的家長的電子郵件以保護您的帳號。";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "驗證連結已傳送到您的電子郵件地址，請驗證您的電子郵件保護您的帳號。您可以前往「設定」>「帳號資訊」修改您的帳號。";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "發生錯誤，請稍後再試。";

	public ContactUpsellResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "新增電子郵件地址";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "新增電子郵件地址";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "現在新增電子郵件地址";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "現在新增";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "新增家長的電子郵件地址";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "現在新增家長的電子郵件地址";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "新增手機號碼";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "現在新增手機號碼";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "關閉";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "確認電子郵件";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "編輯手機號碼";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "重新傳送驗證碼";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "驗證";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "驗證電子郵件地址";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "驗證手機";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "新增家長的電子郵件地址";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "新增電子郵件地址";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "確保自己可以登入帳號！";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "別忘了確認！";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "發生錯誤";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "讓好友更容易找到您！";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "領取免費帽子！";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "驗證電子郵件地址";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "AddPhone";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"輸入驗證碼 ({number} 位數)";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "輸入驗證碼 ({number} 位數)";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "電子郵件地址";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "發生錯誤";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "電子郵件地址無效";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "手機號碼無效";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "沒有電子郵件地址？";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "沒有手機？";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "沒有收到？";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "或";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "家長的電子郵件地址";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Roblox 帳號密碼";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "手機號碼";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "新增電子郵件地址，保護您的帳號！";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "新增您的家長的電子郵件地址，保護您的帳號！";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "以手機號碼保護您的帳戶！";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "重新傳送電子郵件";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "驗證您的電子郵件地址，保護您的帳號！";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "驗證您的家長的電子郵件地址，保護您的帳號！";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Roblox 帳號密碼";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "載入國家清單時發生錯誤";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "請新增您的電子郵件地址，我們將送您一頂帽子，您也可以避免往後無法進入帳號的情況！";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "請新增您的家長的電子郵件地址，我們將送您一頂帽子，您也可以避免往後無法進入帳號的情況！";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "請輸入您的電子郵件地址，我們會傳送連結完成驗證。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "請輸入您的家長的電子郵件地址，我們會傳送連結完成驗證。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "請在您的帳號新增電子郵件地址，確保您可以永遠存取您的 Roblox 帳號。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "請在您的帳號新增您的家長的電子郵件地址，確保您可以永遠存取您的 Roblox 帳號。";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "請在您的帳號新增手機號碼，避免往後無法進入帳號的情況。";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "請新增您的手機號碼，我們將送您一頂帽子，您也可以避免往後無法進入帳號的情況！";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "請確認您的國碼，並輸入您的手機號碼。我們會傳送一則簡訊以完成驗證。（注意：可能會收取簡訊費用）";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "記得確認您的電子郵件地址，獲得免費帽子！";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "記得確認您的家長的電子郵件地址，獲得免費帽子！";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "請在您的帳號新增手機號碼，讓您的好友找得到您！";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"請輸入傳送到 {phoneNumber} 的驗證碼";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "請輸入傳送到 {phoneNumber} 的驗證碼";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "已確認您的手機號碼。恭喜您獲得免費的帽子！";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "已成功新增手機號碼。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "驗證連結已傳送到您的電子郵件地址，請驗證您的電子郵件以保護您的帳號。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "請驗證您的電子郵件地址，確保您永遠可以存取您的 Roblox 帳號。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "請驗證您的家長的電子郵件地址，確保您永遠可以存取您的 Roblox 帳號。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "驗證連結已傳送到您的家長的電子郵件地址，請驗證您的家長的電子郵件以保護您的帳號。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "驗證連結已傳送到您的電子郵件地址，請驗證您的電子郵件保護您的帳號。您可以前往「設定」>「帳號資訊」修改您的帳號。";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "發生錯誤，請稍後再試。";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"代碼應為 {number} 位數";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "代碼應為 {number} 位數";
	}
}
