namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_es_es : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club ahora se llama Premium";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club ahora se llama Roblox Premium";

	public PremiumMigrationResources_es_es(TranslationResourceState state)
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
		return $"Premium ahora te deposita un estipendio mensual en Robux todo de una vez, en lugar de darte una cantidad diaria. Hoy te vamos a depositar tu monto Ãºnico de {robuxAmount}.\n\nRevisa tu bandeja de entrada de Roblox para obtener mÃ¡s informaciÃ³n sobre los desembolsos y la suscripciÃ³n a Premium. ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "Premium ahora te deposita un estipendio mensual en Robux todo de una vez, en lugar de darte una cantidad diaria. Hoy te vamos a depositar tu monto Ãºnico de {robuxAmount}.\n\nRevisa tu bandeja de entrada de Roblox para obtener mÃ¡s informaciÃ³n sobre los desembolsos y la suscripciÃ³n a Premium. ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"Premium ahora te deposita un estipendio mensual en Robux todo de una vez, en lugar de darte una cantidad diaria. Hoy te vamos a depositar tu monto Ãºnico de {robuxAmount}.{newLine}{newLine}Revisa tu bandeja de entrada de Roblox para obtener mÃ¡s informaciÃ³n sobre los desembolsos y la suscripciÃ³n a Premium.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "Premium ahora te deposita un estipendio mensual en Robux todo de una vez, en lugar de darte una cantidad diaria. Hoy te vamos a depositar tu monto Ãºnico de {robuxAmount}.{newLine}{newLine}Revisa tu bandeja de entrada de Roblox para obtener mÃ¡s informaciÃ³n sobre los desembolsos y la suscripciÃ³n a Premium.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"De ahora en adelante, los suscriptores recibirÃ¡n un monto Ãºnico mensual en lugar de una cantidad diaria. Hoy, te depositaremos {robuxAmount} Robux en tu cuenta para llegar al monto total de este mes.\n{newLine}{newLine}\nRevisa tu bandeja de entrada para mÃ¡s detalles.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "De ahora en adelante, los suscriptores recibirÃ¡n un monto Ãºnico mensual en lugar de una cantidad diaria. Hoy, te depositaremos {robuxAmount} Robux en tu cuenta para llegar al monto total de este mes.\n{newLine}{newLine}\nRevisa tu bandeja de entrada para mÃ¡s detalles.  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club ahora se llama Premium";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"De ahora en adelante, los suscriptores recibirÃ¡n un monto Ãºnico mensual en lugar de una cantidad diaria. Hoy, te depositaremos {robuxAmount} Robux en tu cuenta para llegar al monto total de este mes.\n\nRevisa tu bandeja de entrada para mÃ¡s detalles.";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "De ahora en adelante, los suscriptores recibirÃ¡n un monto Ãºnico mensual en lugar de una cantidad diaria. Hoy, te depositaremos {robuxAmount} Robux en tu cuenta para llegar al monto total de este mes.\n\nRevisa tu bandeja de entrada para mÃ¡s detalles.";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club ahora se llama Roblox Premium";
	}
}


}
