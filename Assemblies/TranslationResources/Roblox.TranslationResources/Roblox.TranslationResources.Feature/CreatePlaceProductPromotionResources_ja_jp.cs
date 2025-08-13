namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_ja_jp : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "ゲームに追加";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "キャンセル";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "エラー";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "エラーが発生しました。もう一度お試しください。";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "このアイテムは売られていません。";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "ゲームを宣伝する";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "レンタル";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "グループを選択";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "なし";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "ゲームを選択する";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "ゲームを選択:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "申し訳ありませんが、ゲームからアイテムを削除できませんでした。もう一度お試しください。";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "成功！";

	public CreatePlaceProductPromotionResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "ゲームに追加";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "エラー";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "エラーが発生しました。もう一度お試しください。";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "このアイテムは売られていません。";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "ゲームを宣伝する";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "レンタル";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "グループを選択";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "なし";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "ゲームを選択する";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "ゲームを選択:";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "申し訳ありませんが、ゲームからアイテムを削除できませんでした。もう一度お試しください。";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "成功！";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"ゲームに追加できるギアを設定します。このアイテムはゲームページに表示され、ゲーム内で自動的に許可されます。誰かがゲームページでこのアイテムを買うと、{affiliateSaleTotal} Robuxがもらえます！";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "ゲームに追加できるギアを設定します。このアイテムはゲームページに表示され、ゲーム内で自動的に許可されます。誰かがゲームページでこのアイテムを買うと、{affiliateSaleTotal} Robuxがもらえます！";
	}
}
