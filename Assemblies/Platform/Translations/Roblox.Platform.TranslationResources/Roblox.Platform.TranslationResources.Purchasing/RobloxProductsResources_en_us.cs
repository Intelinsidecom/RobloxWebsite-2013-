using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Purchasing;

internal class RobloxProductsResources_en_us : TranslationResourcesBase, IRobloxProductsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public virtual string HeadingSorry => "Sorry";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public virtual string MessageBuyRobuxToCustomizeAvatar => "Buy Robux to customize your avatar and get items in game!";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public virtual string MessageTryAgainLater => "Robux purchases are temporarily disabled. Please try again later.";

	public RobloxProductsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Heading.Sorry",
				_GetTemplateForHeadingSorry()
			},
			{
				"Message.BuyRobuxToCustomizeAvatar",
				_GetTemplateForMessageBuyRobuxToCustomizeAvatar()
			},
			{
				"Message.TryAgainLater",
				_GetTemplateForMessageTryAgainLater()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Purchasing.RobloxProducts";
	}

	protected virtual string _GetTemplateForHeadingSorry()
	{
		return "Sorry";
	}

	protected virtual string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "Buy Robux to customize your avatar and get items in game!";
	}

	protected virtual string _GetTemplateForMessageTryAgainLater()
	{
		return "Robux purchases are temporarily disabled. Please try again later.";
	}
}
