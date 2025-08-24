using Roblox.TranslationResources.Purchasing;

namespace Roblox.TranslationResources;

public interface IPurchasingResources : ITranslationResourcesNamespacesGroup
{
	IPurchaseDialogResources PurchaseDialog { get; }

	IRedeemGameCardResources RedeemGameCard { get; }

	IRixtyPinResources RixtyPin { get; }

	IRobloxProductsResources RobloxProducts { get; }
}
