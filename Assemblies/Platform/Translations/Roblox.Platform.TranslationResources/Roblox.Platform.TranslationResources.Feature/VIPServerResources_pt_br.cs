namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_pt_br : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Adicionar";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "Adicionar jogadores";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "Cancelar pagamentos";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "Alterar nome";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "Voltar";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "Regenerar";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Remover";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "Renovar servidor VIP";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ver todos";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "Cancelar pagamentos";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "Alterar nome do servidor VIP";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "Configurar servidor VIP";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "Remover jogador";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "Renovar servidor VIP";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "Nome do servidor VIP (1-50 caracteres)";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "Acesso do clã";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "Amigos permitidos";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nome do jogo";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "Acessar link do jogo...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Nenhuma";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "Desligado";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "Ligado";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "Selecionar clã inimigo";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "Pesquisar jogadores";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "Servidores";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "Membros do servidor";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "Status da assinatura";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "Link do servidor VIP";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "Status do servidor VIP";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "Seu clã";

	public VIPServerResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Adicionar";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "Adicionar jogadores";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "Cancelar pagamentos";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "Alterar nome";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "Voltar";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "Regenerar";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Remover";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "Renovar servidor VIP";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ver todos";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "Cancelar pagamentos";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "Alterar nome do servidor VIP";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "Configurar servidor VIP";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "Remover jogador";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "Renovar servidor VIP";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"Quer mesmo cancelar pagamentos futuros para seu servidor VIP de {name} de {creator}? Se você cancelar, seu servidor VIP será desativado dia {date}.";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "Quer mesmo cancelar pagamentos futuros para seu servidor VIP de {name} de {creator}? Se você cancelar, seu servidor VIP será desativado dia {date}.";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "Nome do servidor VIP (1-50 caracteres)";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "Acesso do clã";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "Amigos permitidos";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Nome do jogo";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "Acessar link do jogo...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Nenhuma";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "Desligado";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "Ligado";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "Selecionar clã inimigo";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"Quer mesmo remover {name} do seu servidor VIP? Ele(a) não poderá mais entrar no seu servidor VIP.";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "Quer mesmo remover {name} do seu servidor VIP? Ele(a) não poderá mais entrar no seu servidor VIP.";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"Quer mesmo habilitar pagamentos futuros para seu servidor VIP de {name} de {creator}?";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "Quer mesmo habilitar pagamentos futuros para seu servidor VIP de {name} de {creator}?";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"Este servidor VIP será renovado todo mês ao preço de {date} até você cancelar.";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "Este servidor VIP será renovado todo mês ao preço de {date} até você cancelar.";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "Pesquisar jogadores";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "Servidores";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"Seu servidor VIP expirou dia {date}";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "Seu servidor VIP expirou dia {date}";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "Membros do servidor";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"Você será cobrado de novo dia {date}";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "Você será cobrado de novo dia {date}";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"O pagamento mensal do seu servidor VIP é {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "O pagamento mensal do seu servidor VIP é {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "Status da assinatura";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "Link do servidor VIP";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "Status do servidor VIP";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "Seu clã";
	}
}
