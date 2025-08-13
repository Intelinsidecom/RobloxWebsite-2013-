namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_pt_br : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "O Builders Club agora é Roblox Premium";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "O Builders Club agora é Roblox Premium";

	public PremiumMigrationResources_pt_br(TranslationResourceState state)
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
		return $"O Premium agora dá uma mesada de Robux de uma vez, em vez de uma quantia diária! Hoje, estamos dando a você um pagamento único de {robuxAmount}.\n\nConfira sua caixa de entrada do Roblox para saber mais sobre seu pagamento de Robux e assinatura Premium. ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "O Premium agora dá uma mesada de Robux de uma vez, em vez de uma quantia diária! Hoje, estamos dando a você um pagamento único de {robuxAmount}.\n\nConfira sua caixa de entrada do Roblox para saber mais sobre seu pagamento de Robux e assinatura Premium. ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"O Premium agora dá uma mesada de Robux de uma vez, em vez de uma quantia diária! Hoje, estamos dando a você um pagamento único de {robuxAmount}.{newLine}{newLine}Confira sua caixa de entrada do Roblox para saber mais sobre seu pagamento de Robux e assinatura Premium.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "O Premium agora dá uma mesada de Robux de uma vez, em vez de uma quantia diária! Hoje, estamos dando a você um pagamento único de {robuxAmount}.{newLine}{newLine}Confira sua caixa de entrada do Roblox para saber mais sobre seu pagamento de Robux e assinatura Premium.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"De agora em diante, assinantes receberão uma quantia mensal de Robux em vez de receberem incrementos diários. Hoje, estamos depositando {robuxAmount} Robux na sua conta para completar a quantidade restante que você ganharia neste mês.\n{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "De agora em diante, assinantes receberão uma quantia mensal de Robux em vez de receberem incrementos diários. Hoje, estamos depositando {robuxAmount} Robux na sua conta para completar a quantidade restante que você ganharia neste mês.\n{newLine}{newLine}\nConfira sua caixa de entrada no Roblox para mais detalhes.  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "O Builders Club agora é Roblox Premium";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"De agora em diante, assinantes receberão uma quantia mensal de Robux em vez de receberem incrementos diários. Hoje, estamos depositando {robuxAmount} Robux na sua conta para completar a quantidade restante que você ganharia neste mês.\n\nConfira sua caixa de entrada no Roblox para mais detalhes.";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "De agora em diante, assinantes receberão uma quantia mensal de Robux em vez de receberem incrementos diários. Hoje, estamos depositando {robuxAmount} Robux na sua conta para completar a quantidade restante que você ganharia neste mês.\n\nConfira sua caixa de entrada no Roblox para mais detalhes.";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "O Builders Club agora é Roblox Premium";
	}
}
