namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_pt_br : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "Não consegue encontrar o código?";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fechar";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "Continuar para o vídeo";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "Você tem um código promocional? Clique aqui";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "Como utilizar";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Conectar-se";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Utilizar";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "Utilizar outro item virtual";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "Cadastrar-se";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "Ver item";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "Você está prestes a sair do Roblox para ver um vídeo no Youtube. O Youtube não faz parte de Roblox.com e é regido por uma política de privacidade separada.";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "Utilizado com sucesso";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "Utilizar item virtual do Roblox";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "Você está saindo do Roblox";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "Insira o código do brinquedo";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "Código inválido. Tente novamente.";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "Você precisa estar conectado com sua conta Roblox para utilizar o código do seu item virtual!";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "Você utilizou seu item com sucesso!";

	public RedeemToyResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "Não consegue encontrar o código?";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fechar";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "Continuar para o vídeo";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "Você tem um código promocional? Clique aqui";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "Como utilizar";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Utilizar";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "Utilizar outro item virtual";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Cadastrar-se";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "Ver item";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"Você utilizou {spanTagStart}{itemName}{spanTagEnd} ({itemType}) de {creatorName} com sucesso.";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "Você utilizou {spanTagStart}{itemName}{spanTagEnd} ({itemType}) de {creatorName} com sucesso.";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "Você está prestes a sair do Roblox para ver um vídeo no Youtube. O Youtube não faz parte de Roblox.com e é regido por uma política de privacidade separada.";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "Utilizado com sucesso";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Utilizar item virtual do Roblox";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "Você está saindo do Roblox";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "Insira o código do brinquedo";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "Código inválido. Tente novamente.";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "Você precisa estar conectado com sua conta Roblox para utilizar o código do seu item virtual!";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "Você utilizou seu item com sucesso!";
	}
}
