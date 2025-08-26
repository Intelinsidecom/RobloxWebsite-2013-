namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAddEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "ä»Šã™ããƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "ä»Šã™ãè¿½åŠ ";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "ä»Šã™ãä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "é›»è©±ç•ªå·ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "ä»Šã™ãé›»è©±ç•ªå·ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é–‰ã˜ã‚‹";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®ç¢ºèª";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "é›»è©±ç•ªå·ã‚’ç·¨é›†";

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
	public override string ActionResendCode => "ã‚³ãƒ¼ãƒ‰ã‚’å†é€ä¿¡";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "é€ä¿¡ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ç¢ºèª";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "é›»è©±ç•ªå·ã‚’ç¢ºèª";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«æ³¨æ„ï¼";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "å¿˜ã‚Œãšã«ç¢ºèªã—ã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿ";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "å‹é”ãŒã‚ãªãŸã‚’è¦‹ã¤ã‘ã‚„ã™ãã—ã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "å¸½å­ã‚’ç„¡æ–™ã§ã‚²ãƒƒãƒˆã—ã‚ˆã†ï¼";

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
	public override string HeadingVerifyEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "é›»è©±ç•ªå·ã‚’ç™»éŒ²";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿ";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "ç„¡åŠ¹ãªãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "ç„¡åŠ¹ãªé›»è©±ç•ªå·";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ãŠæŒã¡ã§ãªã„å ´åˆã€‚";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "é›»è©±ã‚’ãŠæŒã¡ã§ãªã„å ´åˆã€‚";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "å—ä¿¡ã§ããªã„å ´åˆã€‚";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "ã¾ãŸã¯";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "é›»è©±ç•ªå·";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã§ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã§ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "é›»è©±ç•ªå·ã§ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "ãƒ¡ãƒ¼ãƒ«ã‚’å†é€ä¿¡";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "å›½åãƒªã‚¹ãƒˆã®èª­ã¿è¾¼ã¿ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ç™»éŒ²ã—ã¦å¸½å­ã‚’ç„¡æ–™ã§ã‚²ãƒƒãƒˆã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¦ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ç™»éŒ²ã—ã¦å¸½å­ã‚’ç„¡æ–™ã§ã‚²ãƒƒãƒˆã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚èªè¨¼ã‚’å®Œäº†ã™ã‚‹ãŸã‚ã®ãƒªãƒ³ã‚¯ã‚’ãŠé€ã‚Šã—ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚èªè¨¼ã‚’å®Œäº†ã™ã‚‹ãŸã‚ã®ãƒªãƒ³ã‚¯ã‚’ãŠé€ã‚Šã—ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "ã„ã¤ã§ã‚‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "ã„ã¤ã§ã‚‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«é›»è©±ç•ªå·ã‚’ç™»éŒ²ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "é›»è©±ç•ªå·ã‚’ç™»éŒ²ã—ã¦å¸½å­ã‚’ç„¡æ–™ã§ã‚²ãƒƒãƒˆã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "å›½ã‚³ãƒ¼ãƒ‰ã‚’ç¢ºèªã—ã¦ã€é›»è©±ç•ªå·ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚èªè¨¼å®Œäº†ç”¨ã®ãƒ†ã‚­ã‚¹ãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒé€ä¿¡ã•ã‚Œã¾ã™ã€‚ï¼ˆã”æ³¨æ„: é€šä¿¡æ–™ãŒã‹ã‹ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ï¼‰";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€å¸½å­ã‚’ç„¡æ–™ã§æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€å¸½å­ã‚’ç„¡æ–™ã§æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«é›»è©±ç•ªå·ã‚’ç™»éŒ²ã—ã¦ã€å‹é”ã«è¦‹ã¤ã‘ã¦ã‚‚ã‚‰ãˆã‚‹ã‚ˆã†ã«ã—ã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "é›»è©±ç•ªå·ã‚’èªè¨¼ã—ã¾ã—ãŸã€‚ç„¡æ–™ã®å¸½å­ã‚’å—ã‘å–ã£ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "é›»è©±ç•ªå·ãŒè¿½åŠ ã•ã‚Œã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "èªè¨¼ç”¨ãƒªãƒ³ã‚¯ã‚’ãƒ¡ãƒ¼ãƒ«ã§é€ä¿¡ã—ã¾ã—ãŸ - ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "ã„ã¤ã§ã‚‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "ã„ã¤ã§ã‚‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "èªè¨¼ç”¨ãƒªãƒ³ã‚¯ã‚’ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã«é€ä¿¡ã—ã¾ã—ãŸ - ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "èªè¨¼ç”¨ãƒªãƒ³ã‚¯ã‚’ãƒ¡ãƒ¼ãƒ«ã§é€ä¿¡ã—ã¾ã—ãŸ - ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ã€‚ã€Œè¨­å®šã€>ã€Œã‚¢ã‚«ã‚¦ãƒ³ãƒˆæƒ…å ±ã€ã§ã„ã¤ã§ã‚‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®šã‚’å¤‰æ›´ã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public ContactUpsellResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "ä»Šã™ããƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "ä»Šã™ãè¿½åŠ ";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "ä»Šã™ãä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "é›»è©±ç•ªå·ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "ä»Šã™ãé›»è©±ç•ªå·ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é–‰ã˜ã‚‹";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®ç¢ºèª";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "é›»è©±ç•ªå·ã‚’ç·¨é›†";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "ã‚³ãƒ¼ãƒ‰ã‚’å†é€ä¿¡";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "é€ä¿¡ã™ã‚‹";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ç¢ºèª";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "é›»è©±ç•ªå·ã‚’ç¢ºèª";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«æ³¨æ„ï¼";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "å¿˜ã‚Œãšã«ç¢ºèªã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿ";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "å‹é”ãŒã‚ãªãŸã‚’è¦‹ã¤ã‘ã‚„ã™ãã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "å¸½å­ã‚’ç„¡æ–™ã§ã‚²ãƒƒãƒˆã—ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "æˆåŠŸ";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "é›»è©±ç•ªå·ã‚’ç™»éŒ²";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ï¼ˆ{number}æ¡ï¼‰";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ï¼ˆ{number}æ¡ï¼‰";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿ";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "ç„¡åŠ¹ãªãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "ç„¡åŠ¹ãªé›»è©±ç•ªå·";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ãŠæŒã¡ã§ãªã„å ´åˆã€‚";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "é›»è©±ã‚’ãŠæŒã¡ã§ãªã„å ´åˆã€‚";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "å—ä¿¡ã§ããªã„å ´åˆã€‚";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "ã¾ãŸã¯";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "é›»è©±ç•ªå·";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã§ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã§ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "é›»è©±ç•ªå·ã§ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚’å†é€ä¿¡";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "å›½åãƒªã‚¹ãƒˆã®èª­ã¿è¾¼ã¿ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ç™»éŒ²ã—ã¦å¸½å­ã‚’ç„¡æ–™ã§ã‚²ãƒƒãƒˆã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¦ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ç™»éŒ²ã—ã¦å¸½å­ã‚’ç„¡æ–™ã§ã‚²ãƒƒãƒˆã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚èªè¨¼ã‚’å®Œäº†ã™ã‚‹ãŸã‚ã®ãƒªãƒ³ã‚¯ã‚’ãŠé€ã‚Šã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚èªè¨¼ã‚’å®Œäº†ã™ã‚‹ãŸã‚ã®ãƒªãƒ³ã‚¯ã‚’ãŠé€ã‚Šã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "ã„ã¤ã§ã‚‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "ã„ã¤ã§ã‚‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«é›»è©±ç•ªå·ã‚’ç™»éŒ²ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "é›»è©±ç•ªå·ã‚’ç™»éŒ²ã—ã¦å¸½å­ã‚’ç„¡æ–™ã§ã‚²ãƒƒãƒˆã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹æ‹’å¦ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "å›½ã‚³ãƒ¼ãƒ‰ã‚’ç¢ºèªã—ã¦ã€é›»è©±ç•ªå·ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚èªè¨¼å®Œäº†ç”¨ã®ãƒ†ã‚­ã‚¹ãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒé€ä¿¡ã•ã‚Œã¾ã™ã€‚ï¼ˆã”æ³¨æ„: é€šä¿¡æ–™ãŒã‹ã‹ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ï¼‰";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€å¸½å­ã‚’ç„¡æ–™ã§æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€å¸½å­ã‚’ç„¡æ–™ã§æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«é›»è©±ç•ªå·ã‚’ç™»éŒ²ã—ã¦ã€å‹é”ã«è¦‹ã¤ã‘ã¦ã‚‚ã‚‰ãˆã‚‹ã‚ˆã†ã«ã—ã¾ã—ã‚‡ã†ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"{phoneNumber}ã«é€ä¿¡ã•ã‚ŒãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "{phoneNumber}ã«é€ä¿¡ã•ã‚ŒãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "é›»è©±ç•ªå·ã‚’èªè¨¼ã—ã¾ã—ãŸã€‚ç„¡æ–™ã®å¸½å­ã‚’å—ã‘å–ã£ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "é›»è©±ç•ªå·ãŒè¿½åŠ ã•ã‚Œã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "èªè¨¼ç”¨ãƒªãƒ³ã‚¯ã‚’ãƒ¡ãƒ¼ãƒ«ã§é€ä¿¡ã—ã¾ã—ãŸ - ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "ã„ã¤ã§ã‚‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "ã„ã¤ã§ã‚‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚¢ã‚¯ã‚»ã‚¹ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "èªè¨¼ç”¨ãƒªãƒ³ã‚¯ã‚’ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã«é€ä¿¡ã—ã¾ã—ãŸ - ä¿è­·è€…ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "èªè¨¼ç”¨ãƒªãƒ³ã‚¯ã‚’ãƒ¡ãƒ¼ãƒ«ã§é€ä¿¡ã—ã¾ã—ãŸ - ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¦ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä¿è­·ã—ã¦ãã ã•ã„ã€‚ã€Œè¨­å®šã€>ã€Œã‚¢ã‚«ã‚¦ãƒ³ãƒˆæƒ…å ±ã€ã§ã„ã¤ã§ã‚‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®šã‚’å¤‰æ›´ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"ã‚³ãƒ¼ãƒ‰ã¯ {number} æ¡ã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "ã‚³ãƒ¼ãƒ‰ã¯ {number} æ¡ã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™";
	}
}


}
