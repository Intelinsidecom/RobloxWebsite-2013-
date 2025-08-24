namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RobloxProductsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxProductsResources_ko_kr : RobloxProductsResources_en_us, IRobloxProductsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public override string HeadingSorry => "죄송합니다";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public override string MessageBuyRobuxToCustomizeAvatar => "Robux를 구매하여 아바타도 꾸미고 게임 아이템도 구입해보세요!";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageTryAgainLater => "일시적으로 Robux를 구입할 수 없습니다. 나중에 다시 시도하세요.";

	public RobloxProductsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingSorry()
	{
		return "죄송합니다";
	}

	protected override string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "Robux를 구매하여 아바타도 꾸미고 게임 아이템도 구입해보세요!";
	}

	protected override string _GetTemplateForMessageTryAgainLater()
	{
		return "일시적으로 Robux를 구입할 수 없습니다. 나중에 다시 시도하세요.";
	}
}
