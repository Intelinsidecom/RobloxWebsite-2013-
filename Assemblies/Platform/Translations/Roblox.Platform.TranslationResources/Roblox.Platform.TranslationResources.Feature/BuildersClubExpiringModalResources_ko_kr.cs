namespace Roblox.TranslationResources.Feature;

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
	public override string ActionNoThanks => "아니요, 갱신하지 않겠습니다.";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public override string ActionWantToRenew => "갱신하고 싶어요!";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public override string DescriptionBuildersClubExpired => "이런! Builders Club 멤버십이 만료되었습니다.";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringOneDay => "이런! Builders Club 멤버십이 하루 후 만료됩니다.";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringToday => "이런! Builders Club 멤버십이 오늘 만료됩니다.";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public override string HeadingDontMissRenewNow => "놓치지 마세요. 지금 갱신하세요!";

	public BuildersClubExpiringModalResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionNoThanks()
	{
		return "아니요, 갱신하지 않겠습니다.";
	}

	protected override string _GetTemplateForActionWantToRenew()
	{
		return "갱신하고 싶어요!";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "이런! Builders Club 멤버십이 만료되었습니다.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "이런! Builders Club 멤버십이 하루 후 만료됩니다.";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public override string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"이런! Builders Club 멤버십 {numDays}일 후 만료됩니다.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "이런! Builders Club 멤버십 {numDays}일 후 만료됩니다.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "이런! Builders Club 멤버십이 오늘 만료됩니다.";
	}

	protected override string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "놓치지 마세요. 지금 갱신하세요!";
	}
}
