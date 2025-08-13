namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides PurchaseDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PurchaseDialogResources_ja_jp : PurchaseDialogResources_en_us, IPurchaseDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "アクセスを買う";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "今すぐ買う";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robuxを買う";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "設定する";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "続ける";

	/// <summary>
	/// Key: "Action.Customize"
	/// English String: "Customize"
	/// </summary>
	public override string ActionCustomize => "カスタマイズ";

	/// <summary>
	/// Key: "Action.GetNow"
	/// English String: "Get Now"
	/// </summary>
	public override string ActionGetNow => "今すぐゲット";

	/// <summary>
	/// Key: "Action.NotNow"
	/// English String: "Not Now"
	/// </summary>
	public override string ActionNotNow => "あとで";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.RentNow"
	/// English String: "Rent Now"
	/// </summary>
	public override string ActionRentNow => "今すぐレンタルする";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "アイテムを買う";

	/// <summary>
	/// Key: "Heading.ErrorOccured"
	/// English String: "Error Occured"
	/// </summary>
	public override string HeadingErrorOccured => "エラーが発生しました";

	/// <summary>
	/// Key: "Heading.GetItem"
	/// English String: "Get Item"
	/// </summary>
	public override string HeadingGetItem => "アイテムをゲット";

	/// <summary>
	/// Key: "Heading.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public override string HeadingInsufficientFunds => "資金が足りません";

	/// <summary>
	/// Key: "Heading.PriceChanged"
	/// English String: "Item Price Has Changed"
	/// </summary>
	public override string HeadingPriceChanged => "アイテムの価格が変わりました";

	/// <summary>
	/// Key: "Heading.PurchaseComplete"
	/// English String: "Purchase Complete"
	/// </summary>
	public override string HeadingPurchaseComplete => "購入完了";

	/// <summary>
	/// Key: "Heading.RentItem"
	/// English String: "Rent Item"
	/// </summary>
	public override string HeadingRentItem => "アイテムをレンタルする";

	/// <summary>
	/// Key: "Label.AgreeAndPay"
	/// English String: "Agree and Pay"
	/// </summary>
	public override string LabelAgreeAndPay => "同意して支払う";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "無料";

	/// <summary>
	/// Key: "Message.PurchasingUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessagePurchasingUnavailable => "一時的に購入が利用できません。後でもう一度お試しください。";

	public PurchaseDialogResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "アクセスを買う";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "今すぐ買う";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robuxを買う";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "設定する";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "続ける";
	}

	protected override string _GetTemplateForActionCustomize()
	{
		return "カスタマイズ";
	}

	protected override string _GetTemplateForActionGetNow()
	{
		return "今すぐゲット";
	}

	protected override string _GetTemplateForActionNotNow()
	{
		return "あとで";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionRentNow()
	{
		return "今すぐレンタルする";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "アイテムを買う";
	}

	protected override string _GetTemplateForHeadingErrorOccured()
	{
		return "エラーが発生しました";
	}

	protected override string _GetTemplateForHeadingGetItem()
	{
		return "アイテムをゲット";
	}

	protected override string _GetTemplateForHeadingInsufficientFunds()
	{
		return "資金が足りません";
	}

	protected override string _GetTemplateForHeadingPriceChanged()
	{
		return "アイテムの価格が変わりました";
	}

	protected override string _GetTemplateForHeadingPurchaseComplete()
	{
		return "購入完了";
	}

	protected override string _GetTemplateForHeadingRentItem()
	{
		return "アイテムをレンタルする";
	}

	protected override string _GetTemplateForLabelAgreeAndPay()
	{
		return "同意して支払う";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "無料";
	}

	/// <summary>
	/// Key: "Message.BalanceAfter"
	/// English String: "Your balance after this transaction will be {robuxBalance}"
	/// </summary>
	public override string MessageBalanceAfter(string robuxBalance)
	{
		return $"取引後の残高は{robuxBalance}になります";
	}

	protected override string _GetTemplateForMessageBalanceAfter()
	{
		return "取引後の残高は{robuxBalance}になります";
	}

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "You need {robux} more to purchase this item."
	/// </summary>
	public override string MessageInsufficientFunds(string robux)
	{
		return $"このアイテムを買うには、あと{robux}が必要です。";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "このアイテムを買うには、あと{robux}が必要です。";
	}

	/// <summary>
	/// Key: "Message.PriceChanged"
	/// English String: "While you were shopping, the price of this item changed from {robuxBefore} to {robuxAfter}."
	/// </summary>
	public override string MessagePriceChanged(string robuxBefore, string robuxAfter)
	{
		return $"ショッピング中に、このアイテムの価格が{robuxBefore}から{robuxAfter}に変わりました。";
	}

	protected override string _GetTemplateForMessagePriceChanged()
	{
		return "ショッピング中に、このアイテムの価格が{robuxBefore}から{robuxAfter}に変わりました。";
	}

	/// <summary>
	/// Key: "Message.PromptBuy"
	/// English String: "Would you like to buy the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuy(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetType} 「{assetName}」を{robux}で購入しますか？";
	}

	protected override string _GetTemplateForMessagePromptBuy()
	{
		return "{seller}さんが作成した{assetType} 「{assetName}」を{robux}で購入しますか？";
	}

	/// <summary>
	/// Key: "Message.PromptBuyAccess"
	/// English String: "Would you like to buy access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptBuyAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetType} 「{assetName}」へのアクセスを{robux}で購入しますか？";
	}

	protected override string _GetTemplateForMessagePromptBuyAccess()
	{
		return "{seller}さんが作成した{assetType} 「{assetName}」へのアクセスを{robux}で購入しますか？";
	}

	/// <summary>
	/// Key: "Message.PromptGetFree"
	/// English String: "Would you like to get the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFree(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"{seller}さんが作成した{assetType} 「{assetName}」を{freeTextStart}無料{freeTextEnd}でゲットしますか？";
	}

	protected override string _GetTemplateForMessagePromptGetFree()
	{
		return "{seller}さんが作成した{assetType} 「{assetName}」を{freeTextStart}無料{freeTextEnd}でゲットしますか？";
	}

	/// <summary>
	/// Key: "Message.PromptGetFreeAccess"
	/// English String: "Would you like to get access to the {assetType} \"{assetName}\" from {seller} for {freeTextStart}Free{freeTextEnd}?"
	/// </summary>
	public override string MessagePromptGetFreeAccess(string assetType, string assetName, string seller, string freeTextStart, string freeTextEnd)
	{
		return $"{seller}さんが作成した{assetType} 「{assetName}」へのアクセスを{freeTextStart}無料{freeTextEnd}でゲットしますか？";
	}

	protected override string _GetTemplateForMessagePromptGetFreeAccess()
	{
		return "{seller}さんが作成した{assetType} 「{assetName}」へのアクセスを{freeTextStart}無料{freeTextEnd}でゲットしますか？";
	}

	/// <summary>
	/// Key: "Message.PromptRent"
	/// English String: "Would you like to rent the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRent(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetType} 「{assetName}」を{robux}でレンタルしますか？";
	}

	protected override string _GetTemplateForMessagePromptRent()
	{
		return "{seller}さんが作成した{assetType} 「{assetName}」を{robux}でレンタルしますか？";
	}

	/// <summary>
	/// Key: "Message.PromptRentAccess"
	/// English String: "Would you like to rent access to the {assetType} \"{assetName}\" from {seller} for {robux}?"
	/// </summary>
	public override string MessagePromptRentAccess(string assetType, string assetName, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetType} 「{assetName}」へのアクセスを{robux}でレンタルしますか？";
	}

	protected override string _GetTemplateForMessagePromptRentAccess()
	{
		return "{seller}さんが作成した{assetType} 「{assetName}」へのアクセスを{robux}でレンタルしますか？";
	}

	protected override string _GetTemplateForMessagePurchasingUnavailable()
	{
		return "一時的に購入が利用できません。後でもう一度お試しください。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquired"
	/// English String: "You have successfully acquired the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquired(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetName} {assetType}を{robux}で取得しました。";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquired()
	{
		return "{seller}さんが作成した{assetName} {assetType}を{robux}で取得しました。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyAcquiredAccess"
	/// English String: "You have successfully acquired access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyAcquiredAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetName} {assetType}へのアクセスを{robux}で取得しました。";
	}

	protected override string _GetTemplateForMessageSuccessfullyAcquiredAccess()
	{
		return "{seller}さんが作成した{assetName} {assetType}へのアクセスを{robux}で取得しました。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBought"
	/// English String: "You have successfully bought the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBought(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetName} {assetType}を{robux}で購入しました。";
	}

	protected override string _GetTemplateForMessageSuccessfullyBought()
	{
		return "{seller}さんが作成した{assetName} {assetType}を{robux}で購入しました。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyBoughtAccess"
	/// English String: "You have successfully bought access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyBoughtAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetName} {assetType}へのアクセスを{robux}で購入しました。";
	}

	protected override string _GetTemplateForMessageSuccessfullyBoughtAccess()
	{
		return "{seller}さんが作成した{assetName} {assetType}へのアクセスを{robux}で購入しました。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewed"
	/// English String: "You have successfully renewed the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewed(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetName} {assetType}を{robux}で更新しました。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewed()
	{
		return "{seller}さんが作成した{assetName} {assetType}を{robux}で更新しました。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRenewedAccess"
	/// English String: "You have successfully renewed access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRenewedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetName} {assetType}へのアクセスを{robux}で更新しました。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRenewedAccess()
	{
		return "{seller}さんが作成した{assetName} {assetType}へのアクセスを{robux}で更新しました。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRented"
	/// English String: "You have successfully rented the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRented(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetName} {assetType}を{robux}でレンタルしました。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRented()
	{
		return "{seller}さんが作成した{assetName} {assetType}を{robux}でレンタルしました。";
	}

	/// <summary>
	/// Key: "Message.SuccessfullyRentedAccess"
	/// English String: "You have successfully rented access to the {assetName} {assetType} from {seller} for {robux}."
	/// </summary>
	public override string MessageSuccessfullyRentedAccess(string assetName, string assetType, string seller, string robux)
	{
		return $"{seller}さんが作成した{assetName} {assetType}へのアクセスを{robux}でレンタルしました。";
	}

	protected override string _GetTemplateForMessageSuccessfullyRentedAccess()
	{
		return "{seller}さんが作成した{assetName} {assetType}へのアクセスを{robux}でレンタルしました。";
	}
}
