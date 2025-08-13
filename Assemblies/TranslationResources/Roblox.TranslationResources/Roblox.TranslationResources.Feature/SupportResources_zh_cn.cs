namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportResources_zh_cn : SupportResources_en_us, ISupportResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string ActionDialogCancel => "取消";

	/// <summary>
	/// Key: "Action.Dialog.OK"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOK => "好";

	/// <summary>
	/// Key: "Action.Dialog.Send"
	/// Send
	/// English String: "Send"
	/// </summary>
	public override string ActionDialogSend => "发送";

	/// <summary>
	/// Key: "Heading.ContactInformation"
	/// Contact Information
	/// English String: "Contact Information"
	/// </summary>
	public override string HeadingContactInformation => "联系信息";

	/// <summary>
	/// Key: "Heading.DescriptionOfIssue"
	/// Description of issue
	/// English String: "Description of issue"
	/// </summary>
	public override string HeadingDescriptionOfIssue => "问题描述";

	/// <summary>
	/// Key: "Heading.DeviceWithProblem"
	/// What device are you having the problem on?
	/// English String: "What device are you having the problem on?"
	/// </summary>
	public override string HeadingDeviceWithProblem => "你在什么设备上遇到问题？";

	/// <summary>
	/// Key: "Heading.Dialog.ErrorWithoutContext"
	/// Error
	/// English String: "Error"
	/// </summary>
	public override string HeadingDialogErrorWithoutContext => "错误";

	/// <summary>
	/// Key: "Heading.Dialog.InvalidUsername"
	/// Invalid Username
	/// English String: "Invalid Username"
	/// </summary>
	public override string HeadingDialogInvalidUsername => "用户名无效";

	/// <summary>
	/// Key: "Heading.Dialog.RequestReceived"
	/// Request Received
	/// English String: "Request Received"
	/// </summary>
	public override string HeadingDialogRequestReceived => "请求已收到";

	/// <summary>
	/// Key: "Heading.HelpCategoryType"
	/// Type of help category
	/// English String: "Type of help category"
	/// </summary>
	public override string HeadingHelpCategoryType => "所需帮助类别";

	/// <summary>
	/// Key: "Heading.IssueDetails"
	/// Issue Details
	/// English String: "Issue Details"
	/// </summary>
	public override string HeadingIssueDetails => "问题详情";

	/// <summary>
	/// Key: "Heading.PageTitle"
	/// Contact Us
	/// English String: "Contact Us"
	/// </summary>
	public override string HeadingPageTitle => "联系我们";

	/// <summary>
	/// Key: "Label.AccountHacked"
	/// Account Hacked
	/// English String: "Account Hacked"
	/// </summary>
	public override string LabelAccountHacked => "帐户遭到黑客入侵";

	/// <summary>
	/// Key: "Label.AccountOwnership"
	/// Account Hacked or Can't Log in
	/// English String: "Account Hacked or Can't Log in"
	/// </summary>
	public override string LabelAccountOwnership => "帐户遭到黑客入侵或无法登录";

	/// <summary>
	/// Key: "Label.AccountPin"
	/// Account PIN
	/// English String: "Account PIN"
	/// </summary>
	public override string LabelAccountPin => "帐户 PIN";

	public override string LabelAdjustChildSettings => "调整儿童隐私和安全性设置";

	/// <summary>
	/// Key: "Label.AmazonDevice"
	/// Amazon Device
	/// English String: "Amazon Device"
	/// </summary>
	public override string LabelAmazonDevice => "Amazon 设备";

	/// <summary>
	/// Key: "Label.AndroidPhone"
	/// Android Phone
	/// English String: "Android Phone"
	/// </summary>
	public override string LabelAndroidPhone => "Android 手机";

	/// <summary>
	/// Key: "Label.AndroidTablet"
	/// Android Tablet
	/// English String: "Android Tablet"
	/// </summary>
	public override string LabelAndroidTablet => "Android 平板电脑";

	/// <summary>
	/// Key: "Label.AppealAccountContent"
	/// Appeal Account or Content
	/// English String: "Appeal Account or Content"
	/// </summary>
	public override string LabelAppealAccountContent => "帐户或内容申诉";

	/// <summary>
	/// Key: "Label.AppealFriend"
	/// Appeal for Friend
	/// English String: "Appeal for Friend"
	/// </summary>
	public override string LabelAppealFriend => "为好友申诉";

	public override string LabelBilling => "账单与付款";

	/// <summary>
	/// Key: "Label.BugReport"
	/// Bug Report
	/// English String: "Bug Report"
	/// </summary>
	public override string LabelBugReport => "漏洞报告";

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
	public override string LabelCancelMembership => "取消会员资格";

	/// <summary>
	/// Key: "Label.CannotInstall"
	/// Cannot Install Roblox or Studio
	/// English String: "Cannot Install Roblox or Studio"
	/// </summary>
	public override string LabelCannotInstall => "无法安装 Roblox 或 Studio";

	/// <summary>
	/// Key: "Label.CannotPlayGame"
	/// Cannot Play Game
	/// English String: "Cannot Play Game"
	/// </summary>
	public override string LabelCannotPlayGame => "无法玩游戏";

	/// <summary>
	/// Key: "Label.ChangeChildAge"
	/// Change Child Age
	/// English String: "Change Child Age"
	/// </summary>
	public override string LabelChangeChildAge => "更改儿童年龄";

	public override string LabelChatAgeSettings => "聊天和年龄设置";

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
	public override string LabelConfirmEmail => "确认电子邮件地址";

	/// <summary>
	/// Key: "Label.ContentAbuseReport"
	/// Report Content Breaking Rules
	/// English String: "Report Content Breaking Rules"
	/// </summary>
	public override string LabelContentAbuseReport => "举报违规内容";

	public override string LabelContest => "竞赛和活动";

	/// <summary>
	/// Key: "Label.ContestEventQuestion"
	/// Question or Issue
	/// English String: "Question or Issue"
	/// </summary>
	public override string LabelContestEventQuestion => "问题或困难";

	/// <summary>
	/// Key: "Label.CSCharacter"
	/// Customer Service Character
	/// English String: "Customer Service Character"
	/// </summary>
	public override string LabelCSCharacter => "Customer Service Character";

	/// <summary>
	/// Key: "Label.DescribeIssue"
	/// Please describe your issue
	/// English String: "Please describe your issue"
	/// </summary>
	public override string LabelDescribeIssue => "请描述你的问题";

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
	public override string LabelDevExHowTo => "DevEx 使用说明";

	/// <summary>
	/// Key: "Label.DevExMyRequest"
	/// DevEx My Request
	/// English String: "DevEx My Request"
	/// </summary>
	public override string LabelDevExMyRequest => "DevEx 我的请求";

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
	public override string LabelEmailAddress => "电子邮件地址";

	/// <summary>
	/// Key: "Label.ExploitReport"
	/// Exploit Report
	/// English String: "Exploit Report"
	/// </summary>
	public override string LabelExploitReport => "举报外挂";

	/// <summary>
	/// Key: "Label.FirstName"
	/// First Name
	/// English String: "First Name"
	/// </summary>
	public override string LabelFirstName => "名字";

	/// <summary>
	/// Key: "Label.ForgotPassword"
	/// Forgot Password
	/// English String: "Forgot Password"
	/// </summary>
	public override string LabelForgotPassword => "忘记密码";

	/// <summary>
	/// Key: "Label.FreeRobux"
	/// Free Robux
	/// English String: "Free Robux"
	/// </summary>
	public override string LabelFreeRobux => "免费 Robux";

	/// <summary>
	/// Key: "Label.GameCredit"
	/// Game Card
	/// English String: "Game Card"
	/// </summary>
	public override string LabelGameCredit => "礼品卡";

	/// <summary>
	/// Key: "Label.GCPartialPayment"
	/// Purchase - Split Payment
	/// English String: "Purchase - Split Payment"
	/// </summary>
	public override string LabelGCPartialPayment => "购买 - 分期付款";

	/// <summary>
	/// Key: "Label.GCRedeem"
	/// Game Card - Redeem
	/// English String: "Game Card - Redeem"
	/// </summary>
	public override string LabelGCRedeem => "礼品卡 - 兑换";

	/// <summary>
	/// Key: "Label.GCSpendCredit"
	/// Game Card - Spend Credit
	/// English String: "Game Card - Spend Credit"
	/// </summary>
	public override string LabelGCSpendCredit => "礼品卡 - 使用点数";

	/// <summary>
	/// Key: "Label.HowTo"
	/// How To
	/// English String: "How To"
	/// </summary>
	public override string LabelHowTo => "使用说明";

	/// <summary>
	/// Key: "Label.HowToGeneral"
	/// How To - General
	/// English String: "How To - General"
	/// </summary>
	public override string LabelHowToGeneral => "使用说明 - 一般";

	/// <summary>
	/// Key: "Label.HowToOther"
	/// How To - Other
	/// English String: "How To - Other"
	/// </summary>
	public override string LabelHowToOther => "使用说明 - 其他";

	public override string LabelIdeasSuggestions => "创意和建议";

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
	public override string LabelIssueDescription => "请描述你面临的问题。请附上任何相关信息，例如问题发生的位置或错误信息。";

	/// <summary>
	/// Key: "Label.IWasScammed"
	/// I was Scammed
	/// English String: "I was Scammed"
	/// </summary>
	public override string LabelIWasScammed => "我受到诈骗";

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
	public override string LabelMembership => "会员资格";

	/// <summary>
	/// Key: "Label.Moderation"
	/// Moderation
	/// English String: "Moderation"
	/// </summary>
	public override string LabelModeration => "过滤";

	/// <summary>
	/// Key: "Label.OtherSiteClaim"
	/// Other Site Claim
	/// English String: "Other Site Claim"
	/// </summary>
	public override string LabelOtherSiteClaim => "其他网站声明";

	/// <summary>
	/// Key: "Label.OwnerDMCAClaim"
	/// Owner DMCA Claim
	/// English String: "Owner DMCA Claim"
	/// </summary>
	public override string LabelOwnerDMCAClaim => "数字千年版权法（DMCA）声明";

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
	public override string LabelPhysicalToyIssue => "实物玩具问题";

	/// <summary>
	/// Key: "Label.PleaseSelect"
	/// Please Select...
	/// English String: "Please Select..."
	/// </summary>
	public override string LabelPleaseSelect => "请选择...";

	/// <summary>
	/// Key: "Label.PrizeNotReceived"
	/// Prize Not Received
	/// English String: "Prize Not Received"
	/// </summary>
	public override string LabelPrizeNotReceived => "奖品未收到";

	/// <summary>
	/// Key: "Label.PurchaseDeclined"
	/// Purchase - Declined
	/// English String: "Purchase - Declined"
	/// </summary>
	public override string LabelPurchaseDeclined => "购买 - 遭拒";

	/// <summary>
	/// Key: "Label.PurchaseDidNotReceive"
	/// Purchase - Did Not Receive
	/// English String: "Purchase - Did Not Receive"
	/// </summary>
	public override string LabelPurchaseDidNotReceive => "购买 - 未收到";

	/// <summary>
	/// Key: "Label.PurchaseUnauthorizedCharge"
	/// Purchase - Unauthorized Charge
	/// English String: "Purchase - Unauthorized Charge"
	/// </summary>
	public override string LabelPurchaseUnauthorizedCharge => "购买 - 未许可收费";

	/// <summary>
	/// Key: "Label.ReportPhish"
	/// Report Phishing Site
	/// English String: "Report Phishing Site"
	/// </summary>
	public override string LabelReportPhish => "举报网络钓鱼网站";

	/// <summary>
	/// Key: "Label.RobloxCrashing"
	/// Roblox Crashing
	/// English String: "Roblox Crashing"
	/// </summary>
	public override string LabelRobloxCrashing => "Roblox 崩溃";

	/// <summary>
	/// Key: "Label.RobloxToys"
	/// Roblox Toys
	/// English String: "Roblox Toys"
	/// </summary>
	public override string LabelRobloxToys => "Roblox 玩具";

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
	public override string LabelRobuxPurchaseIssue => "Robux - 购买问题";

	/// <summary>
	/// Key: "Label.SafetyInquiry"
	/// Inappropriate game or user behavior
	/// English String: "Inappropriate game or user behavior"
	/// </summary>
	public override string LabelSafetyInquiry => "游戏或用户行为不当";

	/// <summary>
	/// Key: "Label.SafetyQueueTicket"
	/// User Safety Concern
	/// English String: "User Safety Concern"
	/// </summary>
	public override string LabelSafetyQueueTicket => "用户安全疑虑";

	/// <summary>
	/// Key: "Label.SpecificGameIssue"
	/// Specific Game Issue
	/// English String: "Specific Game Issue"
	/// </summary>
	public override string LabelSpecificGameIssue => "特定游戏问题";

	/// <summary>
	/// Key: "Label.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "提交";

	/// <summary>
	/// Key: "Label.SuggestFeature"
	/// Feature Suggestion
	/// English String: "Feature Suggestion"
	/// </summary>
	public override string LabelSuggestFeature => "功能建议";

	/// <summary>
	/// Key: "Label.SuggestFeedback"
	/// Feedback
	/// English String: "Feedback"
	/// </summary>
	public override string LabelSuggestFeedback => "反馈";

	/// <summary>
	/// Key: "Label.TechnicalSupport"
	/// Technical Support
	/// English String: "Technical Support"
	/// </summary>
	public override string LabelTechnicalSupport => "技术支持";

	/// <summary>
	/// Key: "Label.ToyCodeIssue"
	/// Toy Code Issue
	/// English String: "Toy Code Issue"
	/// </summary>
	public override string LabelToyCodeIssue => "玩具代码问题";

	/// <summary>
	/// Key: "Label.TwoStepV"
	/// 2-Step Verification
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepV => "两步验证";

	/// <summary>
	/// Key: "Label.UserAbuseReport"
	/// Report User Breaking Rules
	/// English String: "Report User Breaking Rules"
	/// </summary>
	public override string LabelUserAbuseReport => "举报违规用户";

	/// <summary>
	/// Key: "Label.Username"
	/// Username
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "用户名";

	/// <summary>
	/// Key: "Label.VCCatalog"
	/// Website Item
	/// English String: "Website Item"
	/// </summary>
	public override string LabelVCCatalog => "网站道具";

	/// <summary>
	/// Key: "Label.VCInGame"
	/// In-Game Item
	/// English String: "In-Game Item"
	/// </summary>
	public override string LabelVCInGame => "游戏内道具";

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
	public override string ResponseDialogErrorWithoutContext => "发生错误，请稍后重试。";

	/// <summary>
	/// Key: "Response.Dialog.InvalidUsername"
	/// Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.
	/// English String: "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker."
	/// </summary>
	public override string ResponseDialogInvalidUsername => "按下“发送”提交票单，或按下“取消”编辑用户名。用户名是非常重要的信息，有助于加快解决你的问题。";

	/// <summary>
	/// Key: "Response.Dialog.RequestReceived"
	/// Thank you for contacting Roblox. Please check your email for a message from Customer Service.
	/// English String: "Thank you for contacting Roblox. Please check your email for a message from Customer Service."
	/// </summary>
	public override string ResponseDialogRequestReceived => "感谢你联系 Roblox。请查看你的电子邮件以查看客户服务发来的信息。";

	/// <summary>
	/// Key: "Response.Dialog.TooManyAttemptsError"
	/// Too many attempts. Try again later.
	/// English String: "Too many attempts. Try again later."
	/// </summary>
	public override string ResponseDialogTooManyAttemptsError => "尝试次数过多，请稍后重试。";

	/// <summary>
	/// Key: "Response.Dialog.TryAgainError"
	/// An error occurred. Try again later.
	/// English String: "An error occurred. Try again later."
	/// </summary>
	public override string ResponseDialogTryAgainError => "发生错误，请稍后重试。";

	/// <summary>
	/// Key: "Response.EmailFormatError"
	/// Please enter a properly formatted email address
	/// English String: "Please enter a properly formatted email address"
	/// </summary>
	public override string ResponseEmailFormatError => "请输入格式正确的电子邮件地址";

	/// <summary>
	/// Key: "Response.EmailNotMatching"
	/// Email address does not match
	/// English String: "Email address does not match"
	/// </summary>
	public override string ResponseEmailNotMatching => "电子邮件地址不符";

	/// <summary>
	/// Key: "Response.InvalidFirstName"
	/// Please enter a valid first name
	/// English String: "Please enter a valid first name"
	/// </summary>
	public override string ResponseInvalidFirstName => "请输入有效名字";

	/// <summary>
	/// Key: "Response.InvalidUsername"
	/// That doesn't appear to be a valid Roblox username.
	/// English String: "That doesn't appear to be a valid Roblox username."
	/// </summary>
	public override string ResponseInvalidUsername => "那好像不是有效的 Roblox 用户名。";

	/// <summary>
	/// Key: "Response.Under13Email"
	/// If you are under 13 years old, please provide your parent's email address
	/// English String: "If you are under 13 years old, please provide your parent's email address"
	/// </summary>
	public override string ResponseUnder13Email => "如果你未满 13 岁，请提供家长的电子邮件地址";

	public SupportResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionDialogOK()
	{
		return "好";
	}

	protected override string _GetTemplateForActionDialogSend()
	{
		return "发送";
	}

	protected override string _GetTemplateForHeadingContactInformation()
	{
		return "联系信息";
	}

	protected override string _GetTemplateForHeadingDescriptionOfIssue()
	{
		return "问题描述";
	}

	protected override string _GetTemplateForHeadingDeviceWithProblem()
	{
		return "你在什么设备上遇到问题？";
	}

	protected override string _GetTemplateForHeadingDialogErrorWithoutContext()
	{
		return "错误";
	}

	protected override string _GetTemplateForHeadingDialogInvalidUsername()
	{
		return "用户名无效";
	}

	protected override string _GetTemplateForHeadingDialogRequestReceived()
	{
		return "请求已收到";
	}

	protected override string _GetTemplateForHeadingHelpCategoryType()
	{
		return "所需帮助类别";
	}

	protected override string _GetTemplateForHeadingIssueDetails()
	{
		return "问题详情";
	}

	protected override string _GetTemplateForHeadingPageTitle()
	{
		return "联系我们";
	}

	protected override string _GetTemplateForLabelAccountHacked()
	{
		return "帐户遭到黑客入侵";
	}

	protected override string _GetTemplateForLabelAccountOwnership()
	{
		return "帐户遭到黑客入侵或无法登录";
	}

	protected override string _GetTemplateForLabelAccountPin()
	{
		return "帐户 PIN";
	}

	protected override string _GetTemplateForLabelAdjustChildSettings()
	{
		return "调整儿童隐私和安全性设置";
	}

	protected override string _GetTemplateForLabelAmazonDevice()
	{
		return "Amazon 设备";
	}

	protected override string _GetTemplateForLabelAndroidPhone()
	{
		return "Android 手机";
	}

	protected override string _GetTemplateForLabelAndroidTablet()
	{
		return "Android 平板电脑";
	}

	protected override string _GetTemplateForLabelAppealAccountContent()
	{
		return "帐户或内容申诉";
	}

	protected override string _GetTemplateForLabelAppealFriend()
	{
		return "为好友申诉";
	}

	protected override string _GetTemplateForLabelBilling()
	{
		return "账单与付款";
	}

	protected override string _GetTemplateForLabelBugReport()
	{
		return "漏洞报告";
	}

	protected override string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected override string _GetTemplateForLabelCancelMembership()
	{
		return "取消会员资格";
	}

	protected override string _GetTemplateForLabelCannotInstall()
	{
		return "无法安装 Roblox 或 Studio";
	}

	protected override string _GetTemplateForLabelCannotPlayGame()
	{
		return "无法玩游戏";
	}

	protected override string _GetTemplateForLabelChangeChildAge()
	{
		return "更改儿童年龄";
	}

	protected override string _GetTemplateForLabelChatAgeSettings()
	{
		return "聊天和年龄设置";
	}

	protected override string _GetTemplateForLabelChromebook()
	{
		return "Chromebook";
	}

	protected override string _GetTemplateForLabelConfirmEmail()
	{
		return "确认电子邮件地址";
	}

	protected override string _GetTemplateForLabelContentAbuseReport()
	{
		return "举报违规内容";
	}

	protected override string _GetTemplateForLabelContest()
	{
		return "竞赛和活动";
	}

	protected override string _GetTemplateForLabelContestEventQuestion()
	{
		return "问题或困难";
	}

	protected override string _GetTemplateForLabelCSCharacter()
	{
		return "Customer Service Character";
	}

	protected override string _GetTemplateForLabelDescribeIssue()
	{
		return "请描述你的问题";
	}

	protected override string _GetTemplateForLabelDevEx()
	{
		return "DevEx";
	}

	protected override string _GetTemplateForLabelDevExHowTo()
	{
		return "DevEx 使用说明";
	}

	protected override string _GetTemplateForLabelDevExMyRequest()
	{
		return "DevEx 我的请求";
	}

	protected override string _GetTemplateForLabelDMCA()
	{
		return "DMCA";
	}

	protected override string _GetTemplateForLabelEmailAddress()
	{
		return "电子邮件地址";
	}

	protected override string _GetTemplateForLabelExploitReport()
	{
		return "举报外挂";
	}

	protected override string _GetTemplateForLabelFirstName()
	{
		return "名字";
	}

	protected override string _GetTemplateForLabelForgotPassword()
	{
		return "忘记密码";
	}

	protected override string _GetTemplateForLabelFreeRobux()
	{
		return "免费 Robux";
	}

	protected override string _GetTemplateForLabelGameCredit()
	{
		return "礼品卡";
	}

	protected override string _GetTemplateForLabelGCPartialPayment()
	{
		return "购买 - 分期付款";
	}

	protected override string _GetTemplateForLabelGCRedeem()
	{
		return "礼品卡 - 兑换";
	}

	protected override string _GetTemplateForLabelGCSpendCredit()
	{
		return "礼品卡 - 使用点数";
	}

	protected override string _GetTemplateForLabelHowTo()
	{
		return "使用说明";
	}

	protected override string _GetTemplateForLabelHowToGeneral()
	{
		return "使用说明 - 一般";
	}

	protected override string _GetTemplateForLabelHowToOther()
	{
		return "使用说明 - 其他";
	}

	protected override string _GetTemplateForLabelIdeasSuggestions()
	{
		return "创意和建议";
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
		return "请描述你面临的问题。请附上任何相关信息，例如问题发生的位置或错误信息。";
	}

	protected override string _GetTemplateForLabelIWasScammed()
	{
		return "我受到诈骗";
	}

	protected override string _GetTemplateForLabelMac()
	{
		return "Mac";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "会员资格";
	}

	protected override string _GetTemplateForLabelModeration()
	{
		return "过滤";
	}

	protected override string _GetTemplateForLabelOtherSiteClaim()
	{
		return "其他网站声明";
	}

	protected override string _GetTemplateForLabelOwnerDMCAClaim()
	{
		return "数字千年版权法（DMCA）声明";
	}

	protected override string _GetTemplateForLabelPC()
	{
		return "PC";
	}

	protected override string _GetTemplateForLabelPhysicalToyIssue()
	{
		return "实物玩具问题";
	}

	protected override string _GetTemplateForLabelPleaseSelect()
	{
		return "请选择...";
	}

	protected override string _GetTemplateForLabelPrizeNotReceived()
	{
		return "奖品未收到";
	}

	protected override string _GetTemplateForLabelPurchaseDeclined()
	{
		return "购买 - 遭拒";
	}

	protected override string _GetTemplateForLabelPurchaseDidNotReceive()
	{
		return "购买 - 未收到";
	}

	protected override string _GetTemplateForLabelPurchaseUnauthorizedCharge()
	{
		return "购买 - 未许可收费";
	}

	protected override string _GetTemplateForLabelReportPhish()
	{
		return "举报网络钓鱼网站";
	}

	protected override string _GetTemplateForLabelRobloxCrashing()
	{
		return "Roblox 崩溃";
	}

	protected override string _GetTemplateForLabelRobloxToys()
	{
		return "Roblox 玩具";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelRobuxPurchaseIssue()
	{
		return "Robux - 购买问题";
	}

	protected override string _GetTemplateForLabelSafetyInquiry()
	{
		return "游戏或用户行为不当";
	}

	protected override string _GetTemplateForLabelSafetyQueueTicket()
	{
		return "用户安全疑虑";
	}

	protected override string _GetTemplateForLabelSpecificGameIssue()
	{
		return "特定游戏问题";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForLabelSuggestFeature()
	{
		return "功能建议";
	}

	protected override string _GetTemplateForLabelSuggestFeedback()
	{
		return "反馈";
	}

	protected override string _GetTemplateForLabelTechnicalSupport()
	{
		return "技术支持";
	}

	protected override string _GetTemplateForLabelToyCodeIssue()
	{
		return "玩具代码问题";
	}

	protected override string _GetTemplateForLabelTwoStepV()
	{
		return "两步验证";
	}

	protected override string _GetTemplateForLabelUserAbuseReport()
	{
		return "举报违规用户";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "用户名";
	}

	protected override string _GetTemplateForLabelVCCatalog()
	{
		return "网站道具";
	}

	protected override string _GetTemplateForLabelVCInGame()
	{
		return "游戏内道具";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForResponseDialogErrorWithoutContext()
	{
		return "发生错误，请稍后重试。";
	}

	protected override string _GetTemplateForResponseDialogInvalidUsername()
	{
		return "按下“发送”提交票单，或按下“取消”编辑用户名。用户名是非常重要的信息，有助于加快解决你的问题。";
	}

	protected override string _GetTemplateForResponseDialogRequestReceived()
	{
		return "感谢你联系 Roblox。请查看你的电子邮件以查看客户服务发来的信息。";
	}

	protected override string _GetTemplateForResponseDialogTooManyAttemptsError()
	{
		return "尝试次数过多，请稍后重试。";
	}

	protected override string _GetTemplateForResponseDialogTryAgainError()
	{
		return "发生错误，请稍后重试。";
	}

	protected override string _GetTemplateForResponseEmailFormatError()
	{
		return "请输入格式正确的电子邮件地址";
	}

	protected override string _GetTemplateForResponseEmailNotMatching()
	{
		return "电子邮件地址不符";
	}

	protected override string _GetTemplateForResponseInvalidFirstName()
	{
		return "请输入有效名字";
	}

	protected override string _GetTemplateForResponseInvalidUsername()
	{
		return "那好像不是有效的 Roblox 用户名。";
	}

	protected override string _GetTemplateForResponseUnder13Email()
	{
		return "如果你未满 13 岁，请提供家长的电子邮件地址";
	}
}
