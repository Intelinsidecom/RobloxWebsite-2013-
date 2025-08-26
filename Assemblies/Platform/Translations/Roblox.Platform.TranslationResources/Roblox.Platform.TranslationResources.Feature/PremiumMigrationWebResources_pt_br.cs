namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_pt_br : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "O Builders Club agora Ã© Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "O Builders Club agora Ã© Roblox Premium";

	public PremiumMigrationWebResources_pt_br(TranslationResourceState state)
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
		return $"De agora em diante, assinantes receberÃ£o uma quantia mensal de Robux em vez de receberem incrementos diÃ¡rios. Hoje, estamos depositando {robuxAmount} Robux na sua conta para completar a quantidade restante que vocÃª ganharia neste mÃªs.\n{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "De agora em diante, assinantes receberÃ£o uma quantia mensal de Robux em vez de receberem incrementos diÃ¡rios. Hoje, estamos depositando {robuxAmount} Robux na sua conta para completar a quantidade restante que vocÃª ganharia neste mÃªs.\n{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full monthâ€™s worth of Robux on the day of your subscription renewal. Today, weâ€™re giving you this month's Robux minus what youâ€™ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"De agora em diante, vocÃª receberÃ¡ um valor de Robux por todo o mÃªs no dia da renovaÃ§Ã£o da sua assinatura. Hoje, vocÃª ganharÃ¡ a quantia deste mÃªs de Robux menos o que jÃ¡ ganhou durante o mÃªs: {robuxAmount}.{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "De agora em diante, vocÃª receberÃ¡ um valor de Robux por todo o mÃªs no dia da renovaÃ§Ã£o da sua assinatura. Hoje, vocÃª ganharÃ¡ a quantia deste mÃªs de Robux menos o que jÃ¡ ganhou durante o mÃªs: {robuxAmount}.{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "O Builders Club agora Ã© Roblox Premium";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "O Builders Club agora Ã© Roblox Premium";
	}
}


}
