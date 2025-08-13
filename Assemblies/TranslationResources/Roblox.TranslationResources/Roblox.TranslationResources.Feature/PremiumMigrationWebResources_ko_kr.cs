namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_ko_kr : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Club 대신 Roblox Premium이 생겼어요";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club 대신 Roblox Premium이 생겼어요";

	public PremiumMigrationWebResources_ko_kr(TranslationResourceState state)
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
		return $"앞으로 가입자들은 Robux를 매일 지급받는 대신, 한 달에 한 번 몰아서 받게 됩니다. 따라서 오늘, 이번 달에 받아야 할 총 금액인 {robuxAmount} Robux가 계정에 한꺼번에 지급됩니다.\n{newLine}{newLine}\n자세한 내용은 Roblox 수신함에서 확인하세요.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "앞으로 가입자들은 Robux를 매일 지급받는 대신, 한 달에 한 번 몰아서 받게 됩니다. 따라서 오늘, 이번 달에 받아야 할 총 금액인 {robuxAmount} Robux가 계정에 한꺼번에 지급됩니다.\n{newLine}{newLine}\n자세한 내용은 Roblox 수신함에서 확인하세요.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"이제부터는 매월 가입 갱신일마다 한 달치 Robux가 한꺼번에 지급됩니다. 따라서 오늘, 회원님은 이번 달에 이미 받은 액수를 제외한 금액인 {robuxAmount}를 받게 되죠.{newLine}{newLine}\n자세한 내용은 Roblox 수신함에서 확인하세요.";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "이제부터는 매월 가입 갱신일마다 한 달치 Robux가 한꺼번에 지급됩니다. 따라서 오늘, 회원님은 이번 달에 이미 받은 액수를 제외한 금액인 {robuxAmount}를 받게 되죠.{newLine}{newLine}\n자세한 내용은 Roblox 수신함에서 확인하세요.";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club 대신 Roblox Premium이 생겼어요";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club 대신 Roblox Premium이 생겼어요";
	}
}
