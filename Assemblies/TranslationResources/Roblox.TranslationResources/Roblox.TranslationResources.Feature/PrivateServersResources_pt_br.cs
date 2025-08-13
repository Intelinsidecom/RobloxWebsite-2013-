namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_pt_br : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "Criar um servidor VIP";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "Atualizar";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "Link inválido";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "Servidores VIP";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "Não foi possível conectar";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nome do jogo";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "Nenhuma instância de servidor VIP encontrada.";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "Jogue este jogo com amigos e outras pessoas que você convidar.";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "Renovar";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "Atualizar servidor privado";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "Nome do servidor";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "Servidores";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "OK";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "Você não pode entrar nesse servidor VIP porque o jogo é privado.";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "Servidores VIP permitem que você jogue de forma privada com amigos, seu clã ou pessoas que você convidar!";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "Este link de servidor VIP não é mais válido.";

	public PrivateServersResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "Criar um servidor VIP";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "Atualizar";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "Link inválido";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "Servidores VIP";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"Quer mesmo habilitar pagamentos futuros para sua versão VIP privada de {placeName} de {creatorName}?";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "Quer mesmo habilitar pagamentos futuros para sua versão VIP privada de {placeName} de {creatorName}?";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"Criar um servidor VIP para {target}?";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "Criar um servidor VIP para {target}?";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"Seu saldo depois desta transação será de {robuxIcon}. Esta é uma funcionalidade baseada em assinatura. Ela será renovada automaticamente uma vez por mês até você cancelá-la.";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "Seu saldo depois desta transação será de {robuxIcon}. Esta é uma funcionalidade baseada em assinatura. Ela será renovada automaticamente uma vez por mês até você cancelá-la.";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "Não foi possível conectar";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Nome do jogo";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "Nenhuma instância de servidor VIP encontrada.";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "Jogue este jogo com amigos e outras pessoas que você convidar.";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "Renovar";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "Atualizar servidor privado";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"Veja todos os servidores VIP na aba {serversLink}.";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "Veja todos os servidores VIP na aba {serversLink}.";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "Nome do servidor";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "Servidores";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"Este servidor VIP será renovado todo mês ao preço de {price} até você cancelar.";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "Este servidor VIP será renovado todo mês ao preço de {price} até você cancelar.";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "Você não pode entrar nesse servidor VIP porque o jogo é privado.";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "Servidores VIP permitem que você jogue de forma privada com amigos, seu clã ou pessoas que você convidar!";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"Este jogo não tem suporte para {vipServersLink}.";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "Este jogo não tem suporte para {vipServersLink}.";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "Este link de servidor VIP não é mais válido.";
	}
}
