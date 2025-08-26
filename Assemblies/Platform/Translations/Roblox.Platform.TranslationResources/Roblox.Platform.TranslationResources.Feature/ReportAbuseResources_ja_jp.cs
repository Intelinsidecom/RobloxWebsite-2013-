namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ReportAbuseResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReportAbuseResources_ja_jp : ReportAbuseResources_en_us, IReportAbuseResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é–‰ã˜ã‚‹";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "è¦ç´„é•åã‚’å ±å‘Š";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "é€ä¿¡ã™ã‚‹";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "ã‚³ãƒ¡ãƒ³ãƒˆï¼ˆã‚ªãƒ—ã‚·ãƒ§ãƒ³ï¼‰...";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "è¦ç´„é•åã‚’å ±å‘Š";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "ã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™ï¼";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "ã™ã¹ã¦ã®ãƒ«ãƒ¼ãƒ«ã‚’è¦‹ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "ãƒ«ãƒ¼ãƒ«ã«å¾“ã‚ãªã„ãƒ¦ãƒ¼ã‚¶ãƒ¼ã«ã¯ã€ã¾ãšè­¦å‘Šã‚’ä¸Žãˆã¾ã™ãŒã€ãã‚Œã§ã‚‚ãƒ«ãƒ¼ãƒ«é•åãŒç¶šãã‚ˆã†ã§ã‚ã‚Œã°ã€Robloxã‹ã‚‰æŠœã‘ã¦ã„ãŸã ãã‚ˆã†ãŠé¡˜ã„ã™ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚ãã†ã™ã‚‹ã“ã¨ã§ã€Robloxã‚’æ¥½ã—ãå®‰å…¨ã«ä¿ã¤ã“ã¨ãŒã§ãã¾ã™ï¼";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "ã„ã˜ã‚ã€å«ŒãŒã‚‰ã›ã€ãƒ˜ã‚¤ãƒˆã‚¹ãƒ”ãƒ¼ãƒ";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "ã„ã˜ã‚ã€å«ŒãŒã‚‰ã›ã€å·®åˆ¥";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "ä¸é©åˆ‡ãªã‚³ãƒ³ãƒ†ãƒ³ãƒ„ - ãƒ—ãƒ¬ãƒ¼ã‚¹ã€ç”»åƒã€ãƒ¢ãƒ‡ãƒ«";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "æ‹æ„›é–¢ä¿‚";

	public override string LabelCategoryInappropriate => "ä¸é©åˆ‡ãªè¨€è‘‰ - æš´è¨€ã€ã‚¢ãƒ€ãƒ«ãƒˆã‚³ãƒ³ãƒ†ãƒ³ãƒ„";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "ãã®ä»–ã®ãƒ«ãƒ¼ãƒ«é•å";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "å€‹äººæƒ…å ±ã®è¦æ±‚ã¾ãŸã¯æä¾›";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "ä¸æ­£è¡Œç‚ºã€ãƒãƒ¼ãƒˆè¡Œç‚ºã€è©æ¬º";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆçªƒç›— - ãƒ•ã‚£ãƒƒã‚·ãƒ³ã‚°ã€ãƒãƒƒã‚­ãƒ³ã‚°ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆå£²è²·";

	public override string LabelCategoryThreats => "ãƒªã‚¢ãƒ«ã§ã®è„…è¿«ã€è‡ªæ®ºäºˆå‘Š";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "ã‚³ãƒ¡ãƒ³ãƒˆ:";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "æŠ•ç¨¿ï¼ˆãŠã‚ˆã³ã™ã¹ã¦ã®è¿”ä¿¡ï¼‰ã‚’å‰Šé™¤ã™ã‚‹";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "æŠ•ç¨¿ã‚’å¤‰æ›´ã—ãªã„";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "ã‚¢ãƒ€ãƒ«ãƒˆã‚³ãƒ³ãƒ†ãƒ³ãƒ„";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "å®£ä¼";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "å«ŒãŒã‚‰ã›";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "ä¸é©åˆ‡";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "ãªã—";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "æš´è¨€";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "è©æ¬º";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "ã‚¹ãƒ‘ãƒ ";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "æœªåˆ†é¡žã€æ¨™æº–";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "ã”æ³¨æ„: ã“ã®æŠ•ç¨¿ã‚’å‰Šé™¤ã™ã‚‹ã¨ã€è¿”ä¿¡ã‚‚å‰Šé™¤ã•ã‚Œã¾ã™ã€‚æŠ•ç¨¿ã®å–ã‚Šæ¶ˆã—ã‚„å‰Šé™¤ã‚’è¡Œã£ãŸå ´åˆã€ã“ã®ãƒ¬ãƒãƒ¼ãƒˆã¯è¦ç´„é•åã‚­ãƒ¥ãƒ¼ã‚’ã‚¹ã‚­ãƒƒãƒ—ã—ã¦ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ã‚­ãƒ¥ãƒ¼ã«é€ã‚‰ã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "ã“ã®ãƒ“ãƒ‡ã‚ªã‚’è¦‹ã‚‹ã«ã¯ã€JavaScriptã‚’æœ‰åŠ¹ã«ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "å ±å‘Šã—ã‚ˆã†ã¨ã—ã¦ã„ã‚‹å†…å®¹ãŒæœ¬å½“ã«ãƒ«ãƒ¼ãƒ«é•åã‹ã©ã†ã‹åˆ¤æ–­ã§ããªã„å ´åˆã€‚";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "ç†ç”±";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "æ±šã„è¨€è‘‰ã®ä½¿ç”¨ç¦æ­¢";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å…±æœ‰ã‚„å£²è²·ã®ç¦æ­¢";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "æ‹æ„›é–¢ä¿‚ã®ç¦æ­¢ - æ‹äººå‹Ÿé›†ã®ç¦æ­¢";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "å€‹äººæƒ…å ±ã®è¦æ±‚ã‚’ç¦æ­¢ - é›»è©±ç•ªå·ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èžãã“ã¨ã‚’ç¦æ­¢";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "Robloxã®åŸºæœ¬ãƒ«ãƒ¼ãƒ«ã«ã¯æ¬¡ã®ã‚ˆã†ãªã‚‚ã®ãŒã‚ã‚Šã¾ã™:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Robloxã®å®‰å…¨å¯¾ç­–";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "æœ¬æ–‡ã‚’å–ã‚Šæ¶ˆã™";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "ä»¶åã¨æœ¬æ–‡ã‚’å–ã‚Šæ¶ˆã™";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "ã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã®ãƒ«ãƒ¼ãƒ«ã‚’è¦‹ã‚‹";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "ã‚«ãƒ†ã‚´ãƒªã‚’é¸æŠžã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "ä¸é©åˆ‡ãªãƒ¡ãƒ‡ã‚£ã‚¢ã‚’é¸æŠž:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "è¦åˆ¶å¯¾è±¡ã¨ãªã‚‹ç†ç”±ã‚’é¸æŠžã—ã¦ãã ã•ã„:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "ä»¶å:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "å¿…è¦ãªãƒ‘ãƒ©ãƒ¡ãƒ¼ã‚¿ã®ä¸€éƒ¨ã¾ãŸã¯å…¨éƒ¨ãŒä¸è¶³ã€ã¾ãŸã¯ç„¡åŠ¹ã§ã™";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "ãƒ¬ãƒãƒ¼ãƒˆã‚«ãƒ†ã‚´ãƒªã®èª­ã¿è¾¼ã¿ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "ãƒ¬ãƒãƒ¼ãƒˆã®é€ä¿¡ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "ãƒšãƒ¼ã‚¸ã«å•é¡ŒãŒã‚ã‚Šã¾ã™";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "ãƒ¬ãƒãƒ¼ãƒˆã‚’é€ä¿¡ã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "ã”å ±å‘Šã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™ã€‚åˆ©ç”¨è¦ç´„é•åãŒã‚ã£ãŸã‹ã©ã†ã‹ã‚’åˆ¤å®šã™ã‚‹èª¿æŸ»ã‚’ã—ã¾ã™ã€‚è©³ã—ãã¯ä»¥ä¸‹ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚ ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "ã“ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã¯ã€æ¨©é™ãŒä¸è¶³ã—ã¦ã„ã¾ã™";

	public ReportAbuseResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é–‰ã˜ã‚‹";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "è¦ç´„é•åã‚’å ±å‘Š";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "é€ä¿¡ã™ã‚‹";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆï¼ˆã‚ªãƒ—ã‚·ãƒ§ãƒ³ï¼‰...";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "è¦ç´„é•åã‚’å ±å‘Š";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "ã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "ã™ã¹ã¦ã®ãƒ«ãƒ¼ãƒ«ã‚’è¦‹ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "ãƒ«ãƒ¼ãƒ«ã«å¾“ã‚ãªã„ãƒ¦ãƒ¼ã‚¶ãƒ¼ã«ã¯ã€ã¾ãšè­¦å‘Šã‚’ä¸Žãˆã¾ã™ãŒã€ãã‚Œã§ã‚‚ãƒ«ãƒ¼ãƒ«é•åãŒç¶šãã‚ˆã†ã§ã‚ã‚Œã°ã€Robloxã‹ã‚‰æŠœã‘ã¦ã„ãŸã ãã‚ˆã†ãŠé¡˜ã„ã™ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚ãã†ã™ã‚‹ã“ã¨ã§ã€Robloxã‚’æ¥½ã—ãå®‰å…¨ã«ä¿ã¤ã“ã¨ãŒã§ãã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "ã„ã˜ã‚ã€å«ŒãŒã‚‰ã›ã€ãƒ˜ã‚¤ãƒˆã‚¹ãƒ”ãƒ¼ãƒ";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "ã„ã˜ã‚ã€å«ŒãŒã‚‰ã›ã€å·®åˆ¥";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "ä¸é©åˆ‡ãªã‚³ãƒ³ãƒ†ãƒ³ãƒ„ - ãƒ—ãƒ¬ãƒ¼ã‚¹ã€ç”»åƒã€ãƒ¢ãƒ‡ãƒ«";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "æ‹æ„›é–¢ä¿‚";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "ä¸é©åˆ‡ãªè¨€è‘‰ - æš´è¨€ã€ã‚¢ãƒ€ãƒ«ãƒˆã‚³ãƒ³ãƒ†ãƒ³ãƒ„";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "ãã®ä»–ã®ãƒ«ãƒ¼ãƒ«é•å";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "å€‹äººæƒ…å ±ã®è¦æ±‚ã¾ãŸã¯æä¾›";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "ä¸æ­£è¡Œç‚ºã€ãƒãƒ¼ãƒˆè¡Œç‚ºã€è©æ¬º";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆçªƒç›— - ãƒ•ã‚£ãƒƒã‚·ãƒ³ã‚°ã€ãƒãƒƒã‚­ãƒ³ã‚°ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆå£²è²·";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "ãƒªã‚¢ãƒ«ã§ã®è„…è¿«ã€è‡ªæ®ºäºˆå‘Š";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆ:";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "æŠ•ç¨¿ï¼ˆãŠã‚ˆã³ã™ã¹ã¦ã®è¿”ä¿¡ï¼‰ã‚’å‰Šé™¤ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "æŠ•ç¨¿ã‚’å¤‰æ›´ã—ãªã„";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "ã‚¢ãƒ€ãƒ«ãƒˆã‚³ãƒ³ãƒ†ãƒ³ãƒ„";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "å®£ä¼";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "å«ŒãŒã‚‰ã›";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "ä¸é©åˆ‡";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "ãªã—";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "æš´è¨€";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "è©æ¬º";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "ã‚¹ãƒ‘ãƒ ";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "æœªåˆ†é¡žã€æ¨™æº–";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "ã”æ³¨æ„: ã“ã®æŠ•ç¨¿ã‚’å‰Šé™¤ã™ã‚‹ã¨ã€è¿”ä¿¡ã‚‚å‰Šé™¤ã•ã‚Œã¾ã™ã€‚æŠ•ç¨¿ã®å–ã‚Šæ¶ˆã—ã‚„å‰Šé™¤ã‚’è¡Œã£ãŸå ´åˆã€ã“ã®ãƒ¬ãƒãƒ¼ãƒˆã¯è¦ç´„é•åã‚­ãƒ¥ãƒ¼ã‚’ã‚¹ã‚­ãƒƒãƒ—ã—ã¦ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ã‚­ãƒ¥ãƒ¼ã«é€ã‚‰ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "ã“ã®ãƒ“ãƒ‡ã‚ªã‚’è¦‹ã‚‹ã«ã¯ã€JavaScriptã‚’æœ‰åŠ¹ã«ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "å ±å‘Šã—ã‚ˆã†ã¨ã—ã¦ã„ã‚‹å†…å®¹ãŒæœ¬å½“ã«ãƒ«ãƒ¼ãƒ«é•åã‹ã©ã†ã‹åˆ¤æ–­ã§ããªã„å ´åˆã€‚";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "ç†ç”±";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "æ±šã„è¨€è‘‰ã®ä½¿ç”¨ç¦æ­¢";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å…±æœ‰ã‚„å£²è²·ã®ç¦æ­¢";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "æ‹æ„›é–¢ä¿‚ã®ç¦æ­¢ - æ‹äººå‹Ÿé›†ã®ç¦æ­¢";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "å€‹äººæƒ…å ±ã®è¦æ±‚ã‚’ç¦æ­¢ - é›»è©±ç•ªå·ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èžãã“ã¨ã‚’ç¦æ­¢";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "Robloxã®åŸºæœ¬ãƒ«ãƒ¼ãƒ«ã«ã¯æ¬¡ã®ã‚ˆã†ãªã‚‚ã®ãŒã‚ã‚Šã¾ã™:";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Robloxã®å®‰å…¨å¯¾ç­–";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "æœ¬æ–‡ã‚’å–ã‚Šæ¶ˆã™";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "ä»¶åã¨æœ¬æ–‡ã‚’å–ã‚Šæ¶ˆã™";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "ã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã®ãƒ«ãƒ¼ãƒ«ã‚’è¦‹ã‚‹";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "ã‚«ãƒ†ã‚´ãƒªã‚’é¸æŠžã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "ä¸é©åˆ‡ãªãƒ¡ãƒ‡ã‚£ã‚¢ã‚’é¸æŠž:";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "è¦åˆ¶å¯¾è±¡ã¨ãªã‚‹ç†ç”±ã‚’é¸æŠžã—ã¦ãã ã•ã„:";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "ä»¶å:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"{creatorName}ã•ã‚“ãŒã€ã©ã®ã‚ˆã†ã«Robloxã®ãƒ«ãƒ¼ãƒ«é•åã‚’ã—ã¦ã„ã‚‹ã‹ãŠçŸ¥ã‚‰ã›ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "{creatorName}ã•ã‚“ãŒã€ã©ã®ã‚ˆã†ã«Robloxã®ãƒ«ãƒ¼ãƒ«é•åã‚’ã—ã¦ã„ã‚‹ã‹ãŠçŸ¥ã‚‰ã›ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "å¿…è¦ãªãƒ‘ãƒ©ãƒ¡ãƒ¼ã‚¿ã®ä¸€éƒ¨ã¾ãŸã¯å…¨éƒ¨ãŒä¸è¶³ã€ã¾ãŸã¯ç„¡åŠ¹ã§ã™";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "ãƒ¬ãƒãƒ¼ãƒˆã‚«ãƒ†ã‚´ãƒªã®èª­ã¿è¾¼ã¿ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "ãƒ¬ãƒãƒ¼ãƒˆã®é€ä¿¡ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "ãƒšãƒ¼ã‚¸ã«å•é¡ŒãŒã‚ã‚Šã¾ã™";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "ãƒ¬ãƒãƒ¼ãƒˆã‚’é€ä¿¡ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "ã”å ±å‘Šã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™ã€‚åˆ©ç”¨è¦ç´„é•åãŒã‚ã£ãŸã‹ã©ã†ã‹ã‚’åˆ¤å®šã™ã‚‹èª¿æŸ»ã‚’ã—ã¾ã™ã€‚è©³ã—ãã¯ä»¥ä¸‹ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚ ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "ã“ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã¯ã€æ¨©é™ãŒä¸è¶³ã—ã¦ã„ã¾ã™";
	}
}


}
