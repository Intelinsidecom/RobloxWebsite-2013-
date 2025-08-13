namespace Roblox.TranslationResources.Purchasing;

public interface IRobloxProductsResources : ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	string HeadingSorry { get; }

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	string MessageBuyRobuxToCustomizeAvatar { get; }

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	string MessageTryAgainLater { get; }
}
