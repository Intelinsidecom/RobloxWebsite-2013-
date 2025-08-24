namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubExpiringModalResources_fr_fr : BuildersClubExpiringModalResources_en_us, IBuildersClubExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.NoThanks"
	/// button text
	/// English String: "No, thanks."
	/// </summary>
	public override string ActionNoThanks => "Non merci.";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "Je veux renouveler\u00a0!";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "Oh non\u00a0! Votre abonnement au Builders Club a expiré\u00a0!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "Oh non\u00a0! Votre abonnement au Builders Club expirera dans un jour\u00a0!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "Oh non\u00a0! Votre abonnement au Builders Club expire aujourd'hui\u00a0!";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "Ne manquez rien, renouvelez maintenant\u00a0!";

	public BuildersClubExpiringModalResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "Non merci.";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "Je veux renouveler\u00a0!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "Oh non\u00a0! Votre abonnement au Builders Club a expiré\u00a0!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "Oh non\u00a0! Votre abonnement au Builders Club expirera dans un jour\u00a0!";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"Oh non\u00a0! Votre abonnement au Builders Club expirera dans {numDays} jours\u00a0!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "Oh non\u00a0! Votre abonnement au Builders Club expirera dans {numDays} jours\u00a0!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "Oh non\u00a0! Votre abonnement au Builders Club expire aujourd'hui\u00a0!";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "Ne manquez rien, renouvelez maintenant\u00a0!";
	}
}
