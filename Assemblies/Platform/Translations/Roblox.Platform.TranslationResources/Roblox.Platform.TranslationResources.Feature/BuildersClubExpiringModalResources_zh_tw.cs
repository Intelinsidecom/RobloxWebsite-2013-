namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubExpiringModalResources_zh_tw : BuildersClubExpiringModalResources_en_us, IBuildersClubExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.NoThanks"
	/// button text
	/// English String: "No, thanks."
	/// </summary>
	public override string ActionNoThanks => "ä¸ç”¨ï¼Œè¬è¬ã€‚";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "æˆ‘æƒ³çºŒè¨‚ï¼";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "ç³Ÿç³•ï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼åˆ°æœŸäº†ï¼";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "ç³Ÿç³•ï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼å°‡åœ¨æ˜Žå¤©åˆ°æœŸï¼";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "ç³Ÿç³•ï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼å°‡åœ¨ä»Šå¤©åˆ°æœŸï¼";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "åˆ¥éŒ¯éŽæ©Ÿæœƒï¼Œç¾åœ¨å°±çºŒè¨‚å§ï¼";

	public BuildersClubExpiringModalResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "ä¸ç”¨ï¼Œè¬è¬ã€‚";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "æˆ‘æƒ³çºŒè¨‚ï¼";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "ç³Ÿç³•ï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼åˆ°æœŸäº†ï¼";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "ç³Ÿç³•ï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼å°‡åœ¨æ˜Žå¤©åˆ°æœŸï¼";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"ç³Ÿç³•ï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼å°‡åœ¨ {numDays} å¤©å¾Œåˆ°æœŸï¼";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "ç³Ÿç³•ï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼å°‡åœ¨ {numDays} å¤©å¾Œåˆ°æœŸï¼";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "ç³Ÿç³•ï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼å°‡åœ¨ä»Šå¤©åˆ°æœŸï¼";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "åˆ¥éŒ¯éŽæ©Ÿæœƒï¼Œç¾åœ¨å°±çºŒè¨‚å§ï¼";
	}
}


}
