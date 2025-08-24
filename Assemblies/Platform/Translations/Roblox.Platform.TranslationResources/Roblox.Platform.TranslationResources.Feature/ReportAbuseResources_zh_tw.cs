namespace Roblox.TranslationResources.Feature;

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
	public override string ActionClose => "關閉";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "檢舉濫用";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "提交";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "留言（可省略）…";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "檢舉濫用";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "謝謝！";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "查看所有規則。";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "違反規則的使用者會先收到警告，但若該使用者持續違反規則，我們可能會為了維護 Roblox 而將其永久停權。";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "霸凌、騷擾、仇恨言論";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "霸凌、騷擾、歧視";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "內容不當：空間、圖像、模型";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "約會";

	public override string LabelCategoryInappropriate => "言語不當：髒話及成人內容";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "其它違規行為";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "索取或提供私人資訊";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "剝削、欺騙、詐騙";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "帳號盜竊：網路釣魚、駭客、交易";

	public override string LabelCategoryThreats => "生命或自殺威脅";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "詳情：";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "刪除貼文（及所有回覆）";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "不變更貼文";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "成人內容";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "廣告";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "騷擾";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "不當";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "無";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "隱私權";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "髒話";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "詐騙";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "垃圾郵件";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "未分類輕微";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "注意：刪除此貼文也會刪除回覆。若您選擇清除或刪除此貼文，此檢舉報告會跳過濫用佇列，直接進入使用者佇列。";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "若要觀看此影片，請先啟用 JavaScript。";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "不確定您舉報的事項是否違反規則？";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "隱私權政策";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "原因";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "禁止髒話";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "不可共用或交換帳號";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "禁止約會、禁止找男女朋友";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "禁止詢問彼此的現實生活狀況、禁止向他人索取電話號碼或電子郵件地址";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "以下是 Roblox 的一些基本規則：";

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
	public override string LabelScrubBody => "清除本文";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "清除主旨與本文";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "檢視社群規則";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "請選擇類別";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "選擇不當媒體：";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "選擇您執行此過濾動作的原因：";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "類別：";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "欠缺參數或參數無效";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "載入檢舉類別時發生問題。";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "提交檢舉時發生問題。";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "此網頁發生問題";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "檢舉已送出。";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "謝謝您的舉報，我們會進一步確認舉報事項是否違反使用條款。若要取得更多資訊，請前往";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "此帳號權限不足";

	public ReportAbuseResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "關閉";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "檢舉濫用";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "留言（可省略）…";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "檢舉濫用";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "謝謝！";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "查看所有規則。";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "違反規則的使用者會先收到警告，但若該使用者持續違反規則，我們可能會為了維護 Roblox 而將其永久停權。";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "霸凌、騷擾、仇恨言論";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "霸凌、騷擾、歧視";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "內容不當：空間、圖像、模型";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "約會";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "言語不當：髒話及成人內容";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "其它違規行為";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "索取或提供私人資訊";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "剝削、欺騙、詐騙";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "帳號盜竊：網路釣魚、駭客、交易";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "生命或自殺威脅";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "詳情：";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "刪除貼文（及所有回覆）";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "不變更貼文";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "成人內容";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "廣告";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "騷擾";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "不當";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "無";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "隱私權";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "髒話";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "詐騙";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "垃圾郵件";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "未分類輕微";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "注意：刪除此貼文也會刪除回覆。若您選擇清除或刪除此貼文，此檢舉報告會跳過濫用佇列，直接進入使用者佇列。";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "若要觀看此影片，請先啟用 JavaScript。";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "不確定您舉報的事項是否違反規則？";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "隱私權政策";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "原因";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "禁止髒話";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "不可共用或交換帳號";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "禁止約會、禁止找男女朋友";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "禁止詢問彼此的現實生活狀況、禁止向他人索取電話號碼或電子郵件地址";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "以下是 Roblox 的一些基本規則：";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Roblox 安全。";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "清除本文";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "清除主旨與本文";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "檢視社群規則";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "請選擇類別";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "選擇不當媒體：";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "選擇您執行此過濾動作的原因：";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "類別：";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"請告訴我們您認為 {creatorName} 違反 Roblox 規則的原因。";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "請告訴我們您認為 {creatorName} 違反 Roblox 規則的原因。";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "欠缺參數或參數無效";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "載入檢舉類別時發生問題。";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "提交檢舉時發生問題。";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "此網頁發生問題";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "檢舉已送出。";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "謝謝您的舉報，我們會進一步確認舉報事項是否違反使用條款。若要取得更多資訊，請前往";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "此帳號權限不足";
	}
}
