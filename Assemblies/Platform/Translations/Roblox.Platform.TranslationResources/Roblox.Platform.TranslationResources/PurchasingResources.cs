using System;
using Roblox.TranslationResources.Purchasing;

namespace Roblox.TranslationResources;

internal class PurchasingResources : IPurchasingResources, ITranslationResourcesNamespacesGroup
{
	private readonly Lazy<IPurchaseDialogResources> _IPurchaseDialogResources;

	private readonly Lazy<IRedeemGameCardResources> _IRedeemGameCardResources;

	private readonly Lazy<IRixtyPinResources> _IRixtyPinResources;

	private readonly Lazy<IRobloxProductsResources> _IRobloxProductsResources;

	public IPurchaseDialogResources PurchaseDialog => _IPurchaseDialogResources.Value;

	public IRedeemGameCardResources RedeemGameCard => _IRedeemGameCardResources.Value;

	public IRixtyPinResources RixtyPin => _IRixtyPinResources.Value;

	public IRobloxProductsResources RobloxProducts => _IRobloxProductsResources.Value;

	public PurchasingResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		_IPurchaseDialogResources = new Lazy<IPurchaseDialogResources>(() => PurchaseDialogResourceFactory.GetResources(locale, state));
		_IRedeemGameCardResources = new Lazy<IRedeemGameCardResources>(() => RedeemGameCardResourceFactory.GetResources(locale, state));
		_IRixtyPinResources = new Lazy<IRixtyPinResources>(() => RixtyPinResourceFactory.GetResources(locale, state));
		_IRobloxProductsResources = new Lazy<IRobloxProductsResources>(() => RobloxProductsResourceFactory.GetResources(locale, state));
	}

	public ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace)
	{
		if (string.IsNullOrWhiteSpace(fullTranslationResourceNamespace))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "fullTranslationResourceNamespace");
		}
		return fullTranslationResourceNamespace switch
		{
			"Purchasing.PurchaseDialog" => PurchaseDialog, 
			"Purchasing.RedeemGameCard" => RedeemGameCard, 
			"Purchasing.RixtyPin" => RixtyPin, 
			"Purchasing.RobloxProducts" => RobloxProducts, 
			_ => null, 
		};
	}
}
