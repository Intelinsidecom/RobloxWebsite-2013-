namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingMigrationModalTitle => "O Builders Club agora é Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "O Builders Club agora é Roblox Premium";

	public PremiumMigrationWebResources_pt_br(TranslationResourceState state)
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
		return $"De agora em diante, assinantes receberão uma quantia mensal de Robux em vez de receberem incrementos diários. Hoje, estamos depositando {robuxAmount} Robux na sua conta para completar a quantidade restante que você ganharia neste mês.\n{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "De agora em diante, assinantes receberão uma quantia mensal de Robux em vez de receberem incrementos diários. Hoje, estamos depositando {robuxAmount} Robux na sua conta para completar a quantidade restante que você ganharia neste mês.\n{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"De agora em diante, você receberá um valor de Robux por todo o mês no dia da renovação da sua assinatura. Hoje, você ganhará a quantia deste mês de Robux menos o que já ganhou durante o mês: {robuxAmount}.{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "De agora em diante, você receberá um valor de Robux por todo o mês no dia da renovação da sua assinatura. Hoje, você ganhará a quantia deste mês de Robux menos o que já ganhou durante o mês: {robuxAmount}.{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "O Builders Club agora é Roblox Premium";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "O Builders Club agora é Roblox Premium";
	}
}
