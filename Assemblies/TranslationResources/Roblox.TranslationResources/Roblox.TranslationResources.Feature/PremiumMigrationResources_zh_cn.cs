namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_zh_cn : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club 现已更名为 Roblox Premium";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club 现已更名为 Roblox Premium";

	public PremiumMigrationResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}\n\nCheck your Roblox inbox to learn more about your Robux payout and Premium subscription. "
	/// </summary>
	public override string DescriptionMigrationBody(string robuxAmount)
	{
		return $"和以往每日发放 Robux 不同，Premium 将会每月一次性发放整个月的 Robux 给你！我们今天会一次性支付给你 {robuxAmount}。\n\n若要了解更多关于 Robux 支付与 Premium 订阅的信息，请前往 Roblox 收件箱。 ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "和以往每日发放 Robux 不同，Premium 将会每月一次性发放整个月的 Robux 给你！我们今天会一次性支付给你 {robuxAmount}。\n\n若要了解更多关于 Robux 支付与 Premium 订阅的信息，请前往 Roblox 收件箱。 ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"和以往每日发放 Robux 不同，Premium 将会每月一次性发放整个月的 Robux 给你！我们今天会一次性支付给你 {robuxAmount}。{newLine}{newLine}若要了解更多关于 Robux 支付与 Premium 订阅的信息，请前往 Roblox 收件箱。  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "和以往每日发放 Robux 不同，Premium 将会每月一次性发放整个月的 Robux 给你！我们今天会一次性支付给你 {robuxAmount}。{newLine}{newLine}若要了解更多关于 Robux 支付与 Premium 订阅的信息，请前往 Roblox 收件箱。  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"即日起，订阅者将直接获得一整个月的 Robux 额度，而无需等待每日发放的额度。我们今天会给你 {robuxAmount} Robux 以补偿你本月尚未获得的额度。\n{newLine}{newLine}\n要了解更多信息，请前往你的 Roblox 收件箱。  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "即日起，订阅者将直接获得一整个月的 Robux 额度，而无需等待每日发放的额度。我们今天会给你 {robuxAmount} Robux 以补偿你本月尚未获得的额度。\n{newLine}{newLine}\n要了解更多信息，请前往你的 Roblox 收件箱。  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club 现已更名为 Roblox Premium";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"即日起，订阅者将直接获得一整个月的 Robux 额度，而无需等待每日发放的额度。我们今天会给你 {robuxAmount} Robux 以补偿你本月尚未获得的额度。\n\n要了解更多信息，请前往你的 Roblox 收件箱。";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "即日起，订阅者将直接获得一整个月的 Robux 额度，而无需等待每日发放的额度。我们今天会给你 {robuxAmount} Robux 以补偿你本月尚未获得的额度。\n\n要了解更多信息，请前往你的 Roblox 收件箱。";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club 现已更名为 Roblox Premium";
	}
}
