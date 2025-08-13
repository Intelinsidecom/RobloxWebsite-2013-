namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_id_id : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Batal";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Gunakan email untuk mengatur ulang kata sandi";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Gunakan email untuk mendapatkan nama pengguna";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OKE";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "Gunakan nomor telepon untuk mengatur ulang kata sandi";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Gunakan nomor telepon untuk mendapatkan nama pengguna";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verifikasi";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Masukkan emailmu untuk mengatur ulang kata sandi.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Masukkan emailmu untuk mendapatkan nama penggunamu.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Reset Kata Sandi Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Reset Kata Sandi Akun Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Masukkan nomor teleponmu untuk mengatur ulang kata sandi.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Masukkan nomor teleponmu untuk mendapatkan nama penggunamu.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Verifikasi Kode";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Verifikasi Telepon";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Lupa Kata Sandi atau Nama Pengguna";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Ya";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "Lupa Kata Sandi";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Lupa Nama Pengguna";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Email tidak valid";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Nomor telepon tidak valid";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "OKE";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Kata sandi";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Kirim Ulang Kode";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Kirim";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Pengaturan ini mengontrol siapa saja yang bisa mencarimu menggunakan nomor telepon yang kamu berikan.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nama pengguna";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Siapa yang bisa mencariku menggunakan nomor teleponku?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Terjadi kesalahan, harap coba lagi nanti.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Email berisi nama penggunamu sudah terkirim jika emailmu sudah disimpan di akunmu.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Kami sudah mengirimkan email berisi instruksi jika emailmu sudah disimpan di akunmu.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "Email Terkirim";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Kami sudah mengirimkan kode sudah ke ponselmu jika nomornya sudah terverifikasi di akunmu. Masukkan kodenya di bawah ini";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Masukkan kode yang baru saja kami kirimkan ke emailmu.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Kami sudah mengirimkan SMS berisi nama penggunamu jika nomor ponselmu sudah diverifikasi di akunmu.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS Terkirim";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Tidak ada email yang terhubung ke akun ini";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Akun tidak ditemukan. Harap gunakan email lain.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Akun tidak ditemukan. Harap gunakan nomor telepon lain.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Kesalahan Sistem. Akun tidak dapat dipulihkan ke kondisi ini.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Kami perlu memastikan kamu bukan robot!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Kata yang kamu ketikkan tidak sesuai dengan gambar. Harap coba lagi.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Nama pengguna atau kata sandimu salah. Harap periksa ulang kemudian coba lagi.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Terlalu banyak percobaan. Harap coba lagi nanti.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Fitur dinonaktifkan sementara. Harap coba lagi nanti.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Lihat emailmu untuk membaca petunjuk masuk";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "Status akun mencegah pengaturan ulang kata sandi";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Kata sandi tidak valid";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Kami tidak dapat memuat tiket keamanan ini.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Nama pengguna tidak valid, atau email tidak ada";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Tidak ada akun yang terhubung ke alamat email ini";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Sepertinya kamu mencoba masuk dengan nama pengguna yang sudah berubah. Harap masuk dengan nama penggunamu yang baru.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Maaf, kata sandi itu tidak bisa digunakan.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Kata sandi tidak sesuai";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Kamu harus masuk ke Roblox untuk menyelesaikan otentikasi.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Kesalahan Tidak Dikenal";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Kesalahan sistem. Harap kembali ke halaman masuk.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "Email";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Nomor Telepon";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Pengaturan ulang kata sandi berhasil! Silakan masuk lagi.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Berhasil";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Terlalu banyak percobaan. Harap coba lagi nanti.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "Kata sandimu saat ini salah, kata sandi tidak diubah.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Harus mencantumkan kata sandi baru dan kata sandi konfirmasi";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Kata sandi baru dan kata sandi konfirmasimu harus sesuai";

	public ResetPasswordResources_id_id(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Batal";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Gunakan email untuk mengatur ulang kata sandi";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Gunakan email untuk mendapatkan nama pengguna";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OKE";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Gunakan nomor telepon untuk mengatur ulang kata sandi";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Gunakan nomor telepon untuk mendapatkan nama pengguna";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verifikasi";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"Kami mendapati perubahan kata sandi untuk akun Roblox Anda: {userName}. Jika Anda tidak bermaksud mengubahnya, atau menurut Anda orang lain tidak sengaja mengubahnya, klik tautan ini untuk membatalkan tindakan tersebut:{lineBreak} {actionLink} {lineBreak}{lineBreak}Jika tidak keberatan dengan kata sandi Roblox baru Anda, Anda tidak perlu melakukan apa pun! Semua sudah beres. Harap tidak membalas pesan ini. Jika Anda memiliki pertanyaan, kunjungi halaman bantuan Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Kami mendapati perubahan kata sandi untuk akun Roblox Anda: {userName}. Jika Anda tidak bermaksud mengubahnya, atau menurut Anda orang lain tidak sengaja mengubahnya, klik tautan ini untuk membatalkan tindakan tersebut:{lineBreak} {actionLink} {lineBreak}{lineBreak}Jika tidak keberatan dengan kata sandi Roblox baru Anda, Anda tidak perlu melakukan apa pun! Semua sudah beres. Harap tidak membalas pesan ini. Jika Anda memiliki pertanyaan, kunjungi halaman bantuan Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Masukkan emailmu untuk mengatur ulang kata sandi.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Masukkan emailmu untuk mendapatkan nama penggunamu.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Kami mendapati perubahan kata sandi untuk akun Roblox Anda: {userName}. Jika Anda tidak bermaksud mengubahnya, atau menurut Anda orang lain tidak sengaja mengubahnya, klik tautan ini untuk membatalkan tindakan tersebut:\n{urlWithTicket}\n\nJika tidak keberatan dengan kata sandi Roblox baru Anda, Anda tidak perlu melakukan apa pun! Semua sudah beres. Harap tidak membalas pesan ini. Jika Anda memiliki pertanyaan, kunjungi halaman bantuan Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Kami mendapati perubahan kata sandi untuk akun Roblox Anda: {userName}. Jika Anda tidak bermaksud mengubahnya, atau menurut Anda orang lain tidak sengaja mengubahnya, klik tautan ini untuk membatalkan tindakan tersebut:\n{urlWithTicket}\n\nJika tidak keberatan dengan kata sandi Roblox baru Anda, Anda tidak perlu melakukan apa pun! Semua sudah beres. Harap tidak membalas pesan ini. Jika Anda memiliki pertanyaan, kunjungi halaman bantuan Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Reset Kata Sandi Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Reset Kata Sandi Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Reset Kata Sandi Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Reset Kata Sandi Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Reset Kata Sandi Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Kami menerima permintaan untuk me-reset kata sandi akun Roblox Anda: {emailOrUsername}{lineBreak}{lineBreak}Jika Anda mengirim permintaan ini, klik tombol di bawah ini untuk melanjutkan.{lineBreak}Tombol ini akan aktif selama {passwordResetTicketHours} jam, {passwordResetTicketMinutes} menit. Jika Anda tidak ingin me-reset kata sandi, harap abaikan pemberitahuan ini.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Kata Sandi{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Kami menerima permintaan untuk me-reset kata sandi akun Roblox Anda: {emailOrUsername}{lineBreak}{lineBreak}Jika Anda mengirim permintaan ini, klik tombol di bawah ini untuk melanjutkan.{lineBreak}Tombol ini akan aktif selama {passwordResetTicketHours} jam, {passwordResetTicketMinutes} menit. Jika Anda tidak ingin me-reset kata sandi, harap abaikan pemberitahuan ini.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Kata Sandi{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Kami menerima permintaan untuk me-reset kata sandi akun Roblox Anda: {emailOrUsername}{lineBreak}{lineBreak}Jika Anda mengirim permintaan ini, klik tautan di bawah ini atau tempelkan tautan ke browser web untuk melanjutkan.{lineBreak}Tautan ini akan aktif selama {passwordResetTicketHours} jam, {passwordResetTicketMinutes} menit. Jika Anda tidak ingin me-reset kata sandi, harap abaikan pemberitahuan ini.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Kami menerima permintaan untuk me-reset kata sandi akun Roblox Anda: {emailOrUsername}{lineBreak}{lineBreak}Jika Anda mengirim permintaan ini, klik tautan di bawah ini atau tempelkan tautan ke browser web untuk melanjutkan.{lineBreak}Tautan ini akan aktif selama {passwordResetTicketHours} jam, {passwordResetTicketMinutes} menit. Jika Anda tidak ingin me-reset kata sandi, harap abaikan pemberitahuan ini.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Reset Kata Sandi Akun Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Masukkan nomor teleponmu untuk mengatur ulang kata sandi.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Masukkan nomor teleponmu untuk mendapatkan nama penggunamu.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Verifikasi Kode";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Verifikasi Telepon";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Lupa Kata Sandi atau Nama Pengguna";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Ya";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Lupa Kata Sandi";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Lupa Nama Pengguna";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Email tidak valid";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Nomor telepon tidak valid";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "OKE";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Kata sandi";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Kirim Ulang Kode";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Kirim";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Pengaturan ini mengontrol siapa saja yang bisa mencarimu menggunakan nomor telepon yang kamu berikan.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nama pengguna";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Siapa yang bisa mencariku menggunakan nomor teleponku?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Jika kamu tidak memberikan {styleStart}alamat email yang asli{styleEnd} saat membuat akun, kami tidak dapat mengirim email kepadamu.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Jika kamu tidak memberikan {styleStart}alamat email yang asli{styleEnd} saat membuat akun, kami tidak dapat mengirim email kepadamu.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Terjadi kesalahan, harap coba lagi nanti.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Email berisi nama penggunamu sudah terkirim jika emailmu sudah disimpan di akunmu.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Kami sudah mengirimkan email berisi instruksi jika emailmu sudah disimpan di akunmu.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "Email Terkirim";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Kami sudah mengirimkan kode sudah ke ponselmu jika nomornya sudah terverifikasi di akunmu. Masukkan kodenya di bawah ini";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Masukkan kode yang baru saja kami kirimkan ke emailmu.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Kami sudah mengirimkan SMS berisi nama penggunamu jika nomor ponselmu sudah diverifikasi di akunmu.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS Terkirim";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Tidak ada email yang terhubung ke akun ini";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Akun tidak ditemukan. Harap gunakan email lain.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Akun tidak ditemukan. Harap gunakan nomor telepon lain.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Kesalahan Sistem. Akun tidak dapat dipulihkan ke kondisi ini.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Kami perlu memastikan kamu bukan robot!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Kata yang kamu ketikkan tidak sesuai dengan gambar. Harap coba lagi.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Nama pengguna atau kata sandimu salah. Harap periksa ulang kemudian coba lagi.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Terlalu banyak percobaan. Harap coba lagi nanti.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Fitur dinonaktifkan sementara. Harap coba lagi nanti.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Lihat emailmu untuk membaca petunjuk masuk";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Status akun mencegah pengaturan ulang kata sandi";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Kata sandi tidak valid";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Kami tidak dapat memuat tiket keamanan ini.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Nama pengguna tidak valid, atau email tidak ada";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Tidak ada akun yang terhubung ke alamat email ini";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Sepertinya kamu mencoba masuk dengan nama pengguna yang sudah berubah. Harap masuk dengan nama penggunamu yang baru.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Maaf, kata sandi itu tidak bisa digunakan.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Maaf, permintaan pengaturan ulang kata sandi kedaluwarsa dalam {expirationHour} jam, {expirationMinute} menit setelah pengajuan. Silakan minta tiket pengaturan ulang kata sandi lagi.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Maaf, permintaan pengaturan ulang kata sandi kedaluwarsa dalam {expirationHour} jam, {expirationMinute} menit setelah pengajuan. Silakan minta tiket pengaturan ulang kata sandi lagi.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Kata sandi tidak sesuai";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Kamu harus masuk ke Roblox untuk menyelesaikan otentikasi.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Kesalahan Tidak Dikenal";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Kesalahan sistem. Harap kembali ke halaman masuk.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "Email";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"Masukkan Kode ({codeLength}-digit)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Masukkan Kode ({codeLength}-digit)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Nomor Telepon";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Pengaturan ulang kata sandi berhasil! Silakan masuk lagi.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Berhasil";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Terlalu banyak percobaan. Harap coba lagi nanti.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Kata sandimu saat ini salah, kata sandi tidak diubah.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Harus mencantumkan kata sandi baru dan kata sandi konfirmasi";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Kata sandi baru dan kata sandi konfirmasimu harus sesuai";
	}
}
