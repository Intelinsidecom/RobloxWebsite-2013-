namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_es_es : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
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
	public override string ActionCantFindCode => "¿No encuentras el código?";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Cerrar";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "Continuar al vídeo";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "¿Tienes un código de promoción? Haz clic aquí.";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "Cómo canjearlo";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Iniciar sesión";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Canjear";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "Canjear otro objeto";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "Regístrate";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "Ver objeto";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "Estás a punto de abandonar Roblox para ver un vídeo en YouTube. YouTube no forma parte de Roblox.com y se rige por una política de privacidad separada.";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "Canjeado correctamente";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "Canjear un objeto virtual de Roblox";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "Estás abandonando Roblox";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "Ingresa el código del juguete";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "Código no válido. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "¡Debes iniciar sesión con tu cuenta de Roblox para canjear el código de tu objeto virtual!";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "Has canjeado correctamente tu objeto.";

	public RedeemToyResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "¿No encuentras el código?";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Cerrar";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "Continuar al vídeo";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "¿Tienes un código de promoción? Haz clic aquí.";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "Cómo canjearlo";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Iniciar sesión";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Canjear";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "Canjear otro objeto";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Regístrate";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "Ver objeto";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"Has canjeado correctamente {spanTagStart}{itemName}{spanTagEnd} ({itemType}) de {creatorName}.";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "Has canjeado correctamente {spanTagStart}{itemName}{spanTagEnd} ({itemType}) de {creatorName}.";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "Estás a punto de abandonar Roblox para ver un vídeo en YouTube. YouTube no forma parte de Roblox.com y se rige por una política de privacidad separada.";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "Canjeado correctamente";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Canjear un objeto virtual de Roblox";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "Estás abandonando Roblox";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "Ingresa el código del juguete";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "Código no válido. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "¡Debes iniciar sesión con tu cuenta de Roblox para canjear el código de tu objeto virtual!";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "Has canjeado correctamente tu objeto.";
	}
}
