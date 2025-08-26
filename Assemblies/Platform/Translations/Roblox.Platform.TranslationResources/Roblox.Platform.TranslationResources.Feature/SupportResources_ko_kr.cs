namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SupportResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportResources_ko_kr : SupportResources_en_us, ISupportResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string ActionDialogCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Dialog.OK"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOK => "í™•ì¸";

	/// <summary>
	/// Key: "Action.Dialog.Send"
	/// Send
	/// English String: "Send"
	/// </summary>
	public override string ActionDialogSend => "ë³´ë‚´ê¸°";

	/// <summary>
	/// Key: "Heading.ContactInformation"
	/// Contact Information
	/// English String: "Contact Information"
	/// </summary>
	public override string HeadingContactInformation => "ì—°ë½ì²˜ ì •ë³´";

	/// <summary>
	/// Key: "Heading.DescriptionOfIssue"
	/// Description of issue
	/// English String: "Description of issue"
	/// </summary>
	public override string HeadingDescriptionOfIssue => "ë¬¸ì œ ì„¤ëª…";

	/// <summary>
	/// Key: "Heading.DeviceWithProblem"
	/// What device are you having the problem on?
	/// English String: "What device are you having the problem on?"
	/// </summary>
	public override string HeadingDeviceWithProblem => "ì–´ë–¤ ê¸°ê¸°ì—ì„œ ë¬¸ì œë¥¼ ê²ªê³  ìžˆë‚˜ìš”?";

	/// <summary>
	/// Key: "Heading.Dialog.ErrorWithoutContext"
	/// Error
	/// English String: "Error"
	/// </summary>
	public override string HeadingDialogErrorWithoutContext => "ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Heading.Dialog.InvalidUsername"
	/// Invalid Username
	/// English String: "Invalid Username"
	/// </summary>
	public override string HeadingDialogInvalidUsername => "ìœ íš¨í•˜ì§€ ì•Šì€ ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Heading.Dialog.RequestReceived"
	/// Request Received
	/// English String: "Request Received"
	/// </summary>
	public override string HeadingDialogRequestReceived => "ìš”ì²­ ë°›ìŒ";

	/// <summary>
	/// Key: "Heading.HelpCategoryType"
	/// Type of help category
	/// English String: "Type of help category"
	/// </summary>
	public override string HeadingHelpCategoryType => "ë„ì›€ë§ ì¹´í…Œê³ ë¦¬ ìœ í˜•";

	/// <summary>
	/// Key: "Heading.IssueDetails"
	/// Issue Details
	/// English String: "Issue Details"
	/// </summary>
	public override string HeadingIssueDetails => "ë¬¸ì œ ì„¤ëª…";

	/// <summary>
	/// Key: "Heading.PageTitle"
	/// Contact Us
	/// English String: "Contact Us"
	/// </summary>
	public override string HeadingPageTitle => "ê³ ê°ì„¼í„°";

	/// <summary>
	/// Key: "Label.AccountHacked"
	/// Account Hacked
	/// English String: "Account Hacked"
	/// </summary>
	public override string LabelAccountHacked => "ê³„ì • í•´í‚¹";

	/// <summary>
	/// Key: "Label.AccountOwnership"
	/// Account Hacked or Can't Log in
	/// English String: "Account Hacked or Can't Log in"
	/// </summary>
	public override string LabelAccountOwnership => "ê³„ì • í•´í‚¹ í˜¹ì€ ë¡œê·¸ì¸ ë¶ˆê°€";

	/// <summary>
	/// Key: "Label.AccountPin"
	/// Account PIN
	/// English String: "Account PIN"
	/// </summary>
	public override string LabelAccountPin => "ê³„ì • PIN";

	public override string LabelAdjustChildSettings => "ìžë…€ ê°œì¸ì •ë³´ ë° ë³´ì•ˆ ì„¤ì • ë³€ê²½";

	/// <summary>
	/// Key: "Label.AmazonDevice"
	/// Amazon Device
	/// English String: "Amazon Device"
	/// </summary>
	public override string LabelAmazonDevice => "Amazon ê¸°ê¸°";

	/// <summary>
	/// Key: "Label.AndroidPhone"
	/// Android Phone
	/// English String: "Android Phone"
	/// </summary>
	public override string LabelAndroidPhone => "Android í°";

	/// <summary>
	/// Key: "Label.AndroidTablet"
	/// Android Tablet
	/// English String: "Android Tablet"
	/// </summary>
	public override string LabelAndroidTablet => "Android íƒœë¸”ë¦¿";

	/// <summary>
	/// Key: "Label.AppealAccountContent"
	/// Appeal Account or Content
	/// English String: "Appeal Account or Content"
	/// </summary>
	public override string LabelAppealAccountContent => "ê³„ì • ë˜ëŠ” ì½˜í…ì¸  ê´€ë ¨ íƒ„ì›";

	/// <summary>
	/// Key: "Label.AppealFriend"
	/// Appeal for Friend
	/// English String: "Appeal for Friend"
	/// </summary>
	public override string LabelAppealFriend => "ì¹œêµ¬ ê´€ë ¨ íƒ„ì›";

	public override string LabelBilling => "ì²­êµ¬ ë° ê²°ì œ";

	/// <summary>
	/// Key: "Label.BugReport"
	/// Bug Report
	/// English String: "Bug Report"
	/// </summary>
	public override string LabelBugReport => "ë²„ê·¸ ì‹ ê³ ";

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
	public override string LabelCancelMembership => "ë©¤ë²„ì‹­ ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.CannotInstall"
	/// Cannot Install Roblox or Studio
	/// English String: "Cannot Install Roblox or Studio"
	/// </summary>
	public override string LabelCannotInstall => "Roblox ë˜ëŠ” Studio ì„¤ì¹˜ ë¶ˆê°€";

	/// <summary>
	/// Key: "Label.CannotPlayGame"
	/// Cannot Play Game
	/// English String: "Cannot Play Game"
	/// </summary>
	public override string LabelCannotPlayGame => "ê²Œìž„ í”Œë ˆì´ ë¶ˆê°€";

	/// <summary>
	/// Key: "Label.ChangeChildAge"
	/// Change Child Age
	/// English String: "Change Child Age"
	/// </summary>
	public override string LabelChangeChildAge => "ìžë…€ ë‚˜ì´ ë³€ê²½";

	public override string LabelChatAgeSettings => "ì±„íŒ… ë° ë‚˜ì´ ì„¤ì •";

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
	public override string LabelConfirmEmail => "ì´ë©”ì¼ ì£¼ì†Œ í™•ì¸";

	/// <summary>
	/// Key: "Label.ContentAbuseReport"
	/// Report Content Breaking Rules
	/// English String: "Report Content Breaking Rules"
	/// </summary>
	public override string LabelContentAbuseReport => "ê·œì¹™ ìœ„ë°˜ ì½˜í…ì¸  ì‹ ê³ ";

	public override string LabelContest => "ì½˜í…ŒìŠ¤íŠ¸ ë° ì´ë²¤íŠ¸";

	/// <summary>
	/// Key: "Label.ContestEventQuestion"
	/// Question or Issue
	/// English String: "Question or Issue"
	/// </summary>
	public override string LabelContestEventQuestion => "ì§ˆë¬¸ ë˜ëŠ” ë¬¸ì œ";

	/// <summary>
	/// Key: "Label.CSCharacter"
	/// Customer Service Character
	/// English String: "Customer Service Character"
	/// </summary>
	public override string LabelCSCharacter => "ê³ ê°ì§€ì› ìºë¦­í„°";

	/// <summary>
	/// Key: "Label.DescribeIssue"
	/// Please describe your issue
	/// English String: "Please describe your issue"
	/// </summary>
	public override string LabelDescribeIssue => "ë¬¸ì œë¥¼ ì„¤ëª…í•´ì£¼ì„¸ìš”";

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
	public override string LabelDevExHowTo => "DexEx ì‚¬ìš©ë²•";

	/// <summary>
	/// Key: "Label.DevExMyRequest"
	/// DevEx My Request
	/// English String: "DevEx My Request"
	/// </summary>
	public override string LabelDevExMyRequest => "DevEx ë‚´ ìš”ì²­";

	/// <summary>
	/// Key: "Label.DMCA"
	/// DMCA
	/// English String: "DMCA"
	/// </summary>
	public override string LabelDMCA => "DMCA";

	/// <summary>
	/// Key: "Label.EmailAddress"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailAddress => "ì´ë©”ì¼ ì£¼ì†Œ";

	/// <summary>
	/// Key: "Label.ExploitReport"
	/// Exploit Report
	/// English String: "Exploit Report"
	/// </summary>
	public override string LabelExploitReport => "ì•…ìš© ì‹ ê³ ";

	/// <summary>
	/// Key: "Label.FirstName"
	/// First Name
	/// English String: "First Name"
	/// </summary>
	public override string LabelFirstName => "ì´ë¦„";

	/// <summary>
	/// Key: "Label.ForgotPassword"
	/// Forgot Password
	/// English String: "Forgot Password"
	/// </summary>
	public override string LabelForgotPassword => "ë¹„ë°€ë²ˆí˜¸ ë¶„ì‹¤";

	/// <summary>
	/// Key: "Label.FreeRobux"
	/// Free Robux
	/// English String: "Free Robux"
	/// </summary>
	public override string LabelFreeRobux => "ë¬´ë£Œ Robux";

	/// <summary>
	/// Key: "Label.GameCredit"
	/// Game Card
	/// English String: "Game Card"
	/// </summary>
	public override string LabelGameCredit => "ê²Œìž„ì¹´ë“œ";

	/// <summary>
	/// Key: "Label.GCPartialPayment"
	/// Purchase - Split Payment
	/// English String: "Purchase - Split Payment"
	/// </summary>
	public override string LabelGCPartialPayment => "êµ¬ë§¤ - í• ë¶€";

	/// <summary>
	/// Key: "Label.GCRedeem"
	/// Game Card - Redeem
	/// English String: "Game Card - Redeem"
	/// </summary>
	public override string LabelGCRedeem => "ê²Œìž„ì¹´ë“œ - ì‚¬ìš©";

	/// <summary>
	/// Key: "Label.GCSpendCredit"
	/// Game Card - Spend Credit
	/// English String: "Game Card - Spend Credit"
	/// </summary>
	public override string LabelGCSpendCredit => "ê²Œìž„ì¹´ë“œ - í¬ë ˆë”§ ì‚¬ìš©";

	/// <summary>
	/// Key: "Label.HowTo"
	/// How To
	/// English String: "How To"
	/// </summary>
	public override string LabelHowTo => "ì‚¬ìš©ë²•";

	/// <summary>
	/// Key: "Label.HowToGeneral"
	/// How To - General
	/// English String: "How To - General"
	/// </summary>
	public override string LabelHowToGeneral => "ì‚¬ìš©ë²• - ì¼ë°˜";

	/// <summary>
	/// Key: "Label.HowToOther"
	/// How To - Other
	/// English String: "How To - Other"
	/// </summary>
	public override string LabelHowToOther => "ì‚¬ìš©ë²• - ê¸°íƒ€";

	public override string LabelIdeasSuggestions => "ì•„ì´ë””ì–´ ë° ì œì•ˆ";

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
	public override string LabelIssueDescription => "ì–´ë–¤ ë¬¸ì œë¥¼ ê²ªê³  ìžˆëŠ”ì§€ ìžì„¸ížˆ ì ì–´ì£¼ì„¸ìš”. ë¬¸ì œê°€ ë°œìƒí•œ ìœ„ì¹˜ë‚˜ ì˜¤ë¥˜ ë©”ì‹œì§€ë¥¼ ë¹„ë¡¯í•œ ê´€ë ¨ ì •ë³´ë¥¼ ë¬´ì—‡ì´ë“  ê¸°ìž¬í•´ì£¼ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.IWasScammed"
	/// I was Scammed
	/// English String: "I was Scammed"
	/// </summary>
	public override string LabelIWasScammed => "ì‹ ìš© ì‚¬ê¸°";

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
	public override string LabelMembership => "ë©¤ë²„ì‹­";

	/// <summary>
	/// Key: "Label.Moderation"
	/// Moderation
	/// English String: "Moderation"
	/// </summary>
	public override string LabelModeration => "ê²€ì—´";

	/// <summary>
	/// Key: "Label.OtherSiteClaim"
	/// Other Site Claim
	/// English String: "Other Site Claim"
	/// </summary>
	public override string LabelOtherSiteClaim => "ê¸°íƒ€ ì‚¬ì´íŠ¸ í´ë ˆìž„";

	/// <summary>
	/// Key: "Label.OwnerDMCAClaim"
	/// Owner DMCA Claim
	/// English String: "Owner DMCA Claim"
	/// </summary>
	public override string LabelOwnerDMCAClaim => "ì†Œìœ ìž DMCA í´ë ˆìž„";

	/// <summary>
	/// Key: "Label.PC"
	/// PC
	/// English String: "PC"
	/// </summary>
	public override string LabelPC => "PC";

	/// <summary>
	/// Key: "Label.PhysicalToyIssue"
	/// Physical Toy Issue
	/// English String: "Physical Toy Issue"
	/// </summary>
	public override string LabelPhysicalToyIssue => "ì‹¤ë¬¼ ìž¥ë‚œê° ë¬¸ì œ";

	/// <summary>
	/// Key: "Label.PleaseSelect"
	/// Please Select...
	/// English String: "Please Select..."
	/// </summary>
	public override string LabelPleaseSelect => "ì„ íƒ...";

	/// <summary>
	/// Key: "Label.PrizeNotReceived"
	/// Prize Not Received
	/// English String: "Prize Not Received"
	/// </summary>
	public override string LabelPrizeNotReceived => "ìƒí’ˆ ë°›ì§€ ì•ŠìŒ";

	/// <summary>
	/// Key: "Label.PurchaseDeclined"
	/// Purchase - Declined
	/// English String: "Purchase - Declined"
	/// </summary>
	public override string LabelPurchaseDeclined => "êµ¬ë§¤ - ê±°ì ˆë¨";

	/// <summary>
	/// Key: "Label.PurchaseDidNotReceive"
	/// Purchase - Did Not Receive
	/// English String: "Purchase - Did Not Receive"
	/// </summary>
	public override string LabelPurchaseDidNotReceive => "êµ¬ë§¤ - ìˆ˜ë ¹í•˜ì§€ ì•ŠìŒ";

	/// <summary>
	/// Key: "Label.PurchaseUnauthorizedCharge"
	/// Purchase - Unauthorized Charge
	/// English String: "Purchase - Unauthorized Charge"
	/// </summary>
	public override string LabelPurchaseUnauthorizedCharge => "êµ¬ë§¤ - ìŠ¹ì¸ë˜ì§€ ì•Šì€ ì²­êµ¬";

	/// <summary>
	/// Key: "Label.ReportPhish"
	/// Report Phishing Site
	/// English String: "Report Phishing Site"
	/// </summary>
	public override string LabelReportPhish => "í”¼ì‹± ì‚¬ì´íŠ¸ ì‹ ê³ ";

	/// <summary>
	/// Key: "Label.RobloxCrashing"
	/// Roblox Crashing
	/// English String: "Roblox Crashing"
	/// </summary>
	public override string LabelRobloxCrashing => "Roblox ì¶©ëŒ";

	/// <summary>
	/// Key: "Label.RobloxToys"
	/// Roblox Toys
	/// English String: "Roblox Toys"
	/// </summary>
	public override string LabelRobloxToys => "Roblox ìž¥ë‚œê°";

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
	public override string LabelRobuxPurchaseIssue => "Robux - êµ¬ë§¤ ë¬¸ì œ";

	/// <summary>
	/// Key: "Label.SafetyInquiry"
	/// Inappropriate game or user behavior
	/// English String: "Inappropriate game or user behavior"
	/// </summary>
	public override string LabelSafetyInquiry => "ë¶€ì ì ˆí•œ ê²Œìž„ ë˜ëŠ” ì‚¬ìš©ìž í–‰ë™";

	/// <summary>
	/// Key: "Label.SafetyQueueTicket"
	/// User Safety Concern
	/// English String: "User Safety Concern"
	/// </summary>
	public override string LabelSafetyQueueTicket => "ì‚¬ìš©ìž ë³´ì•ˆ ë¬¸ì œ";

	/// <summary>
	/// Key: "Label.SpecificGameIssue"
	/// Specific Game Issue
	/// English String: "Specific Game Issue"
	/// </summary>
	public override string LabelSpecificGameIssue => "íŠ¹ì • ê²Œìž„ ë¬¸ì œ";

	/// <summary>
	/// Key: "Label.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "ì €ìž¥";

	/// <summary>
	/// Key: "Label.SuggestFeature"
	/// Feature Suggestion
	/// English String: "Feature Suggestion"
	/// </summary>
	public override string LabelSuggestFeature => "ê¸°ëŠ¥ ì œì•ˆ";

	/// <summary>
	/// Key: "Label.SuggestFeedback"
	/// Feedback
	/// English String: "Feedback"
	/// </summary>
	public override string LabelSuggestFeedback => "í”¼ë“œë°±";

	/// <summary>
	/// Key: "Label.TechnicalSupport"
	/// Technical Support
	/// English String: "Technical Support"
	/// </summary>
	public override string LabelTechnicalSupport => "ê¸°ìˆ  ì§€ì›";

	/// <summary>
	/// Key: "Label.ToyCodeIssue"
	/// Toy Code Issue
	/// English String: "Toy Code Issue"
	/// </summary>
	public override string LabelToyCodeIssue => "ìž¥ë‚œê° ì½”ë“œ ë¬¸ì œ";

	/// <summary>
	/// Key: "Label.TwoStepV"
	/// 2-Step Verification
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepV => "2ë‹¨ê³„ ì¸ì¦";

	/// <summary>
	/// Key: "Label.UserAbuseReport"
	/// Report User Breaking Rules
	/// English String: "Report User Breaking Rules"
	/// </summary>
	public override string LabelUserAbuseReport => "ê·œì¹™ ìœ„ë°˜ ì‚¬ìš©ìž ì‹ ê³ ";

	/// <summary>
	/// Key: "Label.Username"
	/// Username
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Label.VCCatalog"
	/// Website Item
	/// English String: "Website Item"
	/// </summary>
	public override string LabelVCCatalog => "ì›¹ì‚¬ì´íŠ¸ ì•„ì´í…œ";

	/// <summary>
	/// Key: "Label.VCInGame"
	/// In-Game Item
	/// English String: "In-Game Item"
	/// </summary>
	public override string LabelVCInGame => "ê²Œìž„ ë‚´ ì•„ì´í…œ";

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
	public override string ResponseDialogErrorWithoutContext => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.InvalidUsername"
	/// Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.
	/// English String: "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker."
	/// </summary>
	public override string ResponseDialogInvalidUsername => "ë³´ë‚´ê¸°ë¥¼ ëˆŒëŸ¬ í‹°ì¼“ì„ ì œì¶œí•˜ê±°ë‚˜ ì·¨ì†Œë¥¼ ëˆŒëŸ¬ ì‚¬ìš©ìž ì´ë¦„ì„ íŽ¸ì§‘í•˜ì„¸ìš”. ì‚¬ìš©ìž ì´ë¦„ì€ ë¬¸ì œë¥¼ ì¡°ì†ížˆ í•´ê²°í•˜ëŠ” ë° ë„ì›€ì´ ë  ìˆ˜ ìžˆëŠ” ë§¤ìš° ì¤‘ìš”í•œ ì •ë³´ëžë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.Dialog.RequestReceived"
	/// Thank you for contacting Roblox. Please check your email for a message from Customer Service.
	/// English String: "Thank you for contacting Roblox. Please check your email for a message from Customer Service."
	/// </summary>
	public override string ResponseDialogRequestReceived => "Robloxì— ì—°ë½í•´ì£¼ì…”ì„œ ê°ì‚¬í•©ë‹ˆë‹¤. ê³ ê°ì§€ì› ì´ë©”ì¼ì„ í™•ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.TooManyAttemptsError"
	/// Too many attempts. Try again later.
	/// English String: "Too many attempts. Try again later."
	/// </summary>
	public override string ResponseDialogTooManyAttemptsError => "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.TryAgainError"
	/// An error occurred. Try again later.
	/// English String: "An error occurred. Try again later."
	/// </summary>
	public override string ResponseDialogTryAgainError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.EmailFormatError"
	/// Please enter a properly formatted email address
	/// English String: "Please enter a properly formatted email address"
	/// </summary>
	public override string ResponseEmailFormatError => "ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì˜¬ë°”ë¥¸ í˜•ì‹ìœ¼ë¡œ ìž…ë ¥í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Response.EmailNotMatching"
	/// Email address does not match
	/// English String: "Email address does not match"
	/// </summary>
	public override string ResponseEmailNotMatching => "ì´ë©”ì¼ ì£¼ì†Œê°€ ì¼ì¹˜í•˜ì§€ ì•Šì•„ìš”";

	/// <summary>
	/// Key: "Response.InvalidFirstName"
	/// Please enter a valid first name
	/// English String: "Please enter a valid first name"
	/// </summary>
	public override string ResponseInvalidFirstName => "ìœ íš¨í•œ ì´ë¦„(ì„± ì œì™¸)ì„ ìž…ë ¥í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Response.InvalidUsername"
	/// That doesn't appear to be a valid Roblox username.
	/// English String: "That doesn't appear to be a valid Roblox username."
	/// </summary>
	public override string ResponseInvalidUsername => "ìœ íš¨í•˜ì§€ ì•Šì€ Roblox ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì‹  ê²ƒ ê°™ì•„ìš”.";

	/// <summary>
	/// Key: "Response.Under13Email"
	/// If you are under 13 years old, please provide your parent's email address
	/// English String: "If you are under 13 years old, please provide your parent's email address"
	/// </summary>
	public override string ResponseUnder13Email => "ë§Œ 13ì„¸ ë¯¸ë§Œì´ë¼ë©´ ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ ìž…ë ¥í•˜ì„¸ìš”";

	public SupportResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionDialogOK()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionDialogSend()
	{
		return "ë³´ë‚´ê¸°";
	}

	protected override string _GetTemplateForHeadingContactInformation()
	{
		return "ì—°ë½ì²˜ ì •ë³´";
	}

	protected override string _GetTemplateForHeadingDescriptionOfIssue()
	{
		return "ë¬¸ì œ ì„¤ëª…";
	}

	protected override string _GetTemplateForHeadingDeviceWithProblem()
	{
		return "ì–´ë–¤ ê¸°ê¸°ì—ì„œ ë¬¸ì œë¥¼ ê²ªê³  ìžˆë‚˜ìš”?";
	}

	protected override string _GetTemplateForHeadingDialogErrorWithoutContext()
	{
		return "ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForHeadingDialogInvalidUsername()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForHeadingDialogRequestReceived()
	{
		return "ìš”ì²­ ë°›ìŒ";
	}

	protected override string _GetTemplateForHeadingHelpCategoryType()
	{
		return "ë„ì›€ë§ ì¹´í…Œê³ ë¦¬ ìœ í˜•";
	}

	protected override string _GetTemplateForHeadingIssueDetails()
	{
		return "ë¬¸ì œ ì„¤ëª…";
	}

	protected override string _GetTemplateForHeadingPageTitle()
	{
		return "ê³ ê°ì„¼í„°";
	}

	protected override string _GetTemplateForLabelAccountHacked()
	{
		return "ê³„ì • í•´í‚¹";
	}

	protected override string _GetTemplateForLabelAccountOwnership()
	{
		return "ê³„ì • í•´í‚¹ í˜¹ì€ ë¡œê·¸ì¸ ë¶ˆê°€";
	}

	protected override string _GetTemplateForLabelAccountPin()
	{
		return "ê³„ì • PIN";
	}

	protected override string _GetTemplateForLabelAdjustChildSettings()
	{
		return "ìžë…€ ê°œì¸ì •ë³´ ë° ë³´ì•ˆ ì„¤ì • ë³€ê²½";
	}

	protected override string _GetTemplateForLabelAmazonDevice()
	{
		return "Amazon ê¸°ê¸°";
	}

	protected override string _GetTemplateForLabelAndroidPhone()
	{
		return "Android í°";
	}

	protected override string _GetTemplateForLabelAndroidTablet()
	{
		return "Android íƒœë¸”ë¦¿";
	}

	protected override string _GetTemplateForLabelAppealAccountContent()
	{
		return "ê³„ì • ë˜ëŠ” ì½˜í…ì¸  ê´€ë ¨ íƒ„ì›";
	}

	protected override string _GetTemplateForLabelAppealFriend()
	{
		return "ì¹œêµ¬ ê´€ë ¨ íƒ„ì›";
	}

	protected override string _GetTemplateForLabelBilling()
	{
		return "ì²­êµ¬ ë° ê²°ì œ";
	}

	protected override string _GetTemplateForLabelBugReport()
	{
		return "ë²„ê·¸ ì‹ ê³ ";
	}

	protected override string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected override string _GetTemplateForLabelCancelMembership()
	{
		return "ë©¤ë²„ì‹­ ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelCannotInstall()
	{
		return "Roblox ë˜ëŠ” Studio ì„¤ì¹˜ ë¶ˆê°€";
	}

	protected override string _GetTemplateForLabelCannotPlayGame()
	{
		return "ê²Œìž„ í”Œë ˆì´ ë¶ˆê°€";
	}

	protected override string _GetTemplateForLabelChangeChildAge()
	{
		return "ìžë…€ ë‚˜ì´ ë³€ê²½";
	}

	protected override string _GetTemplateForLabelChatAgeSettings()
	{
		return "ì±„íŒ… ë° ë‚˜ì´ ì„¤ì •";
	}

	protected override string _GetTemplateForLabelChromebook()
	{
		return "Chromebook";
	}

	protected override string _GetTemplateForLabelConfirmEmail()
	{
		return "ì´ë©”ì¼ ì£¼ì†Œ í™•ì¸";
	}

	protected override string _GetTemplateForLabelContentAbuseReport()
	{
		return "ê·œì¹™ ìœ„ë°˜ ì½˜í…ì¸  ì‹ ê³ ";
	}

	protected override string _GetTemplateForLabelContest()
	{
		return "ì½˜í…ŒìŠ¤íŠ¸ ë° ì´ë²¤íŠ¸";
	}

	protected override string _GetTemplateForLabelContestEventQuestion()
	{
		return "ì§ˆë¬¸ ë˜ëŠ” ë¬¸ì œ";
	}

	protected override string _GetTemplateForLabelCSCharacter()
	{
		return "ê³ ê°ì§€ì› ìºë¦­í„°";
	}

	protected override string _GetTemplateForLabelDescribeIssue()
	{
		return "ë¬¸ì œë¥¼ ì„¤ëª…í•´ì£¼ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelDevEx()
	{
		return "DevEx";
	}

	protected override string _GetTemplateForLabelDevExHowTo()
	{
		return "DexEx ì‚¬ìš©ë²•";
	}

	protected override string _GetTemplateForLabelDevExMyRequest()
	{
		return "DevEx ë‚´ ìš”ì²­";
	}

	protected override string _GetTemplateForLabelDMCA()
	{
		return "DMCA";
	}

	protected override string _GetTemplateForLabelEmailAddress()
	{
		return "ì´ë©”ì¼ ì£¼ì†Œ";
	}

	protected override string _GetTemplateForLabelExploitReport()
	{
		return "ì•…ìš© ì‹ ê³ ";
	}

	protected override string _GetTemplateForLabelFirstName()
	{
		return "ì´ë¦„";
	}

	protected override string _GetTemplateForLabelForgotPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸ ë¶„ì‹¤";
	}

	protected override string _GetTemplateForLabelFreeRobux()
	{
		return "ë¬´ë£Œ Robux";
	}

	protected override string _GetTemplateForLabelGameCredit()
	{
		return "ê²Œìž„ì¹´ë“œ";
	}

	protected override string _GetTemplateForLabelGCPartialPayment()
	{
		return "êµ¬ë§¤ - í• ë¶€";
	}

	protected override string _GetTemplateForLabelGCRedeem()
	{
		return "ê²Œìž„ì¹´ë“œ - ì‚¬ìš©";
	}

	protected override string _GetTemplateForLabelGCSpendCredit()
	{
		return "ê²Œìž„ì¹´ë“œ - í¬ë ˆë”§ ì‚¬ìš©";
	}

	protected override string _GetTemplateForLabelHowTo()
	{
		return "ì‚¬ìš©ë²•";
	}

	protected override string _GetTemplateForLabelHowToGeneral()
	{
		return "ì‚¬ìš©ë²• - ì¼ë°˜";
	}

	protected override string _GetTemplateForLabelHowToOther()
	{
		return "ì‚¬ìš©ë²• - ê¸°íƒ€";
	}

	protected override string _GetTemplateForLabelIdeasSuggestions()
	{
		return "ì•„ì´ë””ì–´ ë° ì œì•ˆ";
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
		return "ì–´ë–¤ ë¬¸ì œë¥¼ ê²ªê³  ìžˆëŠ”ì§€ ìžì„¸ížˆ ì ì–´ì£¼ì„¸ìš”. ë¬¸ì œê°€ ë°œìƒí•œ ìœ„ì¹˜ë‚˜ ì˜¤ë¥˜ ë©”ì‹œì§€ë¥¼ ë¹„ë¡¯í•œ ê´€ë ¨ ì •ë³´ë¥¼ ë¬´ì—‡ì´ë“  ê¸°ìž¬í•´ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelIWasScammed()
	{
		return "ì‹ ìš© ì‚¬ê¸°";
	}

	protected override string _GetTemplateForLabelMac()
	{
		return "Mac";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "ë©¤ë²„ì‹­";
	}

	protected override string _GetTemplateForLabelModeration()
	{
		return "ê²€ì—´";
	}

	protected override string _GetTemplateForLabelOtherSiteClaim()
	{
		return "ê¸°íƒ€ ì‚¬ì´íŠ¸ í´ë ˆìž„";
	}

	protected override string _GetTemplateForLabelOwnerDMCAClaim()
	{
		return "ì†Œìœ ìž DMCA í´ë ˆìž„";
	}

	protected override string _GetTemplateForLabelPC()
	{
		return "PC";
	}

	protected override string _GetTemplateForLabelPhysicalToyIssue()
	{
		return "ì‹¤ë¬¼ ìž¥ë‚œê° ë¬¸ì œ";
	}

	protected override string _GetTemplateForLabelPleaseSelect()
	{
		return "ì„ íƒ...";
	}

	protected override string _GetTemplateForLabelPrizeNotReceived()
	{
		return "ìƒí’ˆ ë°›ì§€ ì•ŠìŒ";
	}

	protected override string _GetTemplateForLabelPurchaseDeclined()
	{
		return "êµ¬ë§¤ - ê±°ì ˆë¨";
	}

	protected override string _GetTemplateForLabelPurchaseDidNotReceive()
	{
		return "êµ¬ë§¤ - ìˆ˜ë ¹í•˜ì§€ ì•ŠìŒ";
	}

	protected override string _GetTemplateForLabelPurchaseUnauthorizedCharge()
	{
		return "êµ¬ë§¤ - ìŠ¹ì¸ë˜ì§€ ì•Šì€ ì²­êµ¬";
	}

	protected override string _GetTemplateForLabelReportPhish()
	{
		return "í”¼ì‹± ì‚¬ì´íŠ¸ ì‹ ê³ ";
	}

	protected override string _GetTemplateForLabelRobloxCrashing()
	{
		return "Roblox ì¶©ëŒ";
	}

	protected override string _GetTemplateForLabelRobloxToys()
	{
		return "Roblox ìž¥ë‚œê°";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelRobuxPurchaseIssue()
	{
		return "Robux - êµ¬ë§¤ ë¬¸ì œ";
	}

	protected override string _GetTemplateForLabelSafetyInquiry()
	{
		return "ë¶€ì ì ˆí•œ ê²Œìž„ ë˜ëŠ” ì‚¬ìš©ìž í–‰ë™";
	}

	protected override string _GetTemplateForLabelSafetyQueueTicket()
	{
		return "ì‚¬ìš©ìž ë³´ì•ˆ ë¬¸ì œ";
	}

	protected override string _GetTemplateForLabelSpecificGameIssue()
	{
		return "íŠ¹ì • ê²Œìž„ ë¬¸ì œ";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForLabelSuggestFeature()
	{
		return "ê¸°ëŠ¥ ì œì•ˆ";
	}

	protected override string _GetTemplateForLabelSuggestFeedback()
	{
		return "í”¼ë“œë°±";
	}

	protected override string _GetTemplateForLabelTechnicalSupport()
	{
		return "ê¸°ìˆ  ì§€ì›";
	}

	protected override string _GetTemplateForLabelToyCodeIssue()
	{
		return "ìž¥ë‚œê° ì½”ë“œ ë¬¸ì œ";
	}

	protected override string _GetTemplateForLabelTwoStepV()
	{
		return "2ë‹¨ê³„ ì¸ì¦";
	}

	protected override string _GetTemplateForLabelUserAbuseReport()
	{
		return "ê·œì¹™ ìœ„ë°˜ ì‚¬ìš©ìž ì‹ ê³ ";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForLabelVCCatalog()
	{
		return "ì›¹ì‚¬ì´íŠ¸ ì•„ì´í…œ";
	}

	protected override string _GetTemplateForLabelVCInGame()
	{
		return "ê²Œìž„ ë‚´ ì•„ì´í…œ";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForResponseDialogErrorWithoutContext()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogInvalidUsername()
	{
		return "ë³´ë‚´ê¸°ë¥¼ ëˆŒëŸ¬ í‹°ì¼“ì„ ì œì¶œí•˜ê±°ë‚˜ ì·¨ì†Œë¥¼ ëˆŒëŸ¬ ì‚¬ìš©ìž ì´ë¦„ì„ íŽ¸ì§‘í•˜ì„¸ìš”. ì‚¬ìš©ìž ì´ë¦„ì€ ë¬¸ì œë¥¼ ì¡°ì†ížˆ í•´ê²°í•˜ëŠ” ë° ë„ì›€ì´ ë  ìˆ˜ ìžˆëŠ” ë§¤ìš° ì¤‘ìš”í•œ ì •ë³´ëžë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseDialogRequestReceived()
	{
		return "Robloxì— ì—°ë½í•´ì£¼ì…”ì„œ ê°ì‚¬í•©ë‹ˆë‹¤. ê³ ê°ì§€ì› ì´ë©”ì¼ì„ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogTooManyAttemptsError()
	{
		return "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogTryAgainError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseEmailFormatError()
	{
		return "ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì˜¬ë°”ë¥¸ í˜•ì‹ìœ¼ë¡œ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseEmailNotMatching()
	{
		return "ì´ë©”ì¼ ì£¼ì†Œê°€ ì¼ì¹˜í•˜ì§€ ì•Šì•„ìš”";
	}

	protected override string _GetTemplateForResponseInvalidFirstName()
	{
		return "ìœ íš¨í•œ ì´ë¦„(ì„± ì œì™¸)ì„ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseInvalidUsername()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ Roblox ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì‹  ê²ƒ ê°™ì•„ìš”.";
	}

	protected override string _GetTemplateForResponseUnder13Email()
	{
		return "ë§Œ 13ì„¸ ë¯¸ë§Œì´ë¼ë©´ ë³´í˜¸ìž ì´ë©”ì¼ ì£¼ì†Œë¥¼ ìž…ë ¥í•˜ì„¸ìš”";
	}
}


}
