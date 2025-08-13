namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_es_es : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Club se llama ahora Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club se llama ahora Roblox Premium";

	public PremiumMigrationWebResources_es_es(TranslationResourceState state)
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
		return $"De ahora en adelante, los suscriptores recibirán un monto único mensual de Robux en lugar de una cantidad diaria. Hoy, te depositaremos {robuxAmount} Robux en tu cuenta para llegar al monto total de este mes.\n{newLine}{newLine}\nRevisa tu bandeja de entrada para más detalles.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "De ahora en adelante, los suscriptores recibirán un monto único mensual de Robux en lugar de una cantidad diaria. Hoy, te depositaremos {robuxAmount} Robux en tu cuenta para llegar al monto total de este mes.\n{newLine}{newLine}\nRevisa tu bandeja de entrada para más detalles.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"De ahora en adelante, recibirás todos los Robux de un mes entero en el día en que renueves tu suscripción. Hoy, te depositaremos la cantidad restante de Robux para este mes: {robuxAmount}.\n{newLine}{newLine}\nRevisa tu bandeja de entrada de Roblox para más detalles.";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "De ahora en adelante, recibirás todos los Robux de un mes entero en el día en que renueves tu suscripción. Hoy, te depositaremos la cantidad restante de Robux para este mes: {robuxAmount}.\n{newLine}{newLine}\nRevisa tu bandeja de entrada de Roblox para más detalles.";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club se llama ahora Roblox Premium";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club se llama ahora Roblox Premium";
	}
}
