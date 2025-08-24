namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_ko_kr : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "이용권 구매";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "지금 구매";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux 구매";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "구성";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "계속";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "사용자 정의";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "지금 획득";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "나중에";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "확인";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "지금 빌리기";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "아이템 구매";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "오류 발생";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "아이템 획득";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "잔액 부족";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "아이템 가격 변동됨";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "구매 완료";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "아이템 빌리기";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "동의 및 결제";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "무료";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "일시적으로 구매 불가. 나중에 다시 시도하세요.";

	public PurchaseDialogResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "이용권 구매";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "지금 구매";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux 구매";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "구성";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "계속";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "사용자 정의";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "지금 획득";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "나중에";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "지금 빌리기";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "아이템 구매";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "오류 발생";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "아이템 획득";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "잔액 부족";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "아이템 가격 변동됨";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "구매 완료";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "아이템 빌리기";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "동의 및 결제";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "무료";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"본 거래 후 회원님의 잔액은 {robuxBalance}입니다.";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "본 거래 후 회원님의 잔액은 {robuxBalance}입니다.";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"{robux}이(가) 더 있어야 본 아이템을 구매할 수 있어요.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "{robux}이(가) 더 있어야 본 아이템을 구매할 수 있어요.";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"회원님이 쇼핑하는 동안 아이템의 가격이 {robuxBefore}에서 {robuxAfter}(으)로 변경되었어요.";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "회원님이 쇼핑하는 동안 아이템의 가격이 {robuxBefore}에서 {robuxAfter}(으)로 변경되었어요.";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}님이 판매하는 {assetType}: \"{assetName}\"을(를) {robux}에 구매하시겠습니까?";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "{seller}님이 판매하는 {assetType}: \"{assetName}\"을(를) {robux}에 구매하시겠습니까?";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}님이 판매하는 {assetType}: \"{assetName}\" 이용권을 {robux}에 구매하시겠습니까?";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "{seller}님이 판매하는 {assetType}: \"{assetName}\" 이용권을 {robux}에 구매하시겠습니까?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"{seller}님의 {assetType}: \"{assetName}\"을(를) {freeTextStart}무료{freeTextEnd}로 획득하시겠습니까?";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "{seller}님의 {assetType}: \"{assetName}\"을(를) {freeTextStart}무료{freeTextEnd}로 획득하시겠습니까?";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"{seller}님의 {assetType}: \"{assetName}\" 이용권을 {freeTextStart}무료{freeTextEnd}로 획득하시겠습니까?";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "{seller}님의 {assetType}: \"{assetName}\" 이용권을 {freeTextStart}무료{freeTextEnd}로 획득하시겠습니까?";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}님이 대여하는 {assetType}: \"{assetName}\"을(를) {robux}에 빌리시겠습니까?";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "{seller}님이 대여하는 {assetType}: \"{assetName}\"을(를) {robux}에 빌리시겠습니까?";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}님이 대여하는 {assetType}: \"{assetName}\" 이용권을 {robux}에 빌리시겠습니까?";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "{seller}님이 대여하는 {assetType}: \"{assetName}\" 이용권을 {robux}에 빌리시겠습니까?";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "일시적으로 구매 불가. 나중에 다시 시도하세요.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}님이 판매하는 {assetName} {assetType}을(를) {robux}에 획득했습니다.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "{seller}님이 판매하는 {assetName} {assetType}을(를) {robux}에 획득했습니다.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}님이 판매하는 {assetName} {assetType}의 이용권을 {robux}에 획득했습니다.";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "{seller}님이 판매하는 {assetName} {assetType}의 이용권을 {robux}에 획득했습니다.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}님이 판매하는 {assetName} {assetType}을(를) {robux}에 구매했습니다.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "{seller}님이 판매하는 {assetName} {assetType}을(를) {robux}에 구매했습니다.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}님이 판매하는 {assetName} {assetType}의 이용권을 {robux}에 구매했습니다.";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "{seller}님이 판매하는 {assetName} {assetType}의 이용권을 {robux}에 구매했습니다.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}님이 판매하는 {assetName} {assetType}을(를) {robux}에 갱신했습니다.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "{seller}님이 판매하는 {assetName} {assetType}을(를) {robux}에 갱신했습니다.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}님이 판매하는 {assetName} {assetType}의 이용권을 {robux}에 갱신했습니다.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "{seller}님이 판매하는 {assetName} {assetType}의 이용권을 {robux}에 갱신했습니다.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}님이 대여하는 {assetName} {assetType}을(를) {robux}에 빌렸습니다.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "{seller}님이 대여하는 {assetName} {assetType}을(를) {robux}에 빌렸습니다.";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}님이 대여하는 {assetName} {assetType}의 이용권을 {robux}에 빌렸습니다.";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "{seller}님이 대여하는 {assetName} {assetType}의 이용권을 {robux}에 빌렸습니다.";
	}
}
