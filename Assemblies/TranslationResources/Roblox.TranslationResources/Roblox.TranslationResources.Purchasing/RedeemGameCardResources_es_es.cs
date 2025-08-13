namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_es_es : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "Cerrar";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "Iniciar sesión";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "Regístrate";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "Comprar tarjeta";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Canjear";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "Combina las tarjetas para aumentar tu crédito de Roblox.";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "¡Debes iniciar sesión con tu cuenta de Roblox para canjear la tarjeta de juego!";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "Las compras se pueden realizar con un solo método de pago. Los créditos de las tarjetas de juego no se pueden combinar con otras formas de pago.";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "Compra una tarjeta de juego de Roblox en uno de los comercios participantes o utiliza una tarjeta de regalo que has recibido de alguien.";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "¡Utiliza tu crédito de Roblox para comprar Robux y para unirte al Builders Club!";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "Ingresa el PIN de tu tarjeta en la sección de canjeo.";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "Ingresar PIN";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "Obtén crédito de Roblox para";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "Cómo canjearlas";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "Cómo usarlas";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "Canjear tarjetas de Roblox";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "Canjear tarjeta de juego de Roblox";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "¿Necesitas una tarjeta de juego de Roblox?";

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
	public override string LabelRobuxRedeemed => "Robux canjeados:";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "Tu saldo:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "Esta tarjeta de regalo ya ha sido canjeada.";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "Canjea otra tarjeta Roblox de GameStop para recibir tus Robux de regalo.";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "¡Tu membresía al Builders Club ha sido extendida correctamente!";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "Espera hasta cinco minutos para que los cambios tengan efecto.";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "¡Tu membresía al Builders Club ha sido activada correctamente!";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "No se ha encontrado un código correspondiente.";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "No se ha podido encontrar el objeto solicitado.";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "Esta función está desactivada en este momento.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "Algo ha ido mal. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "PIN no válido";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "Debes iniciar sesión para realizar esta acción.";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "No se ha podido encontrar el objeto solicitado. Inténtalo de nuevo más tarde o ponte en contacto con el servicio al cliente si el problema persiste.";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "¡Has canjeado correctamente tu tarjeta!";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "Se han canjeado demasiados códigos. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "Demasiados intentos de solicitud incorrectos. Inténtalo de nuevo más tarde.";

	public RedeemGameCardResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "Cerrar";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "Iniciar sesión";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "Regístrate";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "Comprar tarjeta";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Canjear";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "Combina las tarjetas para aumentar tu crédito de Roblox.";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "¡Debes iniciar sesión con tu cuenta de Roblox para canjear la tarjeta de juego!";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "Las compras se pueden realizar con un solo método de pago. Los créditos de las tarjetas de juego no se pueden combinar con otras formas de pago.";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"Compra una tarjeta de juego de Roblox en uno de los {retailerLinkStart}comercios participantes{retailerLinkEnd} o utiliza una tarjeta de regalo que has recibido de alguien. ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "Compra una tarjeta de juego de Roblox en uno de los {retailerLinkStart}comercios participantes{retailerLinkEnd} o utiliza una tarjeta de regalo que has recibido de alguien. ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "Compra una tarjeta de juego de Roblox en uno de los comercios participantes o utiliza una tarjeta de regalo que has recibido de alguien.";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "¡Utiliza tu crédito de Roblox para comprar Robux y para unirte al Builders Club!";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "Ingresa el PIN de tu tarjeta en la sección de canjeo.";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "Ingresar PIN";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Obtén crédito de Roblox para";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "Cómo canjearlas";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "Cómo usarlas";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Canjear tarjetas de Roblox";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Canjear tarjeta de juego de Roblox";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "¿Necesitas una tarjeta de juego de Roblox?";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "Código PIN";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "Robux canjeados:";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "Tu saldo:";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "Esta tarjeta de regalo ya ha sido canjeada.";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "Canjea otra tarjeta Roblox de GameStop para recibir tus Robux de regalo.";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "¡Tu membresía al Builders Club ha sido extendida correctamente!";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "Espera hasta cinco minutos para que los cambios tengan efecto.";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "¡Tu membresía al Builders Club ha sido activada correctamente!";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "No se ha encontrado un código correspondiente.";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "No se ha podido encontrar el objeto solicitado.";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "Esta función está desactivada en este momento.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Algo ha ido mal. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "PIN no válido";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "Debes iniciar sesión para realizar esta acción.";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"El usuario ha intentado canjear el PIN, pero el comercio no existe. ID del usuario: {authenticatedUserId} Número PIN: {cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "El usuario ha intentado canjear el PIN, pero el comercio no existe. ID del usuario: {authenticatedUserId} Número PIN: {cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "No se ha podido encontrar el objeto solicitado. Inténtalo de nuevo más tarde o ponte en contacto con el servicio al cliente si el problema persiste.";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "¡Has canjeado correctamente tu tarjeta!";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"Has canjeado correctamente tu tarjeta para {productName}";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "Has canjeado correctamente tu tarjeta para {productName}";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "Se han canjeado demasiados códigos. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "Demasiados intentos de solicitud incorrectos. Inténtalo de nuevo más tarde.";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"Gracias por canjear dos tarjetas de Roblox en GameStop. Se han añadido {robuxCount} Robux a tu cuenta.";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "Gracias por canjear dos tarjetas de Roblox en GameStop. Se han añadido {robuxCount} Robux a tu cuenta.";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"Canjea otra tarjeta Roblox de Walmart para recibir {rewardName}.";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "Canjea otra tarjeta Roblox de Walmart para recibir {rewardName}.";
	}
}
