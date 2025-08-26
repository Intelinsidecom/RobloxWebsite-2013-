namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_zh_cjv : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "æ·»åŠ ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "æ·»åŠ ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "ç«‹å³æ·»åŠ ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "ç«‹å³æ·»åŠ ";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "æ·»åŠ å®¶é•¿ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "ç«‹å³æ·»åŠ å®¶é•¿ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "æ·»åŠ æ‰‹æœºå·ç ";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "ç«‹å³æ·»åŠ æ‰‹æœºå·ç ";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "å…³é—­";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "ç¡®è®¤ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "ç¼–è¾‘æ‰‹æœºå·ç ";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "å¥½";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "é‡æ–°å‘é€éªŒè¯ç ";

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
	public override string ActionVerify => "éªŒè¯";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "éªŒè¯ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "éªŒè¯æ‰‹æœº";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "æ·»åŠ å®¶é•¿ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "æ·»åŠ ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "é˜²æ­¢ä½ çš„è´¦å·è¢«é”å®šï¼";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "åˆ«å¿˜äº†ç¡®è®¤ï¼";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "å‘ç”Ÿé”™è¯¯";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "è®©å¥½å‹æ›´å®¹æ˜“æ‰¾åˆ°ä½ ï¼";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "æ¥é¢†å–å…è´¹å¸½å­å§ï¼";

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
	public override string HeadingVerifyEmail => "éªŒè¯ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "æ·»åŠ æ‰‹æœºå·ç ";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "ç”µå­é‚®ä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "å‘ç”Ÿé”™è¯¯";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "ç”µå­é‚®ä»¶æ— æ•ˆ";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "æ‰‹æœºå·ç æ— æ•ˆ";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "æ²¡æœ‰ç”µå­é‚®ä»¶ï¼Ÿ";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "æ²¡æœ‰æ‰‹æœºï¼Ÿ";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "æ²¡æœ‰æ”¶åˆ°ï¼Ÿ";

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
	public override string LabelParentsEmailPlaceholder => "å®¶é•¿ç”µå­é‚®ä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Roblox å¸æˆ·å¯†ç ";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "æ‰‹æœºå·ç ";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "ä½¿ç”¨ç”µå­é‚®ä»¶ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "ä½¿ç”¨å®¶é•¿çš„ç”µå­é‚®ä»¶ä»¥ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "ä½¿ç”¨æ‰‹æœºå·ç ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "é‡æ–°å‘é€ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "éªŒè¯ä½ çš„ç”µå­é‚®ä»¶ä»¥ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "éªŒè¯ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶ä»¥ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Roblox å¸æˆ·å¯†ç ";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "åŠ è½½å›½å®¶åˆ—è¡¨æ—¶å‘ç”Ÿé”™è¯¯";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "è¯·æ·»åŠ ä½ çš„ç”µå­é‚®ä»¶ï¼Œæˆ‘ä»¬å°†é€ä½ ä¸€é¡¶å…è´¹çš„å¸½å­ï¼Œä½ ä¹Ÿä¼šé¿å…ä»¥åŽå‡ºçŽ°å¸æˆ·é”å®šçš„æƒ…å†µï¼";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "è¯·æ·»åŠ å®¶é•¿çš„ç”µå­é‚®ä»¶ä»¥èŽ·å¾—ä¸€é¡¶å…è´¹å¸½å­ï¼Œç¡®ä¿ä½ ä¸ä¼šè¢«é”åœ¨å¸æˆ·ä¹‹å¤–ï¼";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "è¯·è¾“å…¥ä½ çš„ç”µå­é‚®ä»¶åœ°å€ã€‚æˆ‘ä»¬ä¼šå‘é€é“¾æŽ¥ä»¥å®ŒæˆéªŒè¯ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "è¯·è¾“å…¥ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼Œæˆ‘ä»¬ä¼šå‘é€é“¾æŽ¥ä»¥å®ŒæˆéªŒè¯ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "è¯·åœ¨ä½ çš„å¸æˆ·æ·»åŠ ç”µå­é‚®ä»¶åœ°å€ï¼Œç¡®ä¿å§‹ç»ˆèƒ½å¤Ÿè®¿é—®ä½ çš„ Roblox å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "è¯·åœ¨ä½ çš„å¸æˆ·æ·»åŠ ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼Œç¡®ä¿å§‹ç»ˆèƒ½å¤Ÿè®¿é—®ä½ çš„ Roblox å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "è¯·åœ¨ä½ çš„å¸æˆ·æ·»åŠ æ‰‹æœºå·ç ï¼Œé¿å…ä»¥åŽå‡ºçŽ°å¸æˆ·é”å®šçš„æƒ…å†µã€‚";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "è¯·æ·»åŠ ä½ çš„æ‰‹æœºå·ç ï¼Œæˆ‘ä»¬å°†é€ä½ ä¸€é¡¶å…è´¹çš„å¸½å­ï¼Œä½ ä¹Ÿä¼šé¿å…ä»¥åŽå‡ºçŽ°å¸æˆ·é”å®šçš„æƒ…å†µï¼";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "è¯·ç¡®è®¤ä½ çš„å›½å®¶ä»£ç ï¼Œå¹¶è¾“å…¥ä½ çš„ç”µè¯å·ç ã€‚æˆ‘ä»¬ä¼šå‘é€çŸ­ä¿¡ä»¥å®ŒæˆéªŒè¯ã€‚ï¼ˆæ³¨æ„ï¼šå‘é€çŸ­ä¿¡æ—¶å¯èƒ½ä¼šäº§ç”Ÿé€šä¿¡è´¹ç”¨ï¼‰";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "åˆ«å¿˜äº†ç¡®è®¤ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼ŒèŽ·å¾—å…è´¹å¸½å­ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "åˆ«å¿˜äº†ç¡®è®¤ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼ŒèŽ·å¾—å…è´¹å¸½å­ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "è¯·åœ¨ä½ çš„å¸æˆ·æ·»åŠ æ‰‹æœºå·ç ï¼Œè®©å¥½å‹æ›´å®¹æ˜“æ‰¾åˆ°ä½ ï¼";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "ä½ çš„æ‰‹æœºå·ç å·²ç¡®è®¤ã€‚æ­å–œä½ èŽ·å¾—å…è´¹çš„å¸½å­ï¼";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "æ‰‹æœºå·ç å·²æ·»åŠ æˆåŠŸï¼";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "éªŒè¯é“¾æŽ¥å·²å‘é€è‡³ä½ çš„ç”µå­é‚®ä»¶ - è¯·éªŒè¯ç”µå­é‚®ä»¶ä»¥ä¿è¯å¸æˆ·å®‰å…¨ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "è¯·éªŒè¯ä½ çš„ç”µå­é‚®ä»¶åœ°å€ï¼Œç¡®ä¿å§‹ç»ˆèƒ½å¤Ÿè®¿é—®ä½ çš„ Roblox å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "è¯·éªŒè¯ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼Œç¡®ä¿å§‹ç»ˆèƒ½å¤Ÿè®¿é—®ä½ çš„ Roblox å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "éªŒè¯é“¾æŽ¥å·²å‘é€è‡³ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶ - è¯·éªŒè¯ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶ä»¥ä¿è¯å¸æˆ·å®‰å…¨ã€‚";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "éªŒè¯é“¾æŽ¥å·²å‘é€è‡³ä½ çš„ç”µå­é‚®ä»¶ã€‚è¯·éªŒè¯ç”µå­é‚®ä»¶ä»¥ä¿è¯å¸æˆ·å®‰å…¨ã€‚ä½ éšæ—¶å¯ä»¥è®¿é—®â€œè®¾ç½®â€>â€œå¸æˆ·ä¿¡æ¯â€ä»¥ä¿®æ”¹ä½ çš„å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public ContactUpsellResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "æ·»åŠ ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "æ·»åŠ ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "ç«‹å³æ·»åŠ ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "ç«‹å³æ·»åŠ ";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "æ·»åŠ å®¶é•¿ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "ç«‹å³æ·»åŠ å®¶é•¿ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "æ·»åŠ æ‰‹æœºå·ç ";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "ç«‹å³æ·»åŠ æ‰‹æœºå·ç ";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "å…³é—­";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "ç¡®è®¤ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "ç¼–è¾‘æ‰‹æœºå·ç ";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "é‡æ–°å‘é€éªŒè¯ç ";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "éªŒè¯";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "éªŒè¯ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "éªŒè¯æ‰‹æœº";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "æ·»åŠ å®¶é•¿ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "æ·»åŠ ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "é˜²æ­¢ä½ çš„è´¦å·è¢«é”å®šï¼";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "åˆ«å¿˜äº†ç¡®è®¤ï¼";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "å‘ç”Ÿé”™è¯¯";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "è®©å¥½å‹æ›´å®¹æ˜“æ‰¾åˆ°ä½ ï¼";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "æ¥é¢†å–å…è´¹å¸½å­å§ï¼";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "æˆåŠŸ";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "éªŒè¯ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "æ·»åŠ æ‰‹æœºå·ç ";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"è¾“å…¥éªŒè¯ç ï¼ˆ{number} ä½ï¼‰";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "è¾“å…¥éªŒè¯ç ï¼ˆ{number} ä½ï¼‰";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "ç”µå­é‚®ä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "å‘ç”Ÿé”™è¯¯";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "ç”µå­é‚®ä»¶æ— æ•ˆ";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "æ‰‹æœºå·ç æ— æ•ˆ";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "æ²¡æœ‰ç”µå­é‚®ä»¶ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "æ²¡æœ‰æ‰‹æœºï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "æ²¡æœ‰æ”¶åˆ°ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "æˆ–";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "å®¶é•¿ç”µå­é‚®ä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Roblox å¸æˆ·å¯†ç ";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "æ‰‹æœºå·ç ";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "ä½¿ç”¨ç”µå­é‚®ä»¶ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "ä½¿ç”¨å®¶é•¿çš„ç”µå­é‚®ä»¶ä»¥ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "ä½¿ç”¨æ‰‹æœºå·ç ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "é‡æ–°å‘é€ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "éªŒè¯ä½ çš„ç”µå­é‚®ä»¶ä»¥ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "éªŒè¯ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶ä»¥ä¿è¯ä½ çš„å¸æˆ·å®‰å…¨ï¼";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Roblox å¸æˆ·å¯†ç ";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "åŠ è½½å›½å®¶åˆ—è¡¨æ—¶å‘ç”Ÿé”™è¯¯";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "è¯·æ·»åŠ ä½ çš„ç”µå­é‚®ä»¶ï¼Œæˆ‘ä»¬å°†é€ä½ ä¸€é¡¶å…è´¹çš„å¸½å­ï¼Œä½ ä¹Ÿä¼šé¿å…ä»¥åŽå‡ºçŽ°å¸æˆ·é”å®šçš„æƒ…å†µï¼";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "è¯·æ·»åŠ å®¶é•¿çš„ç”µå­é‚®ä»¶ä»¥èŽ·å¾—ä¸€é¡¶å…è´¹å¸½å­ï¼Œç¡®ä¿ä½ ä¸ä¼šè¢«é”åœ¨å¸æˆ·ä¹‹å¤–ï¼";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "è¯·è¾“å…¥ä½ çš„ç”µå­é‚®ä»¶åœ°å€ã€‚æˆ‘ä»¬ä¼šå‘é€é“¾æŽ¥ä»¥å®ŒæˆéªŒè¯ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "è¯·è¾“å…¥ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼Œæˆ‘ä»¬ä¼šå‘é€é“¾æŽ¥ä»¥å®ŒæˆéªŒè¯ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "è¯·åœ¨ä½ çš„å¸æˆ·æ·»åŠ ç”µå­é‚®ä»¶åœ°å€ï¼Œç¡®ä¿å§‹ç»ˆèƒ½å¤Ÿè®¿é—®ä½ çš„ Roblox å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "è¯·åœ¨ä½ çš„å¸æˆ·æ·»åŠ ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼Œç¡®ä¿å§‹ç»ˆèƒ½å¤Ÿè®¿é—®ä½ çš„ Roblox å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "è¯·åœ¨ä½ çš„å¸æˆ·æ·»åŠ æ‰‹æœºå·ç ï¼Œé¿å…ä»¥åŽå‡ºçŽ°å¸æˆ·é”å®šçš„æƒ…å†µã€‚";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "è¯·æ·»åŠ ä½ çš„æ‰‹æœºå·ç ï¼Œæˆ‘ä»¬å°†é€ä½ ä¸€é¡¶å…è´¹çš„å¸½å­ï¼Œä½ ä¹Ÿä¼šé¿å…ä»¥åŽå‡ºçŽ°å¸æˆ·é”å®šçš„æƒ…å†µï¼";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "è¯·ç¡®è®¤ä½ çš„å›½å®¶ä»£ç ï¼Œå¹¶è¾“å…¥ä½ çš„ç”µè¯å·ç ã€‚æˆ‘ä»¬ä¼šå‘é€çŸ­ä¿¡ä»¥å®ŒæˆéªŒè¯ã€‚ï¼ˆæ³¨æ„ï¼šå‘é€çŸ­ä¿¡æ—¶å¯èƒ½ä¼šäº§ç”Ÿé€šä¿¡è´¹ç”¨ï¼‰";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "åˆ«å¿˜äº†ç¡®è®¤ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼ŒèŽ·å¾—å…è´¹å¸½å­ï¼";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "åˆ«å¿˜äº†ç¡®è®¤ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼ŒèŽ·å¾—å…è´¹å¸½å­ï¼";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "è¯·åœ¨ä½ çš„å¸æˆ·æ·»åŠ æ‰‹æœºå·ç ï¼Œè®©å¥½å‹æ›´å®¹æ˜“æ‰¾åˆ°ä½ ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"è¯·è¾“å…¥å‘é€è‡³ {phoneNumber} çŸ­ä¿¡ä¸­çš„éªŒè¯ç ";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "è¯·è¾“å…¥å‘é€è‡³ {phoneNumber} çŸ­ä¿¡ä¸­çš„éªŒè¯ç ";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "ä½ çš„æ‰‹æœºå·ç å·²ç¡®è®¤ã€‚æ­å–œä½ èŽ·å¾—å…è´¹çš„å¸½å­ï¼";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "æ‰‹æœºå·ç å·²æ·»åŠ æˆåŠŸï¼";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "éªŒè¯é“¾æŽ¥å·²å‘é€è‡³ä½ çš„ç”µå­é‚®ä»¶ - è¯·éªŒè¯ç”µå­é‚®ä»¶ä»¥ä¿è¯å¸æˆ·å®‰å…¨ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "è¯·éªŒè¯ä½ çš„ç”µå­é‚®ä»¶åœ°å€ï¼Œç¡®ä¿å§‹ç»ˆèƒ½å¤Ÿè®¿é—®ä½ çš„ Roblox å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "è¯·éªŒè¯ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶åœ°å€ï¼Œç¡®ä¿å§‹ç»ˆèƒ½å¤Ÿè®¿é—®ä½ çš„ Roblox å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "éªŒè¯é“¾æŽ¥å·²å‘é€è‡³ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶ - è¯·éªŒè¯ä½ å®¶é•¿çš„ç”µå­é‚®ä»¶ä»¥ä¿è¯å¸æˆ·å®‰å…¨ã€‚";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "éªŒè¯é“¾æŽ¥å·²å‘é€è‡³ä½ çš„ç”µå­é‚®ä»¶ã€‚è¯·éªŒè¯ç”µå­é‚®ä»¶ä»¥ä¿è¯å¸æˆ·å®‰å…¨ã€‚ä½ éšæ—¶å¯ä»¥è®¿é—®â€œè®¾ç½®â€>â€œå¸æˆ·ä¿¡æ¯â€ä»¥ä¿®æ”¹ä½ çš„å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"éªŒè¯ç å¿…é¡»æ˜¯ {number} ä½æ•°";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "éªŒè¯ç å¿…é¡»æ˜¯ {number} ä½æ•°";
	}
}


}
