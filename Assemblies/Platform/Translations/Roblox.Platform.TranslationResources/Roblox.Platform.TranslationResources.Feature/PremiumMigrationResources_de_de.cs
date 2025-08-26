namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_de_de : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club heiÃŸt jetzt Roblox Premium";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club heiÃŸt jetzt Roblox Premium";

	public PremiumMigrationResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}\n\nCheck your Roblox inbox to learn more about your Robux payout and Premium subscription. "
	/// </summary>
	public override string DescriptionMigrationBody(string robuxAmount)
	{
		return $"Mit Premium erhÃ¤ltst du jetzt eine monatliche Robux-Zahlung anstelle einer tÃ¤glichen Zahlung. Heute schenken wir dir eine einmalige Auszahlung von {robuxAmount}.\n\nÃœberprÃ¼fe deinen Roblox-Posteingang, um mehr Ã¼ber deine Robux-Auszahlung und dein Premium-Abonnement zu erfahren. ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "Mit Premium erhÃ¤ltst du jetzt eine monatliche Robux-Zahlung anstelle einer tÃ¤glichen Zahlung. Heute schenken wir dir eine einmalige Auszahlung von {robuxAmount}.\n\nÃœberprÃ¼fe deinen Roblox-Posteingang, um mehr Ã¼ber deine Robux-Auszahlung und dein Premium-Abonnement zu erfahren. ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"Mit Premium erhÃ¤ltst du jetzt eine monatliche Robux-Zahlung anstelle einer tÃ¤glichen Zahlung. Heute schenken wir dir eine einmalige Auszahlung von R {robuxAmount}.{newLine}{newLine}ÃœberprÃ¼fe deinen Roblox-Posteingang, um mehr Ã¼ber deine Robux-Auszahlung und dein Premium-Abonnement zu erfahren.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "Mit Premium erhÃ¤ltst du jetzt eine monatliche Robux-Zahlung anstelle einer tÃ¤glichen Zahlung. Heute schenken wir dir eine einmalige Auszahlung von R {robuxAmount}.{newLine}{newLine}ÃœberprÃ¼fe deinen Roblox-Posteingang, um mehr Ã¼ber deine Robux-Auszahlung und dein Premium-Abonnement zu erfahren.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"Abonnenten erhalten kÃ¼nftig einen monatlichen Robux-Pauschalbetrag, anstatt ihn in tÃ¤glichen Auszahlungen zu erhalten. Heute zahlen wir {robuxAmount} Robux auf dein Konto ein, um den verbleibenden Betrag auszugleichen, den du diesen Monat verdient hÃ¤ttest.\n{newLine}{newLine}\nÃœberprÃ¼fe deinen Roblox-Posteingang fÃ¼r weitere Infos.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "Abonnenten erhalten kÃ¼nftig einen monatlichen Robux-Pauschalbetrag, anstatt ihn in tÃ¤glichen Auszahlungen zu erhalten. Heute zahlen wir {robuxAmount} Robux auf dein Konto ein, um den verbleibenden Betrag auszugleichen, den du diesen Monat verdient hÃ¤ttest.\n{newLine}{newLine}\nÃœberprÃ¼fe deinen Roblox-Posteingang fÃ¼r weitere Infos.  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club heiÃŸt jetzt Roblox Premium";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"Abonnenten erhalten kÃ¼nftig einen monatlichen Robux-Pauschalbetrag, anstatt ihn in tÃ¤glichen Auszahlungen zu erhalten. Heute zahlen wir {robuxAmount} Robux auf dein Konto ein, um den verbleibenden Betrag auszugleichen, den du diesen Monat verdient hÃ¤ttest.\n\nÃœberprÃ¼fe deinen Roblox-Posteingang fÃ¼r weitere Infos.";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "Abonnenten erhalten kÃ¼nftig einen monatlichen Robux-Pauschalbetrag, anstatt ihn in tÃ¤glichen Auszahlungen zu erhalten. Heute zahlen wir {robuxAmount} Robux auf dein Konto ein, um den verbleibenden Betrag auszugleichen, den du diesen Monat verdient hÃ¤ttest.\n\nÃœberprÃ¼fe deinen Roblox-Posteingang fÃ¼r weitere Infos.";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club heiÃŸt jetzt Roblox Premium";
	}
}


}
