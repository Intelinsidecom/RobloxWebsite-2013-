namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_ja_jp : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "メールアドレスを使用してパスワードをリセットする";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "メールアドレスを使用してユーザーネームを再確認する";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "電話番号を使用してパスワードをリセットする";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "電話番号を使用してユーザーネームを再確認する";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "確認";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "パスワードをリセットするにはメールアドレスを入力してください。";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "ユーザーネームを再確認するにはメールアドレスを入力してください。";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Robloxパスワードリセット";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Robloxアカウントのパスワードリセット";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "パスワードをリセットするには電話番号を入力してください。";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "ユーザーネームを再確認するには電話番号を入力してください。";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "認証コード";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "電話を確認";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "パスワード、またはユーザネームを忘れた場合";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "はい";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "パスワードを忘れた";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "ユーザーネームを忘れた場合";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "無効なメールアドレス";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "無効な電話番号";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "OK";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "パスワード";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "コードを再送信";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "送信";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "この設定でお使いの電話番号からあなたを見つけられる人を指定できます。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ユーザーネーム";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "電話番号からの検索を許可する対象。";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "エラーが発生しました。しばらくしてからやり直してください。";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "メールアドレスがすでにアカウントに保存されている場合は、ユーザーネームが記載されたメールを送信しています。";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "メールアドレスがすでにアカウントに保存されている場合は、必要な手順が記載されたメールを送信しています。";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "メールが送信されました";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "過去にアカウントで認証を行ったことがある場合は、コードを携帯電話に送信しています。送信されたコードを入力してください";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "メールに記載されたコードを入力してください。";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "過去にアカウントで電話番号の認証を行ったことがある場合は、ユーザーネームが記載されたSMSメッセージを送信しています。";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMSが送信されました";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "このアカウントにリンク済みのメールアドレスはありません";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "アカウントが見つかりませんでした。別のメールアドレスをご利用ください。";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "アカウントが見つかりませんでした。別の電話番号をご利用ください。";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "システムエラーが発生しました。アカウントをこの状態に復旧できませんでした。";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "ロボット入力ではないことを確認する必要があります！";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "画像の文字と入力した文字が一致していません。もう一度お試しください。";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "ユーザーネーム、またはパスワードが間違っています。もう一度チェックしてからやり直してください。";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "試行回数が多すぎます。しばらくしてからやり直してください。";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "機能が一時的に無効になっています。しばらくしてからやり直してください。";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "ログイン方法についてはメールをごらんください";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "アカウントステータスによりパスワードのリセットはできません";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "無効なパスワード";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "このセキュリティチケットを読み込めませんでした。";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "ユーザーネームが無効であるか、メールアドレスが存在しません";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "このメールアドレスにリンク済みのアカウントはありません";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "古いユーザーネームが入力されたようです。新しいユーザーネームでログインしてください。";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "申し訳ありませんが、そのパスワードは使用できません。";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "パスワードが一致しません";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "認証を完了するにはRobloxにログインする必要があります。";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "不明なエラーが発生しました";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "システムエラーが発生しました。ログイン画面にお戻りください。";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "メールアドレス";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "電話番号";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "パスワードのリセットに成功しました！もう一度ログインしてください。";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "成功";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "試行回数が多すぎます。しばらくしてからやり直してください。";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "現在のパスワードが間違っています。パスワードは変更されませんでした。";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "新しいパスワードと確認パスワードを含む必要があります";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "新しいパスワードと確認パスワードが一致している必要があります";

	public ResetPasswordResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "メールアドレスを使用してパスワードをリセットする";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "メールアドレスを使用してユーザーネームを再確認する";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "電話番号を使用してパスワードをリセットする";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "電話番号を使用してユーザーネームを再確認する";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "確認";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"お使いのRobloxアカウント（{userName}）でパスワード変更が行われています。変更するつもりがなかったり、他の誰かが間違って変更したと思われる場合、以下のリンクをクリックして操作を取り消してください:{lineBreak} {actionLink} {lineBreak}{lineBreak}新しいRobloxのパスワードに問題がなければ、何もする必要はありません。新しいパスワードはすでに設定されています。何か質問があれば、Robloxのヘルプページ(https://www.roblox.com/help)を見てください。";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "お使いのRobloxアカウント（{userName}）でパスワード変更が行われています。変更するつもりがなかったり、他の誰かが間違って変更したと思われる場合、以下のリンクをクリックして操作を取り消してください:{lineBreak} {actionLink} {lineBreak}{lineBreak}新しいRobloxのパスワードに問題がなければ、何もする必要はありません。新しいパスワードはすでに設定されています。何か質問があれば、Robloxのヘルプページ(https://www.roblox.com/help)を見てください。";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "パスワードをリセットするにはメールアドレスを入力してください。";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "ユーザーネームを再確認するにはメールアドレスを入力してください。";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"お使いのRobloxアカウント（{userName}）でパスワード変更が行われています。変更するつもりがなかったり、他の誰かが間違って変更したと思われる場合、以下のリンクをクリックして操作を取り消してください:\n{urlWithTicket}\n\n新しいRobloxのパスワードに問題がなければ、何もする必要はありません。新しいパスワードはすでに設定されています。何か質問があれば、Robloxのヘルプページ(https://www.roblox.com/help)を見てください。";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "お使いのRobloxアカウント（{userName}）でパスワード変更が行われています。変更するつもりがなかったり、他の誰かが間違って変更したと思われる場合、以下のリンクをクリックして操作を取り消してください:\n{urlWithTicket}\n\n新しいRobloxのパスワードに問題がなければ、何もする必要はありません。新しいパスワードはすでに設定されています。何か質問があれば、Robloxのヘルプページ(https://www.roblox.com/help)を見てください。";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Robloxパスワードリセット\"{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Robloxパスワードリセット\"{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Robloxパスワードリセット";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Robloxパスワードリセット{escapeLiteralEnd}{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Robloxパスワードリセット{escapeLiteralEnd}{fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Roblox アカウントに対してパスワードリセットのリクエストが届きました：{emailOrUsername}{lineBreak}{lineBreak}このリクエストを送信した場合は、下のボタンをクリックするか、ウェブブラウザに貼り付けて続行してください。{lineBreak}このリンクの期限は{passwordResetTicketHours}時間{passwordResetTicketMinutes}分です。 パスワードをリセットしたくない場合は、この通知を無視してください。{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}パスワードリセット{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Roblox アカウントに対してパスワードリセットのリクエストが届きました：{emailOrUsername}{lineBreak}{lineBreak}このリクエストを送信した場合は、下のボタンをクリックするか、ウェブブラウザに貼り付けて続行してください。{lineBreak}このリンクの期限は{passwordResetTicketHours}時間{passwordResetTicketMinutes}分です。 パスワードをリセットしたくない場合は、この通知を無視してください。{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}パスワードリセット{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Roblox アカウントに対してパスワードリセットのリクエストが届きました：{emailOrUsername}{lineBreak}{lineBreak}このリクエストを送信した場合は、下のリンクをクリックするか、ウェブブラウザに貼り付けて続行してください。{lineBreak}このリンクの期限は{passwordResetTicketHours}時間{passwordResetTicketMinutes}分です。 パスワードをリセットしたくない場合は、この通知を無視してください。{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Roblox アカウントに対してパスワードリセットのリクエストが届きました：{emailOrUsername}{lineBreak}{lineBreak}このリクエストを送信した場合は、下のリンクをクリックするか、ウェブブラウザに貼り付けて続行してください。{lineBreak}このリンクの期限は{passwordResetTicketHours}時間{passwordResetTicketMinutes}分です。 パスワードをリセットしたくない場合は、この通知を無視してください。{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Robloxアカウントのパスワードリセット";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "パスワードをリセットするには電話番号を入力してください。";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "ユーザーネームを再確認するには電話番号を入力してください。";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "認証コード";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "電話を確認";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "パスワード、またはユーザネームを忘れた場合";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "はい";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "パスワードを忘れた";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "ユーザーネームを忘れた場合";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "無効なメールアドレス";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "無効な電話番号";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "パスワード";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "コードを再送信";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "送信";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "この設定でお使いの電話番号からあなたを見つけられる人を指定できます。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ユーザーネーム";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "電話番号からの検索を許可する対象。";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"アカウント作成時に{styleStart}本物のメールアドレス{styleEnd}を入力していないと、こちらからメールを送ることができません。";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "アカウント作成時に{styleStart}本物のメールアドレス{styleEnd}を入力していないと、こちらからメールを送ることができません。";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "エラーが発生しました。しばらくしてからやり直してください。";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "メールアドレスがすでにアカウントに保存されている場合は、ユーザーネームが記載されたメールを送信しています。";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "メールアドレスがすでにアカウントに保存されている場合は、必要な手順が記載されたメールを送信しています。";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "メールが送信されました";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "過去にアカウントで認証を行ったことがある場合は、コードを携帯電話に送信しています。送信されたコードを入力してください";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "メールに記載されたコードを入力してください。";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "過去にアカウントで電話番号の認証を行ったことがある場合は、ユーザーネームが記載されたSMSメッセージを送信しています。";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMSが送信されました";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "このアカウントにリンク済みのメールアドレスはありません";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "アカウントが見つかりませんでした。別のメールアドレスをご利用ください。";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "アカウントが見つかりませんでした。別の電話番号をご利用ください。";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "システムエラーが発生しました。アカウントをこの状態に復旧できませんでした。";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "ロボット入力ではないことを確認する必要があります！";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "画像の文字と入力した文字が一致していません。もう一度お試しください。";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "ユーザーネーム、またはパスワードが間違っています。もう一度チェックしてからやり直してください。";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "試行回数が多すぎます。しばらくしてからやり直してください。";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "機能が一時的に無効になっています。しばらくしてからやり直してください。";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "ログイン方法についてはメールをごらんください";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "アカウントステータスによりパスワードのリセットはできません";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "無効なパスワード";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "このセキュリティチケットを読み込めませんでした。";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "ユーザーネームが無効であるか、メールアドレスが存在しません";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "このメールアドレスにリンク済みのアカウントはありません";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "古いユーザーネームが入力されたようです。新しいユーザーネームでログインしてください。";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "申し訳ありませんが、そのパスワードは使用できません。";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"申し訳ございません。パスワードリセットのリクエストは、ご依頼から{expirationHour}時間{expirationMinute}分で期限切れとなります。再度パスワードリセットをリクエストしてください。";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "申し訳ございません。パスワードリセットのリクエストは、ご依頼から{expirationHour}時間{expirationMinute}分で期限切れとなります。再度パスワードリセットをリクエストしてください。";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "パスワードが一致しません";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "認証を完了するにはRobloxにログインする必要があります。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "不明なエラーが発生しました";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "システムエラーが発生しました。ログイン画面にお戻りください。";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "メールアドレス";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"コードを入力 ({codeLength}-桁)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "コードを入力 ({codeLength}-桁)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "電話番号";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "パスワードのリセットに成功しました！もう一度ログインしてください。";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "試行回数が多すぎます。しばらくしてからやり直してください。";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "現在のパスワードが間違っています。パスワードは変更されませんでした。";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "新しいパスワードと確認パスワードを含む必要があります";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "新しいパスワードと確認パスワードが一致している必要があります";
	}
}
