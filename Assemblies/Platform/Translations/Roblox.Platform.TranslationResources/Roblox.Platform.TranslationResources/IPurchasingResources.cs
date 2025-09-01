using System;
using System.Collections.Generic;
using Roblox.Platform.TranslationResources.Purchasing;
namespace Roblox.Platform.TranslationResources {
    public interface IPurchasingResources : ITranslationResourcesNamespacesGroup

{
	IPurchaseDialogResources PurchaseDialog { get; }

	IRedeemGameCardResources RedeemGameCard { get; }

	IRixtyPinResources RixtyPin { get; }

	IRobloxProductsResources RobloxProducts { get; }
}


}


