namespace Roblox.TranslationResources.Feature;

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
	public override string ActionDialogCancel => "취소";

	/// <summary>
	/// Key: "Action.Dialog.OK"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOK => "확인";

	/// <summary>
	/// Key: "Action.Dialog.Send"
	/// Send
	/// English String: "Send"
	/// </summary>
	public override string ActionDialogSend => "보내기";

	/// <summary>
	/// Key: "Heading.ContactInformation"
	/// Contact Information
	/// English String: "Contact Information"
	/// </summary>
	public override string HeadingContactInformation => "연락처 정보";

	/// <summary>
	/// Key: "Heading.DescriptionOfIssue"
	/// Description of issue
	/// English String: "Description of issue"
	/// </summary>
	public override string HeadingDescriptionOfIssue => "문제 설명";

	/// <summary>
	/// Key: "Heading.DeviceWithProblem"
	/// What device are you having the problem on?
	/// English String: "What device are you having the problem on?"
	/// </summary>
	public override string HeadingDeviceWithProblem => "어떤 기기에서 문제를 겪고 있나요?";

	/// <summary>
	/// Key: "Heading.Dialog.ErrorWithoutContext"
	/// Error
	/// English String: "Error"
	/// </summary>
	public override string HeadingDialogErrorWithoutContext => "오류";

	/// <summary>
	/// Key: "Heading.Dialog.InvalidUsername"
	/// Invalid Username
	/// English String: "Invalid Username"
	/// </summary>
	public override string HeadingDialogInvalidUsername => "유효하지 않은 사용자 이름";

	/// <summary>
	/// Key: "Heading.Dialog.RequestReceived"
	/// Request Received
	/// English String: "Request Received"
	/// </summary>
	public override string HeadingDialogRequestReceived => "요청 받음";

	/// <summary>
	/// Key: "Heading.HelpCategoryType"
	/// Type of help category
	/// English String: "Type of help category"
	/// </summary>
	public override string HeadingHelpCategoryType => "도움말 카테고리 유형";

	/// <summary>
	/// Key: "Heading.IssueDetails"
	/// Issue Details
	/// English String: "Issue Details"
	/// </summary>
	public override string HeadingIssueDetails => "문제 설명";

	/// <summary>
	/// Key: "Heading.PageTitle"
	/// Contact Us
	/// English String: "Contact Us"
	/// </summary>
	public override string HeadingPageTitle => "고객센터";

	/// <summary>
	/// Key: "Label.AccountHacked"
	/// Account Hacked
	/// English String: "Account Hacked"
	/// </summary>
	public override string LabelAccountHacked => "계정 해킹";

	/// <summary>
	/// Key: "Label.AccountOwnership"
	/// Account Hacked or Can't Log in
	/// English String: "Account Hacked or Can't Log in"
	/// </summary>
	public override string LabelAccountOwnership => "계정 해킹 혹은 로그인 불가";

	/// <summary>
	/// Key: "Label.AccountPin"
	/// Account PIN
	/// English String: "Account PIN"
	/// </summary>
	public override string LabelAccountPin => "계정 PIN";

	public override string LabelAdjustChildSettings => "자녀 개인정보 및 보안 설정 변경";

	/// <summary>
	/// Key: "Label.AmazonDevice"
	/// Amazon Device
	/// English String: "Amazon Device"
	/// </summary>
	public override string LabelAmazonDevice => "Amazon 기기";

	/// <summary>
	/// Key: "Label.AndroidPhone"
	/// Android Phone
	/// English String: "Android Phone"
	/// </summary>
	public override string LabelAndroidPhone => "Android 폰";

	/// <summary>
	/// Key: "Label.AndroidTablet"
	/// Android Tablet
	/// English String: "Android Tablet"
	/// </summary>
	public override string LabelAndroidTablet => "Android 태블릿";

	/// <summary>
	/// Key: "Label.AppealAccountContent"
	/// Appeal Account or Content
	/// English String: "Appeal Account or Content"
	/// </summary>
	public override string LabelAppealAccountContent => "계정 또는 콘텐츠 관련 탄원";

	/// <summary>
	/// Key: "Label.AppealFriend"
	/// Appeal for Friend
	/// English String: "Appeal for Friend"
	/// </summary>
	public override string LabelAppealFriend => "친구 관련 탄원";

	public override string LabelBilling => "청구 및 결제";

	/// <summary>
	/// Key: "Label.BugReport"
	/// Bug Report
	/// English String: "Bug Report"
	/// </summary>
	public override string LabelBugReport => "버그 신고";

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
	public override string LabelCancelMembership => "멤버십 취소";

	/// <summary>
	/// Key: "Label.CannotInstall"
	/// Cannot Install Roblox or Studio
	/// English String: "Cannot Install Roblox or Studio"
	/// </summary>
	public override string LabelCannotInstall => "Roblox 또는 Studio 설치 불가";

	/// <summary>
	/// Key: "Label.CannotPlayGame"
	/// Cannot Play Game
	/// English String: "Cannot Play Game"
	/// </summary>
	public override string LabelCannotPlayGame => "게임 플레이 불가";

	/// <summary>
	/// Key: "Label.ChangeChildAge"
	/// Change Child Age
	/// English String: "Change Child Age"
	/// </summary>
	public override string LabelChangeChildAge => "자녀 나이 변경";

	public override string LabelChatAgeSettings => "채팅 및 나이 설정";

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
	public override string LabelConfirmEmail => "이메일 주소 확인";

	/// <summary>
	/// Key: "Label.ContentAbuseReport"
	/// Report Content Breaking Rules
	/// English String: "Report Content Breaking Rules"
	/// </summary>
	public override string LabelContentAbuseReport => "규칙 위반 콘텐츠 신고";

	public override string LabelContest => "콘테스트 및 이벤트";

	/// <summary>
	/// Key: "Label.ContestEventQuestion"
	/// Question or Issue
	/// English String: "Question or Issue"
	/// </summary>
	public override string LabelContestEventQuestion => "질문 또는 문제";

	/// <summary>
	/// Key: "Label.CSCharacter"
	/// Customer Service Character
	/// English String: "Customer Service Character"
	/// </summary>
	public override string LabelCSCharacter => "고객지원 캐릭터";

	/// <summary>
	/// Key: "Label.DescribeIssue"
	/// Please describe your issue
	/// English String: "Please describe your issue"
	/// </summary>
	public override string LabelDescribeIssue => "문제를 설명해주세요";

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
	public override string LabelDevExHowTo => "DexEx 사용법";

	/// <summary>
	/// Key: "Label.DevExMyRequest"
	/// DevEx My Request
	/// English String: "DevEx My Request"
	/// </summary>
	public override string LabelDevExMyRequest => "DevEx 내 요청";

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
	public override string LabelEmailAddress => "이메일 주소";

	/// <summary>
	/// Key: "Label.ExploitReport"
	/// Exploit Report
	/// English String: "Exploit Report"
	/// </summary>
	public override string LabelExploitReport => "악용 신고";

	/// <summary>
	/// Key: "Label.FirstName"
	/// First Name
	/// English String: "First Name"
	/// </summary>
	public override string LabelFirstName => "이름";

	/// <summary>
	/// Key: "Label.ForgotPassword"
	/// Forgot Password
	/// English String: "Forgot Password"
	/// </summary>
	public override string LabelForgotPassword => "비밀번호 분실";

	/// <summary>
	/// Key: "Label.FreeRobux"
	/// Free Robux
	/// English String: "Free Robux"
	/// </summary>
	public override string LabelFreeRobux => "무료 Robux";

	/// <summary>
	/// Key: "Label.GameCredit"
	/// Game Card
	/// English String: "Game Card"
	/// </summary>
	public override string LabelGameCredit => "게임카드";

	/// <summary>
	/// Key: "Label.GCPartialPayment"
	/// Purchase - Split Payment
	/// English String: "Purchase - Split Payment"
	/// </summary>
	public override string LabelGCPartialPayment => "구매 - 할부";

	/// <summary>
	/// Key: "Label.GCRedeem"
	/// Game Card - Redeem
	/// English String: "Game Card - Redeem"
	/// </summary>
	public override string LabelGCRedeem => "게임카드 - 사용";

	/// <summary>
	/// Key: "Label.GCSpendCredit"
	/// Game Card - Spend Credit
	/// English String: "Game Card - Spend Credit"
	/// </summary>
	public override string LabelGCSpendCredit => "게임카드 - 크레딧 사용";

	/// <summary>
	/// Key: "Label.HowTo"
	/// How To
	/// English String: "How To"
	/// </summary>
	public override string LabelHowTo => "사용법";

	/// <summary>
	/// Key: "Label.HowToGeneral"
	/// How To - General
	/// English String: "How To - General"
	/// </summary>
	public override string LabelHowToGeneral => "사용법 - 일반";

	/// <summary>
	/// Key: "Label.HowToOther"
	/// How To - Other
	/// English String: "How To - Other"
	/// </summary>
	public override string LabelHowToOther => "사용법 - 기타";

	public override string LabelIdeasSuggestions => "아이디어 및 제안";

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
	public override string LabelIssueDescription => "어떤 문제를 겪고 있는지 자세히 적어주세요. 문제가 발생한 위치나 오류 메시지를 비롯한 관련 정보를 무엇이든 기재해주세요.";

	/// <summary>
	/// Key: "Label.IWasScammed"
	/// I was Scammed
	/// English String: "I was Scammed"
	/// </summary>
	public override string LabelIWasScammed => "신용 사기";

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
	public override string LabelMembership => "멤버십";

	/// <summary>
	/// Key: "Label.Moderation"
	/// Moderation
	/// English String: "Moderation"
	/// </summary>
	public override string LabelModeration => "검열";

	/// <summary>
	/// Key: "Label.OtherSiteClaim"
	/// Other Site Claim
	/// English String: "Other Site Claim"
	/// </summary>
	public override string LabelOtherSiteClaim => "기타 사이트 클레임";

	/// <summary>
	/// Key: "Label.OwnerDMCAClaim"
	/// Owner DMCA Claim
	/// English String: "Owner DMCA Claim"
	/// </summary>
	public override string LabelOwnerDMCAClaim => "소유자 DMCA 클레임";

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
	public override string LabelPhysicalToyIssue => "실물 장난감 문제";

	/// <summary>
	/// Key: "Label.PleaseSelect"
	/// Please Select...
	/// English String: "Please Select..."
	/// </summary>
	public override string LabelPleaseSelect => "선택...";

	/// <summary>
	/// Key: "Label.PrizeNotReceived"
	/// Prize Not Received
	/// English String: "Prize Not Received"
	/// </summary>
	public override string LabelPrizeNotReceived => "상품 받지 않음";

	/// <summary>
	/// Key: "Label.PurchaseDeclined"
	/// Purchase - Declined
	/// English String: "Purchase - Declined"
	/// </summary>
	public override string LabelPurchaseDeclined => "구매 - 거절됨";

	/// <summary>
	/// Key: "Label.PurchaseDidNotReceive"
	/// Purchase - Did Not Receive
	/// English String: "Purchase - Did Not Receive"
	/// </summary>
	public override string LabelPurchaseDidNotReceive => "구매 - 수령하지 않음";

	/// <summary>
	/// Key: "Label.PurchaseUnauthorizedCharge"
	/// Purchase - Unauthorized Charge
	/// English String: "Purchase - Unauthorized Charge"
	/// </summary>
	public override string LabelPurchaseUnauthorizedCharge => "구매 - 승인되지 않은 청구";

	/// <summary>
	/// Key: "Label.ReportPhish"
	/// Report Phishing Site
	/// English String: "Report Phishing Site"
	/// </summary>
	public override string LabelReportPhish => "피싱 사이트 신고";

	/// <summary>
	/// Key: "Label.RobloxCrashing"
	/// Roblox Crashing
	/// English String: "Roblox Crashing"
	/// </summary>
	public override string LabelRobloxCrashing => "Roblox 충돌";

	/// <summary>
	/// Key: "Label.RobloxToys"
	/// Roblox Toys
	/// English String: "Roblox Toys"
	/// </summary>
	public override string LabelRobloxToys => "Roblox 장난감";

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
	public override string LabelRobuxPurchaseIssue => "Robux - 구매 문제";

	/// <summary>
	/// Key: "Label.SafetyInquiry"
	/// Inappropriate game or user behavior
	/// English String: "Inappropriate game or user behavior"
	/// </summary>
	public override string LabelSafetyInquiry => "부적절한 게임 또는 사용자 행동";

	/// <summary>
	/// Key: "Label.SafetyQueueTicket"
	/// User Safety Concern
	/// English String: "User Safety Concern"
	/// </summary>
	public override string LabelSafetyQueueTicket => "사용자 보안 문제";

	/// <summary>
	/// Key: "Label.SpecificGameIssue"
	/// Specific Game Issue
	/// English String: "Specific Game Issue"
	/// </summary>
	public override string LabelSpecificGameIssue => "특정 게임 문제";

	/// <summary>
	/// Key: "Label.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "저장";

	/// <summary>
	/// Key: "Label.SuggestFeature"
	/// Feature Suggestion
	/// English String: "Feature Suggestion"
	/// </summary>
	public override string LabelSuggestFeature => "기능 제안";

	/// <summary>
	/// Key: "Label.SuggestFeedback"
	/// Feedback
	/// English String: "Feedback"
	/// </summary>
	public override string LabelSuggestFeedback => "피드백";

	/// <summary>
	/// Key: "Label.TechnicalSupport"
	/// Technical Support
	/// English String: "Technical Support"
	/// </summary>
	public override string LabelTechnicalSupport => "기술 지원";

	/// <summary>
	/// Key: "Label.ToyCodeIssue"
	/// Toy Code Issue
	/// English String: "Toy Code Issue"
	/// </summary>
	public override string LabelToyCodeIssue => "장난감 코드 문제";

	/// <summary>
	/// Key: "Label.TwoStepV"
	/// 2-Step Verification
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepV => "2단계 인증";

	/// <summary>
	/// Key: "Label.UserAbuseReport"
	/// Report User Breaking Rules
	/// English String: "Report User Breaking Rules"
	/// </summary>
	public override string LabelUserAbuseReport => "규칙 위반 사용자 신고";

	/// <summary>
	/// Key: "Label.Username"
	/// Username
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "사용자 이름";

	/// <summary>
	/// Key: "Label.VCCatalog"
	/// Website Item
	/// English String: "Website Item"
	/// </summary>
	public override string LabelVCCatalog => "웹사이트 아이템";

	/// <summary>
	/// Key: "Label.VCInGame"
	/// In-Game Item
	/// English String: "In-Game Item"
	/// </summary>
	public override string LabelVCInGame => "게임 내 아이템";

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
	public override string ResponseDialogErrorWithoutContext => "오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.Dialog.InvalidUsername"
	/// Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.
	/// English String: "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker."
	/// </summary>
	public override string ResponseDialogInvalidUsername => "보내기를 눌러 티켓을 제출하거나 취소를 눌러 사용자 이름을 편집하세요. 사용자 이름은 문제를 조속히 해결하는 데 도움이 될 수 있는 매우 중요한 정보랍니다.";

	/// <summary>
	/// Key: "Response.Dialog.RequestReceived"
	/// Thank you for contacting Roblox. Please check your email for a message from Customer Service.
	/// English String: "Thank you for contacting Roblox. Please check your email for a message from Customer Service."
	/// </summary>
	public override string ResponseDialogRequestReceived => "Roblox에 연락해주셔서 감사합니다. 고객지원 이메일을 확인하세요.";

	/// <summary>
	/// Key: "Response.Dialog.TooManyAttemptsError"
	/// Too many attempts. Try again later.
	/// English String: "Too many attempts. Try again later."
	/// </summary>
	public override string ResponseDialogTooManyAttemptsError => "시도 가능 횟수를 초과했습니다. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.Dialog.TryAgainError"
	/// An error occurred. Try again later.
	/// English String: "An error occurred. Try again later."
	/// </summary>
	public override string ResponseDialogTryAgainError => "오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.EmailFormatError"
	/// Please enter a properly formatted email address
	/// English String: "Please enter a properly formatted email address"
	/// </summary>
	public override string ResponseEmailFormatError => "이메일 주소를 올바른 형식으로 입력하세요";

	/// <summary>
	/// Key: "Response.EmailNotMatching"
	/// Email address does not match
	/// English String: "Email address does not match"
	/// </summary>
	public override string ResponseEmailNotMatching => "이메일 주소가 일치하지 않아요";

	/// <summary>
	/// Key: "Response.InvalidFirstName"
	/// Please enter a valid first name
	/// English String: "Please enter a valid first name"
	/// </summary>
	public override string ResponseInvalidFirstName => "유효한 이름(성 제외)을 입력하세요";

	/// <summary>
	/// Key: "Response.InvalidUsername"
	/// That doesn't appear to be a valid Roblox username.
	/// English String: "That doesn't appear to be a valid Roblox username."
	/// </summary>
	public override string ResponseInvalidUsername => "유효하지 않은 Roblox 사용자 이름을 입력하신 것 같아요.";

	/// <summary>
	/// Key: "Response.Under13Email"
	/// If you are under 13 years old, please provide your parent's email address
	/// English String: "If you are under 13 years old, please provide your parent's email address"
	/// </summary>
	public override string ResponseUnder13Email => "만 13세 미만이라면 보호자 이메일 주소를 입력하세요";

	public SupportResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionDialogOK()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionDialogSend()
	{
		return "보내기";
	}

	protected override string _GetTemplateForHeadingContactInformation()
	{
		return "연락처 정보";
	}

	protected override string _GetTemplateForHeadingDescriptionOfIssue()
	{
		return "문제 설명";
	}

	protected override string _GetTemplateForHeadingDeviceWithProblem()
	{
		return "어떤 기기에서 문제를 겪고 있나요?";
	}

	protected override string _GetTemplateForHeadingDialogErrorWithoutContext()
	{
		return "오류";
	}

	protected override string _GetTemplateForHeadingDialogInvalidUsername()
	{
		return "유효하지 않은 사용자 이름";
	}

	protected override string _GetTemplateForHeadingDialogRequestReceived()
	{
		return "요청 받음";
	}

	protected override string _GetTemplateForHeadingHelpCategoryType()
	{
		return "도움말 카테고리 유형";
	}

	protected override string _GetTemplateForHeadingIssueDetails()
	{
		return "문제 설명";
	}

	protected override string _GetTemplateForHeadingPageTitle()
	{
		return "고객센터";
	}

	protected override string _GetTemplateForLabelAccountHacked()
	{
		return "계정 해킹";
	}

	protected override string _GetTemplateForLabelAccountOwnership()
	{
		return "계정 해킹 혹은 로그인 불가";
	}

	protected override string _GetTemplateForLabelAccountPin()
	{
		return "계정 PIN";
	}

	protected override string _GetTemplateForLabelAdjustChildSettings()
	{
		return "자녀 개인정보 및 보안 설정 변경";
	}

	protected override string _GetTemplateForLabelAmazonDevice()
	{
		return "Amazon 기기";
	}

	protected override string _GetTemplateForLabelAndroidPhone()
	{
		return "Android 폰";
	}

	protected override string _GetTemplateForLabelAndroidTablet()
	{
		return "Android 태블릿";
	}

	protected override string _GetTemplateForLabelAppealAccountContent()
	{
		return "계정 또는 콘텐츠 관련 탄원";
	}

	protected override string _GetTemplateForLabelAppealFriend()
	{
		return "친구 관련 탄원";
	}

	protected override string _GetTemplateForLabelBilling()
	{
		return "청구 및 결제";
	}

	protected override string _GetTemplateForLabelBugReport()
	{
		return "버그 신고";
	}

	protected override string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected override string _GetTemplateForLabelCancelMembership()
	{
		return "멤버십 취소";
	}

	protected override string _GetTemplateForLabelCannotInstall()
	{
		return "Roblox 또는 Studio 설치 불가";
	}

	protected override string _GetTemplateForLabelCannotPlayGame()
	{
		return "게임 플레이 불가";
	}

	protected override string _GetTemplateForLabelChangeChildAge()
	{
		return "자녀 나이 변경";
	}

	protected override string _GetTemplateForLabelChatAgeSettings()
	{
		return "채팅 및 나이 설정";
	}

	protected override string _GetTemplateForLabelChromebook()
	{
		return "Chromebook";
	}

	protected override string _GetTemplateForLabelConfirmEmail()
	{
		return "이메일 주소 확인";
	}

	protected override string _GetTemplateForLabelContentAbuseReport()
	{
		return "규칙 위반 콘텐츠 신고";
	}

	protected override string _GetTemplateForLabelContest()
	{
		return "콘테스트 및 이벤트";
	}

	protected override string _GetTemplateForLabelContestEventQuestion()
	{
		return "질문 또는 문제";
	}

	protected override string _GetTemplateForLabelCSCharacter()
	{
		return "고객지원 캐릭터";
	}

	protected override string _GetTemplateForLabelDescribeIssue()
	{
		return "문제를 설명해주세요";
	}

	protected override string _GetTemplateForLabelDevEx()
	{
		return "DevEx";
	}

	protected override string _GetTemplateForLabelDevExHowTo()
	{
		return "DexEx 사용법";
	}

	protected override string _GetTemplateForLabelDevExMyRequest()
	{
		return "DevEx 내 요청";
	}

	protected override string _GetTemplateForLabelDMCA()
	{
		return "DMCA";
	}

	protected override string _GetTemplateForLabelEmailAddress()
	{
		return "이메일 주소";
	}

	protected override string _GetTemplateForLabelExploitReport()
	{
		return "악용 신고";
	}

	protected override string _GetTemplateForLabelFirstName()
	{
		return "이름";
	}

	protected override string _GetTemplateForLabelForgotPassword()
	{
		return "비밀번호 분실";
	}

	protected override string _GetTemplateForLabelFreeRobux()
	{
		return "무료 Robux";
	}

	protected override string _GetTemplateForLabelGameCredit()
	{
		return "게임카드";
	}

	protected override string _GetTemplateForLabelGCPartialPayment()
	{
		return "구매 - 할부";
	}

	protected override string _GetTemplateForLabelGCRedeem()
	{
		return "게임카드 - 사용";
	}

	protected override string _GetTemplateForLabelGCSpendCredit()
	{
		return "게임카드 - 크레딧 사용";
	}

	protected override string _GetTemplateForLabelHowTo()
	{
		return "사용법";
	}

	protected override string _GetTemplateForLabelHowToGeneral()
	{
		return "사용법 - 일반";
	}

	protected override string _GetTemplateForLabelHowToOther()
	{
		return "사용법 - 기타";
	}

	protected override string _GetTemplateForLabelIdeasSuggestions()
	{
		return "아이디어 및 제안";
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
		return "어떤 문제를 겪고 있는지 자세히 적어주세요. 문제가 발생한 위치나 오류 메시지를 비롯한 관련 정보를 무엇이든 기재해주세요.";
	}

	protected override string _GetTemplateForLabelIWasScammed()
	{
		return "신용 사기";
	}

	protected override string _GetTemplateForLabelMac()
	{
		return "Mac";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "멤버십";
	}

	protected override string _GetTemplateForLabelModeration()
	{
		return "검열";
	}

	protected override string _GetTemplateForLabelOtherSiteClaim()
	{
		return "기타 사이트 클레임";
	}

	protected override string _GetTemplateForLabelOwnerDMCAClaim()
	{
		return "소유자 DMCA 클레임";
	}

	protected override string _GetTemplateForLabelPC()
	{
		return "PC";
	}

	protected override string _GetTemplateForLabelPhysicalToyIssue()
	{
		return "실물 장난감 문제";
	}

	protected override string _GetTemplateForLabelPleaseSelect()
	{
		return "선택...";
	}

	protected override string _GetTemplateForLabelPrizeNotReceived()
	{
		return "상품 받지 않음";
	}

	protected override string _GetTemplateForLabelPurchaseDeclined()
	{
		return "구매 - 거절됨";
	}

	protected override string _GetTemplateForLabelPurchaseDidNotReceive()
	{
		return "구매 - 수령하지 않음";
	}

	protected override string _GetTemplateForLabelPurchaseUnauthorizedCharge()
	{
		return "구매 - 승인되지 않은 청구";
	}

	protected override string _GetTemplateForLabelReportPhish()
	{
		return "피싱 사이트 신고";
	}

	protected override string _GetTemplateForLabelRobloxCrashing()
	{
		return "Roblox 충돌";
	}

	protected override string _GetTemplateForLabelRobloxToys()
	{
		return "Roblox 장난감";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelRobuxPurchaseIssue()
	{
		return "Robux - 구매 문제";
	}

	protected override string _GetTemplateForLabelSafetyInquiry()
	{
		return "부적절한 게임 또는 사용자 행동";
	}

	protected override string _GetTemplateForLabelSafetyQueueTicket()
	{
		return "사용자 보안 문제";
	}

	protected override string _GetTemplateForLabelSpecificGameIssue()
	{
		return "특정 게임 문제";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "저장";
	}

	protected override string _GetTemplateForLabelSuggestFeature()
	{
		return "기능 제안";
	}

	protected override string _GetTemplateForLabelSuggestFeedback()
	{
		return "피드백";
	}

	protected override string _GetTemplateForLabelTechnicalSupport()
	{
		return "기술 지원";
	}

	protected override string _GetTemplateForLabelToyCodeIssue()
	{
		return "장난감 코드 문제";
	}

	protected override string _GetTemplateForLabelTwoStepV()
	{
		return "2단계 인증";
	}

	protected override string _GetTemplateForLabelUserAbuseReport()
	{
		return "규칙 위반 사용자 신고";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "사용자 이름";
	}

	protected override string _GetTemplateForLabelVCCatalog()
	{
		return "웹사이트 아이템";
	}

	protected override string _GetTemplateForLabelVCInGame()
	{
		return "게임 내 아이템";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForResponseDialogErrorWithoutContext()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseDialogInvalidUsername()
	{
		return "보내기를 눌러 티켓을 제출하거나 취소를 눌러 사용자 이름을 편집하세요. 사용자 이름은 문제를 조속히 해결하는 데 도움이 될 수 있는 매우 중요한 정보랍니다.";
	}

	protected override string _GetTemplateForResponseDialogRequestReceived()
	{
		return "Roblox에 연락해주셔서 감사합니다. 고객지원 이메일을 확인하세요.";
	}

	protected override string _GetTemplateForResponseDialogTooManyAttemptsError()
	{
		return "시도 가능 횟수를 초과했습니다. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseDialogTryAgainError()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseEmailFormatError()
	{
		return "이메일 주소를 올바른 형식으로 입력하세요";
	}

	protected override string _GetTemplateForResponseEmailNotMatching()
	{
		return "이메일 주소가 일치하지 않아요";
	}

	protected override string _GetTemplateForResponseInvalidFirstName()
	{
		return "유효한 이름(성 제외)을 입력하세요";
	}

	protected override string _GetTemplateForResponseInvalidUsername()
	{
		return "유효하지 않은 Roblox 사용자 이름을 입력하신 것 같아요.";
	}

	protected override string _GetTemplateForResponseUnder13Email()
	{
		return "만 13세 미만이라면 보호자 이메일 주소를 입력하세요";
	}
}
