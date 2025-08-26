namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string HeadingMigrationModalTitle => "Builders Club heiÃŸt jetzt Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club heiÃŸt jetzt Roblox Premium";

	public PremiumMigrationWebResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationBody(string robuxAmount, string newLine)
	{
		return $"Abonnenten erhalten kÃ¼nftig einen monatlichen Robux-Pauschalbetrag, anstatt ihn in tÃ¤glichen Auszahlungen zu erhalten. Heute zahlen wir {robuxAmount} Robux auf dein Konto ein, um den Restbetrag auszugleichen, den du diesen Monat verdient hÃ¤ttest.\n{newLine} {newLine}\nÃœberprÃ¼fe deinen Roblox-Posteingang auf weitere Infos.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "Abonnenten erhalten kÃ¼nftig einen monatlichen Robux-Pauschalbetrag, anstatt ihn in tÃ¤glichen Auszahlungen zu erhalten. Heute zahlen wir {robuxAmount} Robux auf dein Konto ein, um den Restbetrag auszugleichen, den du diesen Monat verdient hÃ¤ttest.\n{newLine} {newLine}\nÃœberprÃ¼fe deinen Roblox-Posteingang auf weitere Infos.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full monthâ€™s worth of Robux on the day of your subscription renewal. Today, weâ€™re giving you this month's Robux minus what youâ€™ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"KÃ¼nftig erhÃ¤ltst du am Tag der VerlÃ¤ngerung deines Abonnements Robux im Wert von einem vollen Monat. Heute geben wir dir die Robux diesen Monats abzÃ¼glich dessen, was du diesen Monat bereits erhalten hast: {robuxAmount}. {newLine} {newLine}\nÃœberprÃ¼fe deinen Roblox-Posteingang auf weitere Infos.";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "KÃ¼nftig erhÃ¤ltst du am Tag der VerlÃ¤ngerung deines Abonnements Robux im Wert von einem vollen Monat. Heute geben wir dir die Robux diesen Monats abzÃ¼glich dessen, was du diesen Monat bereits erhalten hast: {robuxAmount}. {newLine} {newLine}\nÃœberprÃ¼fe deinen Roblox-Posteingang auf weitere Infos.";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club heiÃŸt jetzt Roblox Premium";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club heiÃŸt jetzt Roblox Premium";
	}
}


}
