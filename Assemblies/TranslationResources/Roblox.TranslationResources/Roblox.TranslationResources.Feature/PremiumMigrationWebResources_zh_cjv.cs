namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_zh_cjv : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Club 现已更名为 Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club 现已更名为 Roblox Premium";

	public PremiumMigrationWebResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationBody(string robuxAmount, string newLine)
	{
		return $"即日起，订阅者将直接获得一整个月的 Robux 额度，而无需等待每日发放的额度。我们今天会给你 {robuxAmount} Robux 以补偿你本月尚未获得的额度。\n{newLine}{newLine}\n要了解更多信息，请前往你的 Roblox 收件箱。  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "即日起，订阅者将直接获得一整个月的 Robux 额度，而无需等待每日发放的额度。我们今天会给你 {robuxAmount} Robux 以补偿你本月尚未获得的额度。\n{newLine}{newLine}\n要了解更多信息，请前往你的 Roblox 收件箱。  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"即日起，你在更新订阅的当天将直接获得一整个月的 Robux 额度。我们将把本月的 Robux 减去你在本月已经拿到的额度，你将拿到的总额为：{robuxAmount}。{newLine}{newLine}\n要了解更多信息，请前往你的 Roblox 收件箱。";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "即日起，你在更新订阅的当天将直接获得一整个月的 Robux 额度。我们将把本月的 Robux 减去你在本月已经拿到的额度，你将拿到的总额为：{robuxAmount}。{newLine}{newLine}\n要了解更多信息，请前往你的 Roblox 收件箱。";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club 现已更名为 Roblox Premium";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club 现已更名为 Roblox Premium";
	}
}
