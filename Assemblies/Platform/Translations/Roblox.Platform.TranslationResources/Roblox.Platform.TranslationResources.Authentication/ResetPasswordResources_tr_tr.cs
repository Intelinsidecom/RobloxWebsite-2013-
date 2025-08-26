namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_tr_tr : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Ä°ptal Et";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Åžifreyi sÄ±fÄ±rlamak iÃ§in e-posta kullan";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "KullanÄ±cÄ± adÄ±nÄ± geri almak iÃ§in e-posta kullan";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Tamam";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "Åžifreyi sÄ±fÄ±rlamak iÃ§in telefon numarasÄ± kullan";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "KullanÄ±cÄ± adÄ±nÄ± geri almak iÃ§in telefon numarasÄ± kullan";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "DoÄŸrula";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Åžifreni sÄ±fÄ±rlamak iÃ§in e-posta adresini gir.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "KullanÄ±cÄ± adÄ±nÄ± geri almak iÃ§in e-posta adresini gir.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox Åžifre SÄ±fÄ±rlama";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Roblox HesabÄ± Åžifre SÄ±fÄ±rlama";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Åžifreni sÄ±fÄ±rlamak iÃ§in telefon numaranÄ± gir.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "KullanÄ±cÄ± adÄ±nÄ± geri almak iÃ§in telefon numaranÄ± gir.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Kodu DoÄŸrula";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Telefonu DoÄŸrula";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Åžifremi veya KullanÄ±cÄ± AdÄ±mÄ± unuttum";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Evet";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "Åžifremi Unuttum";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "KullanÄ±cÄ± AdÄ±mÄ± Unuttum";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "GeÃ§ersiz e-posta";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "GeÃ§ersiz telefon numarasÄ±";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "Tamam";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Åžifre";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Kodu Tekrar GÃ¶nder";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "GÃ¶nder";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Bu ayar, saÄŸladÄ±ÄŸÄ±n telefon numarasÄ±nÄ± kullanarak seni kimlerin bulabileceÄŸini kontrol eder.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "KullanÄ±cÄ± AdÄ±";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Telefon numaramla beni kimler bulabilir?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Bir hata oluÅŸtu. Daha sonra tekrar dene.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "E-posta adresini hesabÄ±na daha Ã¶nce kaydettiysen e-posta adresine iÃ§inde kullanÄ±cÄ± adÄ±nÄ±n veya adlarÄ±nÄ±n yer aldÄ±ÄŸÄ± bir e-posta gÃ¶nderildi.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "E-posta adresini hesabÄ±na daha Ã¶nce kaydettiysen e-posta adresine iÃ§inde talimatlarÄ±n yer aldÄ±ÄŸÄ± bir e-posta gÃ¶nderildi.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "E-posta GÃ¶nderildi";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Telefonunu hesabÄ±nda daha Ã¶nce doÄŸruladÄ±ysan bu telefona bir kod gÃ¶nderildi. LÃ¼tfen bu kodu aÅŸaÄŸÄ±ya yaz";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "E-postana gÃ¶nderdiÄŸimiz kodu gir.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Telefon numaranÄ± hesabÄ±nda daha Ã¶nce doÄŸruladÄ±ysan bu numarana kullanÄ±cÄ± adÄ±nÄ±n veya kullanÄ±cÄ± adlarÄ±nÄ±n yer aldÄ±ÄŸÄ± bir SMS gÃ¶nderildi.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS GÃ¶nderildi";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Bu hesaba baÄŸlÄ± e-posta bulunmuyor";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Hesap bulunmadÄ±. LÃ¼tfen farklÄ± bir e-posta adresi kullan.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Hesap bulunmadÄ±. LÃ¼tfen farklÄ± bir telefon numarasÄ± kullan.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Sistem hatasÄ±. Hesap, bu durumuna yenilenemedi.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Senin bir robot olmadÄ±ÄŸÄ±ndan emin olmamÄ±z gerekiyor!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "GirdiÄŸin kelimeler resimle eÅŸleÅŸmedi. LÃ¼tfen tekrar dene.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "KullanÄ±cÄ± adÄ±n ya da ÅŸifren hatalÄ±. LÃ¼tfen bunlarÄ± kontrol edip tekrar dene.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Ã‡ok sayÄ±da deneme. LÃ¼tfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Ã–zellik geÃ§ici olarak devre dÄ±ÅŸÄ±. LÃ¼tfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "GiriÅŸ talimatlarÄ± iÃ§in e-posta'larÄ±nÄ± kontrol et";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "Hesap durumu, ÅŸifre sÄ±fÄ±rlamayÄ± engelliyor";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "GeÃ§ersiz ÅŸifre";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Bu gÃ¼venlik biletini yÃ¼kleyemedik.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "GeÃ§ersiz kullanÄ±cÄ± adÄ± veya e-posta mevcut deÄŸil";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Bu e-posta adresine baÄŸlÄ± hesap bulunmuyor";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "GÃ¶rÃ¼nÃ¼ÅŸe bakÄ±lÄ±rsa deÄŸiÅŸmiÅŸ bir kullanÄ±cÄ± adÄ±yla giriÅŸ yapmaya Ã§alÄ±ÅŸÄ±yorsun. LÃ¼tfen yeni kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "ÃœzgÃ¼nÃ¼z, bu ÅŸifre kullanÄ±lamÄ±yor.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Åžifreler eÅŸleÅŸmiyor";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Kimlik doÄŸrulamayÄ± bitirmek iÃ§in Roblox'a giriÅŸ yapmalÄ±sÄ±n.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Bilinmeyen Hata";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Sistem hatasÄ±. LÃ¼tfen giriÅŸ ekranÄ±na dÃ¶n.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "E-posta";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Telefon NumarasÄ±";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Åžifre sÄ±fÄ±rlama baÅŸarÄ±lÄ±! LÃ¼tfen tekrar giriÅŸ yap.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "BaÅŸarÄ±lÄ±";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Ã‡ok sayÄ±da deneme. LÃ¼tfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "Mevcut ÅŸifren doÄŸru deÄŸil, ÅŸifre deÄŸiÅŸtirilmedi.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Yeni ÅŸifre ve doÄŸrulama ÅŸifresi doldurulmalÄ±dÄ±r";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Yeni ÅŸifren ve doÄŸrulama ÅŸifren eÅŸleÅŸmelidir";

	public ResetPasswordResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Ä°ptal Et";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Åžifreyi sÄ±fÄ±rlamak iÃ§in e-posta kullan";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "KullanÄ±cÄ± adÄ±nÄ± geri almak iÃ§in e-posta kullan";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Tamam";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Åžifreyi sÄ±fÄ±rlamak iÃ§in telefon numarasÄ± kullan";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "KullanÄ±cÄ± adÄ±nÄ± geri almak iÃ§in telefon numarasÄ± kullan";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "DoÄŸrula";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"Åžu Roblox hesabÄ±nÄ±n ÅŸifresinin deÄŸiÅŸtiÄŸini fark ettik: {userName}. DeÄŸiÅŸtirmek istemediysen veya bir baÅŸkasÄ±nÄ±n yanlÄ±ÅŸlÄ±kla deÄŸiÅŸtirdiÄŸini dÃ¼ÅŸÃ¼nÃ¼yorsan bu eylemi geri almak iÃ§in lÃ¼tfen bu baÄŸlantÄ±ya tÄ±kla:{lineBreak} {actionLink} {lineBreak}{lineBreak}Yeni Roblox ÅŸifrenden memnunsan bir ÅŸey yapmana gerek yok! Åžifre zaten ayarlandÄ±. LÃ¼tfen bu mesaja yanÄ±t verme. Herhangi bir sorun varsa lÃ¼tfen Roblox yardÄ±m sayfasÄ±nÄ± incele (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Åžu Roblox hesabÄ±nÄ±n ÅŸifresinin deÄŸiÅŸtiÄŸini fark ettik: {userName}. DeÄŸiÅŸtirmek istemediysen veya bir baÅŸkasÄ±nÄ±n yanlÄ±ÅŸlÄ±kla deÄŸiÅŸtirdiÄŸini dÃ¼ÅŸÃ¼nÃ¼yorsan bu eylemi geri almak iÃ§in lÃ¼tfen bu baÄŸlantÄ±ya tÄ±kla:{lineBreak} {actionLink} {lineBreak}{lineBreak}Yeni Roblox ÅŸifrenden memnunsan bir ÅŸey yapmana gerek yok! Åžifre zaten ayarlandÄ±. LÃ¼tfen bu mesaja yanÄ±t verme. Herhangi bir sorun varsa lÃ¼tfen Roblox yardÄ±m sayfasÄ±nÄ± incele (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Åžifreni sÄ±fÄ±rlamak iÃ§in e-posta adresini gir.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "KullanÄ±cÄ± adÄ±nÄ± geri almak iÃ§in e-posta adresini gir.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Åžu Roblox hesabÄ±nÄ±n ÅŸifresinin deÄŸiÅŸtiÄŸini fark ettik: {userName}. DeÄŸiÅŸtirmek istemediysen veya bir baÅŸkasÄ±nÄ±n yanlÄ±ÅŸlÄ±kla deÄŸiÅŸtirdiÄŸini dÃ¼ÅŸÃ¼nÃ¼yorsan bu eylemi geri almak iÃ§in lÃ¼tfen bu baÄŸlantÄ±ya tÄ±kla:\n{urlWithTicket}\n\nYeni Roblox ÅŸifrenden memnunsan bir ÅŸey yapmana gerek yok! Åžifre zaten ayarlandÄ±. LÃ¼tfen bu mesaja yanÄ±t verme. Herhangi bir sorun varsa lÃ¼tfen Roblox yardÄ±m sayfasÄ±nÄ± incele (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Åžu Roblox hesabÄ±nÄ±n ÅŸifresinin deÄŸiÅŸtiÄŸini fark ettik: {userName}. DeÄŸiÅŸtirmek istemediysen veya bir baÅŸkasÄ±nÄ±n yanlÄ±ÅŸlÄ±kla deÄŸiÅŸtirdiÄŸini dÃ¼ÅŸÃ¼nÃ¼yorsan bu eylemi geri almak iÃ§in lÃ¼tfen bu baÄŸlantÄ±ya tÄ±kla:\n{urlWithTicket}\n\nYeni Roblox ÅŸifrenden memnunsan bir ÅŸey yapmana gerek yok! Åžifre zaten ayarlandÄ±. LÃ¼tfen bu mesaja yanÄ±t verme. Herhangi bir sorun varsa lÃ¼tfen Roblox yardÄ±m sayfasÄ±nÄ± incele (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Roblox Åžifre SÄ±fÄ±rlama\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Roblox Åžifre SÄ±fÄ±rlama\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox Åžifre SÄ±fÄ±rlama";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox Åžifre SÄ±fÄ±rlama{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox Åžifre SÄ±fÄ±rlama{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Åžu Roblox hesabÄ±nÄ±n ÅŸifresini sÄ±fÄ±rlamak iÃ§in bir talep aldÄ±k: {emailOrUsername}{lineBreak}{lineBreak}Bu talebi sen gÃ¶nderdiysen ilerlemek iÃ§in lÃ¼tfen aÅŸaÄŸÄ±daki dÃ¼ÄŸmeye tÄ±kla.{lineBreak}Bu dÃ¼ÄŸme {passwordResetTicketHours} saat, {passwordResetTicketMinutes} dakika boyunca geÃ§erli olacak. Åžifreni sÄ±fÄ±rlamak istemiyorsan lÃ¼tfen bu bildirimi gÃ¶rmezden gel.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Åžifreni SÄ±fÄ±rla{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Åžu Roblox hesabÄ±nÄ±n ÅŸifresini sÄ±fÄ±rlamak iÃ§in bir talep aldÄ±k: {emailOrUsername}{lineBreak}{lineBreak}Bu talebi sen gÃ¶nderdiysen ilerlemek iÃ§in lÃ¼tfen aÅŸaÄŸÄ±daki dÃ¼ÄŸmeye tÄ±kla.{lineBreak}Bu dÃ¼ÄŸme {passwordResetTicketHours} saat, {passwordResetTicketMinutes} dakika boyunca geÃ§erli olacak. Åžifreni sÄ±fÄ±rlamak istemiyorsan lÃ¼tfen bu bildirimi gÃ¶rmezden gel.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Åžifreni SÄ±fÄ±rla{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Åžu Roblox hesabÄ±nÄ±n ÅŸifresini sÄ±fÄ±rlamak iÃ§in bir talep aldÄ±k: {emailOrUsername}{lineBreak}{lineBreak}Bu talebi sen gÃ¶nderdiysen ilerlemek iÃ§in lÃ¼tfen aÅŸaÄŸÄ±daki baÄŸlantÄ±ya tÄ±kla veya onu bir tarayÄ±cÄ±ya yapÄ±ÅŸtÄ±r.{lineBreak}Bu baÄŸlantÄ± {passwordResetTicketHours} saat, {passwordResetTicketMinutes} dakika boyunca geÃ§erli olacak. Åžifreni sÄ±fÄ±rlamak istemiyorsan lÃ¼tfen bu bildirimi gÃ¶rmezden gel.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Åžu Roblox hesabÄ±nÄ±n ÅŸifresini sÄ±fÄ±rlamak iÃ§in bir talep aldÄ±k: {emailOrUsername}{lineBreak}{lineBreak}Bu talebi sen gÃ¶nderdiysen ilerlemek iÃ§in lÃ¼tfen aÅŸaÄŸÄ±daki baÄŸlantÄ±ya tÄ±kla veya onu bir tarayÄ±cÄ±ya yapÄ±ÅŸtÄ±r.{lineBreak}Bu baÄŸlantÄ± {passwordResetTicketHours} saat, {passwordResetTicketMinutes} dakika boyunca geÃ§erli olacak. Åžifreni sÄ±fÄ±rlamak istemiyorsan lÃ¼tfen bu bildirimi gÃ¶rmezden gel.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox HesabÄ± Åžifre SÄ±fÄ±rlama";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Åžifreni sÄ±fÄ±rlamak iÃ§in telefon numaranÄ± gir.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "KullanÄ±cÄ± adÄ±nÄ± geri almak iÃ§in telefon numaranÄ± gir.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Kodu DoÄŸrula";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Telefonu DoÄŸrula";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Åžifremi veya KullanÄ±cÄ± AdÄ±mÄ± unuttum";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Evet";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Åžifremi Unuttum";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "KullanÄ±cÄ± AdÄ±mÄ± Unuttum";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "GeÃ§ersiz e-posta";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "GeÃ§ersiz telefon numarasÄ±";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "Tamam";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Åžifre";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Kodu Tekrar GÃ¶nder";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "GÃ¶nder";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Bu ayar, saÄŸladÄ±ÄŸÄ±n telefon numarasÄ±nÄ± kullanarak seni kimlerin bulabileceÄŸini kontrol eder.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "KullanÄ±cÄ± AdÄ±";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Telefon numaramla beni kimler bulabilir?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"HesabÄ±nÄ± oluÅŸtururken bize {styleStart}gerÃ§ek bir e-posta adresi{styleEnd} vermediysen sana e-posta gÃ¶nderemeyiz.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "HesabÄ±nÄ± oluÅŸtururken bize {styleStart}gerÃ§ek bir e-posta adresi{styleEnd} vermediysen sana e-posta gÃ¶nderemeyiz.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Bir hata oluÅŸtu. Daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "E-posta adresini hesabÄ±na daha Ã¶nce kaydettiysen e-posta adresine iÃ§inde kullanÄ±cÄ± adÄ±nÄ±n veya adlarÄ±nÄ±n yer aldÄ±ÄŸÄ± bir e-posta gÃ¶nderildi.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "E-posta adresini hesabÄ±na daha Ã¶nce kaydettiysen e-posta adresine iÃ§inde talimatlarÄ±n yer aldÄ±ÄŸÄ± bir e-posta gÃ¶nderildi.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "E-posta GÃ¶nderildi";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Telefonunu hesabÄ±nda daha Ã¶nce doÄŸruladÄ±ysan bu telefona bir kod gÃ¶nderildi. LÃ¼tfen bu kodu aÅŸaÄŸÄ±ya yaz";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "E-postana gÃ¶nderdiÄŸimiz kodu gir.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Telefon numaranÄ± hesabÄ±nda daha Ã¶nce doÄŸruladÄ±ysan bu numarana kullanÄ±cÄ± adÄ±nÄ±n veya kullanÄ±cÄ± adlarÄ±nÄ±n yer aldÄ±ÄŸÄ± bir SMS gÃ¶nderildi.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS GÃ¶nderildi";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Bu hesaba baÄŸlÄ± e-posta bulunmuyor";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Hesap bulunmadÄ±. LÃ¼tfen farklÄ± bir e-posta adresi kullan.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Hesap bulunmadÄ±. LÃ¼tfen farklÄ± bir telefon numarasÄ± kullan.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Sistem hatasÄ±. Hesap, bu durumuna yenilenemedi.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Senin bir robot olmadÄ±ÄŸÄ±ndan emin olmamÄ±z gerekiyor!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "GirdiÄŸin kelimeler resimle eÅŸleÅŸmedi. LÃ¼tfen tekrar dene.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "KullanÄ±cÄ± adÄ±n ya da ÅŸifren hatalÄ±. LÃ¼tfen bunlarÄ± kontrol edip tekrar dene.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Ã‡ok sayÄ±da deneme. LÃ¼tfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Ã–zellik geÃ§ici olarak devre dÄ±ÅŸÄ±. LÃ¼tfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "GiriÅŸ talimatlarÄ± iÃ§in e-posta'larÄ±nÄ± kontrol et";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Hesap durumu, ÅŸifre sÄ±fÄ±rlamayÄ± engelliyor";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "GeÃ§ersiz ÅŸifre";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Bu gÃ¼venlik biletini yÃ¼kleyemedik.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "GeÃ§ersiz kullanÄ±cÄ± adÄ± veya e-posta mevcut deÄŸil";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Bu e-posta adresine baÄŸlÄ± hesap bulunmuyor";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "GÃ¶rÃ¼nÃ¼ÅŸe bakÄ±lÄ±rsa deÄŸiÅŸmiÅŸ bir kullanÄ±cÄ± adÄ±yla giriÅŸ yapmaya Ã§alÄ±ÅŸÄ±yorsun. LÃ¼tfen yeni kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "ÃœzgÃ¼nÃ¼z, bu ÅŸifre kullanÄ±lamÄ±yor.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"ÃœzgÃ¼nÃ¼z, ÅŸifre sÄ±fÄ±rlama isteklerinin sÃ¼resi, talep edildikten {expirationHour} saat {expirationMinute} dakika sonra dolar. Yeniden ÅŸifre sÄ±fÄ±rlama bileti talep etmeyi dene.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "ÃœzgÃ¼nÃ¼z, ÅŸifre sÄ±fÄ±rlama isteklerinin sÃ¼resi, talep edildikten {expirationHour} saat {expirationMinute} dakika sonra dolar. Yeniden ÅŸifre sÄ±fÄ±rlama bileti talep etmeyi dene.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Åžifreler eÅŸleÅŸmiyor";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Kimlik doÄŸrulamayÄ± bitirmek iÃ§in Roblox'a giriÅŸ yapmalÄ±sÄ±n.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Bilinmeyen Hata";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Sistem hatasÄ±. LÃ¼tfen giriÅŸ ekranÄ±na dÃ¶n.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "E-posta";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"Kodu Gir ({codeLength} hane)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Kodu Gir ({codeLength} hane)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Telefon NumarasÄ±";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Åžifre sÄ±fÄ±rlama baÅŸarÄ±lÄ±! LÃ¼tfen tekrar giriÅŸ yap.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "BaÅŸarÄ±lÄ±";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Ã‡ok sayÄ±da deneme. LÃ¼tfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Mevcut ÅŸifren doÄŸru deÄŸil, ÅŸifre deÄŸiÅŸtirilmedi.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Yeni ÅŸifre ve doÄŸrulama ÅŸifresi doldurulmalÄ±dÄ±r";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Yeni ÅŸifren ve doÄŸrulama ÅŸifren eÅŸleÅŸmelidir";
	}
}


}
