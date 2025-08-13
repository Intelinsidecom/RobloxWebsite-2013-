namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubExpiringModalResources_pt_br : BuildersClubExpiringModalResources_en_us, IBuildersClubExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.NoThanks"
	/// button text
	/// English String: "No, thanks."
	/// </summary>
	public override string ActionNoThanks => "Não, obrigado.";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "Quero renovar!";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "Ah não! Sua assinatura do Builders Club expirou!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "Ah não! Sua assinatura do Builders Club expira em um dia!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "Ah não! Sua assinatura do Builders Club expira hoje!";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "Não perca tempo. Renove agora!";

	public BuildersClubExpiringModalResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "Não, obrigado.";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "Quero renovar!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "Ah não! Sua assinatura do Builders Club expirou!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "Ah não! Sua assinatura do Builders Club expira em um dia!";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"Ah não! Sua assinatura do Builders Club expira em {numDays} dias!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "Ah não! Sua assinatura do Builders Club expira em {numDays} dias!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "Ah não! Sua assinatura do Builders Club expira hoje!";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "Não perca tempo. Renove agora!";
	}
}
