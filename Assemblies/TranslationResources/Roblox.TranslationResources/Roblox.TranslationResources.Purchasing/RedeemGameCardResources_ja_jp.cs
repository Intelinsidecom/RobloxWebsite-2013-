namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_ja_jp : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "閉じる";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "ログイン";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "新規登録";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "カードを買う";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "引き換え";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "カードを組み合わせて、さらにRobloxクレジットをゲットしよう。";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "ゲームカードを引き換えるにはRobloxアカウントにログインしてください！";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "購入には、1種類の支払い方法のみ使用できます。ゲームカードクレジットは、他のお支払い方法と組み合わせることができません。";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "提携している販売元からRobloxゲームカードを買ったり、誰かからRobloxギフトカードを受け取ります。";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "RobuxやBuilders ClubにRobloxを使いましょう！";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "引き換えセクションにカードのPINを入力します。";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "PINを入力";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "Robloxクレジットをゲット";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "引き換え方法";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "使い方";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "Robloxカードを引き換える";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "Robloxゲームカードを引き換える";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "Robloxゲームカードが必要ですか？";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PINコード";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "引き換え済みのRobux:";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "お持ちのクレジット残高:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "このギフトカードは引き換え済みです。";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "もう1枚RobloxカードをGameStopで引き換えると、ボーナスRobuxを受け取れます。";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "Builders Clubメンバーシップを期限延長しました！";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "変更が反映されるまで、長くて5分ほどかかる場合があります。";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "Builders Clubメンバーシップを引き換えました！";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "一致するコードが見つかりません。";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "リクエストしたオブジェクトが見つかりませんでした。";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "この機能は現在無効になっています。";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "問題が発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "無効なPIN";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "この操作を実行するにはログインしてください。";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "リクエストしたオブジェクトが見つかりませんでした。もう一度リクエストしてください。問題が再発する場合は、カスタマーサービスにお問い合わせください。";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "カードの引き換えに成功しました！";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "引き換えたコードが多すぎます。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "リクエストの失敗回数が多すぎます。後でもう一度お試しください。";

	public RedeemGameCardResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "新規登録";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "カードを買う";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "引き換え";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "カードを組み合わせて、さらにRobloxクレジットをゲットしよう。";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "ゲームカードを引き換えるにはRobloxアカウントにログインしてください！";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "購入には、1種類の支払い方法のみ使用できます。ゲームカードクレジットは、他のお支払い方法と組み合わせることができません。";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"{retailerLinkStart}参加中の販売者{retailerLinkEnd}からRobloxゲームカードを買ったり、誰かからRobloxギフトカードを受け取ります。 ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "{retailerLinkStart}参加中の販売者{retailerLinkEnd}からRobloxゲームカードを買ったり、誰かからRobloxギフトカードを受け取ります。 ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "提携している販売元からRobloxゲームカードを買ったり、誰かからRobloxギフトカードを受け取ります。";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "RobuxやBuilders ClubにRobloxを使いましょう！";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "引き換えセクションにカードのPINを入力します。";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "PINを入力";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Robloxクレジットをゲット";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "引き換え方法";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "使い方";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Robloxカードを引き換える";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Robloxゲームカードを引き換える";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "Robloxゲームカードが必要ですか？";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PINコード";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "引き換え済みのRobux:";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "お持ちのクレジット残高:";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "このギフトカードは引き換え済みです。";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "もう1枚RobloxカードをGameStopで引き換えると、ボーナスRobuxを受け取れます。";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "Builders Clubメンバーシップを期限延長しました！";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "変更が反映されるまで、長くて5分ほどかかる場合があります。";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "Builders Clubメンバーシップを引き換えました！";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "一致するコードが見つかりません。";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "リクエストしたオブジェクトが見つかりませんでした。";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "この機能は現在無効になっています。";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "問題が発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "無効なPIN";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "この操作を実行するにはログインしてください。";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"ユーザーがPINの引き換えをしようとしましたが、販売者が存在しません。ユーザーID: {authenticatedUserId} PIN番号: {cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "ユーザーがPINの引き換えをしようとしましたが、販売者が存在しません。ユーザーID: {authenticatedUserId} PIN番号: {cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "リクエストしたオブジェクトが見つかりませんでした。もう一度リクエストしてください。問題が再発する場合は、カスタマーサービスにお問い合わせください。";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "カードの引き換えに成功しました！";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"カードと{productName}の引き換えに成功しました。";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "カードと{productName}の引き換えに成功しました。";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "引き換えたコードが多すぎます。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "リクエストの失敗回数が多すぎます。後でもう一度お試しください。";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"GameStopで2枚のRobloxカード引き換えを行っていただきありがとうございます。{robuxCount} Robuxがアカウントに追加されました。";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "GameStopで2枚のRobloxカード引き換えを行っていただきありがとうございます。{robuxCount} Robuxがアカウントに追加されました。";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"もう1枚RobloxカードをWalmartで引き換えると、{rewardName} を受け取れます。";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "もう1枚RobloxカードをWalmartで引き換えると、{rewardName} を受け取れます。";
	}
}
