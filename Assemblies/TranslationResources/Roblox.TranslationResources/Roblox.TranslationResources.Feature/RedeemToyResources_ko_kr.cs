namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_ko_kr : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "코드를 찾을 수 없나요?";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "닫기";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "비디오 계속 보기";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "프로모션 코드가 있으신가요? 여기를 클릭";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "사용 방법";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "로그인";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "사용";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "다른 아이템 사용";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "회원가입";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "아이템 보기";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "Roblox를 나가 YouTube 비디오를 시청하려 하시는군요. YouTube는 Roblox.com과는 별개의 콘텐츠로 별도의 개인정보 처리방침이 적용됩니다.";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "사용 완료";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "Roblox 가상 아이템 사용";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "안녕히 가세요";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "장난감 코드 입력";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "유효하지 않은 코드입니다. 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "코드를 가상 아이템으로 교환하려면 Roblox 계정에 로그인해야 해요!";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "아이템 사용을 완료했어요!";

	public RedeemToyResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "코드를 찾을 수 없나요?";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "비디오 계속 보기";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "프로모션 코드가 있으신가요? 여기를 클릭";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "사용 방법";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "사용";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "다른 아이템 사용";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "회원가입";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "아이템 보기";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"{creatorName}의 {spanTagStart}{itemName}{spanTagEnd}({itemType})을 성공적으로 사용했어요!";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "{creatorName}의 {spanTagStart}{itemName}{spanTagEnd}({itemType})을 성공적으로 사용했어요!";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "Roblox를 나가 YouTube 비디오를 시청하려 하시는군요. YouTube는 Roblox.com과는 별개의 콘텐츠로 별도의 개인정보 처리방침이 적용됩니다.";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "사용 완료";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Roblox 가상 아이템 사용";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "안녕히 가세요";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "장난감 코드 입력";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "유효하지 않은 코드입니다. 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "코드를 가상 아이템으로 교환하려면 Roblox 계정에 로그인해야 해요!";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "아이템 사용을 완료했어요!";
	}
}
