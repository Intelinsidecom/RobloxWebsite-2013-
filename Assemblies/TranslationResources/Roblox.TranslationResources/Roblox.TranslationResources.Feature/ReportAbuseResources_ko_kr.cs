namespace Roblox.TranslationResources.Feature;

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
	public override string ActionClose => "닫기";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "신고하기";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "저장";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "입력하세요 (선택)…";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "신고하기";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "고마워요!";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "전체 규칙을 확인하세요.";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "규칙을 준수하지 않을 시 경고를 받게 되며 이후에도 문제가 계속되면 Roblox 이용이 중단될 수도 있습니다. 이는 즐겁고 안전한 Roblox를 만들기 위한 저희의 방침이예요.";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "괴롭힘, 희롱, 혐오 발언";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "괴롭힘, 희롱, 차별";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "부적절한 콘텐츠: 장소, 이미지, 모델";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "이성 교제";

	public override string LabelCategoryInappropriate => "부적절한 언어 - 비속어 및 성인 콘텐츠";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "기타 규정 위반";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "개인 정보 제공 요청";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "악용, 사기, 신용 범죄";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "계정 절도: 피싱, 해킹, 계정 매매";

	public override string LabelCategoryThreats => "신변 위협 및 자살 위협";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "신고 사유:";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "게시물 삭제 (답변 포함)";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "게시물 변경 취소";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "성인 콘텐츠";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "광고";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "희롱";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "부적절한";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "없음";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "개인정보";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "비속어";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "신용 범죄";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "스팸";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "경미한 미분류 위반";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "참고: 본 게시물을 삭제하면 답변도 함께 삭제됩니다. 게시물을 지우거나 삭제하면 본 신고는 해당 대기열을 건너뛰고 사용자 대기열로 곧장 이동합니다.";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "본 동영상을 시청하려면 JavaScript를 활성화해야 합니다.";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "신고하려는 대상이 정말 규칙 위반인지 확실하지 않나요?";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "개인정보 처리방침";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "이유";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "욕설 사용 금지";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "계정 공유 혹은 거래 금지";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "이성 교제 금지 - 애인 구하기 금지";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "사생활 관련 질문 금지 - 전화번호 또는 이메일 주소 요청 금지";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "Roblox 기본 규칙 예시:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Roblox 안전을 확인하세요.";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "본문 삭제";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "제목 및 본문 삭제";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "커뮤니티 규칙 보기";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "카테고리를 선택하세요";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "부적절한 미디어 선택:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "검열 요청 이유 선택:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "제목:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "하나 이상의 필수적인 매개변수가 존재하지 않거나 유효하지 않습니다";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "신고 카테고리를 불러오는 중 오류가 발생했어요.";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "신고를 전송하는 중 오류가 발생했어요.";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "페이지에 오류가 발생했어요";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "회원님의 신고가 전송되었습니다.";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "신고해 주셔서 감사해요. 이용 약관 위반이 있었는지 확인하기 위해 더 살펴보도록 할게요. 자세한 내용은 ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "본 계정은 권한이 충분하지 않습니다";

	public ReportAbuseResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "저장";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "입력하세요 (선택)…";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "고마워요!";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "전체 규칙을 확인하세요.";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "규칙을 준수하지 않을 시 경고를 받게 되며 이후에도 문제가 계속되면 Roblox 이용이 중단될 수도 있습니다. 이는 즐겁고 안전한 Roblox를 만들기 위한 저희의 방침이예요.";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "괴롭힘, 희롱, 혐오 발언";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "괴롭힘, 희롱, 차별";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "부적절한 콘텐츠: 장소, 이미지, 모델";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "이성 교제";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "부적절한 언어 - 비속어 및 성인 콘텐츠";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "기타 규정 위반";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "개인 정보 제공 요청";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "악용, 사기, 신용 범죄";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "계정 절도: 피싱, 해킹, 계정 매매";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "신변 위협 및 자살 위협";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "신고 사유:";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "게시물 삭제 (답변 포함)";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "게시물 변경 취소";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "성인 콘텐츠";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "광고";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "희롱";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "부적절한";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "없음";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "개인정보";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "비속어";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "신용 범죄";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "스팸";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "경미한 미분류 위반";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "참고: 본 게시물을 삭제하면 답변도 함께 삭제됩니다. 게시물을 지우거나 삭제하면 본 신고는 해당 대기열을 건너뛰고 사용자 대기열로 곧장 이동합니다.";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "본 동영상을 시청하려면 JavaScript를 활성화해야 합니다.";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "신고하려는 대상이 정말 규칙 위반인지 확실하지 않나요?";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "개인정보 처리방침";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "이유";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "욕설 사용 금지";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "계정 공유 혹은 거래 금지";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "이성 교제 금지 - 애인 구하기 금지";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "사생활 관련 질문 금지 - 전화번호 또는 이메일 주소 요청 금지";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "Roblox 기본 규칙 예시:";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Roblox 안전을 확인하세요.";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "본문 삭제";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "제목 및 본문 삭제";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "커뮤니티 규칙 보기";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "카테고리를 선택하세요";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "부적절한 미디어 선택:";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "검열 요청 이유 선택:";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "제목:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"{creatorName}님이 Roblox 규정을 위반했다고 생각하시는 이유는 무엇인가요?";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "{creatorName}님이 Roblox 규정을 위반했다고 생각하시는 이유는 무엇인가요?";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "하나 이상의 필수적인 매개변수가 존재하지 않거나 유효하지 않습니다";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "신고 카테고리를 불러오는 중 오류가 발생했어요.";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "신고를 전송하는 중 오류가 발생했어요.";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "페이지에 오류가 발생했어요";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "회원님의 신고가 전송되었습니다.";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "신고해 주셔서 감사해요. 이용 약관 위반이 있었는지 확인하기 위해 더 살펴보도록 할게요. 자세한 내용은 ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "본 계정은 권한이 충분하지 않습니다";
	}
}
