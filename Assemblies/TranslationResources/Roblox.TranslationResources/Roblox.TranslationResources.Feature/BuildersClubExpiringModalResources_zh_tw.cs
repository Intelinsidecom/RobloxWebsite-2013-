namespace Roblox.TranslationResources.Feature;

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
	public override string ActionNoThanks => "不用，謝謝。";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "我想續訂！";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "糟糕，您的 Builders Club 會員資格到期了！";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "糟糕，您的 Builders Club 會員資格將在明天到期！";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "糟糕，您的 Builders Club 會員資格將在今天到期！";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "別錯過機會，現在就續訂吧！";

	public BuildersClubExpiringModalResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "不用，謝謝。";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "我想續訂！";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "糟糕，您的 Builders Club 會員資格到期了！";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "糟糕，您的 Builders Club 會員資格將在明天到期！";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"糟糕，您的 Builders Club 會員資格將在 {numDays} 天後到期！";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "糟糕，您的 Builders Club 會員資格將在 {numDays} 天後到期！";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "糟糕，您的 Builders Club 會員資格將在今天到期！";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "別錯過機會，現在就續訂吧！";
	}
}
