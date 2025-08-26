namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubExpiringModalResources_ja_jp : BuildersClubExpiringModalResources_en_us, IBuildersClubExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.NoThanks"
	/// button text
	/// English String: "No, thanks."
	/// </summary>
	public override string ActionNoThanks => "ã—ãªã„";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "æ›´æ–°ã™ã‚‹ï¼";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒæº€äº†ã—ã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒæº€äº†ã™ã‚‹ã¾ã§1æ—¥ã‚’åˆ‡ã£ã¦ã„ã¾ã™ï¼";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒæœ¬æ—¥ã§æº€äº†ã—ã¾ã™ï¼";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "ã“ã®æ©Ÿä¼šã‚’ãŠè¦‹é€ƒã—ãªãã€ä»Šã™ãæ›´æ–°ã—ã¾ã—ã‚‡ã†ï¼";

	public BuildersClubExpiringModalResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "ã—ãªã„";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "æ›´æ–°ã™ã‚‹ï¼";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒæº€äº†ã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒæº€äº†ã™ã‚‹ã¾ã§1æ—¥ã‚’åˆ‡ã£ã¦ã„ã¾ã™ï¼";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒæº€äº†ã™ã‚‹ã¾ã§{numDays}æ—¥ã‚’åˆ‡ã£ã¦ã„ã¾ã™ï¼";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒæº€äº†ã™ã‚‹ã¾ã§{numDays}æ—¥ã‚’åˆ‡ã£ã¦ã„ã¾ã™ï¼";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒæœ¬æ—¥ã§æº€äº†ã—ã¾ã™ï¼";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "ã“ã®æ©Ÿä¼šã‚’ãŠè¦‹é€ƒã—ãªãã€ä»Šã™ãæ›´æ–°ã—ã¾ã—ã‚‡ã†ï¼";
	}
}


}
