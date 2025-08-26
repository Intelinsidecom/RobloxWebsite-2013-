namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ReportAbuseResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReportAbuseResources_ko_kr : ReportAbuseResources_en_us, IReportAbuseResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "ë‹«ê¸°";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ì €ìž¥";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "ìž…ë ¥í•˜ì„¸ìš” (ì„ íƒ)â€¦";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "ê³ ë§ˆì›Œìš”!";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "ì „ì²´ ê·œì¹™ì„ í™•ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "ê·œì¹™ì„ ì¤€ìˆ˜í•˜ì§€ ì•Šì„ ì‹œ ê²½ê³ ë¥¼ ë°›ê²Œ ë˜ë©° ì´í›„ì—ë„ ë¬¸ì œê°€ ê³„ì†ë˜ë©´ Roblox ì´ìš©ì´ ì¤‘ë‹¨ë  ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. ì´ëŠ” ì¦ê²ê³  ì•ˆì „í•œ Robloxë¥¼ ë§Œë“¤ê¸° ìœ„í•œ ì €í¬ì˜ ë°©ì¹¨ì´ì˜ˆìš”.";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "ê´´ë¡­íž˜, í¬ë¡±, í˜ì˜¤ ë°œì–¸";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "ê´´ë¡­íž˜, í¬ë¡±, ì°¨ë³„";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "ë¶€ì ì ˆí•œ ì½˜í…ì¸ : ìž¥ì†Œ, ì´ë¯¸ì§€, ëª¨ë¸";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "ì´ì„± êµì œ";

	public override string LabelCategoryInappropriate => "ë¶€ì ì ˆí•œ ì–¸ì–´ - ë¹„ì†ì–´ ë° ì„±ì¸ ì½˜í…ì¸ ";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "ê¸°íƒ€ ê·œì • ìœ„ë°˜";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "ê°œì¸ ì •ë³´ ì œê³µ ìš”ì²­";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "ì•…ìš©, ì‚¬ê¸°, ì‹ ìš© ë²”ì£„";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "ê³„ì • ì ˆë„: í”¼ì‹±, í•´í‚¹, ê³„ì • ë§¤ë§¤";

	public override string LabelCategoryThreats => "ì‹ ë³€ ìœ„í˜‘ ë° ìžì‚´ ìœ„í˜‘";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "ì‹ ê³  ì‚¬ìœ :";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "ê²Œì‹œë¬¼ ì‚­ì œ (ë‹µë³€ í¬í•¨)";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "ê²Œì‹œë¬¼ ë³€ê²½ ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "ì„±ì¸ ì½˜í…ì¸ ";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "ê´‘ê³ ";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "í¬ë¡±";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "ë¶€ì ì ˆí•œ";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "ì—†ìŒ";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "ê°œì¸ì •ë³´";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "ë¹„ì†ì–´";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "ì‹ ìš© ë²”ì£„";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "ìŠ¤íŒ¸";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "ê²½ë¯¸í•œ ë¯¸ë¶„ë¥˜ ìœ„ë°˜";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "ì°¸ê³ : ë³¸ ê²Œì‹œë¬¼ì„ ì‚­ì œí•˜ë©´ ë‹µë³€ë„ í•¨ê»˜ ì‚­ì œë©ë‹ˆë‹¤. ê²Œì‹œë¬¼ì„ ì§€ìš°ê±°ë‚˜ ì‚­ì œí•˜ë©´ ë³¸ ì‹ ê³ ëŠ” í•´ë‹¹ ëŒ€ê¸°ì—´ì„ ê±´ë„ˆë›°ê³  ì‚¬ìš©ìž ëŒ€ê¸°ì—´ë¡œ ê³§ìž¥ ì´ë™í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "ë³¸ ë™ì˜ìƒì„ ì‹œì²­í•˜ë ¤ë©´ JavaScriptë¥¼ í™œì„±í™”í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "ì‹ ê³ í•˜ë ¤ëŠ” ëŒ€ìƒì´ ì •ë§ ê·œì¹™ ìœ„ë°˜ì¸ì§€ í™•ì‹¤í•˜ì§€ ì•Šë‚˜ìš”?";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "ì´ìœ ";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "ìš•ì„¤ ì‚¬ìš© ê¸ˆì§€";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "ê³„ì • ê³µìœ  í˜¹ì€ ê±°ëž˜ ê¸ˆì§€";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "ì´ì„± êµì œ ê¸ˆì§€ - ì• ì¸ êµ¬í•˜ê¸° ê¸ˆì§€";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "ì‚¬ìƒí™œ ê´€ë ¨ ì§ˆë¬¸ ê¸ˆì§€ - ì „í™”ë²ˆí˜¸ ë˜ëŠ” ì´ë©”ì¼ ì£¼ì†Œ ìš”ì²­ ê¸ˆì§€";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "Roblox ê¸°ë³¸ ê·œì¹™ ì˜ˆì‹œ:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Roblox ì•ˆì „ì„ í™•ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "ë³¸ë¬¸ ì‚­ì œ";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "ì œëª© ë° ë³¸ë¬¸ ì‚­ì œ";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "ì»¤ë®¤ë‹ˆí‹° ê·œì¹™ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "ì¹´í…Œê³ ë¦¬ë¥¼ ì„ íƒí•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "ë¶€ì ì ˆí•œ ë¯¸ë””ì–´ ì„ íƒ:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "ê²€ì—´ ìš”ì²­ ì´ìœ  ì„ íƒ:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "ì œëª©:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "í•˜ë‚˜ ì´ìƒì˜ í•„ìˆ˜ì ì¸ ë§¤ê°œë³€ìˆ˜ê°€ ì¡´ìž¬í•˜ì§€ ì•Šê±°ë‚˜ ìœ íš¨í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "ì‹ ê³  ì¹´í…Œê³ ë¦¬ë¥¼ ë¶ˆëŸ¬ì˜¤ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "ì‹ ê³ ë¥¼ ì „ì†¡í•˜ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "íŽ˜ì´ì§€ì— ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "íšŒì›ë‹˜ì˜ ì‹ ê³ ê°€ ì „ì†¡ë˜ì—ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "ì‹ ê³ í•´ ì£¼ì…”ì„œ ê°ì‚¬í•´ìš”. ì´ìš© ì•½ê´€ ìœ„ë°˜ì´ ìžˆì—ˆëŠ”ì§€ í™•ì¸í•˜ê¸° ìœ„í•´ ë” ì‚´íŽ´ë³´ë„ë¡ í• ê²Œìš”. ìžì„¸í•œ ë‚´ìš©ì€ ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "ë³¸ ê³„ì •ì€ ê¶Œí•œì´ ì¶©ë¶„í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤";

	public ReportAbuseResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "ë‹«ê¸°";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "ìž…ë ¥í•˜ì„¸ìš” (ì„ íƒ)â€¦";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "ê³ ë§ˆì›Œìš”!";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "ì „ì²´ ê·œì¹™ì„ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "ê·œì¹™ì„ ì¤€ìˆ˜í•˜ì§€ ì•Šì„ ì‹œ ê²½ê³ ë¥¼ ë°›ê²Œ ë˜ë©° ì´í›„ì—ë„ ë¬¸ì œê°€ ê³„ì†ë˜ë©´ Roblox ì´ìš©ì´ ì¤‘ë‹¨ë  ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. ì´ëŠ” ì¦ê²ê³  ì•ˆì „í•œ Robloxë¥¼ ë§Œë“¤ê¸° ìœ„í•œ ì €í¬ì˜ ë°©ì¹¨ì´ì˜ˆìš”.";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "ê´´ë¡­íž˜, í¬ë¡±, í˜ì˜¤ ë°œì–¸";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "ê´´ë¡­íž˜, í¬ë¡±, ì°¨ë³„";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "ë¶€ì ì ˆí•œ ì½˜í…ì¸ : ìž¥ì†Œ, ì´ë¯¸ì§€, ëª¨ë¸";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "ì´ì„± êµì œ";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "ë¶€ì ì ˆí•œ ì–¸ì–´ - ë¹„ì†ì–´ ë° ì„±ì¸ ì½˜í…ì¸ ";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "ê¸°íƒ€ ê·œì • ìœ„ë°˜";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "ê°œì¸ ì •ë³´ ì œê³µ ìš”ì²­";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "ì•…ìš©, ì‚¬ê¸°, ì‹ ìš© ë²”ì£„";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "ê³„ì • ì ˆë„: í”¼ì‹±, í•´í‚¹, ê³„ì • ë§¤ë§¤";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "ì‹ ë³€ ìœ„í˜‘ ë° ìžì‚´ ìœ„í˜‘";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "ì‹ ê³  ì‚¬ìœ :";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "ê²Œì‹œë¬¼ ì‚­ì œ (ë‹µë³€ í¬í•¨)";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "ê²Œì‹œë¬¼ ë³€ê²½ ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "ì„±ì¸ ì½˜í…ì¸ ";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "ê´‘ê³ ";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "í¬ë¡±";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "ë¶€ì ì ˆí•œ";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "ì—†ìŒ";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "ê°œì¸ì •ë³´";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "ë¹„ì†ì–´";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "ì‹ ìš© ë²”ì£„";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "ìŠ¤íŒ¸";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "ê²½ë¯¸í•œ ë¯¸ë¶„ë¥˜ ìœ„ë°˜";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "ì°¸ê³ : ë³¸ ê²Œì‹œë¬¼ì„ ì‚­ì œí•˜ë©´ ë‹µë³€ë„ í•¨ê»˜ ì‚­ì œë©ë‹ˆë‹¤. ê²Œì‹œë¬¼ì„ ì§€ìš°ê±°ë‚˜ ì‚­ì œí•˜ë©´ ë³¸ ì‹ ê³ ëŠ” í•´ë‹¹ ëŒ€ê¸°ì—´ì„ ê±´ë„ˆë›°ê³  ì‚¬ìš©ìž ëŒ€ê¸°ì—´ë¡œ ê³§ìž¥ ì´ë™í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "ë³¸ ë™ì˜ìƒì„ ì‹œì²­í•˜ë ¤ë©´ JavaScriptë¥¼ í™œì„±í™”í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "ì‹ ê³ í•˜ë ¤ëŠ” ëŒ€ìƒì´ ì •ë§ ê·œì¹™ ìœ„ë°˜ì¸ì§€ í™•ì‹¤í•˜ì§€ ì•Šë‚˜ìš”?";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "ì´ìœ ";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "ìš•ì„¤ ì‚¬ìš© ê¸ˆì§€";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "ê³„ì • ê³µìœ  í˜¹ì€ ê±°ëž˜ ê¸ˆì§€";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "ì´ì„± êµì œ ê¸ˆì§€ - ì• ì¸ êµ¬í•˜ê¸° ê¸ˆì§€";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "ì‚¬ìƒí™œ ê´€ë ¨ ì§ˆë¬¸ ê¸ˆì§€ - ì „í™”ë²ˆí˜¸ ë˜ëŠ” ì´ë©”ì¼ ì£¼ì†Œ ìš”ì²­ ê¸ˆì§€";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "Roblox ê¸°ë³¸ ê·œì¹™ ì˜ˆì‹œ:";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Roblox ì•ˆì „ì„ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "ë³¸ë¬¸ ì‚­ì œ";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "ì œëª© ë° ë³¸ë¬¸ ì‚­ì œ";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "ì»¤ë®¤ë‹ˆí‹° ê·œì¹™ ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "ì¹´í…Œê³ ë¦¬ë¥¼ ì„ íƒí•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "ë¶€ì ì ˆí•œ ë¯¸ë””ì–´ ì„ íƒ:";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "ê²€ì—´ ìš”ì²­ ì´ìœ  ì„ íƒ:";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "ì œëª©:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"{creatorName}ë‹˜ì´ Roblox ê·œì •ì„ ìœ„ë°˜í–ˆë‹¤ê³  ìƒê°í•˜ì‹œëŠ” ì´ìœ ëŠ” ë¬´ì—‡ì¸ê°€ìš”?";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "{creatorName}ë‹˜ì´ Roblox ê·œì •ì„ ìœ„ë°˜í–ˆë‹¤ê³  ìƒê°í•˜ì‹œëŠ” ì´ìœ ëŠ” ë¬´ì—‡ì¸ê°€ìš”?";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "í•˜ë‚˜ ì´ìƒì˜ í•„ìˆ˜ì ì¸ ë§¤ê°œë³€ìˆ˜ê°€ ì¡´ìž¬í•˜ì§€ ì•Šê±°ë‚˜ ìœ íš¨í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "ì‹ ê³  ì¹´í…Œê³ ë¦¬ë¥¼ ë¶ˆëŸ¬ì˜¤ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "ì‹ ê³ ë¥¼ ì „ì†¡í•˜ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "íŽ˜ì´ì§€ì— ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "íšŒì›ë‹˜ì˜ ì‹ ê³ ê°€ ì „ì†¡ë˜ì—ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "ì‹ ê³ í•´ ì£¼ì…”ì„œ ê°ì‚¬í•´ìš”. ì´ìš© ì•½ê´€ ìœ„ë°˜ì´ ìžˆì—ˆëŠ”ì§€ í™•ì¸í•˜ê¸° ìœ„í•´ ë” ì‚´íŽ´ë³´ë„ë¡ í• ê²Œìš”. ìžì„¸í•œ ë‚´ìš©ì€ ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "ë³¸ ê³„ì •ì€ ê¶Œí•œì´ ì¶©ë¶„í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤";
	}
}


}
