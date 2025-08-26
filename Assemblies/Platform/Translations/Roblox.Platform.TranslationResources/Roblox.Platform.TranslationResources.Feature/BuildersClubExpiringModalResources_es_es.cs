namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubExpiringModalResources_es_es : BuildersClubExpiringModalResources_en_us, IBuildersClubExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.NoThanks"
	/// button text
	/// English String: "No, thanks."
	/// </summary>
	public override string ActionNoThanks => "No, gracias.";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "Â¡Quiero renovar!";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "Â¡Oh, no! Â¡Tu suscripciÃ³n al Builders Club ha caducado!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "Â¡Oh, no! Â¡Tu suscripciÃ³n al Builders Club caduca en un dÃ­a!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "Â¡Oh, no! Â¡Tu suscripciÃ³n al Builders Club caduca hoy!";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "Â¡No te pierdas nada! Â¡Renueva ya!";

	public BuildersClubExpiringModalResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "No, gracias.";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "Â¡Quiero renovar!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "Â¡Oh, no! Â¡Tu suscripciÃ³n al Builders Club ha caducado!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "Â¡Oh, no! Â¡Tu suscripciÃ³n al Builders Club caduca en un dÃ­a!";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"Â¡Oh, no! Â¡Tu suscripciÃ³n al Builders Club caduca en {numDays} dÃ­as!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "Â¡Oh, no! Â¡Tu suscripciÃ³n al Builders Club caduca en {numDays} dÃ­as!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "Â¡Oh, no! Â¡Tu suscripciÃ³n al Builders Club caduca hoy!";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "Â¡No te pierdas nada! Â¡Renueva ya!";
	}
}


}
