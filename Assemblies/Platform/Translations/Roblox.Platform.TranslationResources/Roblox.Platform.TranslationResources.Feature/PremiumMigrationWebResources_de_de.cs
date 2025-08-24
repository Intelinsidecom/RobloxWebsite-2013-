namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_de_de : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Club heißt jetzt Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club heißt jetzt Roblox Premium";

	public PremiumMigrationWebResources_de_de(TranslationResourceState state)
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
		return $"Abonnenten erhalten künftig einen monatlichen Robux-Pauschalbetrag, anstatt ihn in täglichen Auszahlungen zu erhalten. Heute zahlen wir {robuxAmount} Robux auf dein Konto ein, um den Restbetrag auszugleichen, den du diesen Monat verdient hättest.\n{newLine} {newLine}\nÜberprüfe deinen Roblox-Posteingang auf weitere Infos.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "Abonnenten erhalten künftig einen monatlichen Robux-Pauschalbetrag, anstatt ihn in täglichen Auszahlungen zu erhalten. Heute zahlen wir {robuxAmount} Robux auf dein Konto ein, um den Restbetrag auszugleichen, den du diesen Monat verdient hättest.\n{newLine} {newLine}\nÜberprüfe deinen Roblox-Posteingang auf weitere Infos.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"Künftig erhältst du am Tag der Verlängerung deines Abonnements Robux im Wert von einem vollen Monat. Heute geben wir dir die Robux diesen Monats abzüglich dessen, was du diesen Monat bereits erhalten hast: {robuxAmount}. {newLine} {newLine}\nÜberprüfe deinen Roblox-Posteingang auf weitere Infos.";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "Künftig erhältst du am Tag der Verlängerung deines Abonnements Robux im Wert von einem vollen Monat. Heute geben wir dir die Robux diesen Monats abzüglich dessen, was du diesen Monat bereits erhalten hast: {robuxAmount}. {newLine} {newLine}\nÜberprüfe deinen Roblox-Posteingang auf weitere Infos.";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club heißt jetzt Roblox Premium";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club heißt jetzt Roblox Premium";
	}
}
