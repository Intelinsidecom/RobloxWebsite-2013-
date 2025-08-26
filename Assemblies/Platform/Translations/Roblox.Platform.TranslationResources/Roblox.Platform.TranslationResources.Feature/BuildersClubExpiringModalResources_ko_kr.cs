namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubExpiringModalResources_ko_kr : BuildersClubExpiringModalResources_en_us, IBuildersClubExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.NoThanks"
	/// button text
	/// English String: "No, thanks."
	/// </summary>
	public override string ActionNoThanks => "ì•„ë‹ˆìš”, ê°±ì‹ í•˜ì§€ ì•Šê² ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "ê°±ì‹ í•˜ê³  ì‹¶ì–´ìš”!";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "ì´ëŸ°! Builders Club ë©¤ë²„ì‹­ì´ ë§Œë£Œë˜ì—ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "ì´ëŸ°! Builders Club ë©¤ë²„ì‹­ì´ í•˜ë£¨ í›„ ë§Œë£Œë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "ì´ëŸ°! Builders Club ë©¤ë²„ì‹­ì´ ì˜¤ëŠ˜ ë§Œë£Œë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "ë†“ì¹˜ì§€ ë§ˆì„¸ìš”. ì§€ê¸ˆ ê°±ì‹ í•˜ì„¸ìš”!";

	public BuildersClubExpiringModalResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "ì•„ë‹ˆìš”, ê°±ì‹ í•˜ì§€ ì•Šê² ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "ê°±ì‹ í•˜ê³  ì‹¶ì–´ìš”!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "ì´ëŸ°! Builders Club ë©¤ë²„ì‹­ì´ ë§Œë£Œë˜ì—ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "ì´ëŸ°! Builders Club ë©¤ë²„ì‹­ì´ í•˜ë£¨ í›„ ë§Œë£Œë©ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"ì´ëŸ°! Builders Club ë©¤ë²„ì‹­ {numDays}ì¼ í›„ ë§Œë£Œë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "ì´ëŸ°! Builders Club ë©¤ë²„ì‹­ {numDays}ì¼ í›„ ë§Œë£Œë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "ì´ëŸ°! Builders Club ë©¤ë²„ì‹­ì´ ì˜¤ëŠ˜ ë§Œë£Œë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "ë†“ì¹˜ì§€ ë§ˆì„¸ìš”. ì§€ê¸ˆ ê°±ì‹ í•˜ì„¸ìš”!";
	}
}


}
