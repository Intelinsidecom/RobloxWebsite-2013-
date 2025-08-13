namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_it_it : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Il Builders Club ora si chiama Roblox Premium";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Il Builders Club ora si chiama Roblox Premium";

	public PremiumMigrationResources_it_it(TranslationResourceState state)
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
		return $"La versione Premium ora ti regala una somma mensile di Robux tutta in una volta, invece che assegnartela quotidianamente! Oggi riceverai un pagamento una tantum di {robuxAmount}\n\nControlla la tua posta in arrivo Roblox per maggiori dettagli sul tuo pagamento Robux e sull'abbonamento Premium. ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "La versione Premium ora ti regala una somma mensile di Robux tutta in una volta, invece che assegnartela quotidianamente! Oggi riceverai un pagamento una tantum di {robuxAmount}\n\nControlla la tua posta in arrivo Roblox per maggiori dettagli sul tuo pagamento Robux e sull'abbonamento Premium. ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"La versione Premium ora ti regala una somma mensile di Robux tutta in una volta, invece che assegnartela quotidianamente! Oggi riceverai un pagamento una tantum di {robuxAmount}.{newLine}{newLine}Controlla la tua posta in arrivo Roblox per maggiori dettagli sul tuo pagamento Robux e sull'abbonamento Premium.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "La versione Premium ora ti regala una somma mensile di Robux tutta in una volta, invece che assegnartela quotidianamente! Oggi riceverai un pagamento una tantum di {robuxAmount}.{newLine}{newLine}Controlla la tua posta in arrivo Roblox per maggiori dettagli sul tuo pagamento Robux e sull'abbonamento Premium.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"A partire da ora gli abbonati riceveranno una somma unica mensile di Robux invece di rate quotidiane. Oggi depositiamo {robuxAmount} Robux sul tuo account per compensare la somma che avresti ottenuto questo mese\n{newLine}{newLine}\nControlla la tua posta in arrivo Roblox per ulteriori dettagli.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "A partire da ora gli abbonati riceveranno una somma unica mensile di Robux invece di rate quotidiane. Oggi depositiamo {robuxAmount} Robux sul tuo account per compensare la somma che avresti ottenuto questo mese\n{newLine}{newLine}\nControlla la tua posta in arrivo Roblox per ulteriori dettagli.  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Il Builders Club ora si chiama Roblox Premium";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"A partire da ora gli abbonati riceveranno una somma unica mensile di Robux invece di rate quotidiane. Oggi depositiamo {robuxAmount} Robux sul tuo account per compensare la somma che avresti ottenuto questo mese\n\nControlla la tua posta in arrivo Roblox per ulteriori dettagli.";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "A partire da ora gli abbonati riceveranno una somma unica mensile di Robux invece di rate quotidiane. Oggi depositiamo {robuxAmount} Robux sul tuo account per compensare la somma che avresti ottenuto questo mese\n\nControlla la tua posta in arrivo Roblox per ulteriori dettagli.";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Il Builders Club ora si chiama Roblox Premium";
	}
}
