namespace Roblox.TranslationResources.Feature;

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
	public override string ActionNoThanks => "しない";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "更新する！";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "Builders Clubメンバーシップの期限が満了しました！";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "Builders Clubメンバーシップの期限が満了するまで1日を切っています！";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "Builders Clubメンバーシップの期限が本日で満了します！";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "この機会をお見逃しなく、今すぐ更新しましょう！";

	public BuildersClubExpiringModalResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "しない";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "更新する！";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "Builders Clubメンバーシップの期限が満了しました！";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "Builders Clubメンバーシップの期限が満了するまで1日を切っています！";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"Builders Clubメンバーシップの期限が満了するまで{numDays}日を切っています！";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "Builders Clubメンバーシップの期限が満了するまで{numDays}日を切っています！";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "Builders Clubメンバーシップの期限が本日で満了します！";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "この機会をお見逃しなく、今すぐ更新しましょう！";
	}
}
