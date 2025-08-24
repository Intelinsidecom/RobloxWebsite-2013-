using System;
using Roblox.TranslationResources.Common;

namespace Roblox.TranslationResources;

internal class CommonResources : ICommonResources, ITranslationResourcesNamespacesGroup
{
	private readonly Lazy<IAlertsAndOptionsResources> _IAlertsAndOptionsResources;

	private readonly Lazy<IAssetTypesResources> _IAssetTypesResources;

	private readonly Lazy<IBuildersClubResources> _IBuildersClubResources;

	private readonly Lazy<ICaptchaResources> _ICaptchaResources;

	private readonly Lazy<IExternalLinksResources> _IExternalLinksResources;

	private readonly Lazy<IGameSortsResources> _IGameSortsResources;

	private readonly Lazy<IPremiumFeaturesResources> _IPremiumFeaturesResources;

	private readonly Lazy<IPresenceResources> _IPresenceResources;

	private readonly Lazy<ITermsOfServiceResources> _ITermsOfServiceResources;

	private readonly Lazy<IVisitGameResources> _IVisitGameResources;

	private readonly Lazy<IWebUtilResources> _IWebUtilResources;

	public IAlertsAndOptionsResources AlertsAndOptions => _IAlertsAndOptionsResources.Value;

	public IAssetTypesResources AssetTypes => _IAssetTypesResources.Value;

	public IBuildersClubResources BuildersClub => _IBuildersClubResources.Value;

	public ICaptchaResources Captcha => _ICaptchaResources.Value;

	public IExternalLinksResources ExternalLinks => _IExternalLinksResources.Value;

	public IGameSortsResources GameSorts => _IGameSortsResources.Value;

	public IPremiumFeaturesResources PremiumFeatures => _IPremiumFeaturesResources.Value;

	public IPresenceResources Presence => _IPresenceResources.Value;

	public ITermsOfServiceResources TermsOfService => _ITermsOfServiceResources.Value;

	public IVisitGameResources VisitGame => _IVisitGameResources.Value;

	public IWebUtilResources WebUtil => _IWebUtilResources.Value;

	public CommonResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		_IAlertsAndOptionsResources = new Lazy<IAlertsAndOptionsResources>(() => AlertsAndOptionsResourceFactory.GetResources(locale, state));
		_IAssetTypesResources = new Lazy<IAssetTypesResources>(() => AssetTypesResourceFactory.GetResources(locale, state));
		_IBuildersClubResources = new Lazy<IBuildersClubResources>(() => BuildersClubResourceFactory.GetResources(locale, state));
		_ICaptchaResources = new Lazy<ICaptchaResources>(() => CaptchaResourceFactory.GetResources(locale, state));
		_IExternalLinksResources = new Lazy<IExternalLinksResources>(() => ExternalLinksResourceFactory.GetResources(locale, state));
		_IGameSortsResources = new Lazy<IGameSortsResources>(() => GameSortsResourceFactory.GetResources(locale, state));
		_IPremiumFeaturesResources = new Lazy<IPremiumFeaturesResources>(() => PremiumFeaturesResourceFactory.GetResources(locale, state));
		_IPresenceResources = new Lazy<IPresenceResources>(() => PresenceResourceFactory.GetResources(locale, state));
		_ITermsOfServiceResources = new Lazy<ITermsOfServiceResources>(() => TermsOfServiceResourceFactory.GetResources(locale, state));
		_IVisitGameResources = new Lazy<IVisitGameResources>(() => VisitGameResourceFactory.GetResources(locale, state));
		_IWebUtilResources = new Lazy<IWebUtilResources>(() => WebUtilResourceFactory.GetResources(locale, state));
	}

	public ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace)
	{
		if (string.IsNullOrWhiteSpace(fullTranslationResourceNamespace))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "fullTranslationResourceNamespace");
		}
		return fullTranslationResourceNamespace switch
		{
			"Common.AlertsAndOptions" => AlertsAndOptions, 
			"Common.AssetTypes" => AssetTypes, 
			"Common.BuildersClub" => BuildersClub, 
			"Common.Captcha" => Captcha, 
			"Common.ExternalLinks" => ExternalLinks, 
			"Common.GameSorts" => GameSorts, 
			"Common.PremiumFeatures" => PremiumFeatures, 
			"Common.Presence" => Presence, 
			"Common.TermsOfService" => TermsOfService, 
			"Common.VisitGame" => VisitGame, 
			"Common.WebUtil" => WebUtil, 
			_ => null, 
		};
	}
}
