namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAddEmail => "æ–°å¢žé›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "æ–°å¢žé›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "ç¾åœ¨æ–°å¢žé›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "ç¾åœ¨æ–°å¢ž";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "æ–°å¢žå®¶é•·çš„é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "ç¾åœ¨æ–°å¢žå®¶é•·çš„é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "æ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "ç¾åœ¨æ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é—œé–‰";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "ç¢ºèªé›»å­éƒµä»¶";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "ç·¨è¼¯æ‰‹æ©Ÿè™Ÿç¢¼";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "é‡æ–°å‚³é€é©—è­‰ç¢¼";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "æäº¤";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "é©—è­‰";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "é©—è­‰é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "é©—è­‰æ‰‹æ©Ÿ";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "æ–°å¢žå®¶é•·çš„é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "æ–°å¢žé›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "ç¢ºä¿è‡ªå·±å¯ä»¥ç™»å…¥å¸³è™Ÿï¼";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "åˆ¥å¿˜äº†ç¢ºèªï¼";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "è®“å¥½å‹æ›´å®¹æ˜“æ‰¾åˆ°æ‚¨ï¼";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "é ˜å–å…è²»å¸½å­ï¼";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public override string HeadingSuccess => "æˆåŠŸ";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public override string HeadingVerifyEmail => "é©—è­‰é›»å­éƒµä»¶åœ°å€";

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
	public override string LabelEmailPlaceholder => "é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "é›»å­éƒµä»¶åœ°å€ç„¡æ•ˆ";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "æ‰‹æ©Ÿè™Ÿç¢¼ç„¡æ•ˆ";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "æ²’æœ‰é›»å­éƒµä»¶åœ°å€ï¼Ÿ";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "æ²’æœ‰æ‰‹æ©Ÿï¼Ÿ";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "æ²’æœ‰æ”¶åˆ°ï¼Ÿ";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "æˆ–";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "å®¶é•·çš„é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Roblox å¸³è™Ÿå¯†ç¢¼";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "æ‰‹æ©Ÿè™Ÿç¢¼";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "æ–°å¢žé›»å­éƒµä»¶åœ°å€ï¼Œä¿è­·æ‚¨çš„å¸³è™Ÿï¼";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "æ–°å¢žæ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œä¿è­·æ‚¨çš„å¸³è™Ÿï¼";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "ä»¥æ‰‹æ©Ÿè™Ÿç¢¼ä¿è­·æ‚¨çš„å¸³æˆ¶ï¼";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "é‡æ–°å‚³é€é›»å­éƒµä»¶";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "é©—è­‰æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œä¿è­·æ‚¨çš„å¸³è™Ÿï¼";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "é©—è­‰æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œä¿è­·æ‚¨çš„å¸³è™Ÿï¼";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Roblox å¸³è™Ÿå¯†ç¢¼";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "è¼‰å…¥åœ‹å®¶æ¸…å–®æ™‚ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "è«‹æ–°å¢žæ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œæˆ‘å€‘å°‡é€æ‚¨ä¸€é ‚å¸½å­ï¼Œæ‚¨ä¹Ÿå¯ä»¥é¿å…å¾€å¾Œç„¡æ³•é€²å…¥å¸³è™Ÿçš„æƒ…æ³ï¼";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "è«‹æ–°å¢žæ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œæˆ‘å€‘å°‡é€æ‚¨ä¸€é ‚å¸½å­ï¼Œæ‚¨ä¹Ÿå¯ä»¥é¿å…å¾€å¾Œç„¡æ³•é€²å…¥å¸³è™Ÿçš„æƒ…æ³ï¼";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "è«‹è¼¸å…¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œæˆ‘å€‘æœƒå‚³é€é€£çµå®Œæˆé©—è­‰ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "è«‹è¼¸å…¥æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œæˆ‘å€‘æœƒå‚³é€é€£çµå®Œæˆé©—è­‰ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "è«‹åœ¨æ‚¨çš„å¸³è™Ÿæ–°å¢žé›»å­éƒµä»¶åœ°å€ï¼Œç¢ºä¿æ‚¨å¯ä»¥æ°¸é å­˜å–æ‚¨çš„ Roblox å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "è«‹åœ¨æ‚¨çš„å¸³è™Ÿæ–°å¢žæ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œç¢ºä¿æ‚¨å¯ä»¥æ°¸é å­˜å–æ‚¨çš„ Roblox å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "è«‹åœ¨æ‚¨çš„å¸³è™Ÿæ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼ï¼Œé¿å…å¾€å¾Œç„¡æ³•é€²å…¥å¸³è™Ÿçš„æƒ…æ³ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "è«‹æ–°å¢žæ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ï¼Œæˆ‘å€‘å°‡é€æ‚¨ä¸€é ‚å¸½å­ï¼Œæ‚¨ä¹Ÿå¯ä»¥é¿å…å¾€å¾Œç„¡æ³•é€²å…¥å¸³è™Ÿçš„æƒ…æ³ï¼";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "è«‹ç¢ºèªæ‚¨çš„åœ‹ç¢¼ï¼Œä¸¦è¼¸å…¥æ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ã€‚æˆ‘å€‘æœƒå‚³é€ä¸€å‰‡ç°¡è¨Šä»¥å®Œæˆé©—è­‰ã€‚ï¼ˆæ³¨æ„ï¼šå¯èƒ½æœƒæ”¶å–ç°¡è¨Šè²»ç”¨ï¼‰";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "è¨˜å¾—ç¢ºèªæ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œç²å¾—å…è²»å¸½å­ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "è¨˜å¾—ç¢ºèªæ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œç²å¾—å…è²»å¸½å­ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "è«‹åœ¨æ‚¨çš„å¸³è™Ÿæ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼ï¼Œè®“æ‚¨çš„å¥½å‹æ‰¾å¾—åˆ°æ‚¨ï¼";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "å·²ç¢ºèªæ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ã€‚æ­å–œæ‚¨ç²å¾—å…è²»çš„å¸½å­ï¼";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "å·²æˆåŠŸæ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "é©—è­‰é€£çµå·²å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œè«‹é©—è­‰æ‚¨çš„é›»å­éƒµä»¶ä»¥ä¿è­·æ‚¨çš„å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "è«‹é©—è­‰æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œç¢ºä¿æ‚¨æ°¸é å¯ä»¥å­˜å–æ‚¨çš„ Roblox å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "è«‹é©—è­‰æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œç¢ºä¿æ‚¨æ°¸é å¯ä»¥å­˜å–æ‚¨çš„ Roblox å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "é©—è­‰é€£çµå·²å‚³é€åˆ°æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œè«‹é©—è­‰æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶ä»¥ä¿è­·æ‚¨çš„å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "é©—è­‰é€£çµå·²å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œè«‹é©—è­‰æ‚¨çš„é›»å­éƒµä»¶ä¿è­·æ‚¨çš„å¸³è™Ÿã€‚æ‚¨å¯ä»¥å‰å¾€ã€Œè¨­å®šã€>ã€Œå¸³è™Ÿè³‡è¨Šã€ä¿®æ”¹æ‚¨çš„å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public ContactUpsellResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "æ–°å¢žé›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "æ–°å¢žé›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "ç¾åœ¨æ–°å¢žé›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "ç¾åœ¨æ–°å¢ž";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "æ–°å¢žå®¶é•·çš„é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "ç¾åœ¨æ–°å¢žå®¶é•·çš„é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "æ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "ç¾åœ¨æ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "ç¢ºèªé›»å­éƒµä»¶";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "ç·¨è¼¯æ‰‹æ©Ÿè™Ÿç¢¼";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "é‡æ–°å‚³é€é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "é©—è­‰";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "é©—è­‰é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "é©—è­‰æ‰‹æ©Ÿ";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "æ–°å¢žå®¶é•·çš„é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "æ–°å¢žé›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "ç¢ºä¿è‡ªå·±å¯ä»¥ç™»å…¥å¸³è™Ÿï¼";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "åˆ¥å¿˜äº†ç¢ºèªï¼";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "è®“å¥½å‹æ›´å®¹æ˜“æ‰¾åˆ°æ‚¨ï¼";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "é ˜å–å…è²»å¸½å­ï¼";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "æˆåŠŸ";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "é©—è­‰é›»å­éƒµä»¶åœ°å€";
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
		return $"è¼¸å…¥é©—è­‰ç¢¼ ({number} ä½æ•¸)";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "è¼¸å…¥é©—è­‰ç¢¼ ({number} ä½æ•¸)";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "é›»å­éƒµä»¶åœ°å€ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "æ‰‹æ©Ÿè™Ÿç¢¼ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "æ²’æœ‰é›»å­éƒµä»¶åœ°å€ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "æ²’æœ‰æ‰‹æ©Ÿï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "æ²’æœ‰æ”¶åˆ°ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "æˆ–";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "å®¶é•·çš„é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Roblox å¸³è™Ÿå¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "æ‰‹æ©Ÿè™Ÿç¢¼";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "æ–°å¢žé›»å­éƒµä»¶åœ°å€ï¼Œä¿è­·æ‚¨çš„å¸³è™Ÿï¼";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "æ–°å¢žæ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œä¿è­·æ‚¨çš„å¸³è™Ÿï¼";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "ä»¥æ‰‹æ©Ÿè™Ÿç¢¼ä¿è­·æ‚¨çš„å¸³æˆ¶ï¼";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "é‡æ–°å‚³é€é›»å­éƒµä»¶";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "é©—è­‰æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œä¿è­·æ‚¨çš„å¸³è™Ÿï¼";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "é©—è­‰æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œä¿è­·æ‚¨çš„å¸³è™Ÿï¼";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Roblox å¸³è™Ÿå¯†ç¢¼";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "è¼‰å…¥åœ‹å®¶æ¸…å–®æ™‚ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "è«‹æ–°å¢žæ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œæˆ‘å€‘å°‡é€æ‚¨ä¸€é ‚å¸½å­ï¼Œæ‚¨ä¹Ÿå¯ä»¥é¿å…å¾€å¾Œç„¡æ³•é€²å…¥å¸³è™Ÿçš„æƒ…æ³ï¼";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "è«‹æ–°å¢žæ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œæˆ‘å€‘å°‡é€æ‚¨ä¸€é ‚å¸½å­ï¼Œæ‚¨ä¹Ÿå¯ä»¥é¿å…å¾€å¾Œç„¡æ³•é€²å…¥å¸³è™Ÿçš„æƒ…æ³ï¼";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "è«‹è¼¸å…¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œæˆ‘å€‘æœƒå‚³é€é€£çµå®Œæˆé©—è­‰ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "è«‹è¼¸å…¥æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œæˆ‘å€‘æœƒå‚³é€é€£çµå®Œæˆé©—è­‰ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "è«‹åœ¨æ‚¨çš„å¸³è™Ÿæ–°å¢žé›»å­éƒµä»¶åœ°å€ï¼Œç¢ºä¿æ‚¨å¯ä»¥æ°¸é å­˜å–æ‚¨çš„ Roblox å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "è«‹åœ¨æ‚¨çš„å¸³è™Ÿæ–°å¢žæ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œç¢ºä¿æ‚¨å¯ä»¥æ°¸é å­˜å–æ‚¨çš„ Roblox å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "è«‹åœ¨æ‚¨çš„å¸³è™Ÿæ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼ï¼Œé¿å…å¾€å¾Œç„¡æ³•é€²å…¥å¸³è™Ÿçš„æƒ…æ³ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "è«‹æ–°å¢žæ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ï¼Œæˆ‘å€‘å°‡é€æ‚¨ä¸€é ‚å¸½å­ï¼Œæ‚¨ä¹Ÿå¯ä»¥é¿å…å¾€å¾Œç„¡æ³•é€²å…¥å¸³è™Ÿçš„æƒ…æ³ï¼";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "è«‹ç¢ºèªæ‚¨çš„åœ‹ç¢¼ï¼Œä¸¦è¼¸å…¥æ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ã€‚æˆ‘å€‘æœƒå‚³é€ä¸€å‰‡ç°¡è¨Šä»¥å®Œæˆé©—è­‰ã€‚ï¼ˆæ³¨æ„ï¼šå¯èƒ½æœƒæ”¶å–ç°¡è¨Šè²»ç”¨ï¼‰";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "è¨˜å¾—ç¢ºèªæ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œç²å¾—å…è²»å¸½å­ï¼";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "è¨˜å¾—ç¢ºèªæ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œç²å¾—å…è²»å¸½å­ï¼";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "è«‹åœ¨æ‚¨çš„å¸³è™Ÿæ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼ï¼Œè®“æ‚¨çš„å¥½å‹æ‰¾å¾—åˆ°æ‚¨ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"è«‹è¼¸å…¥å‚³é€åˆ° {phoneNumber} çš„é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "è«‹è¼¸å…¥å‚³é€åˆ° {phoneNumber} çš„é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "å·²ç¢ºèªæ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ã€‚æ­å–œæ‚¨ç²å¾—å…è²»çš„å¸½å­ï¼";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "å·²æˆåŠŸæ–°å¢žæ‰‹æ©Ÿè™Ÿç¢¼ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "é©—è­‰é€£çµå·²å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œè«‹é©—è­‰æ‚¨çš„é›»å­éƒµä»¶ä»¥ä¿è­·æ‚¨çš„å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "è«‹é©—è­‰æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œç¢ºä¿æ‚¨æ°¸é å¯ä»¥å­˜å–æ‚¨çš„ Roblox å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "è«‹é©—è­‰æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œç¢ºä¿æ‚¨æ°¸é å¯ä»¥å­˜å–æ‚¨çš„ Roblox å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "é©—è­‰é€£çµå·²å‚³é€åˆ°æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€ï¼Œè«‹é©—è­‰æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶ä»¥ä¿è­·æ‚¨çš„å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "é©—è­‰é€£çµå·²å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶åœ°å€ï¼Œè«‹é©—è­‰æ‚¨çš„é›»å­éƒµä»¶ä¿è­·æ‚¨çš„å¸³è™Ÿã€‚æ‚¨å¯ä»¥å‰å¾€ã€Œè¨­å®šã€>ã€Œå¸³è™Ÿè³‡è¨Šã€ä¿®æ”¹æ‚¨çš„å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"ä»£ç¢¼æ‡‰ç‚º {number} ä½æ•¸";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "ä»£ç¢¼æ‡‰ç‚º {number} ä½æ•¸";
	}
}


}
