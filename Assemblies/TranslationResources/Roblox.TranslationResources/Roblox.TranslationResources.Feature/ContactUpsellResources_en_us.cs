using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ContactUpsellResources_en_us : TranslationResourcesBase, IContactUpsellResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public virtual string ActionAddEmail => "Add Email";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public virtual string ActionAddEmailLink => "Add email";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public virtual string ActionAddEmailNow => "Add Email Now";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public virtual string ActionAddNow => "Add Now";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public virtual string ActionAddParentsEmail => "Add Parent's Email";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public virtual string ActionAddParentsEmailNow => "Add Parent's Email Now";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public virtual string ActionAddPhone => "Add Phone Number";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public virtual string ActionAddPhoneNow => "Add Phone Now";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public virtual string ActionClose => "Close";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public virtual string ActionConfirmEmail => "Confirm Email";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public virtual string ActionEditPhoneNumber => "Edit Phone Number";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public virtual string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public virtual string ActionResendCode => "Resend Code";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public virtual string ActionSubmit => "Submit";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public virtual string ActionVerify => "Verify";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public virtual string ActionVerifyEmail => "Verify Email";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public virtual string ActionVerifyPhone => "Verify Phone";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public virtual string ActionsAddParentsEmail => "Add Parent's Email";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public virtual string HeadingAddEmail => "Add Email";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public virtual string HeadingDefaultHeader => "Don't get locked out!";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public virtual string HeadingDontForgetToConfirm => "Don't forget to confirm!";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public virtual string HeadingError => "An error occurred";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public virtual string HeadingFindFriends => "Help your friends find you!";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public virtual string HeadingFreeHat => "Get yourself a free hat!";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public virtual string HeadingSuccess => "Success";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public virtual string HeadingVerifyEmail => "Verify Email";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public virtual string LabelAddPhone => "AddPhone";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public virtual string LabelEmailPlaceholder => "Email Address";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public virtual string LabelError => "An error occurred";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public virtual string LabelInvalidEmail => "Invalid email";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public virtual string LabelInvalidPhoneNumber => "Invalid phone number";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public virtual string LabelNoEmail => "Don't have an email?";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public virtual string LabelNoPhone => "Don't have a phone?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public virtual string LabelNotReceived => "Didn't receive it?";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public virtual string LabelOr => "Or";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public virtual string LabelParentsEmailPlaceholder => "Parent's Email Address";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public virtual string LabelPassword => "Roblox Account Password";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public virtual string LabelPhonePlaceholder => "Phone Number";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public virtual string LabelProtectAccountWithEmail => "Protect your account with an email!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public virtual string LabelProtectAccountWithParentsEmail => "Protect your account with your parent's email!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public virtual string LabelProtectAccountWithPhone => "Protect your account with a phone number!";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public virtual string LabelResendEmail => "Resend Email";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public virtual string LabelVerifyEmailToProtectAccount => "Verify your email to protect your account!";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public virtual string LabelVerifyParentsEmailToProtectAccount => "Verify your parent's email to protect your account!";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public virtual string LabelVerifyPasswordPlaceholder => "Roblox Account Password";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public virtual string ResponseCountryListError => "An error occurred loading the country list";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public virtual string ResponseDialogAddEmailForFreeHatOver13 => "Please add your email to receive a free hat and ensure that you never get locked out of your account!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public virtual string ResponseDialogAddEmailForFreeHatUnder13 => "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public virtual string ResponseDialogAddEmailInstructionsOver13 => "Please enter your email address. We will send a link to complete verification.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public virtual string ResponseDialogAddEmailInstructionsUnder13 => "Please enter your parent's email address. We will send a link to complete verification.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public virtual string ResponseDialogAddEmailOver13 => "Please add an email address to your account to ensure that you can always access your Roblox account.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public virtual string ResponseDialogAddEmailUnder13 => "Please add your parent's email address to your account to ensure that you can always access your Roblox account.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public virtual string ResponseDialogAddPhone => "Please add a phone number to your account to ensure that you never get locked out of your account.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public virtual string ResponseDialogAddPhoneForFreeHat => "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public virtual string ResponseDialogAddPhoneInstructions => "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public virtual string ResponseDialogConfirmEmailForFreeHatOver13 => "Remember to confirm your email address to receive the free hat!";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public virtual string ResponseDialogConfirmEmailForFreeHatUnder13 => "Remember to confirm your parent's email address to receive the free hat!";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public virtual string ResponseDialogContactFriendFinderPhoneUpsell => "Please add a phone number to your account so that your friends can find you!";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public virtual string ResponseDialogFreeHatForAddingPhone => "Your phone number has been confirmed. Enjoy the free hat!";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public virtual string ResponseDialogPhoneAdded => "Phone has been successfully added.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public virtual string ResponseDialogVerifyEmail13AndOverSuccessMessage => "Verification link has been sent to your email - please verify your email to secure your account.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public virtual string ResponseDialogVerifyEmailOver13 => "Please verify your email address to ensure that you can always access your Roblox account.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public virtual string ResponseDialogVerifyEmailUnder13 => "Please verify your parent's email address to ensure that you can always access your Roblox account.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public virtual string ResponseDialogVerifyEmailUnder13SuccessMessage => "Verification link has been sent to your parent's email - please verify your parent's email to secure your account.";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public virtual string ResponseDialogVerifyEmailInstructions => "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings > Account Info to modify your account.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public virtual string ResponseGenericError => "An error occurred. Please try again later.";

	public ContactUpsellResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.AddEmail",
				_GetTemplateForActionAddEmail()
			},
			{
				"Action.AddEmailLink",
				_GetTemplateForActionAddEmailLink()
			},
			{
				"Action.AddEmailNow",
				_GetTemplateForActionAddEmailNow()
			},
			{
				"Action.AddNow",
				_GetTemplateForActionAddNow()
			},
			{
				"Action.AddParentsEmail",
				_GetTemplateForActionAddParentsEmail()
			},
			{
				"Action.AddParentsEmailNow",
				_GetTemplateForActionAddParentsEmailNow()
			},
			{
				"Action.AddPhone",
				_GetTemplateForActionAddPhone()
			},
			{
				"Action.AddPhoneNow",
				_GetTemplateForActionAddPhoneNow()
			},
			{
				"Action.Close",
				_GetTemplateForActionClose()
			},
			{
				"Action.ConfirmEmail",
				_GetTemplateForActionConfirmEmail()
			},
			{
				"Action.EditPhoneNumber",
				_GetTemplateForActionEditPhoneNumber()
			},
			{
				"Action.Ok",
				_GetTemplateForActionOk()
			},
			{
				"Action.ResendCode",
				_GetTemplateForActionResendCode()
			},
			{
				"Action.Submit",
				_GetTemplateForActionSubmit()
			},
			{
				"Action.Verify",
				_GetTemplateForActionVerify()
			},
			{
				"Action.VerifyEmail",
				_GetTemplateForActionVerifyEmail()
			},
			{
				"Action.VerifyPhone",
				_GetTemplateForActionVerifyPhone()
			},
			{
				"Actions.AddParentsEmail",
				_GetTemplateForActionsAddParentsEmail()
			},
			{
				"Heading.AddEmail",
				_GetTemplateForHeadingAddEmail()
			},
			{
				"Heading.DefaultHeader",
				_GetTemplateForHeadingDefaultHeader()
			},
			{
				"Heading.DontForgetToConfirm",
				_GetTemplateForHeadingDontForgetToConfirm()
			},
			{
				"Heading.Error",
				_GetTemplateForHeadingError()
			},
			{
				"Heading.FindFriends",
				_GetTemplateForHeadingFindFriends()
			},
			{
				"Heading.FreeHat",
				_GetTemplateForHeadingFreeHat()
			},
			{
				"Heading.Success",
				_GetTemplateForHeadingSuccess()
			},
			{
				"Heading.VerifyEmail",
				_GetTemplateForHeadingVerifyEmail()
			},
			{
				"Label.AddPhone",
				_GetTemplateForLabelAddPhone()
			},
			{
				"Label.CodePlaceHolder",
				_GetTemplateForLabelCodePlaceHolder()
			},
			{
				"Label.EmailPlaceholder",
				_GetTemplateForLabelEmailPlaceholder()
			},
			{
				"Label.Error",
				_GetTemplateForLabelError()
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
				"Label.NoEmail",
				_GetTemplateForLabelNoEmail()
			},
			{
				"Label.NoPhone",
				_GetTemplateForLabelNoPhone()
			},
			{
				"Label.NotReceived",
				_GetTemplateForLabelNotReceived()
			},
			{
				"Label.Or",
				_GetTemplateForLabelOr()
			},
			{
				"Label.ParentsEmailPlaceholder",
				_GetTemplateForLabelParentsEmailPlaceholder()
			},
			{
				"Label.Password",
				_GetTemplateForLabelPassword()
			},
			{
				"Label.PhonePlaceholder",
				_GetTemplateForLabelPhonePlaceholder()
			},
			{
				"Label.ProtectAccountWithEmail",
				_GetTemplateForLabelProtectAccountWithEmail()
			},
			{
				"Label.ProtectAccountWithParentsEmail",
				_GetTemplateForLabelProtectAccountWithParentsEmail()
			},
			{
				"Label.ProtectAccountWithPhone",
				_GetTemplateForLabelProtectAccountWithPhone()
			},
			{
				"Label.ResendEmail",
				_GetTemplateForLabelResendEmail()
			},
			{
				"Label.VerifyEmailToProtectAccount",
				_GetTemplateForLabelVerifyEmailToProtectAccount()
			},
			{
				"Label.VerifyParentsEmailToProtectAccount",
				_GetTemplateForLabelVerifyParentsEmailToProtectAccount()
			},
			{
				"Label.VerifyPasswordPlaceholder",
				_GetTemplateForLabelVerifyPasswordPlaceholder()
			},
			{
				"Response.CountryListError",
				_GetTemplateForResponseCountryListError()
			},
			{
				"Response.Dialog.AddEmailForFreeHatOver13",
				_GetTemplateForResponseDialogAddEmailForFreeHatOver13()
			},
			{
				"Response.Dialog.AddEmailForFreeHatUnder13",
				_GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
			},
			{
				"Response.Dialog.AddEmailInstructionsOver13",
				_GetTemplateForResponseDialogAddEmailInstructionsOver13()
			},
			{
				"Response.Dialog.AddEmailInstructionsUnder13",
				_GetTemplateForResponseDialogAddEmailInstructionsUnder13()
			},
			{
				"Response.Dialog.AddEmailOver13",
				_GetTemplateForResponseDialogAddEmailOver13()
			},
			{
				"Response.Dialog.AddEmailUnder13",
				_GetTemplateForResponseDialogAddEmailUnder13()
			},
			{
				"Response.Dialog.AddPhone",
				_GetTemplateForResponseDialogAddPhone()
			},
			{
				"Response.Dialog.AddPhoneForFreeHat",
				_GetTemplateForResponseDialogAddPhoneForFreeHat()
			},
			{
				"Response.Dialog.AddPhoneInstructions",
				_GetTemplateForResponseDialogAddPhoneInstructions()
			},
			{
				"Response.Dialog.ConfirmEmailForFreeHatOver13",
				_GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
			},
			{
				"Response.Dialog.ConfirmEmailForFreeHatUnder13",
				_GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
			},
			{
				"Response.Dialog.ContactFriendFinderPhoneUpsell",
				_GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
			},
			{
				"Response.Dialog.EnterCodeInstructions",
				_GetTemplateForResponseDialogEnterCodeInstructions()
			},
			{
				"Response.Dialog.FreeHatForAddingPhone",
				_GetTemplateForResponseDialogFreeHatForAddingPhone()
			},
			{
				"Response.Dialog.PhoneAdded",
				_GetTemplateForResponseDialogPhoneAdded()
			},
			{
				"Response.Dialog.VerifyEmail13AndOverSuccessMessage",
				_GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
			},
			{
				"Response.Dialog.VerifyEmailOver13",
				_GetTemplateForResponseDialogVerifyEmailOver13()
			},
			{
				"Response.Dialog.VerifyEmailUnder13",
				_GetTemplateForResponseDialogVerifyEmailUnder13()
			},
			{
				"Response.Dialog.VerifyEmailUnder13SuccessMessage",
				_GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
			},
			{
				"Response.DialogVerifyEmailInstructions",
				_GetTemplateForResponseDialogVerifyEmailInstructions()
			},
			{
				"Response.GenericError",
				_GetTemplateForResponseGenericError()
			},
			{
				"Response.IncorrectCodeLength",
				_GetTemplateForResponseIncorrectCodeLength()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.ContactUpsell";
	}

	protected virtual string _GetTemplateForActionAddEmail()
	{
		return "Add Email";
	}

	protected virtual string _GetTemplateForActionAddEmailLink()
	{
		return "Add email";
	}

	protected virtual string _GetTemplateForActionAddEmailNow()
	{
		return "Add Email Now";
	}

	protected virtual string _GetTemplateForActionAddNow()
	{
		return "Add Now";
	}

	protected virtual string _GetTemplateForActionAddParentsEmail()
	{
		return "Add Parent's Email";
	}

	protected virtual string _GetTemplateForActionAddParentsEmailNow()
	{
		return "Add Parent's Email Now";
	}

	protected virtual string _GetTemplateForActionAddPhone()
	{
		return "Add Phone Number";
	}

	protected virtual string _GetTemplateForActionAddPhoneNow()
	{
		return "Add Phone Now";
	}

	protected virtual string _GetTemplateForActionClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionConfirmEmail()
	{
		return "Confirm Email";
	}

	protected virtual string _GetTemplateForActionEditPhoneNumber()
	{
		return "Edit Phone Number";
	}

	protected virtual string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionResendCode()
	{
		return "Resend Code";
	}

	protected virtual string _GetTemplateForActionSubmit()
	{
		return "Submit";
	}

	protected virtual string _GetTemplateForActionVerify()
	{
		return "Verify";
	}

	protected virtual string _GetTemplateForActionVerifyEmail()
	{
		return "Verify Email";
	}

	protected virtual string _GetTemplateForActionVerifyPhone()
	{
		return "Verify Phone";
	}

	protected virtual string _GetTemplateForActionsAddParentsEmail()
	{
		return "Add Parent's Email";
	}

	protected virtual string _GetTemplateForHeadingAddEmail()
	{
		return "Add Email";
	}

	protected virtual string _GetTemplateForHeadingDefaultHeader()
	{
		return "Don't get locked out!";
	}

	protected virtual string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "Don't forget to confirm!";
	}

	protected virtual string _GetTemplateForHeadingError()
	{
		return "An error occurred";
	}

	protected virtual string _GetTemplateForHeadingFindFriends()
	{
		return "Help your friends find you!";
	}

	protected virtual string _GetTemplateForHeadingFreeHat()
	{
		return "Get yourself a free hat!";
	}

	protected virtual string _GetTemplateForHeadingSuccess()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForHeadingVerifyEmail()
	{
		return "Verify Email";
	}

	protected virtual string _GetTemplateForLabelAddPhone()
	{
		return "AddPhone";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public virtual string LabelCodePlaceHolder(string number)
	{
		return $"Enter Code ({number}- digit)";
	}

	protected virtual string _GetTemplateForLabelCodePlaceHolder()
	{
		return "Enter Code ({number}- digit)";
	}

	protected virtual string _GetTemplateForLabelEmailPlaceholder()
	{
		return "Email Address";
	}

	protected virtual string _GetTemplateForLabelError()
	{
		return "An error occurred";
	}

	protected virtual string _GetTemplateForLabelInvalidEmail()
	{
		return "Invalid email";
	}

	protected virtual string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Invalid phone number";
	}

	protected virtual string _GetTemplateForLabelNoEmail()
	{
		return "Don't have an email?";
	}

	protected virtual string _GetTemplateForLabelNoPhone()
	{
		return "Don't have a phone?";
	}

	protected virtual string _GetTemplateForLabelNotReceived()
	{
		return "Didn't receive it?";
	}

	protected virtual string _GetTemplateForLabelOr()
	{
		return "Or";
	}

	protected virtual string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "Parent's Email Address";
	}

	protected virtual string _GetTemplateForLabelPassword()
	{
		return "Roblox Account Password";
	}

	protected virtual string _GetTemplateForLabelPhonePlaceholder()
	{
		return "Phone Number";
	}

	protected virtual string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "Protect your account with an email!";
	}

	protected virtual string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "Protect your account with your parent's email!";
	}

	protected virtual string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "Protect your account with a phone number!";
	}

	protected virtual string _GetTemplateForLabelResendEmail()
	{
		return "Resend Email";
	}

	protected virtual string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "Verify your email to protect your account!";
	}

	protected virtual string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "Verify your parent's email to protect your account!";
	}

	protected virtual string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Roblox Account Password";
	}

	protected virtual string _GetTemplateForResponseCountryListError()
	{
		return "An error occurred loading the country list";
	}

	protected virtual string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "Please add your email to receive a free hat and ensure that you never get locked out of your account!";
	}

	protected virtual string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!";
	}

	protected virtual string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "Please enter your email address. We will send a link to complete verification.";
	}

	protected virtual string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "Please enter your parent's email address. We will send a link to complete verification.";
	}

	protected virtual string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "Please add an email address to your account to ensure that you can always access your Roblox account.";
	}

	protected virtual string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "Please add your parent's email address to your account to ensure that you can always access your Roblox account.";
	}

	protected virtual string _GetTemplateForResponseDialogAddPhone()
	{
		return "Please add a phone number to your account to ensure that you never get locked out of your account.";
	}

	protected virtual string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!";
	}

	protected virtual string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)";
	}

	protected virtual string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "Remember to confirm your email address to receive the free hat!";
	}

	protected virtual string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "Remember to confirm your parent's email address to receive the free hat!";
	}

	protected virtual string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "Please add a phone number to your account so that your friends can find you!";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public virtual string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"Enter the code in the text sent to {phoneNumber}";
	}

	protected virtual string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "Enter the code in the text sent to {phoneNumber}";
	}

	protected virtual string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "Your phone number has been confirmed. Enjoy the free hat!";
	}

	protected virtual string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "Phone has been successfully added.";
	}

	protected virtual string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "Verification link has been sent to your email - please verify your email to secure your account.";
	}

	protected virtual string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "Please verify your email address to ensure that you can always access your Roblox account.";
	}

	protected virtual string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "Please verify your parent's email address to ensure that you can always access your Roblox account.";
	}

	protected virtual string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "Verification link has been sent to your parent's email - please verify your parent's email to secure your account.";
	}

	protected virtual string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings > Account Info to modify your account.";
	}

	protected virtual string _GetTemplateForResponseGenericError()
	{
		return "An error occurred. Please try again later.";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public virtual string ResponseIncorrectCodeLength(string number)
	{
		return $"Code must be {number} digits";
	}

	protected virtual string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "Code must be {number} digits";
	}
}
