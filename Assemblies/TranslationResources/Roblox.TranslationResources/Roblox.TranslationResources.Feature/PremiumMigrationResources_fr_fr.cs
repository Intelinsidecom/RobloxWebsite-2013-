namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_fr_fr : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club devient Roblox Premium";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club devient Roblox Premium";

	public PremiumMigrationResources_fr_fr(TranslationResourceState state)
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
		return $"Premium te donne tous tes Robux une fois par mois au lieu de tous les jours ! Aujourd'hui, tu vas recevoir tes Robux du mois, mais ceux que tu as déjà reçus en seront déduits. Tu recevras : R{robuxAmount}.\n\nVérifie tes messages pour en savoir plus à propos de tes paiements et de l'abonnement Premium. ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "Premium te donne tous tes Robux une fois par mois au lieu de tous les jours ! Aujourd'hui, tu vas recevoir tes Robux du mois, mais ceux que tu as déjà reçus en seront déduits. Tu recevras : R{robuxAmount}.\n\nVérifie tes messages pour en savoir plus à propos de tes paiements et de l'abonnement Premium. ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club devient Roblox Premium";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"À partir de maintenant, les abonnés recevront tous leurs Robux une fois par mois au lieu de tous les jours ! Aujourd'hui, tu vas recevoir tes Robux restants pour le mois. Tu recevras : {robuxAmount} Robux.\n\nVérifie tes messages pour en savoir plus à propos de tes paiements et de l'abonnement Premium. ";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "À partir de maintenant, les abonnés recevront tous leurs Robux une fois par mois au lieu de tous les jours ! Aujourd'hui, tu vas recevoir tes Robux restants pour le mois. Tu recevras : {robuxAmount} Robux.\n\nVérifie tes messages pour en savoir plus à propos de tes paiements et de l'abonnement Premium. ";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club devient Roblox Premium";
	}
}
