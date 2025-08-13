namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_ko_kr : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club 대신 Roblox 프리미엄이 생겼어요";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club 대신 Roblox 프리미엄이 생겼어요";

	public PremiumMigrationResources_ko_kr(TranslationResourceState state)
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
		return $"프리미엄에서는 Robux 지급이 기존의 일일 지급이 아닌 월별 총액 지급 방식으로 이루어집니다. 오늘 수령할 금액은 R${robuxAmount}입니다.\n\nRobux 지급 및 프리미엄 구독에 대한 자세한 내용을 Roblox 수신함에서 확인하세요.\n\n";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "프리미엄에서는 Robux 지급이 기존의 일일 지급이 아닌 월별 총액 지급 방식으로 이루어집니다. 오늘 수령할 금액은 R${robuxAmount}입니다.\n\nRobux 지급 및 프리미엄 구독에 대한 자세한 내용을 Roblox 수신함에서 확인하세요.\n\n";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"프리미엄에서는 Robux 지급이 기존의 일일 지급이 아닌 월별 총액 지급 방식으로 이루어집니다. 오늘 수령할 금액은 {robuxAmount}입니다.{newLine}{newLine}Robux 지급 및 프리미엄 구독에 대한 자세한 내용을 Roblox 수신함에서 확인하세요.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "프리미엄에서는 Robux 지급이 기존의 일일 지급이 아닌 월별 총액 지급 방식으로 이루어집니다. 오늘 수령할 금액은 {robuxAmount}입니다.{newLine}{newLine}Robux 지급 및 프리미엄 구독에 대한 자세한 내용을 Roblox 수신함에서 확인하세요.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"앞으로 가입자들은 Robux를 매일 지급받는 대신, 한 달에 한 번 몰아서 받게 됩니다. 따라서 오늘, 이번 달에 받아야 할 총 금액인 {robuxAmount} Robux가 계정에 한꺼번에 지급됩니다.\n{newLine}{newLine}\n자세한 내용은 Roblox 수신함에서 확인하세요.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "앞으로 가입자들은 Robux를 매일 지급받는 대신, 한 달에 한 번 몰아서 받게 됩니다. 따라서 오늘, 이번 달에 받아야 할 총 금액인 {robuxAmount} Robux가 계정에 한꺼번에 지급됩니다.\n{newLine}{newLine}\n자세한 내용은 Roblox 수신함에서 확인하세요.  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club 대신 Roblox 프리미엄이 생겼어요";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"앞으로 가입자들은 Robux를 매일 지급받는 대신, 한 달에 한 번 몰아서 받게 됩니다. 따라서 오늘, 이번 달에 받아야 할 총 금액인 {robuxAmount} Robux가 계정에 한꺼번에 지급됩니다.\n\n자세한 내용은 Roblox 수신함에서 확인하세요.";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "앞으로 가입자들은 Robux를 매일 지급받는 대신, 한 달에 한 번 몰아서 받게 됩니다. 따라서 오늘, 이번 달에 받아야 할 총 금액인 {robuxAmount} Robux가 계정에 한꺼번에 지급됩니다.\n\n자세한 내용은 Roblox 수신함에서 확인하세요.";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club 대신 Roblox 프리미엄이 생겼어요";
	}
}
