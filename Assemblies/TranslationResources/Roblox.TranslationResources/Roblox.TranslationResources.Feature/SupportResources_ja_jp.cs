namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportResources_ja_jp : SupportResources_en_us, ISupportResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string ActionDialogCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Dialog.OK"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOK => "OK";

	/// <summary>
	/// Key: "Action.Dialog.Send"
	/// Send
	/// English String: "Send"
	/// </summary>
	public override string ActionDialogSend => "送信";

	/// <summary>
	/// Key: "Heading.ContactInformation"
	/// Contact Information
	/// English String: "Contact Information"
	/// </summary>
	public override string HeadingContactInformation => "連絡先情報";

	/// <summary>
	/// Key: "Heading.DescriptionOfIssue"
	/// Description of issue
	/// English String: "Description of issue"
	/// </summary>
	public override string HeadingDescriptionOfIssue => "問題の詳細";

	/// <summary>
	/// Key: "Heading.DeviceWithProblem"
	/// What device are you having the problem on?
	/// English String: "What device are you having the problem on?"
	/// </summary>
	public override string HeadingDeviceWithProblem => "問題が発生したデバイスは何ですか？";

	/// <summary>
	/// Key: "Heading.Dialog.ErrorWithoutContext"
	/// Error
	/// English String: "Error"
	/// </summary>
	public override string HeadingDialogErrorWithoutContext => "エラー";

	/// <summary>
	/// Key: "Heading.Dialog.InvalidUsername"
	/// Invalid Username
	/// English String: "Invalid Username"
	/// </summary>
	public override string HeadingDialogInvalidUsername => "無効なユーザーネーム";

	/// <summary>
	/// Key: "Heading.Dialog.RequestReceived"
	/// Request Received
	/// English String: "Request Received"
	/// </summary>
	public override string HeadingDialogRequestReceived => "リクエストが届きました";

	/// <summary>
	/// Key: "Heading.HelpCategoryType"
	/// Type of help category
	/// English String: "Type of help category"
	/// </summary>
	public override string HeadingHelpCategoryType => "ヘルプカテゴリの種類";

	/// <summary>
	/// Key: "Heading.IssueDetails"
	/// Issue Details
	/// English String: "Issue Details"
	/// </summary>
	public override string HeadingIssueDetails => "問題の詳細";

	/// <summary>
	/// Key: "Heading.PageTitle"
	/// Contact Us
	/// English String: "Contact Us"
	/// </summary>
	public override string HeadingPageTitle => "お問い合わせ";

	/// <summary>
	/// Key: "Label.AccountHacked"
	/// Account Hacked
	/// English String: "Account Hacked"
	/// </summary>
	public override string LabelAccountHacked => "アカウントがハッキングされています";

	/// <summary>
	/// Key: "Label.AccountOwnership"
	/// Account Hacked or Can't Log in
	/// English String: "Account Hacked or Can't Log in"
	/// </summary>
	public override string LabelAccountOwnership => "アカウントがハッキングされているか、ログインができません";

	/// <summary>
	/// Key: "Label.AccountPin"
	/// Account PIN
	/// English String: "Account PIN"
	/// </summary>
	public override string LabelAccountPin => "アカウントPIN";

	public override string LabelAdjustChildSettings => "子供のプライバシーとセキュリティ設定を調整";

	/// <summary>
	/// Key: "Label.AmazonDevice"
	/// Amazon Device
	/// English String: "Amazon Device"
	/// </summary>
	public override string LabelAmazonDevice => "Amazonデバイス";

	/// <summary>
	/// Key: "Label.AndroidPhone"
	/// Android Phone
	/// English String: "Android Phone"
	/// </summary>
	public override string LabelAndroidPhone => "Android携帯";

	/// <summary>
	/// Key: "Label.AndroidTablet"
	/// Android Tablet
	/// English String: "Android Tablet"
	/// </summary>
	public override string LabelAndroidTablet => "Androidタブレット";

	/// <summary>
	/// Key: "Label.AppealAccountContent"
	/// Appeal Account or Content
	/// English String: "Appeal Account or Content"
	/// </summary>
	public override string LabelAppealAccountContent => "アカウントや内容規制への異議申し立て";

	/// <summary>
	/// Key: "Label.AppealFriend"
	/// Appeal for Friend
	/// English String: "Appeal for Friend"
	/// </summary>
	public override string LabelAppealFriend => "友達に代わって問い合わせる";

	public override string LabelBilling => "ご請求とお支払い";

	/// <summary>
	/// Key: "Label.BugReport"
	/// Bug Report
	/// English String: "Bug Report"
	/// </summary>
	public override string LabelBugReport => "バグレポート";

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
	public override string LabelCancelMembership => "メンバーシップをキャンセルする";

	/// <summary>
	/// Key: "Label.CannotInstall"
	/// Cannot Install Roblox or Studio
	/// English String: "Cannot Install Roblox or Studio"
	/// </summary>
	public override string LabelCannotInstall => "RobloxやStudioがインストールできない";

	/// <summary>
	/// Key: "Label.CannotPlayGame"
	/// Cannot Play Game
	/// English String: "Cannot Play Game"
	/// </summary>
	public override string LabelCannotPlayGame => "ゲームをプレイできません";

	/// <summary>
	/// Key: "Label.ChangeChildAge"
	/// Change Child Age
	/// English String: "Change Child Age"
	/// </summary>
	public override string LabelChangeChildAge => "子供の年齢の変更";

	public override string LabelChatAgeSettings => "チャットと年齢設定";

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
	public override string LabelConfirmEmail => "メールアドレスの確認";

	/// <summary>
	/// Key: "Label.ContentAbuseReport"
	/// Report Content Breaking Rules
	/// English String: "Report Content Breaking Rules"
	/// </summary>
	public override string LabelContentAbuseReport => "コンテンツのルール違反を報告";

	public override string LabelContest => "コンテストとイベント";

	/// <summary>
	/// Key: "Label.ContestEventQuestion"
	/// Question or Issue
	/// English String: "Question or Issue"
	/// </summary>
	public override string LabelContestEventQuestion => "質問または問題";

	/// <summary>
	/// Key: "Label.CSCharacter"
	/// Customer Service Character
	/// English String: "Customer Service Character"
	/// </summary>
	public override string LabelCSCharacter => "カスタマーサービスキャラクター";

	/// <summary>
	/// Key: "Label.DescribeIssue"
	/// Please describe your issue
	/// English String: "Please describe your issue"
	/// </summary>
	public override string LabelDescribeIssue => "問題を詳しく記入してください";

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
	public override string LabelDevExHowTo => "DevExの使い方";

	/// <summary>
	/// Key: "Label.DevExMyRequest"
	/// DevEx My Request
	/// English String: "DevEx My Request"
	/// </summary>
	public override string LabelDevExMyRequest => "DevExのマイリクエスト";

	/// <summary>
	/// Key: "Label.DMCA"
	/// DMCA
	/// English String: "DMCA"
	/// </summary>
	public override string LabelDMCA => "デジタルミレニアム著作権法 （DMCA）";

	/// <summary>
	/// Key: "Label.EmailAddress"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailAddress => "メールアドレス";

	/// <summary>
	/// Key: "Label.ExploitReport"
	/// Exploit Report
	/// English String: "Exploit Report"
	/// </summary>
	public override string LabelExploitReport => "脆弱性レポート";

	/// <summary>
	/// Key: "Label.FirstName"
	/// First Name
	/// English String: "First Name"
	/// </summary>
	public override string LabelFirstName => "下の名前";

	/// <summary>
	/// Key: "Label.ForgotPassword"
	/// Forgot Password
	/// English String: "Forgot Password"
	/// </summary>
	public override string LabelForgotPassword => "パスワードをお忘れですか";

	/// <summary>
	/// Key: "Label.FreeRobux"
	/// Free Robux
	/// English String: "Free Robux"
	/// </summary>
	public override string LabelFreeRobux => "無料Robux";

	/// <summary>
	/// Key: "Label.GameCredit"
	/// Game Card
	/// English String: "Game Card"
	/// </summary>
	public override string LabelGameCredit => "ゲームカード";

	/// <summary>
	/// Key: "Label.GCPartialPayment"
	/// Purchase - Split Payment
	/// English String: "Purchase - Split Payment"
	/// </summary>
	public override string LabelGCPartialPayment => "購入 - 分割払い";

	/// <summary>
	/// Key: "Label.GCRedeem"
	/// Game Card - Redeem
	/// English String: "Game Card - Redeem"
	/// </summary>
	public override string LabelGCRedeem => "ゲームカード - 引き換え";

	/// <summary>
	/// Key: "Label.GCSpendCredit"
	/// Game Card - Spend Credit
	/// English String: "Game Card - Spend Credit"
	/// </summary>
	public override string LabelGCSpendCredit => "ゲームカード - 使用したクレジット";

	/// <summary>
	/// Key: "Label.HowTo"
	/// How To
	/// English String: "How To"
	/// </summary>
	public override string LabelHowTo => "使い方";

	/// <summary>
	/// Key: "Label.HowToGeneral"
	/// How To - General
	/// English String: "How To - General"
	/// </summary>
	public override string LabelHowToGeneral => "使い方 - 一般";

	/// <summary>
	/// Key: "Label.HowToOther"
	/// How To - Other
	/// English String: "How To - Other"
	/// </summary>
	public override string LabelHowToOther => "使い方 - その他";

	public override string LabelIdeasSuggestions => "アイデアと提案";

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
	public override string LabelIssueDescription => "発生した問題を詳しく記入してください。問題の発生場所やエラーメッセージなど、関連情報を教えてください。";

	/// <summary>
	/// Key: "Label.IWasScammed"
	/// I was Scammed
	/// English String: "I was Scammed"
	/// </summary>
	public override string LabelIWasScammed => "騙されました";

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
	public override string LabelMembership => "メンバーシップ";

	/// <summary>
	/// Key: "Label.Moderation"
	/// Moderation
	/// English String: "Moderation"
	/// </summary>
	public override string LabelModeration => "規制対象";

	/// <summary>
	/// Key: "Label.OtherSiteClaim"
	/// Other Site Claim
	/// English String: "Other Site Claim"
	/// </summary>
	public override string LabelOtherSiteClaim => "その他サイトの報告";

	/// <summary>
	/// Key: "Label.OwnerDMCAClaim"
	/// Owner DMCA Claim
	/// English String: "Owner DMCA Claim"
	/// </summary>
	public override string LabelOwnerDMCAClaim => "所有者のデジタルミレニアム著作権法 （DMCA）に基づく申し立て";

	/// <summary>
	/// Key: "Label.PC"
	/// PC
	/// English String: "PC"
	/// </summary>
	public override string LabelPC => "パソコン";

	/// <summary>
	/// Key: "Label.PhysicalToyIssue"
	/// Physical Toy Issue
	/// English String: "Physical Toy Issue"
	/// </summary>
	public override string LabelPhysicalToyIssue => "有形トイの問題";

	/// <summary>
	/// Key: "Label.PleaseSelect"
	/// Please Select...
	/// English String: "Please Select..."
	/// </summary>
	public override string LabelPleaseSelect => "選択してください...";

	/// <summary>
	/// Key: "Label.PrizeNotReceived"
	/// Prize Not Received
	/// English String: "Prize Not Received"
	/// </summary>
	public override string LabelPrizeNotReceived => "賞品を受け取っていません";

	/// <summary>
	/// Key: "Label.PurchaseDeclined"
	/// Purchase - Declined
	/// English String: "Purchase - Declined"
	/// </summary>
	public override string LabelPurchaseDeclined => "購入 - 却下された";

	/// <summary>
	/// Key: "Label.PurchaseDidNotReceive"
	/// Purchase - Did Not Receive
	/// English String: "Purchase - Did Not Receive"
	/// </summary>
	public override string LabelPurchaseDidNotReceive => "購入 - 商品が届かない";

	/// <summary>
	/// Key: "Label.PurchaseUnauthorizedCharge"
	/// Purchase - Unauthorized Charge
	/// English String: "Purchase - Unauthorized Charge"
	/// </summary>
	public override string LabelPurchaseUnauthorizedCharge => "購入 - 承認していない課金がある";

	/// <summary>
	/// Key: "Label.ReportPhish"
	/// Report Phishing Site
	/// English String: "Report Phishing Site"
	/// </summary>
	public override string LabelReportPhish => "フィッシングサイトを報告";

	/// <summary>
	/// Key: "Label.RobloxCrashing"
	/// Roblox Crashing
	/// English String: "Roblox Crashing"
	/// </summary>
	public override string LabelRobloxCrashing => "Robloxのクラッシュ";

	/// <summary>
	/// Key: "Label.RobloxToys"
	/// Roblox Toys
	/// English String: "Roblox Toys"
	/// </summary>
	public override string LabelRobloxToys => "Robloxトイ";

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
	public override string LabelRobuxPurchaseIssue => "Robux - 購入の問題";

	/// <summary>
	/// Key: "Label.SafetyInquiry"
	/// Inappropriate game or user behavior
	/// English String: "Inappropriate game or user behavior"
	/// </summary>
	public override string LabelSafetyInquiry => "不適切なゲームまたはユーザーの動作";

	/// <summary>
	/// Key: "Label.SafetyQueueTicket"
	/// User Safety Concern
	/// English String: "User Safety Concern"
	/// </summary>
	public override string LabelSafetyQueueTicket => "セキュリティ上の不安";

	/// <summary>
	/// Key: "Label.SpecificGameIssue"
	/// Specific Game Issue
	/// English String: "Specific Game Issue"
	/// </summary>
	public override string LabelSpecificGameIssue => "特定のゲームの問題";

	/// <summary>
	/// Key: "Label.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "送信する";

	/// <summary>
	/// Key: "Label.SuggestFeature"
	/// Feature Suggestion
	/// English String: "Feature Suggestion"
	/// </summary>
	public override string LabelSuggestFeature => "機能の提案";

	/// <summary>
	/// Key: "Label.SuggestFeedback"
	/// Feedback
	/// English String: "Feedback"
	/// </summary>
	public override string LabelSuggestFeedback => "ご意見やご感想";

	/// <summary>
	/// Key: "Label.TechnicalSupport"
	/// Technical Support
	/// English String: "Technical Support"
	/// </summary>
	public override string LabelTechnicalSupport => "テクニカルサポート";

	/// <summary>
	/// Key: "Label.ToyCodeIssue"
	/// Toy Code Issue
	/// English String: "Toy Code Issue"
	/// </summary>
	public override string LabelToyCodeIssue => "トイコードの問題";

	/// <summary>
	/// Key: "Label.TwoStepV"
	/// 2-Step Verification
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepV => "二段階認証";

	/// <summary>
	/// Key: "Label.UserAbuseReport"
	/// Report User Breaking Rules
	/// English String: "Report User Breaking Rules"
	/// </summary>
	public override string LabelUserAbuseReport => "ユーザーのルール違反を報告";

	/// <summary>
	/// Key: "Label.Username"
	/// Username
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ユーザー名";

	/// <summary>
	/// Key: "Label.VCCatalog"
	/// Website Item
	/// English String: "Website Item"
	/// </summary>
	public override string LabelVCCatalog => "Webサイト用アイテム";

	/// <summary>
	/// Key: "Label.VCInGame"
	/// In-Game Item
	/// English String: "In-Game Item"
	/// </summary>
	public override string LabelVCInGame => "ゲーム内アイテム";

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
	public override string ResponseDialogErrorWithoutContext => "問題が発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.Dialog.InvalidUsername"
	/// Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.
	/// English String: "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker."
	/// </summary>
	public override string ResponseDialogInvalidUsername => "「送信」を押してチケットを送信するか、「キャンセル」を押してユーザーネームを編集してください。ユーザーネームはとても重要な情報であり、発生した問題を素早く解決するのに役立ちます。";

	/// <summary>
	/// Key: "Response.Dialog.RequestReceived"
	/// Thank you for contacting Roblox. Please check your email for a message from Customer Service.
	/// English String: "Thank you for contacting Roblox. Please check your email for a message from Customer Service."
	/// </summary>
	public override string ResponseDialogRequestReceived => "Robloxにお問い合わせいただきありがとうございます。メールを送信しますので、カスタマーサービスからのメッセージを確認してください。";

	/// <summary>
	/// Key: "Response.Dialog.TooManyAttemptsError"
	/// Too many attempts. Try again later.
	/// English String: "Too many attempts. Try again later."
	/// </summary>
	public override string ResponseDialogTooManyAttemptsError => "試行回数が多すぎます。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.Dialog.TryAgainError"
	/// An error occurred. Try again later.
	/// English String: "An error occurred. Try again later."
	/// </summary>
	public override string ResponseDialogTryAgainError => "エラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.EmailFormatError"
	/// Please enter a properly formatted email address
	/// English String: "Please enter a properly formatted email address"
	/// </summary>
	public override string ResponseEmailFormatError => "メールアドレスを正しい形式で入力して下さい。";

	/// <summary>
	/// Key: "Response.EmailNotMatching"
	/// Email address does not match
	/// English String: "Email address does not match"
	/// </summary>
	public override string ResponseEmailNotMatching => "メールアドレスが一致しません";

	/// <summary>
	/// Key: "Response.InvalidFirstName"
	/// Please enter a valid first name
	/// English String: "Please enter a valid first name"
	/// </summary>
	public override string ResponseInvalidFirstName => "有効な下の名前を入力して下さい。";

	/// <summary>
	/// Key: "Response.InvalidUsername"
	/// That doesn't appear to be a valid Roblox username.
	/// English String: "That doesn't appear to be a valid Roblox username."
	/// </summary>
	public override string ResponseInvalidUsername => "有効なRobloxユーザーネームではありません。";

	/// <summary>
	/// Key: "Response.Under13Email"
	/// If you are under 13 years old, please provide your parent's email address
	/// English String: "If you are under 13 years old, please provide your parent's email address"
	/// </summary>
	public override string ResponseUnder13Email => "13歳未満の場合は、保護者のメールアドレスを登録してください。";

	public SupportResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionDialogOK()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionDialogSend()
	{
		return "送信";
	}

	protected override string _GetTemplateForHeadingContactInformation()
	{
		return "連絡先情報";
	}

	protected override string _GetTemplateForHeadingDescriptionOfIssue()
	{
		return "問題の詳細";
	}

	protected override string _GetTemplateForHeadingDeviceWithProblem()
	{
		return "問題が発生したデバイスは何ですか？";
	}

	protected override string _GetTemplateForHeadingDialogErrorWithoutContext()
	{
		return "エラー";
	}

	protected override string _GetTemplateForHeadingDialogInvalidUsername()
	{
		return "無効なユーザーネーム";
	}

	protected override string _GetTemplateForHeadingDialogRequestReceived()
	{
		return "リクエストが届きました";
	}

	protected override string _GetTemplateForHeadingHelpCategoryType()
	{
		return "ヘルプカテゴリの種類";
	}

	protected override string _GetTemplateForHeadingIssueDetails()
	{
		return "問題の詳細";
	}

	protected override string _GetTemplateForHeadingPageTitle()
	{
		return "お問い合わせ";
	}

	protected override string _GetTemplateForLabelAccountHacked()
	{
		return "アカウントがハッキングされています";
	}

	protected override string _GetTemplateForLabelAccountOwnership()
	{
		return "アカウントがハッキングされているか、ログインができません";
	}

	protected override string _GetTemplateForLabelAccountPin()
	{
		return "アカウントPIN";
	}

	protected override string _GetTemplateForLabelAdjustChildSettings()
	{
		return "子供のプライバシーとセキュリティ設定を調整";
	}

	protected override string _GetTemplateForLabelAmazonDevice()
	{
		return "Amazonデバイス";
	}

	protected override string _GetTemplateForLabelAndroidPhone()
	{
		return "Android携帯";
	}

	protected override string _GetTemplateForLabelAndroidTablet()
	{
		return "Androidタブレット";
	}

	protected override string _GetTemplateForLabelAppealAccountContent()
	{
		return "アカウントや内容規制への異議申し立て";
	}

	protected override string _GetTemplateForLabelAppealFriend()
	{
		return "友達に代わって問い合わせる";
	}

	protected override string _GetTemplateForLabelBilling()
	{
		return "ご請求とお支払い";
	}

	protected override string _GetTemplateForLabelBugReport()
	{
		return "バグレポート";
	}

	protected override string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected override string _GetTemplateForLabelCancelMembership()
	{
		return "メンバーシップをキャンセルする";
	}

	protected override string _GetTemplateForLabelCannotInstall()
	{
		return "RobloxやStudioがインストールできない";
	}

	protected override string _GetTemplateForLabelCannotPlayGame()
	{
		return "ゲームをプレイできません";
	}

	protected override string _GetTemplateForLabelChangeChildAge()
	{
		return "子供の年齢の変更";
	}

	protected override string _GetTemplateForLabelChatAgeSettings()
	{
		return "チャットと年齢設定";
	}

	protected override string _GetTemplateForLabelChromebook()
	{
		return "Chromebook";
	}

	protected override string _GetTemplateForLabelConfirmEmail()
	{
		return "メールアドレスの確認";
	}

	protected override string _GetTemplateForLabelContentAbuseReport()
	{
		return "コンテンツのルール違反を報告";
	}

	protected override string _GetTemplateForLabelContest()
	{
		return "コンテストとイベント";
	}

	protected override string _GetTemplateForLabelContestEventQuestion()
	{
		return "質問または問題";
	}

	protected override string _GetTemplateForLabelCSCharacter()
	{
		return "カスタマーサービスキャラクター";
	}

	protected override string _GetTemplateForLabelDescribeIssue()
	{
		return "問題を詳しく記入してください";
	}

	protected override string _GetTemplateForLabelDevEx()
	{
		return "DevEx";
	}

	protected override string _GetTemplateForLabelDevExHowTo()
	{
		return "DevExの使い方";
	}

	protected override string _GetTemplateForLabelDevExMyRequest()
	{
		return "DevExのマイリクエスト";
	}

	protected override string _GetTemplateForLabelDMCA()
	{
		return "デジタルミレニアム著作権法 （DMCA）";
	}

	protected override string _GetTemplateForLabelEmailAddress()
	{
		return "メールアドレス";
	}

	protected override string _GetTemplateForLabelExploitReport()
	{
		return "脆弱性レポート";
	}

	protected override string _GetTemplateForLabelFirstName()
	{
		return "下の名前";
	}

	protected override string _GetTemplateForLabelForgotPassword()
	{
		return "パスワードをお忘れですか";
	}

	protected override string _GetTemplateForLabelFreeRobux()
	{
		return "無料Robux";
	}

	protected override string _GetTemplateForLabelGameCredit()
	{
		return "ゲームカード";
	}

	protected override string _GetTemplateForLabelGCPartialPayment()
	{
		return "購入 - 分割払い";
	}

	protected override string _GetTemplateForLabelGCRedeem()
	{
		return "ゲームカード - 引き換え";
	}

	protected override string _GetTemplateForLabelGCSpendCredit()
	{
		return "ゲームカード - 使用したクレジット";
	}

	protected override string _GetTemplateForLabelHowTo()
	{
		return "使い方";
	}

	protected override string _GetTemplateForLabelHowToGeneral()
	{
		return "使い方 - 一般";
	}

	protected override string _GetTemplateForLabelHowToOther()
	{
		return "使い方 - その他";
	}

	protected override string _GetTemplateForLabelIdeasSuggestions()
	{
		return "アイデアと提案";
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
		return "発生した問題を詳しく記入してください。問題の発生場所やエラーメッセージなど、関連情報を教えてください。";
	}

	protected override string _GetTemplateForLabelIWasScammed()
	{
		return "騙されました";
	}

	protected override string _GetTemplateForLabelMac()
	{
		return "Mac";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "メンバーシップ";
	}

	protected override string _GetTemplateForLabelModeration()
	{
		return "規制対象";
	}

	protected override string _GetTemplateForLabelOtherSiteClaim()
	{
		return "その他サイトの報告";
	}

	protected override string _GetTemplateForLabelOwnerDMCAClaim()
	{
		return "所有者のデジタルミレニアム著作権法 （DMCA）に基づく申し立て";
	}

	protected override string _GetTemplateForLabelPC()
	{
		return "パソコン";
	}

	protected override string _GetTemplateForLabelPhysicalToyIssue()
	{
		return "有形トイの問題";
	}

	protected override string _GetTemplateForLabelPleaseSelect()
	{
		return "選択してください...";
	}

	protected override string _GetTemplateForLabelPrizeNotReceived()
	{
		return "賞品を受け取っていません";
	}

	protected override string _GetTemplateForLabelPurchaseDeclined()
	{
		return "購入 - 却下された";
	}

	protected override string _GetTemplateForLabelPurchaseDidNotReceive()
	{
		return "購入 - 商品が届かない";
	}

	protected override string _GetTemplateForLabelPurchaseUnauthorizedCharge()
	{
		return "購入 - 承認していない課金がある";
	}

	protected override string _GetTemplateForLabelReportPhish()
	{
		return "フィッシングサイトを報告";
	}

	protected override string _GetTemplateForLabelRobloxCrashing()
	{
		return "Robloxのクラッシュ";
	}

	protected override string _GetTemplateForLabelRobloxToys()
	{
		return "Robloxトイ";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelRobuxPurchaseIssue()
	{
		return "Robux - 購入の問題";
	}

	protected override string _GetTemplateForLabelSafetyInquiry()
	{
		return "不適切なゲームまたはユーザーの動作";
	}

	protected override string _GetTemplateForLabelSafetyQueueTicket()
	{
		return "セキュリティ上の不安";
	}

	protected override string _GetTemplateForLabelSpecificGameIssue()
	{
		return "特定のゲームの問題";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "送信する";
	}

	protected override string _GetTemplateForLabelSuggestFeature()
	{
		return "機能の提案";
	}

	protected override string _GetTemplateForLabelSuggestFeedback()
	{
		return "ご意見やご感想";
	}

	protected override string _GetTemplateForLabelTechnicalSupport()
	{
		return "テクニカルサポート";
	}

	protected override string _GetTemplateForLabelToyCodeIssue()
	{
		return "トイコードの問題";
	}

	protected override string _GetTemplateForLabelTwoStepV()
	{
		return "二段階認証";
	}

	protected override string _GetTemplateForLabelUserAbuseReport()
	{
		return "ユーザーのルール違反を報告";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ユーザー名";
	}

	protected override string _GetTemplateForLabelVCCatalog()
	{
		return "Webサイト用アイテム";
	}

	protected override string _GetTemplateForLabelVCInGame()
	{
		return "ゲーム内アイテム";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForResponseDialogErrorWithoutContext()
	{
		return "問題が発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseDialogInvalidUsername()
	{
		return "「送信」を押してチケットを送信するか、「キャンセル」を押してユーザーネームを編集してください。ユーザーネームはとても重要な情報であり、発生した問題を素早く解決するのに役立ちます。";
	}

	protected override string _GetTemplateForResponseDialogRequestReceived()
	{
		return "Robloxにお問い合わせいただきありがとうございます。メールを送信しますので、カスタマーサービスからのメッセージを確認してください。";
	}

	protected override string _GetTemplateForResponseDialogTooManyAttemptsError()
	{
		return "試行回数が多すぎます。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseDialogTryAgainError()
	{
		return "エラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseEmailFormatError()
	{
		return "メールアドレスを正しい形式で入力して下さい。";
	}

	protected override string _GetTemplateForResponseEmailNotMatching()
	{
		return "メールアドレスが一致しません";
	}

	protected override string _GetTemplateForResponseInvalidFirstName()
	{
		return "有効な下の名前を入力して下さい。";
	}

	protected override string _GetTemplateForResponseInvalidUsername()
	{
		return "有効なRobloxユーザーネームではありません。";
	}

	protected override string _GetTemplateForResponseUnder13Email()
	{
		return "13歳未満の場合は、保護者のメールアドレスを登録してください。";
	}
}
