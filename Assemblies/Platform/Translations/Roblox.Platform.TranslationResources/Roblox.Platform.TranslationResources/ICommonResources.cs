using System;
using System.Collections.Generic;
using Roblox.Platform.TranslationResources.Common;
namespace Roblox.Platform.TranslationResources {
    public interface ICommonResources : ITranslationResourcesNamespacesGroup

{
	IAlertsAndOptionsResources AlertsAndOptions { get; }

	IAssetTypesResources AssetTypes { get; }

	IBuildersClubResources BuildersClub { get; }

	ICaptchaResources Captcha { get; }

	IExternalLinksResources ExternalLinks { get; }

	IGameSortsResources GameSorts { get; }

	IPremiumFeaturesResources PremiumFeatures { get; }

	IPresenceResources Presence { get; }

	ITermsOfServiceResources TermsOfService { get; }

	IVisitGameResources VisitGame { get; }

	IWebUtilResources WebUtil { get; }
}


}


