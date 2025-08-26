namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ReportAbuseResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReportAbuseResources_zh_tw : ReportAbuseResources_en_us, IReportAbuseResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é—œé–‰";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "æª¢èˆ‰æ¿«ç”¨";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "æäº¤";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "ç•™è¨€ï¼ˆå¯çœç•¥ï¼‰â€¦";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "æª¢èˆ‰æ¿«ç”¨";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "è¬è¬ï¼";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "æŸ¥çœ‹æ‰€æœ‰è¦å‰‡ã€‚";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "é•åè¦å‰‡çš„ä½¿ç”¨è€…æœƒå…ˆæ”¶åˆ°è­¦å‘Šï¼Œä½†è‹¥è©²ä½¿ç”¨è€…æŒçºŒé•åè¦å‰‡ï¼Œæˆ‘å€‘å¯èƒ½æœƒç‚ºäº†ç¶­è­· Roblox è€Œå°‡å…¶æ°¸ä¹…åœæ¬Šã€‚";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "éœ¸å‡Œã€é¨·æ“¾ã€ä»‡æ¨è¨€è«–";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "éœ¸å‡Œã€é¨·æ“¾ã€æ­§è¦–";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "å…§å®¹ä¸ç•¶ï¼šç©ºé–“ã€åœ–åƒã€æ¨¡åž‹";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "ç´„æœƒ";

	public override string LabelCategoryInappropriate => "è¨€èªžä¸ç•¶ï¼šé«’è©±åŠæˆäººå…§å®¹";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "å…¶å®ƒé•è¦è¡Œç‚º";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "ç´¢å–æˆ–æä¾›ç§äººè³‡è¨Š";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "å‰å‰Šã€æ¬ºé¨™ã€è©é¨™";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "å¸³è™Ÿç›œç«Šï¼šç¶²è·¯é‡£é­šã€é§­å®¢ã€äº¤æ˜“";

	public override string LabelCategoryThreats => "ç”Ÿå‘½æˆ–è‡ªæ®ºå¨è„…";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "è©³æƒ…ï¼š";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "åˆªé™¤è²¼æ–‡ï¼ˆåŠæ‰€æœ‰å›žè¦†ï¼‰";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "ä¸è®Šæ›´è²¼æ–‡";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "æˆäººå…§å®¹";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "å»£å‘Š";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "é¨·æ“¾";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "ä¸ç•¶";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "ç„¡";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "éš±ç§æ¬Š";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "é«’è©±";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "è©é¨™";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "åžƒåœ¾éƒµä»¶";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "æœªåˆ†é¡žè¼•å¾®";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "æ³¨æ„ï¼šåˆªé™¤æ­¤è²¼æ–‡ä¹Ÿæœƒåˆªé™¤å›žè¦†ã€‚è‹¥æ‚¨é¸æ“‡æ¸…é™¤æˆ–åˆªé™¤æ­¤è²¼æ–‡ï¼Œæ­¤æª¢èˆ‰å ±å‘Šæœƒè·³éŽæ¿«ç”¨ä½‡åˆ—ï¼Œç›´æŽ¥é€²å…¥ä½¿ç”¨è€…ä½‡åˆ—ã€‚";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "è‹¥è¦è§€çœ‹æ­¤å½±ç‰‡ï¼Œè«‹å…ˆå•Ÿç”¨ JavaScriptã€‚";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "ä¸ç¢ºå®šæ‚¨èˆ‰å ±çš„äº‹é …æ˜¯å¦é•åè¦å‰‡ï¼Ÿ";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "éš±ç§æ¬Šæ”¿ç­–";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "åŽŸå› ";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "ç¦æ­¢é«’è©±";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "ä¸å¯å…±ç”¨æˆ–äº¤æ›å¸³è™Ÿ";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "ç¦æ­¢ç´„æœƒã€ç¦æ­¢æ‰¾ç”·å¥³æœ‹å‹";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "ç¦æ­¢è©¢å•å½¼æ­¤çš„ç¾å¯¦ç”Ÿæ´»ç‹€æ³ã€ç¦æ­¢å‘ä»–äººç´¢å–é›»è©±è™Ÿç¢¼æˆ–é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "ä»¥ä¸‹æ˜¯ Roblox çš„ä¸€äº›åŸºæœ¬è¦å‰‡ï¼š";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Roblox å®‰å…¨ã€‚";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "æ¸…é™¤æœ¬æ–‡";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "æ¸…é™¤ä¸»æ—¨èˆ‡æœ¬æ–‡";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "æª¢è¦–ç¤¾ç¾¤è¦å‰‡";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "è«‹é¸æ“‡é¡žåˆ¥";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "é¸æ“‡ä¸ç•¶åª’é«”ï¼š";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "é¸æ“‡æ‚¨åŸ·è¡Œæ­¤éŽæ¿¾å‹•ä½œçš„åŽŸå› ï¼š";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "é¡žåˆ¥ï¼š";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "æ¬ ç¼ºåƒæ•¸æˆ–åƒæ•¸ç„¡æ•ˆ";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "è¼‰å…¥æª¢èˆ‰é¡žåˆ¥æ™‚ç™¼ç”Ÿå•é¡Œã€‚";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "æäº¤æª¢èˆ‰æ™‚ç™¼ç”Ÿå•é¡Œã€‚";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "æ­¤ç¶²é ç™¼ç”Ÿå•é¡Œ";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "æª¢èˆ‰å·²é€å‡ºã€‚";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "è¬è¬æ‚¨çš„èˆ‰å ±ï¼Œæˆ‘å€‘æœƒé€²ä¸€æ­¥ç¢ºèªèˆ‰å ±äº‹é …æ˜¯å¦é•åä½¿ç”¨æ¢æ¬¾ã€‚è‹¥è¦å–å¾—æ›´å¤šè³‡è¨Šï¼Œè«‹å‰å¾€";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "æ­¤å¸³è™Ÿæ¬Šé™ä¸è¶³";

	public ReportAbuseResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "æª¢èˆ‰æ¿«ç”¨";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "ç•™è¨€ï¼ˆå¯çœç•¥ï¼‰â€¦";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "æª¢èˆ‰æ¿«ç”¨";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "è¬è¬ï¼";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "æŸ¥çœ‹æ‰€æœ‰è¦å‰‡ã€‚";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "é•åè¦å‰‡çš„ä½¿ç”¨è€…æœƒå…ˆæ”¶åˆ°è­¦å‘Šï¼Œä½†è‹¥è©²ä½¿ç”¨è€…æŒçºŒé•åè¦å‰‡ï¼Œæˆ‘å€‘å¯èƒ½æœƒç‚ºäº†ç¶­è­· Roblox è€Œå°‡å…¶æ°¸ä¹…åœæ¬Šã€‚";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "éœ¸å‡Œã€é¨·æ“¾ã€ä»‡æ¨è¨€è«–";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "éœ¸å‡Œã€é¨·æ“¾ã€æ­§è¦–";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "å…§å®¹ä¸ç•¶ï¼šç©ºé–“ã€åœ–åƒã€æ¨¡åž‹";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "ç´„æœƒ";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "è¨€èªžä¸ç•¶ï¼šé«’è©±åŠæˆäººå…§å®¹";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "å…¶å®ƒé•è¦è¡Œç‚º";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "ç´¢å–æˆ–æä¾›ç§äººè³‡è¨Š";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "å‰å‰Šã€æ¬ºé¨™ã€è©é¨™";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "å¸³è™Ÿç›œç«Šï¼šç¶²è·¯é‡£é­šã€é§­å®¢ã€äº¤æ˜“";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "ç”Ÿå‘½æˆ–è‡ªæ®ºå¨è„…";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "è©³æƒ…ï¼š";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "åˆªé™¤è²¼æ–‡ï¼ˆåŠæ‰€æœ‰å›žè¦†ï¼‰";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "ä¸è®Šæ›´è²¼æ–‡";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "æˆäººå…§å®¹";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "å»£å‘Š";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "é¨·æ“¾";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "ä¸ç•¶";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "ç„¡";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "éš±ç§æ¬Š";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "é«’è©±";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "è©é¨™";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "åžƒåœ¾éƒµä»¶";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "æœªåˆ†é¡žè¼•å¾®";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "æ³¨æ„ï¼šåˆªé™¤æ­¤è²¼æ–‡ä¹Ÿæœƒåˆªé™¤å›žè¦†ã€‚è‹¥æ‚¨é¸æ“‡æ¸…é™¤æˆ–åˆªé™¤æ­¤è²¼æ–‡ï¼Œæ­¤æª¢èˆ‰å ±å‘Šæœƒè·³éŽæ¿«ç”¨ä½‡åˆ—ï¼Œç›´æŽ¥é€²å…¥ä½¿ç”¨è€…ä½‡åˆ—ã€‚";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "è‹¥è¦è§€çœ‹æ­¤å½±ç‰‡ï¼Œè«‹å…ˆå•Ÿç”¨ JavaScriptã€‚";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "ä¸ç¢ºå®šæ‚¨èˆ‰å ±çš„äº‹é …æ˜¯å¦é•åè¦å‰‡ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "éš±ç§æ¬Šæ”¿ç­–";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "åŽŸå› ";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "ç¦æ­¢é«’è©±";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "ä¸å¯å…±ç”¨æˆ–äº¤æ›å¸³è™Ÿ";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "ç¦æ­¢ç´„æœƒã€ç¦æ­¢æ‰¾ç”·å¥³æœ‹å‹";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "ç¦æ­¢è©¢å•å½¼æ­¤çš„ç¾å¯¦ç”Ÿæ´»ç‹€æ³ã€ç¦æ­¢å‘ä»–äººç´¢å–é›»è©±è™Ÿç¢¼æˆ–é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "ä»¥ä¸‹æ˜¯ Roblox çš„ä¸€äº›åŸºæœ¬è¦å‰‡ï¼š";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Roblox å®‰å…¨ã€‚";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "æ¸…é™¤æœ¬æ–‡";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "æ¸…é™¤ä¸»æ—¨èˆ‡æœ¬æ–‡";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "æª¢è¦–ç¤¾ç¾¤è¦å‰‡";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "è«‹é¸æ“‡é¡žåˆ¥";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "é¸æ“‡ä¸ç•¶åª’é«”ï¼š";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "é¸æ“‡æ‚¨åŸ·è¡Œæ­¤éŽæ¿¾å‹•ä½œçš„åŽŸå› ï¼š";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "é¡žåˆ¥ï¼š";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"è«‹å‘Šè¨´æˆ‘å€‘æ‚¨èªç‚º {creatorName} é•å Roblox è¦å‰‡çš„åŽŸå› ã€‚";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "è«‹å‘Šè¨´æˆ‘å€‘æ‚¨èªç‚º {creatorName} é•å Roblox è¦å‰‡çš„åŽŸå› ã€‚";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "æ¬ ç¼ºåƒæ•¸æˆ–åƒæ•¸ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "è¼‰å…¥æª¢èˆ‰é¡žåˆ¥æ™‚ç™¼ç”Ÿå•é¡Œã€‚";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "æäº¤æª¢èˆ‰æ™‚ç™¼ç”Ÿå•é¡Œã€‚";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "æ­¤ç¶²é ç™¼ç”Ÿå•é¡Œ";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "æª¢èˆ‰å·²é€å‡ºã€‚";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "è¬è¬æ‚¨çš„èˆ‰å ±ï¼Œæˆ‘å€‘æœƒé€²ä¸€æ­¥ç¢ºèªèˆ‰å ±äº‹é …æ˜¯å¦é•åä½¿ç”¨æ¢æ¬¾ã€‚è‹¥è¦å–å¾—æ›´å¤šè³‡è¨Šï¼Œè«‹å‰å¾€";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "æ­¤å¸³è™Ÿæ¬Šé™ä¸è¶³";
	}
}


}
