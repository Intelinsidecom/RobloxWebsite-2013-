namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_zh_tw : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club 成為 Roblox Premium 了";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club 成為 Roblox Premium 了";

	public PremiumMigrationResources_zh_tw(TranslationResourceState state)
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
		return $"和以往每日發放 Robux 不同，Premium 將會每月發放整個月的 Robux 給您！我們今天會發放給您本月的 Robux 金額，扣除您已經獲得的金額。您將獲得：{robuxAmount}。\n\n若要了解ㄍ更多關於 Robux 發放和 Premium 訂閱的資訊，請前往收件匣。";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "和以往每日發放 Robux 不同，Premium 將會每月發放整個月的 Robux 給您！我們今天會發放給您本月的 Robux 金額，扣除您已經獲得的金額。您將獲得：{robuxAmount}。\n\n若要了解ㄍ更多關於 Robux 發放和 Premium 訂閱的資訊，請前往收件匣。";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"和以往每日發放 Robux 不同，Premium 將會每月發放整個月的 Robux 給您！我們今天會發放給您本月的 Robux 金額，扣除您已經獲得的金額。您將獲得：R${robuxAmount}。{newLine}{newLine}若要了解ㄍ更多關於 Robux 發放和 Premium 訂閱的資訊，請前往收件匣。";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "和以往每日發放 Robux 不同，Premium 將會每月發放整個月的 Robux 給您！我們今天會發放給您本月的 Robux 金額，扣除您已經獲得的金額。您將獲得：R${robuxAmount}。{newLine}{newLine}若要了解ㄍ更多關於 Robux 發放和 Premium 訂閱的資訊，請前往收件匣。";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"和以往每日發放 Robux 不同，訂閱者每個月將會獲得一整個月的 Robux 金額。我們今天會給您 {robuxAmount} Robux，補償您本月尚未獲得的金額。\n{newLine}{newLine}\n若要了解更多，請前往您的 Roblox 收件箱。";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "和以往每日發放 Robux 不同，訂閱者每個月將會獲得一整個月的 Robux 金額。我們今天會給您 {robuxAmount} Robux，補償您本月尚未獲得的金額。\n{newLine}{newLine}\n若要了解更多，請前往您的 Roblox 收件箱。";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club 成為 Roblox Premium 了";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"和以往每日發放 Robux 不同，訂閱者每個月將會獲得一整個月的 Robux 金額。我們今天會給您 {robuxAmount} Robux，補償您本月尚未獲得的金額。\n\n若要了解更多，請前往您的 Roblox 收件箱。";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "和以往每日發放 Robux 不同，訂閱者每個月將會獲得一整個月的 Robux 金額。我們今天會給您 {robuxAmount} Robux，補償您本月尚未獲得的金額。\n\n若要了解更多，請前往您的 Roblox 收件箱。";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club 成為 Roblox Premium 了";
	}
}
