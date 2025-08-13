namespace Roblox.TranslationResources.Feature;

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
	public override string ActionWantToRenew => "¡Quiero renovar!";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "¡Oh, no! ¡Tu suscripción al Builders Club ha caducado!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "¡Oh, no! ¡Tu suscripción al Builders Club caduca en un día!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "¡Oh, no! ¡Tu suscripción al Builders Club caduca hoy!";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "¡No te pierdas nada! ¡Renueva ya!";

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
		return "¡Quiero renovar!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "¡Oh, no! ¡Tu suscripción al Builders Club ha caducado!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "¡Oh, no! ¡Tu suscripción al Builders Club caduca en un día!";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"¡Oh, no! ¡Tu suscripción al Builders Club caduca en {numDays} días!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "¡Oh, no! ¡Tu suscripción al Builders Club caduca en {numDays} días!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "¡Oh, no! ¡Tu suscripción al Builders Club caduca hoy!";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "¡No te pierdas nada! ¡Renueva ya!";
	}
}
