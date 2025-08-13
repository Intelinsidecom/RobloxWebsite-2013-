namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ReportAbuseResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReportAbuseResources_zh_cjv : ReportAbuseResources_en_us, IReportAbuseResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "关闭";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "报告滥用行为";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "提交";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "评论（可选）...";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "报告滥用行为";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "谢谢！";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "查看所有规则";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "不遵守规则的用户最初会收到警告，但如果屡教不改，我们将会禁止他们再来 Roblox。只有这样，我们才能确保 Roblox 的趣味性与安全性。";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "欺凌、骚扰、仇恨言论";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "欺凌、骚扰、歧视";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "内容不当 - 游戏场景、图像、模型";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "约会";

	public override string LabelCategoryInappropriate => "言语不当 - 脏话和成人内容";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "其他违规行为";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "询问或提供私人信息";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "外挂、欺骗、诈骗";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "帐户盗窃 - 网络钓鱼、破解、交易";

	public override string LabelCategoryThreats => "现实生活中的生命威胁或自杀威胁";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "评论：";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "删除帖子（和所有回复）";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "保持帖子不变";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "成人内容";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "广告";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "骚扰";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "不当";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "无";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "隐私";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "脏话";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "诈骗";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "垃圾邮件";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "未分类轻微";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "注意：删除此帖会同时删除回复。如果你选择清除或删除此帖，本次举报会跳过滥用行为队列，直接进入用户队列。";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "你需要启用 JavaScript 才能查看此视频。";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "不确定你要举报的内容是否的确违反规则？";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "隐私政策";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "理由";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "禁止骂脏话";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "禁止帐户共享或交易";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "禁止约会 - 不得询问是否可以做男/女朋友";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "禁止询问对方关于现实生活中的信息 - 不得询问电话号码或电子邮件地址";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "下面列举部分 Roblox 的基本规则以供参考：";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Roblox 安全。";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "清除正文";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "清除主题和正文";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "查看社区规则";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "请选择类别";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "选择任意不当媒体：";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "为你的过滤动作选择原因：";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "主题：";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "一个或多个必要参数缺失或无效";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "加载举报类别发生问题。";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "提交你的举报时发生问题。";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "此页面发生问题";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "你的举报已发送。";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "谢谢你的举报。我们将进一步确认举报事项是否违反使用条款。要了解更多信息，请前往 ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "此帐户权限不足";

	public ReportAbuseResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "报告滥用行为";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "评论（可选）...";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "报告滥用行为";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "谢谢！";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "查看所有规则";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "不遵守规则的用户最初会收到警告，但如果屡教不改，我们将会禁止他们再来 Roblox。只有这样，我们才能确保 Roblox 的趣味性与安全性。";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "欺凌、骚扰、仇恨言论";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "欺凌、骚扰、歧视";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "内容不当 - 游戏场景、图像、模型";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "约会";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "言语不当 - 脏话和成人内容";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "其他违规行为";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "询问或提供私人信息";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "外挂、欺骗、诈骗";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "帐户盗窃 - 网络钓鱼、破解、交易";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "现实生活中的生命威胁或自杀威胁";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "评论：";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "删除帖子（和所有回复）";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "保持帖子不变";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "成人内容";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "广告";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "骚扰";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "不当";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "无";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "隐私";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "脏话";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "诈骗";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "垃圾邮件";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "未分类轻微";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "注意：删除此帖会同时删除回复。如果你选择清除或删除此帖，本次举报会跳过滥用行为队列，直接进入用户队列。";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "你需要启用 JavaScript 才能查看此视频。";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "不确定你要举报的内容是否的确违反规则？";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "隐私政策";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "理由";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "禁止骂脏话";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "禁止帐户共享或交易";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "禁止约会 - 不得询问是否可以做男/女朋友";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "禁止询问对方关于现实生活中的信息 - 不得询问电话号码或电子邮件地址";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "下面列举部分 Roblox 的基本规则以供参考：";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Roblox 安全。";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "清除正文";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "清除主题和正文";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "查看社区规则";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "请选择类别";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "选择任意不当媒体：";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "为你的过滤动作选择原因：";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "主题：";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"告诉我们你认为“{creatorName}”违反 Roblox 规则的理由。";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "告诉我们你认为“{creatorName}”违反 Roblox 规则的理由。";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "一个或多个必要参数缺失或无效";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "加载举报类别发生问题。";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "提交你的举报时发生问题。";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "此页面发生问题";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "你的举报已发送。";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "谢谢你的举报。我们将进一步确认举报事项是否违反使用条款。要了解更多信息，请前往 ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "此帐户权限不足";
	}
}
