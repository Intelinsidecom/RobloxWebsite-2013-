namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_ko_kr : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "ì´ë©”ì¼ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "ì´ë©”ì¼ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "ì§€ê¸ˆ ì´ë©”ì¼ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "ì§€ê¸ˆ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "ë³´í˜¸ìž ì´ë©”ì¼ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "ì§€ê¸ˆ ë³´í˜¸ìž ì´ë©”ì¼ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "ì „í™”ë²ˆí˜¸ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "ì§€ê¸ˆ ì „í™”ë²ˆí˜¸ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "ë‹«ê¸°";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "ì´ë©”ì¼ í™•ì¸";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "ì „í™”ë²ˆí˜¸ ìˆ˜ì •";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "í™•ì¸";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "ì½”ë“œ ë‹¤ì‹œ ë³´ë‚´ê¸°";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ì €ìž¥";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ì¸ì¦";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "ì´ë©”ì¼ ì¸ì¦";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "ì „í™” ì¸ì¦";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "ë³´í˜¸ìž ì´ë©”ì¼ ì¶”ê°€";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "ì´ë©”ì¼ ì¶”ê°€";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "ìž ê¸°ì§€ ì•Šë„ë¡ í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "í™•ì¸ì„ ìžŠì§€ ë§ˆì„¸ìš”!";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "íšŒì›ë‹˜ì˜ ì¹œêµ¬ë“¤ì´ íšŒì›ë‹˜ì„ ì°¾ì„ ìˆ˜ ìžˆê²Œ ë„ì™€ì¤˜ìš”!";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "ë¬´ë£Œ ëª¨ìžë¥¼ íšë“í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public override string HeadingSuccess => "ì™„ë£Œ";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public override string HeadingVerifyEmail => "ì´ë©”ì¼ ì¸ì¦";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "ì „í™”ë²ˆí˜¸ ì¶”ê°€";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "ì´ë©”ì¼ ì£¼ì†Œ";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "ìœ íš¨í•˜ì§€ ì•Šì€ ì´ë©”ì¼";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "ìœ íš¨í•˜ì§€ ì•Šì€ ì „í™”ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "ì´ë©”ì¼ì´ ì—†ë‹¤êµ¬ìš”?";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "ì „í™”ë²ˆí˜¸ê°€ ì—†ë‹¤êµ¬ìš”?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "ë§í¬ë¥¼ ë°›ì§€ ëª»í•˜ì…¨ë‚˜ìš”?";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "ë˜ëŠ”";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œ";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "ì „í™”ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "ì´ë©”ì¼ë¡œ ê³„ì •ì„ ë³´í˜¸í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "ë³´í˜¸ìž ì´ë©”ì¼ì„ í†µí•´ ê³„ì •ì„ ë³´í˜¸í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "ì „í™”ë²ˆí˜¸ë¡œ ê³„ì •ì„ ë³´í˜¸í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "ì´ë©”ì¼ ë‹¤ì‹œ ë³´ë‚´ê¸°";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "ì´ë©”ì¼ì„ ì¸ì¦í•˜ì—¬ ê³„ì •ì„ ë³´í˜¸í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "ê³„ì • ë³´í˜¸ë¥¼ ìœ„í•´ ë³´í˜¸ìž ì´ë©”ì¼ì„ ì¸ì¦í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "êµ­ê°€ ëª©ë¡ ë¡œë“œ ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "ë³¸ì¸ ì´ë©”ì¼ì„ ì¶”ê°€í•´ ë¬´ë£Œ ëª¨ìžë„ ë°›ê³  ê³„ì • ìž ê¹€ë„ ë°©ì§€í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "ë³´í˜¸ìž ì´ë©”ì¼ì„ ì¶”ê°€í•´ ë¬´ë£Œ ëª¨ìžë„ ë°›ê³  ê³„ì • ìž ê¹€ë„ ë°©ì§€í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "ë³¸ì¸ ì´ë©”ì¼ ì£¼ì†Œë¥¼ ìž…ë ¥í•˜ì„¸ìš”. ì¸ì¦ ì™„ë£Œë¥¼ ìœ„í•´ ë§í¬ë¥¼ ë³´ë‚´ë“œë¦´ê²Œìš”.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ ìž…ë ¥í•˜ì„¸ìš”. ì¸ì¦ ì™„ë£Œë¥¼ ìœ„í•´ ë§í¬ë¥¼ ë³´ë‚´ë“œë ¤ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "í•­ìƒ Roblox ê³„ì •ì— ì ‘ê·¼í•  ìˆ˜ ìžˆë„ë¡ ê³„ì •ì— ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "í•­ìƒ Roblox ê³„ì •ì— ì ‘ê·¼í•  ìˆ˜ ìžˆë„ë¡ ê³„ì •ì— ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "ê³„ì •ì´ ìž ê¸°ëŠ” ì¼ì´ ë°œìƒí•˜ì§€ ì•Šë„ë¡ ê³„ì •ì— ì „í™”ë²ˆí˜¸ë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "ì „í™”ë²ˆí˜¸ë¥¼ ì¶”ê°€í•´ ë¬´ë£Œ ëª¨ìžë„ ë°›ê³  ê³„ì • ìž ê¹€ë„ ë°©ì§€í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "êµ­ê°€ ì½”ë“œë¥¼ í™•ì¸í•˜ê³  ì „í™”ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”. ì¸ì¦ ì™„ë£Œë¥¼ ìœ„í•´ ë¬¸ìž ë©”ì‹œì§€ë¥¼ ë³´ë‚´ë“œë ¤ìš”. (ì°¸ê³ : ë¬¸ìž ë©”ì‹œì§€ ë°œì†¡ ìˆ˜ìˆ˜ë£Œê°€ ë¶€ê³¼ë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤)";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "ë³¸ì¸ì˜ ì´ë©”ì¼ ì£¼ì†Œë¥¼ í™•ì¸í•˜ê³  ë¬´ë£Œ ëª¨ìžë„ ë°›ìœ¼ì„¸ìš”!";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ í™•ì¸í•˜ê³  ë¬´ë£Œ ëª¨ìžë„ ë°›ìœ¼ì„¸ìš”!";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "ì¹œêµ¬ê°€ íšŒì›ë‹˜ì„ ì°¾ì„ ìˆ˜ ìžˆë„ë¡ ê³„ì •ì— ì „í™”ë²ˆí˜¸ë¥¼ ì¶”ê°€í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "ì „í™”ë²ˆí˜¸ê°€ í™•ì¸ë˜ì—ˆìŠµë‹ˆë‹¤. ë¬´ë£Œ ëª¨ìžë¥¼ ì°©ìš©í•  ìˆ˜ ìžˆì–´ìš”!";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "ì „í™”ë²ˆí˜¸ ì¶”ê°€ê°€ ì™„ë£Œë˜ì—ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "ìž…ë ¥í•œ ì´ë©”ì¼ë¡œ ì¸ì¦ ë§í¬ê°€ ë°œì†¡ë˜ì—ˆì–´ìš”. ì´ë©”ì¼ì„ ì¸ì¦í•˜ì—¬ ê³„ì •ì„ ì•ˆì „í•˜ê²Œ ë³´í˜¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "í•­ìƒ Roblox ê³„ì •ì— ì ‘ê·¼í•  ìˆ˜ ìžˆë„ë¡ ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¸ì¦í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "í•­ìƒ Roblox ê³„ì •ì— ì ‘ê·¼í•  ìˆ˜ ìžˆë„ë¡ ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¸ì¦í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "ìž…ë ¥í•˜ì‹  ë³´í˜¸ìž ì´ë©”ì¼ë¡œ ì¸ì¦ ë§í¬ê°€ ë°œì†¡ë˜ì—ˆìŠµë‹ˆë‹¤. ë³´í˜¸ìž ì´ë©”ì¼ì„ ì¸ì¦í•˜ì—¬ ê³„ì •ì„ ì•ˆì „í•˜ê²Œ ë³´í˜¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "ìž…ë ¥í•˜ì‹  ì´ë©”ì¼ë¡œ ì¸ì¦ ë§í¬ê°€ ë°œì†¡ë˜ì—ˆìŠµë‹ˆë‹¤. ì´ë©”ì¼ì„ ì¸ì¦í•˜ì—¬ ê³„ì •ì„ ì•ˆì „í•˜ê²Œ ë³´í˜¸í•˜ì„¸ìš”. ê³„ì •ì •ë³´ëŠ” ì„¤ì • > ê³„ì • ì •ë³´ì—ì„œ ì–¸ì œë“ ì§€ ë³€ê²½í•  ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public ContactUpsellResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "ì´ë©”ì¼ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "ì´ë©”ì¼ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "ì§€ê¸ˆ ì´ë©”ì¼ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "ì§€ê¸ˆ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "ë³´í˜¸ìž ì´ë©”ì¼ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "ì§€ê¸ˆ ë³´í˜¸ìž ì´ë©”ì¼ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "ì „í™”ë²ˆí˜¸ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "ì§€ê¸ˆ ì „í™”ë²ˆí˜¸ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "ë‹«ê¸°";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "ì´ë©”ì¼ í™•ì¸";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "ì „í™”ë²ˆí˜¸ ìˆ˜ì •";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "ì½”ë“œ ë‹¤ì‹œ ë³´ë‚´ê¸°";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ì¸ì¦";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "ì´ë©”ì¼ ì¸ì¦";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "ì „í™” ì¸ì¦";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "ë³´í˜¸ìž ì´ë©”ì¼ ì¶”ê°€";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "ì´ë©”ì¼ ì¶”ê°€";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "ìž ê¸°ì§€ ì•Šë„ë¡ í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "í™•ì¸ì„ ìžŠì§€ ë§ˆì„¸ìš”!";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "íšŒì›ë‹˜ì˜ ì¹œêµ¬ë“¤ì´ íšŒì›ë‹˜ì„ ì°¾ì„ ìˆ˜ ìžˆê²Œ ë„ì™€ì¤˜ìš”!";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "ë¬´ë£Œ ëª¨ìžë¥¼ íšë“í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "ì™„ë£Œ";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "ì´ë©”ì¼ ì¸ì¦";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "ì „í™”ë²ˆí˜¸ ì¶”ê°€";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"ì½”ë“œ ìž…ë ¥ ({number}ìžë¦¬)";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "ì½”ë“œ ìž…ë ¥ ({number}ìžë¦¬)";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "ì´ë©”ì¼ ì£¼ì†Œ";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì´ë©”ì¼";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì „í™”ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "ì´ë©”ì¼ì´ ì—†ë‹¤êµ¬ìš”?";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "ì „í™”ë²ˆí˜¸ê°€ ì—†ë‹¤êµ¬ìš”?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "ë§í¬ë¥¼ ë°›ì§€ ëª»í•˜ì…¨ë‚˜ìš”?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "ë˜ëŠ”";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œ";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "ì „í™”ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "ì´ë©”ì¼ë¡œ ê³„ì •ì„ ë³´í˜¸í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "ë³´í˜¸ìž ì´ë©”ì¼ì„ í†µí•´ ê³„ì •ì„ ë³´í˜¸í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "ì „í™”ë²ˆí˜¸ë¡œ ê³„ì •ì„ ë³´í˜¸í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "ì´ë©”ì¼ ë‹¤ì‹œ ë³´ë‚´ê¸°";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "ì´ë©”ì¼ì„ ì¸ì¦í•˜ì—¬ ê³„ì •ì„ ë³´í˜¸í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "ê³„ì • ë³´í˜¸ë¥¼ ìœ„í•´ ë³´í˜¸ìž ì´ë©”ì¼ì„ ì¸ì¦í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "êµ­ê°€ ëª©ë¡ ë¡œë“œ ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "ë³¸ì¸ ì´ë©”ì¼ì„ ì¶”ê°€í•´ ë¬´ë£Œ ëª¨ìžë„ ë°›ê³  ê³„ì • ìž ê¹€ë„ ë°©ì§€í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "ë³´í˜¸ìž ì´ë©”ì¼ì„ ì¶”ê°€í•´ ë¬´ë£Œ ëª¨ìžë„ ë°›ê³  ê³„ì • ìž ê¹€ë„ ë°©ì§€í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "ë³¸ì¸ ì´ë©”ì¼ ì£¼ì†Œë¥¼ ìž…ë ¥í•˜ì„¸ìš”. ì¸ì¦ ì™„ë£Œë¥¼ ìœ„í•´ ë§í¬ë¥¼ ë³´ë‚´ë“œë¦´ê²Œìš”.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ ìž…ë ¥í•˜ì„¸ìš”. ì¸ì¦ ì™„ë£Œë¥¼ ìœ„í•´ ë§í¬ë¥¼ ë³´ë‚´ë“œë ¤ìš”.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "í•­ìƒ Roblox ê³„ì •ì— ì ‘ê·¼í•  ìˆ˜ ìžˆë„ë¡ ê³„ì •ì— ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "í•­ìƒ Roblox ê³„ì •ì— ì ‘ê·¼í•  ìˆ˜ ìžˆë„ë¡ ê³„ì •ì— ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "ê³„ì •ì´ ìž ê¸°ëŠ” ì¼ì´ ë°œìƒí•˜ì§€ ì•Šë„ë¡ ê³„ì •ì— ì „í™”ë²ˆí˜¸ë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "ì „í™”ë²ˆí˜¸ë¥¼ ì¶”ê°€í•´ ë¬´ë£Œ ëª¨ìžë„ ë°›ê³  ê³„ì • ìž ê¹€ë„ ë°©ì§€í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "êµ­ê°€ ì½”ë“œë¥¼ í™•ì¸í•˜ê³  ì „í™”ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”. ì¸ì¦ ì™„ë£Œë¥¼ ìœ„í•´ ë¬¸ìž ë©”ì‹œì§€ë¥¼ ë³´ë‚´ë“œë ¤ìš”. (ì°¸ê³ : ë¬¸ìž ë©”ì‹œì§€ ë°œì†¡ ìˆ˜ìˆ˜ë£Œê°€ ë¶€ê³¼ë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤)";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "ë³¸ì¸ì˜ ì´ë©”ì¼ ì£¼ì†Œë¥¼ í™•ì¸í•˜ê³  ë¬´ë£Œ ëª¨ìžë„ ë°›ìœ¼ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ í™•ì¸í•˜ê³  ë¬´ë£Œ ëª¨ìžë„ ë°›ìœ¼ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "ì¹œêµ¬ê°€ íšŒì›ë‹˜ì„ ì°¾ì„ ìˆ˜ ìžˆë„ë¡ ê³„ì •ì— ì „í™”ë²ˆí˜¸ë¥¼ ì¶”ê°€í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"{phoneNumber}(ìœ¼)ë¡œ ì „ì†¡ëœ ë¬¸ìžì— ìžˆëŠ” ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "{phoneNumber}(ìœ¼)ë¡œ ì „ì†¡ëœ ë¬¸ìžì— ìžˆëŠ” ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "ì „í™”ë²ˆí˜¸ê°€ í™•ì¸ë˜ì—ˆìŠµë‹ˆë‹¤. ë¬´ë£Œ ëª¨ìžë¥¼ ì°©ìš©í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "ì „í™”ë²ˆí˜¸ ì¶”ê°€ê°€ ì™„ë£Œë˜ì—ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "ìž…ë ¥í•œ ì´ë©”ì¼ë¡œ ì¸ì¦ ë§í¬ê°€ ë°œì†¡ë˜ì—ˆì–´ìš”. ì´ë©”ì¼ì„ ì¸ì¦í•˜ì—¬ ê³„ì •ì„ ì•ˆì „í•˜ê²Œ ë³´í˜¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "í•­ìƒ Roblox ê³„ì •ì— ì ‘ê·¼í•  ìˆ˜ ìžˆë„ë¡ ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¸ì¦í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "í•­ìƒ Roblox ê³„ì •ì— ì ‘ê·¼í•  ìˆ˜ ìžˆë„ë¡ ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¸ì¦í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "ìž…ë ¥í•˜ì‹  ë³´í˜¸ìž ì´ë©”ì¼ë¡œ ì¸ì¦ ë§í¬ê°€ ë°œì†¡ë˜ì—ˆìŠµë‹ˆë‹¤. ë³´í˜¸ìž ì´ë©”ì¼ì„ ì¸ì¦í•˜ì—¬ ê³„ì •ì„ ì•ˆì „í•˜ê²Œ ë³´í˜¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "ìž…ë ¥í•˜ì‹  ì´ë©”ì¼ë¡œ ì¸ì¦ ë§í¬ê°€ ë°œì†¡ë˜ì—ˆìŠµë‹ˆë‹¤. ì´ë©”ì¼ì„ ì¸ì¦í•˜ì—¬ ê³„ì •ì„ ì•ˆì „í•˜ê²Œ ë³´í˜¸í•˜ì„¸ìš”. ê³„ì •ì •ë³´ëŠ” ì„¤ì • > ê³„ì • ì •ë³´ì—ì„œ ì–¸ì œë“ ì§€ ë³€ê²½í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"{number}ìžë¦¬ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "{number}ìžë¦¬ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”";
	}
}


}
