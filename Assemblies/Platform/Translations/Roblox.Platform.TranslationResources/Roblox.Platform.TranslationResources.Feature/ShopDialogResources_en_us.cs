using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ShopDialogResources_en_us : TranslationResourcesBase, IShopDialogResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public virtual string ActionContinue => "Continue";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public virtual string ActionContinueToShop => "Continue to Shop";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public virtual string DescriptionAgeWarning => "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy.";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public virtual string DescriptionPurchaseAgeWarning => "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public virtual string DescriptionRetailWebsiteRedirect => "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public virtual string HeadingLeavingRoblox => "You are leaving Roblox";

	public ShopDialogResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Continue",
				_GetTemplateForActionContinue()
			},
			{
				"Action.ContinueToShop",
				_GetTemplateForActionContinueToShop()
			},
			{
				"Description.AgeWarning",
				_GetTemplateForDescriptionAgeWarning()
			},
			{
				"Description.AmazonRedirect",
				_GetTemplateForDescriptionAmazonRedirect()
			},
			{
				"Description.PurchaseAgeWarning",
				_GetTemplateForDescriptionPurchaseAgeWarning()
			},
			{
				"Description.RetailWebsiteRedirect",
				_GetTemplateForDescriptionRetailWebsiteRedirect()
			},
			{
				"Heading.LeavingRoblox",
				_GetTemplateForHeadingLeavingRoblox()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.ShopDialog";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionContinue()
	{
		return "Continue";
	}

	protected virtual string _GetTemplateForActionContinueToShop()
	{
		return "Continue to Shop";
	}

	protected virtual string _GetTemplateForDescriptionAgeWarning()
	{
		return "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy.";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public virtual string DescriptionAmazonRedirect(string shopLink)
	{
		return $"Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}.";
	}

	protected virtual string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}.";
	}

	protected virtual string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!";
	}

	protected virtual string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies.";
	}

	protected virtual string _GetTemplateForHeadingLeavingRoblox()
	{
		return "You are leaving Roblox";
	}
}
