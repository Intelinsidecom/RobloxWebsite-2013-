namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_ko_kr : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "게임에 추가";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "취소";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "오류";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "오류가 발생했어요. 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "판매 중인 아이템이 아닙니다.";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "확인";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "회원님의 게임에서 홍보하기";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "빌리기";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "그룹 선택";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "없음";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "게임 선택";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "게임 선택:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "죄송합니다. 해당 아이템을 게임에서 삭제할 수 없어요. 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "완료!";

	public CreatePlaceProductPromotionResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "게임에 추가";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "오류";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "오류가 발생했어요. 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "판매 중인 아이템이 아닙니다.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "회원님의 게임에서 홍보하기";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "빌리기";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "그룹 선택";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "없음";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "게임 선택";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "게임 선택:";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "죄송합니다. 해당 아이템을 게임에서 삭제할 수 없어요. 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "완료!";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"게임에 장비를 추가하면, 추가한 장비는 게임 페이지에 표시되고 자동적으로 게임에서 사용할 수 있습니다. 누군가 회원님의 게임 페이지에서 본 장비를 구입하면 회원님은 {affiliateSaleTotal} Robux를 획득할 수 있어요!";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "게임에 장비를 추가하면, 추가한 장비는 게임 페이지에 표시되고 자동적으로 게임에서 사용할 수 있습니다. 누군가 회원님의 게임 페이지에서 본 장비를 구입하면 회원님은 {affiliateSaleTotal} Robux를 획득할 수 있어요!";
	}
}
