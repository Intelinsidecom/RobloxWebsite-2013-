namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_ja_jp : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "メールアドレスを追加";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "メールアドレスを追加";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "今すぐメールアドレスを追加";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "今すぐ追加";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "保護者のメールアドレスを追加";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "今すぐ保護者のメールアドレスを追加";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "電話番号を追加";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "今すぐ電話番号を追加";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "閉じる";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "メールアドレスの確認";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "電話番号を編集";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "コードを再送信";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "送信する";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "確認";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "メールアドレスを認証";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "電話番号を確認";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "保護者のメールアドレスを追加";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "メールアドレスを追加";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "アクセス拒否されないように注意！";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "忘れずに確認しましょう！";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "エラーが発生";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "友達があなたを見つけやすくしましょう！";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "帽子を無料でゲットしよう！";

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
	public override string HeadingVerifyEmail => "メールアドレスを認証";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "電話番号を登録";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "メールアドレス";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "エラーが発生";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "無効なメールアドレス";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "無効な電話番号";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "メールアドレスをお持ちでない場合。";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "電話をお持ちでない場合。";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "受信できない場合。";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "または";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "保護者のメールアドレス";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Robloxアカウントのパスワード";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "電話番号";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "メールアドレスでアカウントを保護してください！";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "保護者のメールアドレスでアカウントを保護してください！";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "電話番号でアカウントを保護してください！";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "メールを再送信";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "メールアドレスを認証して、アカウントを保護してください！";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "保護者のメールアドレスを認証して、アカウントを保護してください！";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Robloxアカウントのパスワード";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "国名リストの読み込み中にエラーが発生しました";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "メールアドレスを登録して帽子を無料でゲットして、アカウントにアクセス拒否されないようにしてしてください。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "保護者のメールアドレスを登録して帽子を無料でゲットして、アカウントにアクセス拒否されないようにしてください！";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "メールアドレスを入力してください。認証を完了するためのリンクをお送りします。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "保護者のメールアドレスを入力してください。認証を完了するためのリンクをお送りします。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "いつでもRobloxアカウントにアクセスできるようにするには、アカウントにメールアドレスを登録してください。";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "いつでもRobloxアカウントにアクセスできるようにするには、アカウントに保護者のメールアドレスを登録してください。";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "アカウントに電話番号を登録して、アカウントにアクセス拒否されないようにしてください。";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "電話番号を登録して帽子を無料でゲットして、アカウントにアクセス拒否されないようにしてください！";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "国コードを確認して、電話番号を入力してください。認証完了用のテキストメッセージが送信されます。（ご注意: 通信料がかかる場合があります）";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "メールアドレスを認証して、帽子を無料で手に入れましょう！";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "保護者のメールアドレスを認証して、帽子を無料で手に入れましょう！";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "アカウントに電話番号を登録して、友達に見つけてもらえるようにしましょう！";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "電話番号を認証しました。無料の帽子を受け取ってください！";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "電話番号が追加されました。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "認証用リンクをメールで送信しました - メールアドレスを認証して、アカウントを保護してください。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "いつでもRobloxアカウントにアクセスできるようにするには、メールアドレスを認証してしてください。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "いつでもRobloxアカウントにアクセスできるようにするには、保護者のメールアドレスを認証してください。";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "認証用リンクを保護者のメールアドレスに送信しました - 保護者のメールアドレスを認証して、アカウントを保護してください。";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "認証用リンクをメールで送信しました - メールアドレスを認証して、アカウントを保護してください。「設定」>「アカウント情報」でいつでもアカウント設定を変更できます。";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "エラーが発生しました。後でもう一度お試しください。";

	public ContactUpsellResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "メールアドレスを追加";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "メールアドレスを追加";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "今すぐメールアドレスを追加";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "今すぐ追加";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "保護者のメールアドレスを追加";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "今すぐ保護者のメールアドレスを追加";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "電話番号を追加";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "今すぐ電話番号を追加";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "メールアドレスの確認";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "電話番号を編集";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "コードを再送信";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "送信する";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "確認";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "メールアドレスを認証";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "電話番号を確認";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "保護者のメールアドレスを追加";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "メールアドレスを追加";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "アクセス拒否されないように注意！";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "忘れずに確認しましょう！";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "エラーが発生";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "友達があなたを見つけやすくしましょう！";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "帽子を無料でゲットしよう！";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "メールアドレスを認証";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "電話番号を登録";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"コードを入力（{number}桁）";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "コードを入力（{number}桁）";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "メールアドレス";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "エラーが発生";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "無効なメールアドレス";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "無効な電話番号";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "メールアドレスをお持ちでない場合。";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "電話をお持ちでない場合。";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "受信できない場合。";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "または";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "保護者のメールアドレス";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Robloxアカウントのパスワード";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "電話番号";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "メールアドレスでアカウントを保護してください！";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "保護者のメールアドレスでアカウントを保護してください！";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "電話番号でアカウントを保護してください！";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "メールを再送信";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "メールアドレスを認証して、アカウントを保護してください！";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "保護者のメールアドレスを認証して、アカウントを保護してください！";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Robloxアカウントのパスワード";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "国名リストの読み込み中にエラーが発生しました";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "メールアドレスを登録して帽子を無料でゲットして、アカウントにアクセス拒否されないようにしてしてください。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "保護者のメールアドレスを登録して帽子を無料でゲットして、アカウントにアクセス拒否されないようにしてください！";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "メールアドレスを入力してください。認証を完了するためのリンクをお送りします。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "保護者のメールアドレスを入力してください。認証を完了するためのリンクをお送りします。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "いつでもRobloxアカウントにアクセスできるようにするには、アカウントにメールアドレスを登録してください。";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "いつでもRobloxアカウントにアクセスできるようにするには、アカウントに保護者のメールアドレスを登録してください。";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "アカウントに電話番号を登録して、アカウントにアクセス拒否されないようにしてください。";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "電話番号を登録して帽子を無料でゲットして、アカウントにアクセス拒否されないようにしてください！";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "国コードを確認して、電話番号を入力してください。認証完了用のテキストメッセージが送信されます。（ご注意: 通信料がかかる場合があります）";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "メールアドレスを認証して、帽子を無料で手に入れましょう！";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "保護者のメールアドレスを認証して、帽子を無料で手に入れましょう！";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "アカウントに電話番号を登録して、友達に見つけてもらえるようにしましょう！";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"{phoneNumber}に送信されたコードを入力してください。";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "{phoneNumber}に送信されたコードを入力してください。";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "電話番号を認証しました。無料の帽子を受け取ってください！";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "電話番号が追加されました。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "認証用リンクをメールで送信しました - メールアドレスを認証して、アカウントを保護してください。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "いつでもRobloxアカウントにアクセスできるようにするには、メールアドレスを認証してしてください。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "いつでもRobloxアカウントにアクセスできるようにするには、保護者のメールアドレスを認証してください。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "認証用リンクを保護者のメールアドレスに送信しました - 保護者のメールアドレスを認証して、アカウントを保護してください。";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "認証用リンクをメールで送信しました - メールアドレスを認証して、アカウントを保護してください。「設定」>「アカウント情報」でいつでもアカウント設定を変更できます。";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "エラーが発生しました。後でもう一度お試しください。";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"コードは {number} 桁である必要があります";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "コードは {number} 桁である必要があります";
	}
}
