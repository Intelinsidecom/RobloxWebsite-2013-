namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_pt_br : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "Fechar";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "Conectar-se";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "Cadastrar-se";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "Comprar cartão";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Utilizar";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "Combine cartões para obter mais créditos Roblox.";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "Você precisa estar conectado com sua conta Roblox para utilizar seu cartão do jogo!";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "Compras podem ser feitas com apenas uma forma de pagamento. Créditos de cartão do jogo não podem ser combinados com outras formas de pagamento.";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "Compre um cartão do jogo Roblox em um dos estabelecimentos participantes ou receba um cartão de presente de alguém.";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "Gaste seus créditos Roblox com Robux e Builders Club!";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "Digite o PIN do seu cartão na seção de utilizar.";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "Inserir PIN";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "Obtenha créditos Roblox por";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "Como utilizar";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "Como usar";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "Utilizar cartões Roblox";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "Utilizar cartão do jogo Roblox";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "Precisa de um cartão do jogo Roblox?";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "Código PIN";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "Robux resgatados:";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "Seu saldo de créditos:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "Este cartão de presente já foi utilizado.";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "Utilize mais um cartão Roblox da GameStop para receber seus Robux bônus.";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "Sua assinatura do Builders Club foi prolongada com sucesso!";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "Dê-nos 5 minutos para que as alterações sejam realizadas.";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "Sua assinatura do Builders Club foi realizada com sucesso!";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "O código não confere.";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "Impossível encontrar objeto solicitado.";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "Esta funcionalidade está desabilitada.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "Algo deu errado. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "PIN inválido";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "Você precisa estar conectado para realizar esta ação.";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "Impossível encontrar objeto solicitado. Tente solicitar novamente e contate o serviço ao cliente se o problema persistir.";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "Você utilizou seu cartão com sucesso!";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "Códigos demais utilizados. Tente mais tarde.";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "Tentativas demais de solicitação fracassadas. Tente mais tarde.";

	public RedeemGameCardResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "Fechar";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "Cadastrar-se";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "Comprar cartão";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Utilizar";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "Combine cartões para obter mais créditos Roblox.";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "Você precisa estar conectado com sua conta Roblox para utilizar seu cartão do jogo!";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "Compras podem ser feitas com apenas uma forma de pagamento. Créditos de cartão do jogo não podem ser combinados com outras formas de pagamento.";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"Compre um cartão do jogo Roblox em um dos {retailerLinkStart}estabelecimentos participantes{retailerLinkEnd} ou receba um cartão de presente de alguém. ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "Compre um cartão do jogo Roblox em um dos {retailerLinkStart}estabelecimentos participantes{retailerLinkEnd} ou receba um cartão de presente de alguém. ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "Compre um cartão do jogo Roblox em um dos estabelecimentos participantes ou receba um cartão de presente de alguém.";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "Gaste seus créditos Roblox com Robux e Builders Club!";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "Digite o PIN do seu cartão na seção de utilizar.";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "Inserir PIN";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Obtenha créditos Roblox por";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "Como utilizar";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "Como usar";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Utilizar cartões Roblox";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Utilizar cartão do jogo Roblox";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "Precisa de um cartão do jogo Roblox?";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "Código PIN";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "Robux resgatados:";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "Seu saldo de créditos:";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "Este cartão de presente já foi utilizado.";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "Utilize mais um cartão Roblox da GameStop para receber seus Robux bônus.";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "Sua assinatura do Builders Club foi prolongada com sucesso!";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "Dê-nos 5 minutos para que as alterações sejam realizadas.";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "Sua assinatura do Builders Club foi realizada com sucesso!";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "O código não confere.";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "Impossível encontrar objeto solicitado.";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "Esta funcionalidade está desabilitada.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Algo deu errado. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "PIN inválido";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "Você precisa estar conectado para realizar esta ação.";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"Usuário tentou utilizar Pin, mas o estabelecimento não existe. ID de usuário: {authenticatedUserId} Número de Pin: {cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "Usuário tentou utilizar Pin, mas o estabelecimento não existe. ID de usuário: {authenticatedUserId} Número de Pin: {cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "Impossível encontrar objeto solicitado. Tente solicitar novamente e contate o serviço ao cliente se o problema persistir.";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "Você utilizou seu cartão com sucesso!";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"Você utilizou seu cartão com sucesso para {productName}";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "Você utilizou seu cartão com sucesso para {productName}";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "Códigos demais utilizados. Tente mais tarde.";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "Tentativas demais de solicitação fracassadas. Tente mais tarde.";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"Obrigado por utilizar dois cartões Roblox da GameStop. {robuxCount} Robux foram adicionados à sua conta.";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "Obrigado por utilizar dois cartões Roblox da GameStop. {robuxCount} Robux foram adicionados à sua conta.";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"Utilize mais um cartão Roblox do Walmart para receber {rewardName}.";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "Utilize mais um cartão Roblox do Walmart para receber {rewardName}.";
	}
}
