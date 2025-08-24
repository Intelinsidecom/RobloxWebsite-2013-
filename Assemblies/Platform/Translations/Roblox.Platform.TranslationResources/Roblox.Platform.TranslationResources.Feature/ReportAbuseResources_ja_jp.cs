namespace Roblox.TranslationResources.Feature;

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
	public override string ActionClose => "閉じる";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "規約違反を報告";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "送信する";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "コメント（オプション）...";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "規約違反を報告";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "ありがとうございます！";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "すべてのルールを見てください。";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "ルールに従わないユーザーには、まず警告を与えますが、それでもルール違反が続くようであれば、Robloxから抜けていただくようお願いする場合があります。そうすることで、Robloxを楽しく安全に保つことができます！";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "いじめ、嫌がらせ、ヘイトスピーチ";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "いじめ、嫌がらせ、差別";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "不適切なコンテンツ - プレース、画像、モデル";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "恋愛関係";

	public override string LabelCategoryInappropriate => "不適切な言葉 - 暴言、アダルトコンテンツ";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "その他のルール違反";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "個人情報の要求または提供";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "不正行為、チート行為、詐欺";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "アカウント窃盗 - フィッシング、ハッキング、アカウント売買";

	public override string LabelCategoryThreats => "リアルでの脅迫、自殺予告";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "コメント:";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "投稿（およびすべての返信）を削除する";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "投稿を変更しない";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "アダルトコンテンツ";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "宣伝";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "嫌がらせ";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "不適切";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "なし";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "プライバシー";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "暴言";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "詐欺";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "スパム";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "未分類、標準";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "ご注意: この投稿を削除すると、返信も削除されます。投稿の取り消しや削除を行った場合、このレポートは規約違反キューをスキップして、ユーザーキューに送られます。";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "このビデオを見るには、JavaScriptを有効にする必要があります。";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "報告しようとしている内容が本当にルール違反かどうか判断できない場合。";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "プライバシーポリシー";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "理由";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "汚い言葉の使用禁止";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "アカウントの共有や売買の禁止";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "恋愛関係の禁止 - 恋人募集の禁止";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "個人情報の要求を禁止 - 電話番号、メールアドレスを聞くことを禁止";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "Robloxの基本ルールには次のようなものがあります:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Robloxの安全対策";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "本文を取り消す";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "件名と本文を取り消す";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "コミュニティのルールを見る";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "カテゴリを選択してください";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "不適切なメディアを選択:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "規制対象となる理由を選択してください:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "件名:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "必要なパラメータの一部または全部が不足、または無効です";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "レポートカテゴリの読み込み中にエラーが発生しました";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "レポートの送信中にエラーが発生しました。";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "ページに問題があります";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "レポートを送信しました。";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "ご報告ありがとうございます。利用規約違反があったかどうかを判定する調査をします。詳しくは以下をチェックしてください。 ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "このアカウントには、権限が不足しています";

	public ReportAbuseResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "規約違反を報告";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "送信する";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "コメント（オプション）...";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "規約違反を報告";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "ありがとうございます！";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "すべてのルールを見てください。";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "ルールに従わないユーザーには、まず警告を与えますが、それでもルール違反が続くようであれば、Robloxから抜けていただくようお願いする場合があります。そうすることで、Robloxを楽しく安全に保つことができます！";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "いじめ、嫌がらせ、ヘイトスピーチ";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "いじめ、嫌がらせ、差別";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "不適切なコンテンツ - プレース、画像、モデル";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "恋愛関係";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "不適切な言葉 - 暴言、アダルトコンテンツ";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "その他のルール違反";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "個人情報の要求または提供";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "不正行為、チート行為、詐欺";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "アカウント窃盗 - フィッシング、ハッキング、アカウント売買";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "リアルでの脅迫、自殺予告";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "コメント:";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "投稿（およびすべての返信）を削除する";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "投稿を変更しない";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "アダルトコンテンツ";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "宣伝";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "嫌がらせ";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "不適切";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "なし";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "プライバシー";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "暴言";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "詐欺";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "スパム";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "未分類、標準";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "ご注意: この投稿を削除すると、返信も削除されます。投稿の取り消しや削除を行った場合、このレポートは規約違反キューをスキップして、ユーザーキューに送られます。";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "このビデオを見るには、JavaScriptを有効にする必要があります。";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "報告しようとしている内容が本当にルール違反かどうか判断できない場合。";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "プライバシーポリシー";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "理由";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "汚い言葉の使用禁止";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "アカウントの共有や売買の禁止";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "恋愛関係の禁止 - 恋人募集の禁止";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "個人情報の要求を禁止 - 電話番号、メールアドレスを聞くことを禁止";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "Robloxの基本ルールには次のようなものがあります:";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Robloxの安全対策";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "本文を取り消す";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "件名と本文を取り消す";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "コミュニティのルールを見る";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "カテゴリを選択してください";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "不適切なメディアを選択:";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "規制対象となる理由を選択してください:";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "件名:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"{creatorName}さんが、どのようにRobloxのルール違反をしているかお知らせください。";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "{creatorName}さんが、どのようにRobloxのルール違反をしているかお知らせください。";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "必要なパラメータの一部または全部が不足、または無効です";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "レポートカテゴリの読み込み中にエラーが発生しました";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "レポートの送信中にエラーが発生しました。";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "ページに問題があります";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "レポートを送信しました。";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "ご報告ありがとうございます。利用規約違反があったかどうかを判定する調査をします。詳しくは以下をチェックしてください。 ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "このアカウントには、権限が不足しています";
	}
}
