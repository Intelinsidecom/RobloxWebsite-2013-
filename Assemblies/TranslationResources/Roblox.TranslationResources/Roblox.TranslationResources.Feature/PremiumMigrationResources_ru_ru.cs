namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_ru_ru : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Клуб создателей теперь стал Roblox Премиум";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Клуб создателей теперь стал Roblox Премиум";

	public PremiumMigrationResources_ru_ru(TranslationResourceState state)
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
		return $"Сейчас Премиум дает вам сразу месячный допуск к Robux вместо каждодневного! Сегодня мы дарим вам одноразовую выплату в размере {robuxAmount}.\n\nЗайдите в свою учетную запись Roblox, чтобы получить подробные сведения о выплате Robux и подписке Премиум. ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "Сейчас Премиум дает вам сразу месячный допуск к Robux вместо каждодневного! Сегодня мы дарим вам одноразовую выплату в размере {robuxAmount}.\n\nЗайдите в свою учетную запись Roblox, чтобы получить подробные сведения о выплате Robux и подписке Премиум. ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"Сейчас Премиум дает вам сразу месячный допуск к Robux вместо каждодневного! Сегодня мы дарим вам одноразовую выплату в размере {robuxAmount}.{newLine}{newLine}Зайдите в свою учетную запись Roblox, чтобы получить подробные сведения о выплате Robux и подписке Премиум.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "Сейчас Премиум дает вам сразу месячный допуск к Robux вместо каждодневного! Сегодня мы дарим вам одноразовую выплату в размере {robuxAmount}.{newLine}{newLine}Зайдите в свою учетную запись Roblox, чтобы получить подробные сведения о выплате Robux и подписке Премиум.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"Чем дальше продвигается подписчик, тем больше возрастает его ежемесячное получение Robux вместо ежедневного. Сегодня мы переводим {robuxAmount} Robux на вашу учетную запись, чтобы пополнить ваш счет за текущий месяц.\n{newLine}{newLine}\nПроверьте вашу учетную запись Roblox.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "Чем дальше продвигается подписчик, тем больше возрастает его ежемесячное получение Robux вместо ежедневного. Сегодня мы переводим {robuxAmount} Robux на вашу учетную запись, чтобы пополнить ваш счет за текущий месяц.\n{newLine}{newLine}\nПроверьте вашу учетную запись Roblox.  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Клуб создателей теперь стал Roblox Премиум";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"Чем дальше продвигается подписчик, тем больше возрастает его ежемесячное получение Robux вместо ежедневного. Сегодня мы переводим {robuxAmount} Robux на вашу учетную запись, чтобы пополнить ваш счет за текущий месяц.\n\nПроверьте вашу учетную запись Roblox.";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "Чем дальше продвигается подписчик, тем больше возрастает его ежемесячное получение Robux вместо ежедневного. Сегодня мы переводим {robuxAmount} Robux на вашу учетную запись, чтобы пополнить ваш счет за текущий месяц.\n\nПроверьте вашу учетную запись Roblox.";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Клуб создателей теперь стал Roblox Премиум";
	}
}
