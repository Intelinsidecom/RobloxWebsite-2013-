using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class ResetPasswordResources_en_us : TranslationResourcesBase, IResetPasswordResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public virtual string ActionEmailToResetPassword => "Use email to reset password";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public virtual string ActionEmailToRetriveUsername => "Use email to retrieve username";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public virtual string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public virtual string ActionPhoneToResetPassword => "Use phone number to reset password";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public virtual string ActionPhoneToRetriveUsername => "Use phone number to retrieve username";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public virtual string ActionVerify => "Verify";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public virtual string DescriptionEmailToResetPassword => "Enter your email to reset your password.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public virtual string DescriptionEmailToRetriveUsername => "Enter your email to retrieve your username.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public virtual string DescriptionPasswordChangeEmailSubject => "Roblox Password Reset";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public virtual string DescriptionPasswordResetEmailSubject => "Roblox Account Password Reset";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public virtual string DescriptionPhoneToResetPassword => "Enter your phone number to reset your password.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public virtual string DescriptionPhoneToRetriveUsername => "Enter your phone number to retrieve your username.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public virtual string HeadingVerifyCode => "Verify Code";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public virtual string HeadingVerifyPhone => "Verify Phone";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public virtual string HeadingForgetPasswordOrUsername => "Forgot Password or Username";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public virtual string LabelActionButtonYes => "Yes";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public virtual string LabelForgetMyPassword => "Forgot My Password";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public virtual string LabelForgetMyUsername => "Forgot My Username";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public virtual string LabelInvalidEmail => "Invalid email";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public virtual string LabelInvalidPhoneNumber => "Invalid phone number";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public virtual string LabelNeutralButtonOk => "OK";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public virtual string LabelPassword => "Password";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public virtual string LabelResendCode => "Resend Code";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public virtual string LabelSubmit => "Submit";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public virtual string LabelToolTipWhoCanFindMeByPhone => "This setting controls who can find you using the phone number you provided.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public virtual string LabelUsername => "Username";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public virtual string LabelWhoCanFindMeByPhone => "Who can find me by my phone number?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public virtual string MessageDefaultError => "An error occurred, try again later.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public virtual string MessageEmailForUsernameSuccessBody => "An email with your username(s) has been sent to you if the email was previously saved on your account.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public virtual string MessageEmailSuccessBody => "An email with instructions has been sent to you if the email was previously saved on your account.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public virtual string MessageEmailSuccessTitle => "Email Sent";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public virtual string MessageEnterCode => "A code was sent to your phone if it was previously verified on your account. Please enter it below";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public virtual string MessageEnterCodeSentToEmail => "Enter the code we just sent to your email.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public virtual string MessagePhoneForUsernameSuccessBody => "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public virtual string MessagePhoneForUsernameSuccessTitle => "SMS Sent";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public virtual string MessageAccountDoesNotHaveAnEmail => "There is no email linked to this account";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public virtual string MessageAccountNotFoundByEmail => "No account found. Please use a different email.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public virtual string MessageAccountNotFoundByPhone => "No account found. Please use a different phone number.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public virtual string MessageAccountRecoveryUnknownError => "System error. Account could not be restored to this state.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public virtual string MessageCaptchaError => "We need to make sure you're not a robot!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public virtual string MessageCaptchaFailError => "The words you typed didn't match the picture. Please try again.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public virtual string MessageCredentialsError => "Your username or password is incorrect. Please check them and try again.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public virtual string MessageFloodCheckedError => "Too many attempts. Please try again later.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public virtual string MessageForgotPasswordFeatureDisabled => "Feature temporarily disabled. Please try again later.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public virtual string MessageForgotPasswordSuccess => "Check your email for login instructions";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public virtual string MessageInvalidAccountStatus => "Account status prevents resetting password";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public virtual string MessageInvalidPassword => "Invalid password";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public virtual string MessageInvalidTicket => "We couldn't load this security ticket.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public virtual string MessageInvalidUserNameOrEmail => "Invalid username, or no email exists";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public virtual string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public virtual string MessageNoAccountsLinkedToEmail => "There are no accounts linked to this email address";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public virtual string MessageOldUsernameError => "It looks like you are trying to log in with a username that has changed. Please log in with your new username.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public virtual string MessagePasswordCannotBeUsed => "Sorry, that password cannot be used.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public virtual string MessagePasswordsDoNotMatch => "Passwords do not match";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public virtual string MessageSamlUnauthenticated => "You must log in to Roblox to finish authenticating.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public virtual string MessageUnknownError => "Unknown Error";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public virtual string MessageUnknownSystemError => "System error. Please return to login screen.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public virtual string PlaceholderEmail => "Email";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public virtual string PlaceholderPhoneNumber => "Phone Number";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public virtual string ResponsePasswordResetSuccess => "Password reset success! Please login again.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public virtual string ResponseSuccess => "Success";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public virtual string ResponseUpdatePasswordFlooded => "Too many attempts. Please try again later.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public virtual string ResponseUpdatePasswordIncorrect => "Your current password is incorrect, the password was not changed.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public virtual string ResponseUpdatePasswordInputMissing => "Must include new password and confirm password";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public virtual string ResponseUpdatePasswordMismatch => "Your new password and confirm password must match";

	public ResetPasswordResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.EmailToResetPassword",
				_GetTemplateForActionEmailToResetPassword()
			},
			{
				"Action.EmailToRetriveUsername",
				_GetTemplateForActionEmailToRetriveUsername()
			},
			{
				"Action.Ok",
				_GetTemplateForActionOk()
			},
			{
				"Action.PhoneToResetPassword",
				_GetTemplateForActionPhoneToResetPassword()
			},
			{
				"Action.PhoneToRetriveUsername",
				_GetTemplateForActionPhoneToRetriveUsername()
			},
			{
				"Action.Verify",
				_GetTemplateForActionVerify()
			},
			{
				"Description.ChangePasswordEmail.HtmlBody1",
				_GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
			},
			{
				"Description.EmailToResetPassword",
				_GetTemplateForDescriptionEmailToResetPassword()
			},
			{
				"Description.EmailToRetriveUsername",
				_GetTemplateForDescriptionEmailToRetriveUsername()
			},
			{
				"Description.PasswordChangeEmail.BodyPlainText",
				_GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
			},
			{
				"Description.PasswordChangeEmail.From",
				_GetTemplateForDescriptionPasswordChangeEmailFrom()
			},
			{
				"Description.PasswordChangeEmail.Subject",
				_GetTemplateForDescriptionPasswordChangeEmailSubject()
			},
			{
				"Description.PasswordResetEmail.From",
				_GetTemplateForDescriptionPasswordResetEmailFrom()
			},
			{
				"Description.PasswordResetEmail.HtmlBody",
				_GetTemplateForDescriptionPasswordResetEmailHtmlBody()
			},
			{
				"Description.PasswordResetEmail.PlainBody",
				_GetTemplateForDescriptionPasswordResetEmailPlainBody()
			},
			{
				"Description.PasswordResetEmail.Subject",
				_GetTemplateForDescriptionPasswordResetEmailSubject()
			},
			{
				"Description.PhoneToResetPassword",
				_GetTemplateForDescriptionPhoneToResetPassword()
			},
			{
				"Description.PhoneToRetriveUsername",
				_GetTemplateForDescriptionPhoneToRetriveUsername()
			},
			{
				"Heading.VerifyCode",
				_GetTemplateForHeadingVerifyCode()
			},
			{
				"Heading.VerifyPhone",
				_GetTemplateForHeadingVerifyPhone()
			},
			{
				"HeadingForgetPasswordOrUsername",
				_GetTemplateForHeadingForgetPasswordOrUsername()
			},
			{
				"Label.ActionButtonYes",
				_GetTemplateForLabelActionButtonYes()
			},
			{
				"Label.ForgetMyPassword",
				_GetTemplateForLabelForgetMyPassword()
			},
			{
				"Label.ForgetMyUsername",
				_GetTemplateForLabelForgetMyUsername()
			},
			{
				"Label.InvalidEmail",
				_GetTemplateForLabelInvalidEmail()
			},
			{
				"Label.InvalidPhoneNumber",
				_GetTemplateForLabelInvalidPhoneNumber()
			},
			{
				"Label.NeutralButtonOk",
				_GetTemplateForLabelNeutralButtonOk()
			},
			{
				"Label.Password",
				_GetTemplateForLabelPassword()
			},
			{
				"Label.ResendCode",
				_GetTemplateForLabelResendCode()
			},
			{
				"Label.Submit",
				_GetTemplateForLabelSubmit()
			},
			{
				"Label.ToolTip.WhoCanFindMeByPhone",
				_GetTemplateForLabelToolTipWhoCanFindMeByPhone()
			},
			{
				"Label.Username",
				_GetTemplateForLabelUsername()
			},
			{
				"Label.WhoCanFindMeByPhone",
				_GetTemplateForLabelWhoCanFindMeByPhone()
			},
			{
				"Message.CantSendEmailWarning",
				_GetTemplateForMessageCantSendEmailWarning()
			},
			{
				"Message.DefaultError",
				_GetTemplateForMessageDefaultError()
			},
			{
				"Message.EmailForUsernameSuccessBody",
				_GetTemplateForMessageEmailForUsernameSuccessBody()
			},
			{
				"Message.EmailSuccessBody",
				_GetTemplateForMessageEmailSuccessBody()
			},
			{
				"Message.EmailSuccessTitle",
				_GetTemplateForMessageEmailSuccessTitle()
			},
			{
				"Message.EnterCode",
				_GetTemplateForMessageEnterCode()
			},
			{
				"Message.EnterCodeSentToEmail",
				_GetTemplateForMessageEnterCodeSentToEmail()
			},
			{
				"Message.PhoneForUsernameSuccessBody",
				_GetTemplateForMessagePhoneForUsernameSuccessBody()
			},
			{
				"Message.PhoneForUsernameSuccessTitle",
				_GetTemplateForMessagePhoneForUsernameSuccessTitle()
			},
			{
				"MessageAccountDoesNotHaveAnEmail",
				_GetTemplateForMessageAccountDoesNotHaveAnEmail()
			},
			{
				"MessageAccountNotFoundByEmail",
				_GetTemplateForMessageAccountNotFoundByEmail()
			},
			{
				"MessageAccountNotFoundByPhone",
				_GetTemplateForMessageAccountNotFoundByPhone()
			},
			{
				"MessageAccountRecoveryUnknownError",
				_GetTemplateForMessageAccountRecoveryUnknownError()
			},
			{
				"MessageCaptchaError",
				_GetTemplateForMessageCaptchaError()
			},
			{
				"MessageCaptchaFailError",
				_GetTemplateForMessageCaptchaFailError()
			},
			{
				"MessageCredentialsError",
				_GetTemplateForMessageCredentialsError()
			},
			{
				"MessageFloodCheckedError",
				_GetTemplateForMessageFloodCheckedError()
			},
			{
				"MessageForgotPasswordFeatureDisabled",
				_GetTemplateForMessageForgotPasswordFeatureDisabled()
			},
			{
				"MessageForgotPasswordSuccess",
				_GetTemplateForMessageForgotPasswordSuccess()
			},
			{
				"MessageInvalidAccountStatus",
				_GetTemplateForMessageInvalidAccountStatus()
			},
			{
				"MessageInvalidPassword",
				_GetTemplateForMessageInvalidPassword()
			},
			{
				"MessageInvalidTicket",
				_GetTemplateForMessageInvalidTicket()
			},
			{
				"MessageInvalidUserNameOrEmail",
				_GetTemplateForMessageInvalidUserNameOrEmail()
			},
			{
				"MessageMobileResetPasswordSuccess",
				_GetTemplateForMessageMobileResetPasswordSuccess()
			},
			{
				"MessageNoAccountsLinkedToEmail",
				_GetTemplateForMessageNoAccountsLinkedToEmail()
			},
			{
				"MessageOldUsernameError",
				_GetTemplateForMessageOldUsernameError()
			},
			{
				"MessagePasswordCannotBeUsed",
				_GetTemplateForMessagePasswordCannotBeUsed()
			},
			{
				"MessagePasswordResetTicketExpired",
				_GetTemplateForMessagePasswordResetTicketExpired()
			},
			{
				"MessagePasswordsDoNotMatch",
				_GetTemplateForMessagePasswordsDoNotMatch()
			},
			{
				"MessageSamlUnauthenticated",
				_GetTemplateForMessageSamlUnauthenticated()
			},
			{
				"MessageUnknownError",
				_GetTemplateForMessageUnknownError()
			},
			{
				"MessageUnknownSystemError",
				_GetTemplateForMessageUnknownSystemError()
			},
			{
				"Placeholder.Email",
				_GetTemplateForPlaceholderEmail()
			},
			{
				"Placeholder.EnterCode",
				_GetTemplateForPlaceholderEnterCode()
			},
			{
				"Placeholder.PhoneNumber",
				_GetTemplateForPlaceholderPhoneNumber()
			},
			{
				"Response.PasswordResetSuccess",
				_GetTemplateForResponsePasswordResetSuccess()
			},
			{
				"Response.Success",
				_GetTemplateForResponseSuccess()
			},
			{
				"Response.UpdatePasswordFlooded",
				_GetTemplateForResponseUpdatePasswordFlooded()
			},
			{
				"Response.UpdatePasswordIncorrect",
				_GetTemplateForResponseUpdatePasswordIncorrect()
			},
			{
				"Response.UpdatePasswordInputMissing",
				_GetTemplateForResponseUpdatePasswordInputMissing()
			},
			{
				"Response.UpdatePasswordMismatch",
				_GetTemplateForResponseUpdatePasswordMismatch()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.ResetPassword";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionEmailToResetPassword()
	{
		return "Use email to reset password";
	}

	protected virtual string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Use email to retrieve username";
	}

	protected virtual string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Use phone number to reset password";
	}

	protected virtual string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Use phone number to retrieve username";
	}

	protected virtual string _GetTemplateForActionVerify()
	{
		return "Verify";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public virtual string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help).";
	}

	protected virtual string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help).";
	}

	protected virtual string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Enter your email to reset your password.";
	}

	protected virtual string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Enter your email to retrieve your username.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public virtual string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help).";
	}

	protected virtual string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public virtual string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Roblox Password Reset\" {fromEmailAddress}";
	}

	protected virtual string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Roblox Password Reset\" {fromEmailAddress}";
	}

	protected virtual string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox Password Reset";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public virtual string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected virtual string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public virtual string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}";
	}

	protected virtual string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public virtual string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected virtual string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected virtual string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox Account Password Reset";
	}

	protected virtual string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Enter your phone number to reset your password.";
	}

	protected virtual string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Enter your phone number to retrieve your username.";
	}

	protected virtual string _GetTemplateForHeadingVerifyCode()
	{
		return "Verify Code";
	}

	protected virtual string _GetTemplateForHeadingVerifyPhone()
	{
		return "Verify Phone";
	}

	protected virtual string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Forgot Password or Username";
	}

	protected virtual string _GetTemplateForLabelActionButtonYes()
	{
		return "Yes";
	}

	protected virtual string _GetTemplateForLabelForgetMyPassword()
	{
		return "Forgot My Password";
	}

	protected virtual string _GetTemplateForLabelForgetMyUsername()
	{
		return "Forgot My Username";
	}

	protected virtual string _GetTemplateForLabelInvalidEmail()
	{
		return "Invalid email";
	}

	protected virtual string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Invalid phone number";
	}

	protected virtual string _GetTemplateForLabelNeutralButtonOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForLabelPassword()
	{
		return "Password";
	}

	protected virtual string _GetTemplateForLabelResendCode()
	{
		return "Resend Code";
	}

	protected virtual string _GetTemplateForLabelSubmit()
	{
		return "Submit";
	}

	protected virtual string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "This setting controls who can find you using the phone number you provided.";
	}

	protected virtual string _GetTemplateForLabelUsername()
	{
		return "Username";
	}

	protected virtual string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Who can find me by my phone number?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public virtual string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email.";
	}

	protected virtual string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email.";
	}

	protected virtual string _GetTemplateForMessageDefaultError()
	{
		return "An error occurred, try again later.";
	}

	protected virtual string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "An email with your username(s) has been sent to you if the email was previously saved on your account.";
	}

	protected virtual string _GetTemplateForMessageEmailSuccessBody()
	{
		return "An email with instructions has been sent to you if the email was previously saved on your account.";
	}

	protected virtual string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "Email Sent";
	}

	protected virtual string _GetTemplateForMessageEnterCode()
	{
		return "A code was sent to your phone if it was previously verified on your account. Please enter it below";
	}

	protected virtual string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Enter the code we just sent to your email.";
	}

	protected virtual string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account.";
	}

	protected virtual string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS Sent";
	}

	protected virtual string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "There is no email linked to this account";
	}

	protected virtual string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "No account found. Please use a different email.";
	}

	protected virtual string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "No account found. Please use a different phone number.";
	}

	protected virtual string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "System error. Account could not be restored to this state.";
	}

	protected virtual string _GetTemplateForMessageCaptchaError()
	{
		return "We need to make sure you're not a robot!";
	}

	protected virtual string _GetTemplateForMessageCaptchaFailError()
	{
		return "The words you typed didn't match the picture. Please try again.";
	}

	protected virtual string _GetTemplateForMessageCredentialsError()
	{
		return "Your username or password is incorrect. Please check them and try again.";
	}

	protected virtual string _GetTemplateForMessageFloodCheckedError()
	{
		return "Too many attempts. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Feature temporarily disabled. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Check your email for login instructions";
	}

	protected virtual string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Account status prevents resetting password";
	}

	protected virtual string _GetTemplateForMessageInvalidPassword()
	{
		return "Invalid password";
	}

	protected virtual string _GetTemplateForMessageInvalidTicket()
	{
		return "We couldn't load this security ticket.";
	}

	protected virtual string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Invalid username, or no email exists";
	}

	protected virtual string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected virtual string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "There are no accounts linked to this email address";
	}

	protected virtual string _GetTemplateForMessageOldUsernameError()
	{
		return "It looks like you are trying to log in with a username that has changed. Please log in with your new username.";
	}

	protected virtual string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Sorry, that password cannot be used.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public virtual string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again.";
	}

	protected virtual string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again.";
	}

	protected virtual string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Passwords do not match";
	}

	protected virtual string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "You must log in to Roblox to finish authenticating.";
	}

	protected virtual string _GetTemplateForMessageUnknownError()
	{
		return "Unknown Error";
	}

	protected virtual string _GetTemplateForMessageUnknownSystemError()
	{
		return "System error. Please return to login screen.";
	}

	protected virtual string _GetTemplateForPlaceholderEmail()
	{
		return "Email";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public virtual string PlaceholderEnterCode(string codeLength)
	{
		return $"Enter Code ({codeLength}-digit)";
	}

	protected virtual string _GetTemplateForPlaceholderEnterCode()
	{
		return "Enter Code ({codeLength}-digit)";
	}

	protected virtual string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Phone Number";
	}

	protected virtual string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Password reset success! Please login again.";
	}

	protected virtual string _GetTemplateForResponseSuccess()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Too many attempts. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Your current password is incorrect, the password was not changed.";
	}

	protected virtual string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Must include new password and confirm password";
	}

	protected virtual string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Your new password and confirm password must match";
	}
}
