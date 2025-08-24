namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_vi_vn : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Hủy";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Dùng email để đặt lại mật khẩu";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Dùng email để truy xuất tên người dùng";

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
	public override string ActionPhoneToResetPassword => "Dùng số điện thoại để đặt lại mật khẩu";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Dùng số điện thoại để truy xuất tên người dùng";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Xác minh";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Nhập email để đặt lại mật khẩu của bạn.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Nhập email để truy xuất tên người dùng của bạn.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Đặt lại Mật khẩu Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Đặt lại Mật khẩu Tài khoản Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Nhập số điện thoại để đặt lại mật khẩu của bạn.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Nhập số điện thoại để truy xuất tên người dùng của bạn.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Xác minh mã";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Xác minh qua điện thoại";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Quên Mật khẩu hoặc Tên người dùng";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Có";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "Quên mật khẩu của tôi";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Quên tên người dùng của tôi";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Email không hợp lệ";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Số điện thoại không hợp lệ";

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
	public override string LabelPassword => "Mật khẩu";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Gửi lại mã";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Gửi";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Cài đặt này kiểm soát người có thể tìm bạn theo số điện thoại mà bạn đã cung cấp.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Tên người dùng";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Ai có thể tìm tôi theo số điện thoại?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Đã xảy ra lỗi, vui lòng thử lại sau.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Chúng tôi đã gửi email kèm tên người dùng cho bạn nếu bạn đã lưu địa chỉ email trên tài khoản của mình trước đó.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Chúng tôi đã gửi email kèm hướng dẫn cho bạn nếu bạn đã lưu địa chỉ email trên tài khoản của bạn trước đó.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "Đã gửi Email";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Chúng tôi đã gửi một mã vào điện thoại của bạn nếu bạn đã xác minh số điện thoại trên tài khoản của mình trước đó. Vui lòng nhập mã đó vào phần bên dưới";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Nhập mã chúng tôi vừa gửi tới email của bạn.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Bạn đã nhận được một tin nhắn SMS chứa tên người dùng nếu bạn đã xác minh số điện thoại trên tài khoản của mình trước đó.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "Đã gửi SMS";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Không có email nào được liên kết với tài khoản này";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Không tìm thấy tài khoản. Vui lòng sử dụng email khác.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Không tìm thấy tài khoản. Vui lòng sử dụng một số điện thoại khác.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Lỗi hệ thống. Không thể khôi phục tài khoản về trạng thái này.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Chúng tôi cần đảm bảo rằng bạn không phải là người máy!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Các từ bạn nhập không khớp vời hình. Vui lòng thử lại.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Sai tên người dùng hoặc mật khẩu. Vui lòng kiểm tra các thông tin đó và thử lại.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Quá nhiều lần thử. Vui lòng thử lại sau.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Tính năng tạm thời bị khóa. Vui lòng thử lại sau.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Kiểm tra email của bạn để xem hướng dẫn đăng nhập";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "Trạng thái tài khoản không cho phép đặt lại mật khẩu";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Mật khẩu không hợp lệ";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Chúng tôi không thể tải vé bảo mật này.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Tên người dùng không hợp lệ hoặc email không tồn tại";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Không có tài khoản nào được liên kết với địa chỉ email này";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Có vẻ như bạn đang đăng nhập bằng tên người dùng đã thay đổi. Vui lòng đăng nhập bằng tên người dùng mới.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Rất tiếc, bạn không thể sử dụng mật khẩu đó.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Mật khẩu không trùng nhau";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Bạn phải đăng nhập vào Roblox để hoàn tất xác thực.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Lỗi không xác định";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Lỗi hệ thống. Vui lòng quay lại màn hình đăng nhập.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "Email";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Số điện thoại";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Mật khẩu được đặt lại thành công! Vui lòng đăng nhập lại.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Thành công";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Quá nhiều lần thử. Vui lòng thử lại sau.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "Mật khẩu đang dùng không đúng, mật khẩu chưa được đổi.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Phải có mật khẩu mới và mật khẩu xác nhận";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Mật khẩu mới và mật khẩu xác nhận phải trùng nhau";

	public ResetPasswordResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Hủy";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Dùng email để đặt lại mật khẩu";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Dùng email để truy xuất tên người dùng";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Dùng số điện thoại để đặt lại mật khẩu";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Dùng số điện thoại để truy xuất tên người dùng";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Xác minh";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"Chúng tôi thấy rằng mật khẩu của tài khoản Roblox của bạn đã thay đổi: {userName}. Nếu bạn không có ý định thay đổi mật khẩu hoặc bạn cho rằng ai đó đã vô tình thay đổi, vui lòng bấm vào liên kết này để hoàn tác hành động:{lineBreak} {actionLink} {lineBreak}{lineBreak}Nếu bạn hài lòng với mật khẩu Roblox mới của mình thì bạn không cần làm gì! Mật khẩu đã được cài đặt. Vui lòng không trả lời tin nhắn này. Nếu bạn có bất kỳ câu hỏi nào, vui lòng truy cập trang trợ giúp của Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Chúng tôi thấy rằng mật khẩu của tài khoản Roblox của bạn đã thay đổi: {userName}. Nếu bạn không có ý định thay đổi mật khẩu hoặc bạn cho rằng ai đó đã vô tình thay đổi, vui lòng bấm vào liên kết này để hoàn tác hành động:{lineBreak} {actionLink} {lineBreak}{lineBreak}Nếu bạn hài lòng với mật khẩu Roblox mới của mình thì bạn không cần làm gì! Mật khẩu đã được cài đặt. Vui lòng không trả lời tin nhắn này. Nếu bạn có bất kỳ câu hỏi nào, vui lòng truy cập trang trợ giúp của Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Nhập email để đặt lại mật khẩu của bạn.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Nhập email để truy xuất tên người dùng của bạn.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Chúng tôi thấy rằng mật khẩu của tài khoản Roblox của bạn đã thay đổi: {userName}. Nếu bạn không có ý định thay đổi mật khẩu hoặc bạn cho rằng ai đó đã vô tình thay đổi, vui lòng bấm vào liên kết này để hoàn tác hành động:\n{urlWithTicket}\n\nNếu bạn hài lòng với mật khẩu Roblox mới của mình thì bạn không cần làm gì! Mật khẩu đã được cài đặt. Vui lòng không trả lời tin nhắn này. Nếu bạn có bất kỳ câu hỏi nào, vui lòng truy cập trang trợ giúp của Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Chúng tôi thấy rằng mật khẩu của tài khoản Roblox của bạn đã thay đổi: {userName}. Nếu bạn không có ý định thay đổi mật khẩu hoặc bạn cho rằng ai đó đã vô tình thay đổi, vui lòng bấm vào liên kết này để hoàn tác hành động:\n{urlWithTicket}\n\nNếu bạn hài lòng với mật khẩu Roblox mới của mình thì bạn không cần làm gì! Mật khẩu đã được cài đặt. Vui lòng không trả lời tin nhắn này. Nếu bạn có bất kỳ câu hỏi nào, vui lòng truy cập trang trợ giúp của Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Đặt lại Mật khẩu Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Đặt lại Mật khẩu Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Đặt lại Mật khẩu Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Đặt lại Mật khẩu Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Đặt lại Mật khẩu Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản Roblox của bạn: {emailOrUsername}{lineBreak}{lineBreak}Nếu bạn gửi yêu cầu này, vui lòng bấm vào nút bên dưới để tiếp tục.{lineBreak}Nút này sẽ hoạt động trong vòng {passwordResetTicketHours} giờ, {passwordResetTicketMinutes} phút. Nếu bạn không muốn đặt lại mật khẩu, vui lòng bỏ qua thông báo này.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Đặt lại mật khẩu{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản Roblox của bạn: {emailOrUsername}{lineBreak}{lineBreak}Nếu bạn gửi yêu cầu này, vui lòng bấm vào nút bên dưới để tiếp tục.{lineBreak}Nút này sẽ hoạt động trong vòng {passwordResetTicketHours} giờ, {passwordResetTicketMinutes} phút. Nếu bạn không muốn đặt lại mật khẩu, vui lòng bỏ qua thông báo này.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Đặt lại mật khẩu{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản Roblox của bạn: {emailOrUsername}{lineBreak}{lineBreak}Nếu bạn gửi yêu cầu này, vui lòng bấm vào hoặc dán liên kết bên dưới vào trình duyệt web để tiếp tục.{lineBreak}Liên kết này sẽ hoạt động trong vòng {passwordResetTicketHours} giờ, {passwordResetTicketMinutes} phút. Nếu bạn không muốn đặt lại mật khẩu, vui lòng bỏ qua thông báo này.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản Roblox của bạn: {emailOrUsername}{lineBreak}{lineBreak}Nếu bạn gửi yêu cầu này, vui lòng bấm vào hoặc dán liên kết bên dưới vào trình duyệt web để tiếp tục.{lineBreak}Liên kết này sẽ hoạt động trong vòng {passwordResetTicketHours} giờ, {passwordResetTicketMinutes} phút. Nếu bạn không muốn đặt lại mật khẩu, vui lòng bỏ qua thông báo này.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Đặt lại Mật khẩu Tài khoản Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Nhập số điện thoại để đặt lại mật khẩu của bạn.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Nhập số điện thoại để truy xuất tên người dùng của bạn.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Xác minh mã";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Xác minh qua điện thoại";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Quên Mật khẩu hoặc Tên người dùng";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Có";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Quên mật khẩu của tôi";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Quên tên người dùng của tôi";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Email không hợp lệ";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Số điện thoại không hợp lệ";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Mật khẩu";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Gửi lại mã";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Gửi";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Cài đặt này kiểm soát người có thể tìm bạn theo số điện thoại mà bạn đã cung cấp.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Tên người dùng";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Ai có thể tìm tôi theo số điện thoại?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Nếu bạn không cung cấp {styleStart}địa chỉ email thật{styleEnd} cho chúng tôi khi bạn tạo tài khoản thì chúng tôi không thể gửi email cho bạn.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Nếu bạn không cung cấp {styleStart}địa chỉ email thật{styleEnd} cho chúng tôi khi bạn tạo tài khoản thì chúng tôi không thể gửi email cho bạn.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Đã xảy ra lỗi, vui lòng thử lại sau.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Chúng tôi đã gửi email kèm tên người dùng cho bạn nếu bạn đã lưu địa chỉ email trên tài khoản của mình trước đó.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Chúng tôi đã gửi email kèm hướng dẫn cho bạn nếu bạn đã lưu địa chỉ email trên tài khoản của bạn trước đó.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "Đã gửi Email";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Chúng tôi đã gửi một mã vào điện thoại của bạn nếu bạn đã xác minh số điện thoại trên tài khoản của mình trước đó. Vui lòng nhập mã đó vào phần bên dưới";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Nhập mã chúng tôi vừa gửi tới email của bạn.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Bạn đã nhận được một tin nhắn SMS chứa tên người dùng nếu bạn đã xác minh số điện thoại trên tài khoản của mình trước đó.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "Đã gửi SMS";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Không có email nào được liên kết với tài khoản này";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Không tìm thấy tài khoản. Vui lòng sử dụng email khác.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Không tìm thấy tài khoản. Vui lòng sử dụng một số điện thoại khác.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Lỗi hệ thống. Không thể khôi phục tài khoản về trạng thái này.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Chúng tôi cần đảm bảo rằng bạn không phải là người máy!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Các từ bạn nhập không khớp vời hình. Vui lòng thử lại.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Sai tên người dùng hoặc mật khẩu. Vui lòng kiểm tra các thông tin đó và thử lại.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Quá nhiều lần thử. Vui lòng thử lại sau.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Tính năng tạm thời bị khóa. Vui lòng thử lại sau.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Kiểm tra email của bạn để xem hướng dẫn đăng nhập";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Trạng thái tài khoản không cho phép đặt lại mật khẩu";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Mật khẩu không hợp lệ";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Chúng tôi không thể tải vé bảo mật này.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Tên người dùng không hợp lệ hoặc email không tồn tại";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Không có tài khoản nào được liên kết với địa chỉ email này";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Có vẻ như bạn đang đăng nhập bằng tên người dùng đã thay đổi. Vui lòng đăng nhập bằng tên người dùng mới.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Rất tiếc, bạn không thể sử dụng mật khẩu đó.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Rất tiếc, yêu cầu đặt lại mật khẩu hết hạn {expirationHour} giờ, {expirationMinute} phút sau khi cấp. Thử yêu cầu lại vé đặt lại mật khẩu khác.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Rất tiếc, yêu cầu đặt lại mật khẩu hết hạn {expirationHour} giờ, {expirationMinute} phút sau khi cấp. Thử yêu cầu lại vé đặt lại mật khẩu khác.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Mật khẩu không trùng nhau";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Bạn phải đăng nhập vào Roblox để hoàn tất xác thực.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Lỗi không xác định";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Lỗi hệ thống. Vui lòng quay lại màn hình đăng nhập.";
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
		return $"Nhập mã ({codeLength} chữ số)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Nhập mã ({codeLength} chữ số)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Số điện thoại";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Mật khẩu được đặt lại thành công! Vui lòng đăng nhập lại.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Thành công";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Quá nhiều lần thử. Vui lòng thử lại sau.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Mật khẩu đang dùng không đúng, mật khẩu chưa được đổi.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Phải có mật khẩu mới và mật khẩu xác nhận";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Mật khẩu mới và mật khẩu xác nhận phải trùng nhau";
	}
}
