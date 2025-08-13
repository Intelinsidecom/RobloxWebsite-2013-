namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_ko_kr : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "이메일 추가";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "이메일 추가";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "지금 이메일 추가";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "지금 추가";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "보호자 이메일 추가";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "지금 보호자 이메일 추가";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "전화번호 추가";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "지금 전화번호 추가";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "닫기";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "이메일 확인";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "전화번호 수정";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "확인";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "코드 다시 보내기";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "저장";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "인증";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "이메일 인증";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "전화 인증";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "보호자 이메일 추가";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "이메일 추가";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "잠기지 않도록 하세요!";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "확인을 잊지 마세요!";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "오류가 발생했어요";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "회원님의 친구들이 회원님을 찾을 수 있게 도와줘요!";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "무료 모자를 획득하세요!";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public override string HeadingSuccess => "완료";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public override string HeadingVerifyEmail => "이메일 인증";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "전화번호 추가";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "이메일 주소";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "오류가 발생했어요";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "유효하지 않은 이메일";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "유효하지 않은 전화번호";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "이메일이 없다구요?";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "전화번호가 없다구요?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "링크를 받지 못하셨나요?";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "또는";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "보호자 이메일 주소";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Roblox 계정 비밀번호";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "전화번호";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "이메일로 계정을 보호하세요!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "보호자 이메일을 통해 계정을 보호하세요!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "전화번호로 계정을 보호하세요!";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "이메일 다시 보내기";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "이메일을 인증하여 계정을 보호하세요!";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "계정 보호를 위해 보호자 이메일을 인증하세요!";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Roblox 계정 비밀번호";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "국가 목록 로드 중 오류가 발생했어요";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "본인 이메일을 추가해 무료 모자도 받고 계정 잠김도 방지하세요!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "보호자 이메일을 추가해 무료 모자도 받고 계정 잠김도 방지하세요!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "본인 이메일 주소를 입력하세요. 인증 완료를 위해 링크를 보내드릴게요.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "보호자 이메일 주소를 입력하세요. 인증 완료를 위해 링크를 보내드려요.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "항상 Roblox 계정에 접근할 수 있도록 계정에 이메일 주소를 추가하세요.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "항상 Roblox 계정에 접근할 수 있도록 계정에 보호자 이메일 주소를 추가하세요.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "계정이 잠기는 일이 발생하지 않도록 계정에 전화번호를 추가하세요.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "전화번호를 추가해 무료 모자도 받고 계정 잠김도 방지하세요!";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "국가 코드를 확인하고 전화번호를 입력하세요. 인증 완료를 위해 문자 메시지를 보내드려요. (참고: 문자 메시지 발송 수수료가 부과될 수 있습니다)";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "본인의 이메일 주소를 확인하고 무료 모자도 받으세요!";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "보호자 이메일 주소를 확인하고 무료 모자도 받으세요!";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "친구가 회원님을 찾을 수 있도록 계정에 전화번호를 추가하세요!";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "전화번호가 확인되었습니다. 무료 모자를 착용할 수 있어요!";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "전화번호 추가가 완료되었습니다.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "입력한 이메일로 인증 링크가 발송되었어요. 이메일을 인증하여 계정을 안전하게 보호하세요.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "항상 Roblox 계정에 접근할 수 있도록 이메일 주소를 인증하세요.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "항상 Roblox 계정에 접근할 수 있도록 보호자 이메일 주소를 인증하세요.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "입력하신 보호자 이메일로 인증 링크가 발송되었습니다. 보호자 이메일을 인증하여 계정을 안전하게 보호하세요.";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "입력하신 이메일로 인증 링크가 발송되었습니다. 이메일을 인증하여 계정을 안전하게 보호하세요. 계정정보는 설정 > 계정 정보에서 언제든지 변경할 수 있어요.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "오류가 발생했어요. 나중에 다시 시도하세요.";

	public ContactUpsellResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "이메일 추가";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "이메일 추가";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "지금 이메일 추가";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "지금 추가";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "보호자 이메일 추가";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "지금 보호자 이메일 추가";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "전화번호 추가";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "지금 전화번호 추가";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "이메일 확인";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "전화번호 수정";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "코드 다시 보내기";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "저장";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "인증";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "이메일 인증";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "전화 인증";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "보호자 이메일 추가";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "이메일 추가";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "잠기지 않도록 하세요!";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "확인을 잊지 마세요!";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "오류가 발생했어요";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "회원님의 친구들이 회원님을 찾을 수 있게 도와줘요!";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "무료 모자를 획득하세요!";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "완료";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "이메일 인증";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "전화번호 추가";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"코드 입력 ({number}자리)";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "코드 입력 ({number}자리)";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "이메일 주소";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "오류가 발생했어요";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "유효하지 않은 이메일";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "유효하지 않은 전화번호";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "이메일이 없다구요?";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "전화번호가 없다구요?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "링크를 받지 못하셨나요?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "또는";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "보호자 이메일 주소";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Roblox 계정 비밀번호";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "전화번호";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "이메일로 계정을 보호하세요!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "보호자 이메일을 통해 계정을 보호하세요!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "전화번호로 계정을 보호하세요!";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "이메일 다시 보내기";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "이메일을 인증하여 계정을 보호하세요!";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "계정 보호를 위해 보호자 이메일을 인증하세요!";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Roblox 계정 비밀번호";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "국가 목록 로드 중 오류가 발생했어요";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "본인 이메일을 추가해 무료 모자도 받고 계정 잠김도 방지하세요!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "보호자 이메일을 추가해 무료 모자도 받고 계정 잠김도 방지하세요!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "본인 이메일 주소를 입력하세요. 인증 완료를 위해 링크를 보내드릴게요.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "보호자 이메일 주소를 입력하세요. 인증 완료를 위해 링크를 보내드려요.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "항상 Roblox 계정에 접근할 수 있도록 계정에 이메일 주소를 추가하세요.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "항상 Roblox 계정에 접근할 수 있도록 계정에 보호자 이메일 주소를 추가하세요.";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "계정이 잠기는 일이 발생하지 않도록 계정에 전화번호를 추가하세요.";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "전화번호를 추가해 무료 모자도 받고 계정 잠김도 방지하세요!";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "국가 코드를 확인하고 전화번호를 입력하세요. 인증 완료를 위해 문자 메시지를 보내드려요. (참고: 문자 메시지 발송 수수료가 부과될 수 있습니다)";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "본인의 이메일 주소를 확인하고 무료 모자도 받으세요!";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "보호자 이메일 주소를 확인하고 무료 모자도 받으세요!";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "친구가 회원님을 찾을 수 있도록 계정에 전화번호를 추가하세요!";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"{phoneNumber}(으)로 전송된 문자에 있는 코드를 입력하세요";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "{phoneNumber}(으)로 전송된 문자에 있는 코드를 입력하세요";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "전화번호가 확인되었습니다. 무료 모자를 착용할 수 있어요!";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "전화번호 추가가 완료되었습니다.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "입력한 이메일로 인증 링크가 발송되었어요. 이메일을 인증하여 계정을 안전하게 보호하세요.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "항상 Roblox 계정에 접근할 수 있도록 이메일 주소를 인증하세요.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "항상 Roblox 계정에 접근할 수 있도록 보호자 이메일 주소를 인증하세요.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "입력하신 보호자 이메일로 인증 링크가 발송되었습니다. 보호자 이메일을 인증하여 계정을 안전하게 보호하세요.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "입력하신 이메일로 인증 링크가 발송되었습니다. 이메일을 인증하여 계정을 안전하게 보호하세요. 계정정보는 설정 > 계정 정보에서 언제든지 변경할 수 있어요.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"{number}자리 코드를 입력하세요";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "{number}자리 코드를 입력하세요";
	}
}
