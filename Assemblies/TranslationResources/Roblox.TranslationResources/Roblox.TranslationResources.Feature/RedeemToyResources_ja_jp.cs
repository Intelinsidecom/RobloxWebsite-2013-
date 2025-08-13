namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_ja_jp : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "コードが見つからない場合";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "閉じる";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "別サイトでビデオを見る";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "プロモーションコードを持っている場合は、こちらをクリックしてください";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "引き換え方法";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ログイン";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "引き換え";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "他のアイテムを引き換える";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "新規登録";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "アイテムを表示";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "Robloxを終了してYouTubeでビデオを見ようとしています。YouTubeはRoblox.comのサイトの一部でないため、別のプライバシーポリシーで管理されています。";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "引き換えに成功しました";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "Robloxバーチャルアイテムを引き換える";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "Robloxではないサイトに移動しています";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "トイコードを入力";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "コードが無効です。もう一度お試しください。";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "バーチャルアイテムのコードを引き換えるには、Robloxアカウントにログインしてください！";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "アイテムの引き換えに成功しました。";

	public RedeemToyResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "コードが見つからない場合";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "別サイトでビデオを見る";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "プロモーションコードを持っている場合は、こちらをクリックしてください";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "引き換え方法";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "引き換え";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "他のアイテムを引き換える";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "新規登録";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "アイテムを表示";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"{creatorName} さんの {spanTagStart}{itemName}{spanTagEnd} ({itemType}) の引き換えに成功しました。";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "{creatorName} さんの {spanTagStart}{itemName}{spanTagEnd} ({itemType}) の引き換えに成功しました。";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "Robloxを終了してYouTubeでビデオを見ようとしています。YouTubeはRoblox.comのサイトの一部でないため、別のプライバシーポリシーで管理されています。";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "引き換えに成功しました";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Robloxバーチャルアイテムを引き換える";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "Robloxではないサイトに移動しています";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "トイコードを入力";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "コードが無効です。もう一度お試しください。";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "バーチャルアイテムのコードを引き換えるには、Robloxアカウントにログインしてください！";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "アイテムの引き換えに成功しました。";
	}
}
