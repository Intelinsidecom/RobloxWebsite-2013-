namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubExpiringModalResources_de_de : BuildersClubExpiringModalResources_en_us, IBuildersClubExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.NoThanks"
	/// button text
	/// English String: "No, thanks."
	/// </summary>
	public override string ActionNoThanks => "Nein danke.";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "Ich möchte verlängern!";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "Oh nein! Deine „Builders Club“-Mitgliedschaft ist abgelaufen!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "Oh nein! Deine „Builders Club“-Mitgliedschaft läuft in einem Tag ab!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "Oh nein! Deine „Builders Club“-Mitgliedschaft läuft heute ab!";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "Nicht verpassen. Jetzt verlängern!";

	public BuildersClubExpiringModalResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "Nein danke.";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "Ich möchte verlängern!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "Oh nein! Deine „Builders Club“-Mitgliedschaft ist abgelaufen!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "Oh nein! Deine „Builders Club“-Mitgliedschaft läuft in einem Tag ab!";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"Oh nein! Deine „Builders Club“-Mitgliedschaft läuft in {numDays} Tagen ab!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "Oh nein! Deine „Builders Club“-Mitgliedschaft läuft in {numDays} Tagen ab!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "Oh nein! Deine „Builders Club“-Mitgliedschaft läuft heute ab!";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "Nicht verpassen. Jetzt verlängern!";
	}
}
