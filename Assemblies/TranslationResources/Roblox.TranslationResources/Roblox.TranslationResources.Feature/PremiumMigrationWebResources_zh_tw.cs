namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_zh_tw : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Club 已成為 Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club 已成為 Roblox Premium";

	public PremiumMigrationWebResources_zh_tw(TranslationResourceState state)
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
		return $"從現在開始，您會在訂閱更新當天獲得一整個月的 Robux 金額。我們今天會給您本月尚未獲得的 Robux 金額：{robuxAmount}。\n{newLine}{newLine}\n若需更多資訊，請前往收件箱。";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "從現在開始，您會在訂閱更新當天獲得一整個月的 Robux 金額。我們今天會給您本月尚未獲得的 Robux 金額：{robuxAmount}。\n{newLine}{newLine}\n若需更多資訊，請前往收件箱。";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"從現在開始，您會在訂閱更新當天獲得一整個月的 Robux 金額。我們今天會給您本月尚未獲得的 Robux 金額：{robuxAmount}。{newLine}{newLine}若需更多資訊，請前往收件箱。";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "從現在開始，您會在訂閱更新當天獲得一整個月的 Robux 金額。我們今天會給您本月尚未獲得的 Robux 金額：{robuxAmount}。{newLine}{newLine}若需更多資訊，請前往收件箱。";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club 已成為 Roblox Premium";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club 已成為 Roblox Premium";
	}
}
