namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "İptal Et";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Şifreyi sıfırlamak için e-posta kullan";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Kullanıcı adını geri almak için e-posta kullan";

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
	public override string ActionPhoneToResetPassword => "Şifreyi sıfırlamak için telefon numarası kullan";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Kullanıcı adını geri almak için telefon numarası kullan";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Doğrula";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Şifreni sıfırlamak için e-posta adresini gir.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Kullanıcı adını geri almak için e-posta adresini gir.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox Şifre Sıfırlama";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Roblox Hesabı Şifre Sıfırlama";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Şifreni sıfırlamak için telefon numaranı gir.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Kullanıcı adını geri almak için telefon numaranı gir.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Kodu Doğrula";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Telefonu Doğrula";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Şifremi veya Kullanıcı Adımı unuttum";

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
	public override string LabelForgetMyPassword => "Şifremi Unuttum";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Kullanıcı Adımı Unuttum";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Geçersiz e-posta";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Geçersiz telefon numarası";

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
	public override string LabelPassword => "Şifre";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Kodu Tekrar Gönder";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Gönder";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Bu ayar, sağladığın telefon numarasını kullanarak seni kimlerin bulabileceğini kontrol eder.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Kullanıcı Adı";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Telefon numaramla beni kimler bulabilir?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Bir hata oluştu. Daha sonra tekrar dene.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "E-posta adresini hesabına daha önce kaydettiysen e-posta adresine içinde kullanıcı adının veya adlarının yer aldığı bir e-posta gönderildi.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "E-posta adresini hesabına daha önce kaydettiysen e-posta adresine içinde talimatların yer aldığı bir e-posta gönderildi.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "E-posta Gönderildi";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Telefonunu hesabında daha önce doğruladıysan bu telefona bir kod gönderildi. Lütfen bu kodu aşağıya yaz";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "E-postana gönderdiğimiz kodu gir.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Telefon numaranı hesabında daha önce doğruladıysan bu numarana kullanıcı adının veya kullanıcı adlarının yer aldığı bir SMS gönderildi.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS Gönderildi";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Bu hesaba bağlı e-posta bulunmuyor";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Hesap bulunmadı. Lütfen farklı bir e-posta adresi kullan.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Hesap bulunmadı. Lütfen farklı bir telefon numarası kullan.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Sistem hatası. Hesap, bu durumuna yenilenemedi.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Senin bir robot olmadığından emin olmamız gerekiyor!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Girdiğin kelimeler resimle eşleşmedi. Lütfen tekrar dene.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Kullanıcı adın ya da şifren hatalı. Lütfen bunları kontrol edip tekrar dene.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Çok sayıda deneme. Lütfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Özellik geçici olarak devre dışı. Lütfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Giriş talimatları için e-posta'larını kontrol et";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "Hesap durumu, şifre sıfırlamayı engelliyor";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Geçersiz şifre";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Bu güvenlik biletini yükleyemedik.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Geçersiz kullanıcı adı veya e-posta mevcut değil";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Bu e-posta adresine bağlı hesap bulunmuyor";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Görünüşe bakılırsa değişmiş bir kullanıcı adıyla giriş yapmaya çalışıyorsun. Lütfen yeni kullanıcı adınla giriş yap.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Üzgünüz, bu şifre kullanılamıyor.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Şifreler eşleşmiyor";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Kimlik doğrulamayı bitirmek için Roblox'a giriş yapmalısın.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Bilinmeyen Hata";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Sistem hatası. Lütfen giriş ekranına dön.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "E-posta";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Telefon Numarası";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Şifre sıfırlama başarılı! Lütfen tekrar giriş yap.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Başarılı";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Çok sayıda deneme. Lütfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "Mevcut şifren doğru değil, şifre değiştirilmedi.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Yeni şifre ve doğrulama şifresi doldurulmalıdır";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Yeni şifren ve doğrulama şifren eşleşmelidir";

	public ResetPasswordResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "İptal Et";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Şifreyi sıfırlamak için e-posta kullan";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Kullanıcı adını geri almak için e-posta kullan";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Tamam";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Şifreyi sıfırlamak için telefon numarası kullan";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Kullanıcı adını geri almak için telefon numarası kullan";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Doğrula";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"Şu Roblox hesabının şifresinin değiştiğini fark ettik: {userName}. Değiştirmek istemediysen veya bir başkasının yanlışlıkla değiştirdiğini düşünüyorsan bu eylemi geri almak için lütfen bu bağlantıya tıkla:{lineBreak} {actionLink} {lineBreak}{lineBreak}Yeni Roblox şifrenden memnunsan bir şey yapmana gerek yok! Şifre zaten ayarlandı. Lütfen bu mesaja yanıt verme. Herhangi bir sorun varsa lütfen Roblox yardım sayfasını incele (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Şu Roblox hesabının şifresinin değiştiğini fark ettik: {userName}. Değiştirmek istemediysen veya bir başkasının yanlışlıkla değiştirdiğini düşünüyorsan bu eylemi geri almak için lütfen bu bağlantıya tıkla:{lineBreak} {actionLink} {lineBreak}{lineBreak}Yeni Roblox şifrenden memnunsan bir şey yapmana gerek yok! Şifre zaten ayarlandı. Lütfen bu mesaja yanıt verme. Herhangi bir sorun varsa lütfen Roblox yardım sayfasını incele (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Şifreni sıfırlamak için e-posta adresini gir.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Kullanıcı adını geri almak için e-posta adresini gir.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Şu Roblox hesabının şifresinin değiştiğini fark ettik: {userName}. Değiştirmek istemediysen veya bir başkasının yanlışlıkla değiştirdiğini düşünüyorsan bu eylemi geri almak için lütfen bu bağlantıya tıkla:\n{urlWithTicket}\n\nYeni Roblox şifrenden memnunsan bir şey yapmana gerek yok! Şifre zaten ayarlandı. Lütfen bu mesaja yanıt verme. Herhangi bir sorun varsa lütfen Roblox yardım sayfasını incele (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Şu Roblox hesabının şifresinin değiştiğini fark ettik: {userName}. Değiştirmek istemediysen veya bir başkasının yanlışlıkla değiştirdiğini düşünüyorsan bu eylemi geri almak için lütfen bu bağlantıya tıkla:\n{urlWithTicket}\n\nYeni Roblox şifrenden memnunsan bir şey yapmana gerek yok! Şifre zaten ayarlandı. Lütfen bu mesaja yanıt verme. Herhangi bir sorun varsa lütfen Roblox yardım sayfasını incele (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Roblox Şifre Sıfırlama\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Roblox Şifre Sıfırlama\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox Şifre Sıfırlama";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox Şifre Sıfırlama{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox Şifre Sıfırlama{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Şu Roblox hesabının şifresini sıfırlamak için bir talep aldık: {emailOrUsername}{lineBreak}{lineBreak}Bu talebi sen gönderdiysen ilerlemek için lütfen aşağıdaki düğmeye tıkla.{lineBreak}Bu düğme {passwordResetTicketHours} saat, {passwordResetTicketMinutes} dakika boyunca geçerli olacak. Şifreni sıfırlamak istemiyorsan lütfen bu bildirimi görmezden gel.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Şifreni Sıfırla{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Şu Roblox hesabının şifresini sıfırlamak için bir talep aldık: {emailOrUsername}{lineBreak}{lineBreak}Bu talebi sen gönderdiysen ilerlemek için lütfen aşağıdaki düğmeye tıkla.{lineBreak}Bu düğme {passwordResetTicketHours} saat, {passwordResetTicketMinutes} dakika boyunca geçerli olacak. Şifreni sıfırlamak istemiyorsan lütfen bu bildirimi görmezden gel.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Şifreni Sıfırla{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Şu Roblox hesabının şifresini sıfırlamak için bir talep aldık: {emailOrUsername}{lineBreak}{lineBreak}Bu talebi sen gönderdiysen ilerlemek için lütfen aşağıdaki bağlantıya tıkla veya onu bir tarayıcıya yapıştır.{lineBreak}Bu bağlantı {passwordResetTicketHours} saat, {passwordResetTicketMinutes} dakika boyunca geçerli olacak. Şifreni sıfırlamak istemiyorsan lütfen bu bildirimi görmezden gel.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Şu Roblox hesabının şifresini sıfırlamak için bir talep aldık: {emailOrUsername}{lineBreak}{lineBreak}Bu talebi sen gönderdiysen ilerlemek için lütfen aşağıdaki bağlantıya tıkla veya onu bir tarayıcıya yapıştır.{lineBreak}Bu bağlantı {passwordResetTicketHours} saat, {passwordResetTicketMinutes} dakika boyunca geçerli olacak. Şifreni sıfırlamak istemiyorsan lütfen bu bildirimi görmezden gel.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox Hesabı Şifre Sıfırlama";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Şifreni sıfırlamak için telefon numaranı gir.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Kullanıcı adını geri almak için telefon numaranı gir.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Kodu Doğrula";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Telefonu Doğrula";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Şifremi veya Kullanıcı Adımı unuttum";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Evet";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Şifremi Unuttum";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Kullanıcı Adımı Unuttum";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Geçersiz e-posta";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Geçersiz telefon numarası";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "Tamam";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Şifre";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Kodu Tekrar Gönder";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Gönder";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Bu ayar, sağladığın telefon numarasını kullanarak seni kimlerin bulabileceğini kontrol eder.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Kullanıcı Adı";
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
		return $"Hesabını oluştururken bize {styleStart}gerçek bir e-posta adresi{styleEnd} vermediysen sana e-posta gönderemeyiz.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Hesabını oluştururken bize {styleStart}gerçek bir e-posta adresi{styleEnd} vermediysen sana e-posta gönderemeyiz.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Bir hata oluştu. Daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "E-posta adresini hesabına daha önce kaydettiysen e-posta adresine içinde kullanıcı adının veya adlarının yer aldığı bir e-posta gönderildi.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "E-posta adresini hesabına daha önce kaydettiysen e-posta adresine içinde talimatların yer aldığı bir e-posta gönderildi.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "E-posta Gönderildi";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Telefonunu hesabında daha önce doğruladıysan bu telefona bir kod gönderildi. Lütfen bu kodu aşağıya yaz";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "E-postana gönderdiğimiz kodu gir.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Telefon numaranı hesabında daha önce doğruladıysan bu numarana kullanıcı adının veya kullanıcı adlarının yer aldığı bir SMS gönderildi.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS Gönderildi";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Bu hesaba bağlı e-posta bulunmuyor";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Hesap bulunmadı. Lütfen farklı bir e-posta adresi kullan.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Hesap bulunmadı. Lütfen farklı bir telefon numarası kullan.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Sistem hatası. Hesap, bu durumuna yenilenemedi.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Senin bir robot olmadığından emin olmamız gerekiyor!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Girdiğin kelimeler resimle eşleşmedi. Lütfen tekrar dene.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Kullanıcı adın ya da şifren hatalı. Lütfen bunları kontrol edip tekrar dene.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Çok sayıda deneme. Lütfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Özellik geçici olarak devre dışı. Lütfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Giriş talimatları için e-posta'larını kontrol et";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Hesap durumu, şifre sıfırlamayı engelliyor";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Geçersiz şifre";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Bu güvenlik biletini yükleyemedik.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Geçersiz kullanıcı adı veya e-posta mevcut değil";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Bu e-posta adresine bağlı hesap bulunmuyor";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Görünüşe bakılırsa değişmiş bir kullanıcı adıyla giriş yapmaya çalışıyorsun. Lütfen yeni kullanıcı adınla giriş yap.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Üzgünüz, bu şifre kullanılamıyor.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Üzgünüz, şifre sıfırlama isteklerinin süresi, talep edildikten {expirationHour} saat {expirationMinute} dakika sonra dolar. Yeniden şifre sıfırlama bileti talep etmeyi dene.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Üzgünüz, şifre sıfırlama isteklerinin süresi, talep edildikten {expirationHour} saat {expirationMinute} dakika sonra dolar. Yeniden şifre sıfırlama bileti talep etmeyi dene.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Şifreler eşleşmiyor";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Kimlik doğrulamayı bitirmek için Roblox'a giriş yapmalısın.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Bilinmeyen Hata";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Sistem hatası. Lütfen giriş ekranına dön.";
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
		return "Telefon Numarası";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Şifre sıfırlama başarılı! Lütfen tekrar giriş yap.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Başarılı";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Çok sayıda deneme. Lütfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Mevcut şifren doğru değil, şifre değiştirilmedi.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Yeni şifre ve doğrulama şifresi doldurulmalıdır";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Yeni şifren ve doğrulama şifren eşleşmelidir";
	}
}
