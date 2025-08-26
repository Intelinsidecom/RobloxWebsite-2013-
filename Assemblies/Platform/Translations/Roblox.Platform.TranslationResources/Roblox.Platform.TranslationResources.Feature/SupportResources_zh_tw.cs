namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SupportResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportResources_zh_tw : SupportResources_en_us, ISupportResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string ActionDialogCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Dialog.OK"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOK => "ç¢ºå®š";

	/// <summary>
	/// Key: "Action.Dialog.Send"
	/// Send
	/// English String: "Send"
	/// </summary>
	public override string ActionDialogSend => "å‚³é€";

	/// <summary>
	/// Key: "Heading.ContactInformation"
	/// Contact Information
	/// English String: "Contact Information"
	/// </summary>
	public override string HeadingContactInformation => "è¯çµ¡è³‡è¨Š";

	/// <summary>
	/// Key: "Heading.DescriptionOfIssue"
	/// Description of issue
	/// English String: "Description of issue"
	/// </summary>
	public override string HeadingDescriptionOfIssue => "å•é¡Œèªªæ˜Ž";

	/// <summary>
	/// Key: "Heading.DeviceWithProblem"
	/// What device are you having the problem on?
	/// English String: "What device are you having the problem on?"
	/// </summary>
	public override string HeadingDeviceWithProblem => "æ‚¨é‡åˆ°å•é¡Œçš„è£ç½®æ˜¯ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.Dialog.ErrorWithoutContext"
	/// Error
	/// English String: "Error"
	/// </summary>
	public override string HeadingDialogErrorWithoutContext => "éŒ¯èª¤";

	/// <summary>
	/// Key: "Heading.Dialog.InvalidUsername"
	/// Invalid Username
	/// English String: "Invalid Username"
	/// </summary>
	public override string HeadingDialogInvalidUsername => "ä½¿ç”¨è€…åç¨±ç„¡æ•ˆ";

	/// <summary>
	/// Key: "Heading.Dialog.RequestReceived"
	/// Request Received
	/// English String: "Request Received"
	/// </summary>
	public override string HeadingDialogRequestReceived => "å·²æ”¶åˆ°è«‹æ±‚";

	/// <summary>
	/// Key: "Heading.HelpCategoryType"
	/// Type of help category
	/// English String: "Type of help category"
	/// </summary>
	public override string HeadingHelpCategoryType => "èªªæ˜Žé¡žåˆ¥çš„ç¨®é¡ž";

	/// <summary>
	/// Key: "Heading.IssueDetails"
	/// Issue Details
	/// English String: "Issue Details"
	/// </summary>
	public override string HeadingIssueDetails => "å•é¡Œè©³ç´°è³‡æ–™";

	/// <summary>
	/// Key: "Heading.PageTitle"
	/// Contact Us
	/// English String: "Contact Us"
	/// </summary>
	public override string HeadingPageTitle => "è¯çµ¡æˆ‘å€‘";

	/// <summary>
	/// Key: "Label.AccountHacked"
	/// Account Hacked
	/// English String: "Account Hacked"
	/// </summary>
	public override string LabelAccountHacked => "å¸³è™Ÿé­é§­";

	/// <summary>
	/// Key: "Label.AccountOwnership"
	/// Account Hacked or Can't Log in
	/// English String: "Account Hacked or Can't Log in"
	/// </summary>
	public override string LabelAccountOwnership => "å¸³è™Ÿé­é§­æˆ–ç„¡æ³•ç™»å…¥";

	/// <summary>
	/// Key: "Label.AccountPin"
	/// Account PIN
	/// English String: "Account PIN"
	/// </summary>
	public override string LabelAccountPin => "å¸³è™Ÿ PIN";

	public override string LabelAdjustChildSettings => "èª¿æ•´å…’ç«¥éš±ç§æ¬ŠåŠå®‰å…¨è¨­å®š";

	/// <summary>
	/// Key: "Label.AmazonDevice"
	/// Amazon Device
	/// English String: "Amazon Device"
	/// </summary>
	public override string LabelAmazonDevice => "Amazon è£ç½®";

	/// <summary>
	/// Key: "Label.AndroidPhone"
	/// Android Phone
	/// English String: "Android Phone"
	/// </summary>
	public override string LabelAndroidPhone => "Android æ‰‹æ©Ÿ";

	/// <summary>
	/// Key: "Label.AndroidTablet"
	/// Android Tablet
	/// English String: "Android Tablet"
	/// </summary>
	public override string LabelAndroidTablet => "Android å¹³æ¿é›»è…¦";

	/// <summary>
	/// Key: "Label.AppealAccountContent"
	/// Appeal Account or Content
	/// English String: "Appeal Account or Content"
	/// </summary>
	public override string LabelAppealAccountContent => "å¸³è™Ÿæˆ–å…§å®¹ä¸Šè¨´";

	/// <summary>
	/// Key: "Label.AppealFriend"
	/// Appeal for Friend
	/// English String: "Appeal for Friend"
	/// </summary>
	public override string LabelAppealFriend => "ç‚ºå¥½å‹ä¸Šè¨´";

	public override string LabelBilling => "å¸³å‹™å’Œä»˜æ¬¾";

	/// <summary>
	/// Key: "Label.BugReport"
	/// Bug Report
	/// English String: "Bug Report"
	/// </summary>
	public override string LabelBugReport => "èˆ‰å ±æ¼æ´ž";

	/// <summary>
	/// Key: "Label.BuildersClub"
	/// Builders Club
	/// English String: "Builders Club"
	/// </summary>
	public override string LabelBuildersClub => "Builders Club";

	/// <summary>
	/// Key: "Label.CancelMembership"
	/// Cancel Membership
	/// English String: "Cancel Membership"
	/// </summary>
	public override string LabelCancelMembership => "å–æ¶ˆæœƒå“¡è³‡æ ¼";

	/// <summary>
	/// Key: "Label.CannotInstall"
	/// Cannot Install Roblox or Studio
	/// English String: "Cannot Install Roblox or Studio"
	/// </summary>
	public override string LabelCannotInstall => "ç„¡æ³•å®‰è£ Roblox æˆ– Studio";

	/// <summary>
	/// Key: "Label.CannotPlayGame"
	/// Cannot Play Game
	/// English String: "Cannot Play Game"
	/// </summary>
	public override string LabelCannotPlayGame => "ç„¡æ³•çŽ©éŠæˆ²";

	/// <summary>
	/// Key: "Label.ChangeChildAge"
	/// Change Child Age
	/// English String: "Change Child Age"
	/// </summary>
	public override string LabelChangeChildAge => "è®Šæ›´å…’ç«¥å¹´é½¡";

	public override string LabelChatAgeSettings => "èŠå¤©èˆ‡å¹´é½¡è¨­å®š";

	/// <summary>
	/// Key: "Label.Chromebook"
	/// Chromebook
	/// English String: "Chromebook"
	/// </summary>
	public override string LabelChromebook => "Chromebook";

	/// <summary>
	/// Key: "Label.ConfirmEmail"
	/// Confirm Email Address
	/// English String: "Confirm Email Address"
	/// </summary>
	public override string LabelConfirmEmail => "ç¢ºèªé›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.ContentAbuseReport"
	/// Report Content Breaking Rules
	/// English String: "Report Content Breaking Rules"
	/// </summary>
	public override string LabelContentAbuseReport => "èˆ‰å ±é•è¦å…§å®¹";

	public override string LabelContest => "æ¯”è³½åŠæ´»å‹•";

	/// <summary>
	/// Key: "Label.ContestEventQuestion"
	/// Question or Issue
	/// English String: "Question or Issue"
	/// </summary>
	public override string LabelContestEventQuestion => "å•é¡Œæˆ–å›°é›£";

	/// <summary>
	/// Key: "Label.CSCharacter"
	/// Customer Service Character
	/// English String: "Customer Service Character"
	/// </summary>
	public override string LabelCSCharacter => "å®¢æœäººå“¡è§’è‰²";

	/// <summary>
	/// Key: "Label.DescribeIssue"
	/// Please describe your issue
	/// English String: "Please describe your issue"
	/// </summary>
	public override string LabelDescribeIssue => "è«‹æè¿°æ‚¨çš„å•é¡Œ";

	/// <summary>
	/// Key: "Label.DevEx"
	/// DevEx
	/// English String: "DevEx"
	/// </summary>
	public override string LabelDevEx => "DevEx";

	/// <summary>
	/// Key: "Label.DevExHowTo"
	/// DevEx How To
	/// English String: "DevEx How To"
	/// </summary>
	public override string LabelDevExHowTo => "DevEx èªªæ˜Ž";

	/// <summary>
	/// Key: "Label.DevExMyRequest"
	/// DevEx My Request
	/// English String: "DevEx My Request"
	/// </summary>
	public override string LabelDevExMyRequest => "DevEx æˆ‘çš„è«‹æ±‚";

	/// <summary>
	/// Key: "Label.DMCA"
	/// DMCA
	/// English String: "DMCA"
	/// </summary>
	public override string LabelDMCA => "æ•¸ä½åƒç¦§å¹´è‘—ä½œæ¬Šæ³•ï¼ˆDMCAï¼‰";

	/// <summary>
	/// Key: "Label.EmailAddress"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailAddress => "é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.ExploitReport"
	/// Exploit Report
	/// English String: "Exploit Report"
	/// </summary>
	public override string LabelExploitReport => "èˆ‰å ±å¤–æŽ›";

	/// <summary>
	/// Key: "Label.FirstName"
	/// First Name
	/// English String: "First Name"
	/// </summary>
	public override string LabelFirstName => "åå­—";

	/// <summary>
	/// Key: "Label.ForgotPassword"
	/// Forgot Password
	/// English String: "Forgot Password"
	/// </summary>
	public override string LabelForgotPassword => "å¿˜è¨˜å¯†ç¢¼";

	/// <summary>
	/// Key: "Label.FreeRobux"
	/// Free Robux
	/// English String: "Free Robux"
	/// </summary>
	public override string LabelFreeRobux => "å…è²» Robux";

	/// <summary>
	/// Key: "Label.GameCredit"
	/// Game Card
	/// English String: "Game Card"
	/// </summary>
	public override string LabelGameCredit => "é»žæ•¸å¡";

	/// <summary>
	/// Key: "Label.GCPartialPayment"
	/// Purchase - Split Payment
	/// English String: "Purchase - Split Payment"
	/// </summary>
	public override string LabelGCPartialPayment => "è³¼è²· - æ‹†åˆ†ä»˜æ¬¾";

	/// <summary>
	/// Key: "Label.GCRedeem"
	/// Game Card - Redeem
	/// English String: "Game Card - Redeem"
	/// </summary>
	public override string LabelGCRedeem => "é»žæ•¸å¡ - å…Œæ›";

	/// <summary>
	/// Key: "Label.GCSpendCredit"
	/// Game Card - Spend Credit
	/// English String: "Game Card - Spend Credit"
	/// </summary>
	public override string LabelGCSpendCredit => "é»žæ•¸å¡ - ä½¿ç”¨é»žæ•¸";

	/// <summary>
	/// Key: "Label.HowTo"
	/// How To
	/// English String: "How To"
	/// </summary>
	public override string LabelHowTo => "èªªæ˜Ž";

	/// <summary>
	/// Key: "Label.HowToGeneral"
	/// How To - General
	/// English String: "How To - General"
	/// </summary>
	public override string LabelHowToGeneral => "èªªæ˜Ž - ä¸€èˆ¬";

	/// <summary>
	/// Key: "Label.HowToOther"
	/// How To - Other
	/// English String: "How To - Other"
	/// </summary>
	public override string LabelHowToOther => "èªªæ˜Ž - å…¶å®ƒ";

	public override string LabelIdeasSuggestions => "å»ºè­°";

	/// <summary>
	/// Key: "Label.IPad"
	/// iPad
	/// English String: "iPad"
	/// </summary>
	public override string LabelIPad => "iPad";

	/// <summary>
	/// Key: "Label.IPhone"
	/// iPhone
	/// English String: "iPhone"
	/// </summary>
	public override string LabelIPhone => "iPhone";

	/// <summary>
	/// Key: "Label.IssueDescription"
	/// Please describe the issue that you are facing. Include any relevant information like where the issue is occurring or the error message.
	/// English String: "Please describe the issue that you are facing. Include any relevant information like where the issue is occurring or the error message."
	/// </summary>
	public override string LabelIssueDescription => "è«‹æè¿°æ‚¨é¢è‡¨çš„å•é¡Œã€‚è«‹é™„ä¸Šä»»ä½•ç›¸é—œè³‡è¨Šï¼Œä¾‹å¦‚å•é¡Œç™¼ç”Ÿçš„æ‰€åœ¨åŠéŒ¯èª¤è¨Šæ¯æ–‡å­—ã€‚";

	/// <summary>
	/// Key: "Label.IWasScammed"
	/// I was Scammed
	/// English String: "I was Scammed"
	/// </summary>
	public override string LabelIWasScammed => "æˆ‘é­åˆ°è©é¨™";

	/// <summary>
	/// Key: "Label.Mac"
	/// Mac
	/// English String: "Mac"
	/// </summary>
	public override string LabelMac => "Mac";

	/// <summary>
	/// Key: "Label.Membership"
	/// Support page. Membership {{dc.field_membership}} stop_memb.
	/// English String: "Membership"
	/// </summary>
	public override string LabelMembership => "æœƒå“¡è³‡æ ¼";

	/// <summary>
	/// Key: "Label.Moderation"
	/// Moderation
	/// English String: "Moderation"
	/// </summary>
	public override string LabelModeration => "éŽæ¿¾";

	/// <summary>
	/// Key: "Label.OtherSiteClaim"
	/// Other Site Claim
	/// English String: "Other Site Claim"
	/// </summary>
	public override string LabelOtherSiteClaim => "å…¶å®ƒç¶²ç«™è²æ˜Ž";

	/// <summary>
	/// Key: "Label.OwnerDMCAClaim"
	/// Owner DMCA Claim
	/// English String: "Owner DMCA Claim"
	/// </summary>
	public override string LabelOwnerDMCAClaim => "æ•¸ä½åƒç¦§å¹´è‘—ä½œæ¬Šæ³•ï¼ˆDMCAï¼‰æ‰€æœ‰æ¬Šäººè²æ˜Ž";

	/// <summary>
	/// Key: "Label.PC"
	/// PC
	/// English String: "PC"
	/// </summary>
	public override string LabelPC => "å€‹äººé›»è…¦";

	/// <summary>
	/// Key: "Label.PhysicalToyIssue"
	/// Physical Toy Issue
	/// English String: "Physical Toy Issue"
	/// </summary>
	public override string LabelPhysicalToyIssue => "å¯¦é«”çŽ©å…·å•é¡Œ";

	/// <summary>
	/// Key: "Label.PleaseSelect"
	/// Please Select...
	/// English String: "Please Select..."
	/// </summary>
	public override string LabelPleaseSelect => "è«‹é¸æ“‡â€¦";

	/// <summary>
	/// Key: "Label.PrizeNotReceived"
	/// Prize Not Received
	/// English String: "Prize Not Received"
	/// </summary>
	public override string LabelPrizeNotReceived => "æœªæ”¶åˆ°çŽé …";

	/// <summary>
	/// Key: "Label.PurchaseDeclined"
	/// Purchase - Declined
	/// English String: "Purchase - Declined"
	/// </summary>
	public override string LabelPurchaseDeclined => "è³¼è²· - é­æ‹’";

	/// <summary>
	/// Key: "Label.PurchaseDidNotReceive"
	/// Purchase - Did Not Receive
	/// English String: "Purchase - Did Not Receive"
	/// </summary>
	public override string LabelPurchaseDidNotReceive => "è³¼è²· - æœªæ”¶åˆ°";

	/// <summary>
	/// Key: "Label.PurchaseUnauthorizedCharge"
	/// Purchase - Unauthorized Charge
	/// English String: "Purchase - Unauthorized Charge"
	/// </summary>
	public override string LabelPurchaseUnauthorizedCharge => "è³¼è²· - æœªæŽˆæ¬Šæ”¶è²»";

	/// <summary>
	/// Key: "Label.ReportPhish"
	/// Report Phishing Site
	/// English String: "Report Phishing Site"
	/// </summary>
	public override string LabelReportPhish => "æª¢èˆ‰ç¶²è·¯é‡£é­šç¶²ç«™";

	/// <summary>
	/// Key: "Label.RobloxCrashing"
	/// Roblox Crashing
	/// English String: "Roblox Crashing"
	/// </summary>
	public override string LabelRobloxCrashing => "Roblox ç•¶æ©Ÿ";

	/// <summary>
	/// Key: "Label.RobloxToys"
	/// Roblox Toys
	/// English String: "Roblox Toys"
	/// </summary>
	public override string LabelRobloxToys => "Roblox çŽ©å…·";

	/// <summary>
	/// Key: "Label.Robux"
	/// Robux
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.RobuxPurchaseIssue"
	/// Robux - Purchase Issue
	/// English String: "Robux - Purchase Issue"
	/// </summary>
	public override string LabelRobuxPurchaseIssue => "Robux - è³¼è²·å•é¡Œ";

	/// <summary>
	/// Key: "Label.SafetyInquiry"
	/// Inappropriate game or user behavior
	/// English String: "Inappropriate game or user behavior"
	/// </summary>
	public override string LabelSafetyInquiry => "éŠæˆ²æˆ–ä½¿ç”¨è€…è¡Œç‚ºä¸ç•¶";

	/// <summary>
	/// Key: "Label.SafetyQueueTicket"
	/// User Safety Concern
	/// English String: "User Safety Concern"
	/// </summary>
	public override string LabelSafetyQueueTicket => "ä½¿ç”¨è€…å®‰å…¨ç–‘æ…®";

	/// <summary>
	/// Key: "Label.SpecificGameIssue"
	/// Specific Game Issue
	/// English String: "Specific Game Issue"
	/// </summary>
	public override string LabelSpecificGameIssue => "ç‰¹å®šéŠæˆ²å•é¡Œ";

	/// <summary>
	/// Key: "Label.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "æäº¤";

	/// <summary>
	/// Key: "Label.SuggestFeature"
	/// Feature Suggestion
	/// English String: "Feature Suggestion"
	/// </summary>
	public override string LabelSuggestFeature => "åŠŸèƒ½å»ºè­°";

	/// <summary>
	/// Key: "Label.SuggestFeedback"
	/// Feedback
	/// English String: "Feedback"
	/// </summary>
	public override string LabelSuggestFeedback => "å›žé¥‹";

	/// <summary>
	/// Key: "Label.TechnicalSupport"
	/// Technical Support
	/// English String: "Technical Support"
	/// </summary>
	public override string LabelTechnicalSupport => "æŠ€è¡“å”åŠ©";

	/// <summary>
	/// Key: "Label.ToyCodeIssue"
	/// Toy Code Issue
	/// English String: "Toy Code Issue"
	/// </summary>
	public override string LabelToyCodeIssue => "çŽ©å…·ä»£ç¢¼å•é¡Œ";

	/// <summary>
	/// Key: "Label.TwoStepV"
	/// 2-Step Verification
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepV => "é›™æ­¥é©Ÿé©—è­‰";

	/// <summary>
	/// Key: "Label.UserAbuseReport"
	/// Report User Breaking Rules
	/// English String: "Report User Breaking Rules"
	/// </summary>
	public override string LabelUserAbuseReport => "èˆ‰å ±é•è¦ä½¿ç”¨è€…";

	/// <summary>
	/// Key: "Label.Username"
	/// Username
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.VCCatalog"
	/// Website Item
	/// English String: "Website Item"
	/// </summary>
	public override string LabelVCCatalog => "ç¶²ç«™é“å…·";

	/// <summary>
	/// Key: "Label.VCInGame"
	/// In-Game Item
	/// English String: "In-Game Item"
	/// </summary>
	public override string LabelVCInGame => "éŠæˆ²ä¸­é“å…·";

	/// <summary>
	/// Key: "Label.Xbox"
	/// Xbox
	/// English String: "Xbox"
	/// </summary>
	public override string LabelXbox => "Xbox";

	/// <summary>
	/// Key: "Response.Dialog.ErrorWithoutContext"
	/// Something went wrong, please try again later.
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseDialogErrorWithoutContext => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.InvalidUsername"
	/// Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.
	/// English String: "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker."
	/// </summary>
	public override string ResponseDialogInvalidUsername => "æŒ‰ä¸‹ã€Œå‚³é€ã€æäº¤è¯çµ¡å–®ï¼Œæˆ–æŒ‰ä¸‹ã€Œå–æ¶ˆã€ç·¨è¼¯ä½¿ç”¨è€…åç¨±ã€‚æä¾›æ­£ç¢ºçš„ä½¿ç”¨è€…åç¨±èƒ½è®“æˆ‘æ›´å¿«è§£æ±ºæ‚¨çš„å•é¡Œã€‚";

	/// <summary>
	/// Key: "Response.Dialog.RequestReceived"
	/// Thank you for contacting Roblox. Please check your email for a message from Customer Service.
	/// English String: "Thank you for contacting Roblox. Please check your email for a message from Customer Service."
	/// </summary>
	public override string ResponseDialogRequestReceived => "è¬è¬æ‚¨è¯çµ¡ Robloxï¼Œå®¢æœäººå“¡å°‡ç›¡é€Ÿé€éŽé›»å­éƒµä»¶å›žè¦†æ‚¨ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.TooManyAttemptsError"
	/// Too many attempts. Try again later.
	/// English String: "Too many attempts. Try again later."
	/// </summary>
	public override string ResponseDialogTooManyAttemptsError => "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.TryAgainError"
	/// An error occurred. Try again later.
	/// English String: "An error occurred. Try again later."
	/// </summary>
	public override string ResponseDialogTryAgainError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.EmailFormatError"
	/// Please enter a properly formatted email address
	/// English String: "Please enter a properly formatted email address"
	/// </summary>
	public override string ResponseEmailFormatError => "è«‹è¼¸å…¥æ ¼å¼æ­£ç¢ºçš„é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Response.EmailNotMatching"
	/// Email address does not match
	/// English String: "Email address does not match"
	/// </summary>
	public override string ResponseEmailNotMatching => "é›»å­éƒµä»¶åœ°å€ä¸ç¬¦";

	/// <summary>
	/// Key: "Response.InvalidFirstName"
	/// Please enter a valid first name
	/// English String: "Please enter a valid first name"
	/// </summary>
	public override string ResponseInvalidFirstName => "è«‹è¼¸å…¥æœ‰æ•ˆåå­—";

	/// <summary>
	/// Key: "Response.InvalidUsername"
	/// That doesn't appear to be a valid Roblox username.
	/// English String: "That doesn't appear to be a valid Roblox username."
	/// </summary>
	public override string ResponseInvalidUsername => "Roblox ä½¿ç”¨è€…åç¨±ç„¡æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.Under13Email"
	/// If you are under 13 years old, please provide your parent's email address
	/// English String: "If you are under 13 years old, please provide your parent's email address"
	/// </summary>
	public override string ResponseUnder13Email => "è‹¥æ‚¨ 13 æ­²ä»¥ä¸‹ï¼Œè«‹æä¾›æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€";

	public SupportResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionDialogOK()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForActionDialogSend()
	{
		return "å‚³é€";
	}

	protected override string _GetTemplateForHeadingContactInformation()
	{
		return "è¯çµ¡è³‡è¨Š";
	}

	protected override string _GetTemplateForHeadingDescriptionOfIssue()
	{
		return "å•é¡Œèªªæ˜Ž";
	}

	protected override string _GetTemplateForHeadingDeviceWithProblem()
	{
		return "æ‚¨é‡åˆ°å•é¡Œçš„è£ç½®æ˜¯ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingDialogErrorWithoutContext()
	{
		return "éŒ¯èª¤";
	}

	protected override string _GetTemplateForHeadingDialogInvalidUsername()
	{
		return "ä½¿ç”¨è€…åç¨±ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForHeadingDialogRequestReceived()
	{
		return "å·²æ”¶åˆ°è«‹æ±‚";
	}

	protected override string _GetTemplateForHeadingHelpCategoryType()
	{
		return "èªªæ˜Žé¡žåˆ¥çš„ç¨®é¡ž";
	}

	protected override string _GetTemplateForHeadingIssueDetails()
	{
		return "å•é¡Œè©³ç´°è³‡æ–™";
	}

	protected override string _GetTemplateForHeadingPageTitle()
	{
		return "è¯çµ¡æˆ‘å€‘";
	}

	protected override string _GetTemplateForLabelAccountHacked()
	{
		return "å¸³è™Ÿé­é§­";
	}

	protected override string _GetTemplateForLabelAccountOwnership()
	{
		return "å¸³è™Ÿé­é§­æˆ–ç„¡æ³•ç™»å…¥";
	}

	protected override string _GetTemplateForLabelAccountPin()
	{
		return "å¸³è™Ÿ PIN";
	}

	protected override string _GetTemplateForLabelAdjustChildSettings()
	{
		return "èª¿æ•´å…’ç«¥éš±ç§æ¬ŠåŠå®‰å…¨è¨­å®š";
	}

	protected override string _GetTemplateForLabelAmazonDevice()
	{
		return "Amazon è£ç½®";
	}

	protected override string _GetTemplateForLabelAndroidPhone()
	{
		return "Android æ‰‹æ©Ÿ";
	}

	protected override string _GetTemplateForLabelAndroidTablet()
	{
		return "Android å¹³æ¿é›»è…¦";
	}

	protected override string _GetTemplateForLabelAppealAccountContent()
	{
		return "å¸³è™Ÿæˆ–å…§å®¹ä¸Šè¨´";
	}

	protected override string _GetTemplateForLabelAppealFriend()
	{
		return "ç‚ºå¥½å‹ä¸Šè¨´";
	}

	protected override string _GetTemplateForLabelBilling()
	{
		return "å¸³å‹™å’Œä»˜æ¬¾";
	}

	protected override string _GetTemplateForLabelBugReport()
	{
		return "èˆ‰å ±æ¼æ´ž";
	}

	protected override string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected override string _GetTemplateForLabelCancelMembership()
	{
		return "å–æ¶ˆæœƒå“¡è³‡æ ¼";
	}

	protected override string _GetTemplateForLabelCannotInstall()
	{
		return "ç„¡æ³•å®‰è£ Roblox æˆ– Studio";
	}

	protected override string _GetTemplateForLabelCannotPlayGame()
	{
		return "ç„¡æ³•çŽ©éŠæˆ²";
	}

	protected override string _GetTemplateForLabelChangeChildAge()
	{
		return "è®Šæ›´å…’ç«¥å¹´é½¡";
	}

	protected override string _GetTemplateForLabelChatAgeSettings()
	{
		return "èŠå¤©èˆ‡å¹´é½¡è¨­å®š";
	}

	protected override string _GetTemplateForLabelChromebook()
	{
		return "Chromebook";
	}

	protected override string _GetTemplateForLabelConfirmEmail()
	{
		return "ç¢ºèªé›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelContentAbuseReport()
	{
		return "èˆ‰å ±é•è¦å…§å®¹";
	}

	protected override string _GetTemplateForLabelContest()
	{
		return "æ¯”è³½åŠæ´»å‹•";
	}

	protected override string _GetTemplateForLabelContestEventQuestion()
	{
		return "å•é¡Œæˆ–å›°é›£";
	}

	protected override string _GetTemplateForLabelCSCharacter()
	{
		return "å®¢æœäººå“¡è§’è‰²";
	}

	protected override string _GetTemplateForLabelDescribeIssue()
	{
		return "è«‹æè¿°æ‚¨çš„å•é¡Œ";
	}

	protected override string _GetTemplateForLabelDevEx()
	{
		return "DevEx";
	}

	protected override string _GetTemplateForLabelDevExHowTo()
	{
		return "DevEx èªªæ˜Ž";
	}

	protected override string _GetTemplateForLabelDevExMyRequest()
	{
		return "DevEx æˆ‘çš„è«‹æ±‚";
	}

	protected override string _GetTemplateForLabelDMCA()
	{
		return "æ•¸ä½åƒç¦§å¹´è‘—ä½œæ¬Šæ³•ï¼ˆDMCAï¼‰";
	}

	protected override string _GetTemplateForLabelEmailAddress()
	{
		return "é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelExploitReport()
	{
		return "èˆ‰å ±å¤–æŽ›";
	}

	protected override string _GetTemplateForLabelFirstName()
	{
		return "åå­—";
	}

	protected override string _GetTemplateForLabelForgotPassword()
	{
		return "å¿˜è¨˜å¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelFreeRobux()
	{
		return "å…è²» Robux";
	}

	protected override string _GetTemplateForLabelGameCredit()
	{
		return "é»žæ•¸å¡";
	}

	protected override string _GetTemplateForLabelGCPartialPayment()
	{
		return "è³¼è²· - æ‹†åˆ†ä»˜æ¬¾";
	}

	protected override string _GetTemplateForLabelGCRedeem()
	{
		return "é»žæ•¸å¡ - å…Œæ›";
	}

	protected override string _GetTemplateForLabelGCSpendCredit()
	{
		return "é»žæ•¸å¡ - ä½¿ç”¨é»žæ•¸";
	}

	protected override string _GetTemplateForLabelHowTo()
	{
		return "èªªæ˜Ž";
	}

	protected override string _GetTemplateForLabelHowToGeneral()
	{
		return "èªªæ˜Ž - ä¸€èˆ¬";
	}

	protected override string _GetTemplateForLabelHowToOther()
	{
		return "èªªæ˜Ž - å…¶å®ƒ";
	}

	protected override string _GetTemplateForLabelIdeasSuggestions()
	{
		return "å»ºè­°";
	}

	protected override string _GetTemplateForLabelIPad()
	{
		return "iPad";
	}

	protected override string _GetTemplateForLabelIPhone()
	{
		return "iPhone";
	}

	protected override string _GetTemplateForLabelIssueDescription()
	{
		return "è«‹æè¿°æ‚¨é¢è‡¨çš„å•é¡Œã€‚è«‹é™„ä¸Šä»»ä½•ç›¸é—œè³‡è¨Šï¼Œä¾‹å¦‚å•é¡Œç™¼ç”Ÿçš„æ‰€åœ¨åŠéŒ¯èª¤è¨Šæ¯æ–‡å­—ã€‚";
	}

	protected override string _GetTemplateForLabelIWasScammed()
	{
		return "æˆ‘é­åˆ°è©é¨™";
	}

	protected override string _GetTemplateForLabelMac()
	{
		return "Mac";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "æœƒå“¡è³‡æ ¼";
	}

	protected override string _GetTemplateForLabelModeration()
	{
		return "éŽæ¿¾";
	}

	protected override string _GetTemplateForLabelOtherSiteClaim()
	{
		return "å…¶å®ƒç¶²ç«™è²æ˜Ž";
	}

	protected override string _GetTemplateForLabelOwnerDMCAClaim()
	{
		return "æ•¸ä½åƒç¦§å¹´è‘—ä½œæ¬Šæ³•ï¼ˆDMCAï¼‰æ‰€æœ‰æ¬Šäººè²æ˜Ž";
	}

	protected override string _GetTemplateForLabelPC()
	{
		return "å€‹äººé›»è…¦";
	}

	protected override string _GetTemplateForLabelPhysicalToyIssue()
	{
		return "å¯¦é«”çŽ©å…·å•é¡Œ";
	}

	protected override string _GetTemplateForLabelPleaseSelect()
	{
		return "è«‹é¸æ“‡â€¦";
	}

	protected override string _GetTemplateForLabelPrizeNotReceived()
	{
		return "æœªæ”¶åˆ°çŽé …";
	}

	protected override string _GetTemplateForLabelPurchaseDeclined()
	{
		return "è³¼è²· - é­æ‹’";
	}

	protected override string _GetTemplateForLabelPurchaseDidNotReceive()
	{
		return "è³¼è²· - æœªæ”¶åˆ°";
	}

	protected override string _GetTemplateForLabelPurchaseUnauthorizedCharge()
	{
		return "è³¼è²· - æœªæŽˆæ¬Šæ”¶è²»";
	}

	protected override string _GetTemplateForLabelReportPhish()
	{
		return "æª¢èˆ‰ç¶²è·¯é‡£é­šç¶²ç«™";
	}

	protected override string _GetTemplateForLabelRobloxCrashing()
	{
		return "Roblox ç•¶æ©Ÿ";
	}

	protected override string _GetTemplateForLabelRobloxToys()
	{
		return "Roblox çŽ©å…·";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelRobuxPurchaseIssue()
	{
		return "Robux - è³¼è²·å•é¡Œ";
	}

	protected override string _GetTemplateForLabelSafetyInquiry()
	{
		return "éŠæˆ²æˆ–ä½¿ç”¨è€…è¡Œç‚ºä¸ç•¶";
	}

	protected override string _GetTemplateForLabelSafetyQueueTicket()
	{
		return "ä½¿ç”¨è€…å®‰å…¨ç–‘æ…®";
	}

	protected override string _GetTemplateForLabelSpecificGameIssue()
	{
		return "ç‰¹å®šéŠæˆ²å•é¡Œ";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForLabelSuggestFeature()
	{
		return "åŠŸèƒ½å»ºè­°";
	}

	protected override string _GetTemplateForLabelSuggestFeedback()
	{
		return "å›žé¥‹";
	}

	protected override string _GetTemplateForLabelTechnicalSupport()
	{
		return "æŠ€è¡“å”åŠ©";
	}

	protected override string _GetTemplateForLabelToyCodeIssue()
	{
		return "çŽ©å…·ä»£ç¢¼å•é¡Œ";
	}

	protected override string _GetTemplateForLabelTwoStepV()
	{
		return "é›™æ­¥é©Ÿé©—è­‰";
	}

	protected override string _GetTemplateForLabelUserAbuseReport()
	{
		return "èˆ‰å ±é•è¦ä½¿ç”¨è€…";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelVCCatalog()
	{
		return "ç¶²ç«™é“å…·";
	}

	protected override string _GetTemplateForLabelVCInGame()
	{
		return "éŠæˆ²ä¸­é“å…·";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForResponseDialogErrorWithoutContext()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseDialogInvalidUsername()
	{
		return "æŒ‰ä¸‹ã€Œå‚³é€ã€æäº¤è¯çµ¡å–®ï¼Œæˆ–æŒ‰ä¸‹ã€Œå–æ¶ˆã€ç·¨è¼¯ä½¿ç”¨è€…åç¨±ã€‚æä¾›æ­£ç¢ºçš„ä½¿ç”¨è€…åç¨±èƒ½è®“æˆ‘æ›´å¿«è§£æ±ºæ‚¨çš„å•é¡Œã€‚";
	}

	protected override string _GetTemplateForResponseDialogRequestReceived()
	{
		return "è¬è¬æ‚¨è¯çµ¡ Robloxï¼Œå®¢æœäººå“¡å°‡ç›¡é€Ÿé€éŽé›»å­éƒµä»¶å›žè¦†æ‚¨ã€‚";
	}

	protected override string _GetTemplateForResponseDialogTooManyAttemptsError()
	{
		return "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseDialogTryAgainError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseEmailFormatError()
	{
		return "è«‹è¼¸å…¥æ ¼å¼æ­£ç¢ºçš„é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForResponseEmailNotMatching()
	{
		return "é›»å­éƒµä»¶åœ°å€ä¸ç¬¦";
	}

	protected override string _GetTemplateForResponseInvalidFirstName()
	{
		return "è«‹è¼¸å…¥æœ‰æ•ˆåå­—";
	}

	protected override string _GetTemplateForResponseInvalidUsername()
	{
		return "Roblox ä½¿ç”¨è€…åç¨±ç„¡æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseUnder13Email()
	{
		return "è‹¥æ‚¨ 13 æ­²ä»¥ä¸‹ï¼Œè«‹æä¾›æ‚¨çš„å®¶é•·çš„é›»å­éƒµä»¶åœ°å€";
	}
}


}
