namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_ja_jp : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Clubは現在はRoblox Premiumです";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Clubは現在はRoblox Premiumです";

	public PremiumMigrationWebResources_ja_jp(TranslationResourceState state)
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
		return $"これからは、サブスクリプション契約者は一日ごとのRobux額ではなく、一ヶ月ごとのご利用額を一度にお渡しします。今日は、お持ちのアカウントに今月お渡しする予定だった残りの {robuxAmount} Robuxをお支払いします。\n{newLine}{newLine}\n詳しくは、Roblox受信トレイをチェックしてください。  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "これからは、サブスクリプション契約者は一日ごとのRobux額ではなく、一ヶ月ごとのご利用額を一度にお渡しします。今日は、お持ちのアカウントに今月お渡しする予定だった残りの {robuxAmount} Robuxをお支払いします。\n{newLine}{newLine}\n詳しくは、Roblox受信トレイをチェックしてください。  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"これからは、サブスクリプション更新日に一ヶ月分のRobuxご利用額を一度にお渡しします。今日は、お持ちのアカウントに今月分からすでに受け取った額を差し引きした残りのRobuxをお支払いします: \n{robuxAmount}.{newLine}{newLine}\n詳しくは、Roblox受信トレイをチェックしてください。";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "これからは、サブスクリプション更新日に一ヶ月分のRobuxご利用額を一度にお渡しします。今日は、お持ちのアカウントに今月分からすでに受け取った額を差し引きした残りのRobuxをお支払いします: \n{robuxAmount}.{newLine}{newLine}\n詳しくは、Roblox受信トレイをチェックしてください。";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Clubは現在はRoblox Premiumです";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Clubは現在はRoblox Premiumです";
	}
}
