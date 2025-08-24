namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_zh_cjv : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "找不到代码？";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "关闭";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "继续前往视频";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "有促销代码？请点按这里";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "兑换方法";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "登录";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "兑换";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "兑换其他道具";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "注册";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "查看道具";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "你即将离开 Roblox，前往 Youtube 观看视频。Youtube 不属于 Roblox.com，受单独隐私政策的监管。";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "兑换成功";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "兑换 Roblox 虚拟道具";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "你即将离开 Roblox";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "输入玩具代码";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "代码无效，请重试。";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "若要使用代码兑换虚拟道具，请先登录 Roblox！";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "你已成功兑换你的道具！";

	public RedeemToyResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "找不到代码？";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "继续前往视频";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "有促销代码？请点按这里";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "兑换方法";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "兑换";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "兑换其他道具";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "注册";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "查看道具";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"你已成功从“{creatorName}”兑换 {spanTagStart}“{itemName}”{spanTagEnd}（{itemType}）。";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "你已成功从“{creatorName}”兑换 {spanTagStart}“{itemName}”{spanTagEnd}（{itemType}）。";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "你即将离开 Roblox，前往 Youtube 观看视频。Youtube 不属于 Roblox.com，受单独隐私政策的监管。";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "兑换成功";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "兑换 Roblox 虚拟道具";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "你即将离开 Roblox";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "输入玩具代码";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "代码无效，请重试。";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "若要使用代码兑换虚拟道具，请先登录 Roblox！";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "你已成功兑换你的道具！";
	}
}
