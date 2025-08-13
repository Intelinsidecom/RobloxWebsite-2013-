namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumResources_es_es : PremiumResources_en_us, IPremiumResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Bought"
	/// English String: "Bought"
	/// </summary>
	public override string ActionBought => "Comprado";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "Comprar ahora";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Comprar Robux";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "Obtén un 10% adicional en tu compra de Robux";

	/// <summary>
	/// Key: "Description.GooglePlayMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that is charged to your Google Play account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Google Play account settings. If you’re under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionGooglePlayMonthlySubscriptionDisclosure => "Roblox Premium es una suscripción mensual que se factura a tu cuenta de Google Play una vez que se confirme la compra. Premium se renovará automáticamente, a menos que no se desactive la renovación automática por lo menos 24 horas antes de que termine el periodo actual. Tu cuenta se facturará durante las 24 horas anteriores a la finalización del periodo vigente. Se pueden gestionar las suscripciones y desactivar la renovación automática en Configuración de la cuenta de Google Play. Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores antes de comprar. Realizar una compra sin su permiso puede resultar en la eliminación de la cuenta.";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "Al unirte a Roblox Premium, recibirás un estipendio mensual de Robux y un bonus del 10% en la compra de nuestra moneda virtual. También te beneficiarás de nuestra economía, que incluye la compra, venta e intercambio de objetos, además de obtener mayores ganancias en todas las ventas en tus juegos.";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "Revende objetos y obtén más Robux al vender tus creaciones";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "Intercambia objetos con otros miembros de Premium";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Comprar Robux";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "Confirmar cancelación";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "Con aún más funciones";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "Error";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "Como suscriptor(a) de Premium, recibirás descuentos en la compra de Robux.";

	/// <summary>
	/// Key: "Heading.RobloxPremium"
	/// The title of Subscription page
	/// English String: "Roblox Premium"
	/// </summary>
	public override string HeadingRobloxPremium => "Roblox Premium";

	/// <summary>
	/// Key: "Heading.ServerError"
	/// English String: "Server Error"
	/// </summary>
	public override string HeadingServerError => "Error del servidor";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "Suscripción no disponible";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "Confirmar actualización de la suscripción";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "No se puede encontrar el Builders Club";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "Mejorar a Roblox Premium";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "Actualización no disponible";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "Obtendrás un 10% más de Robux";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "y obtén más!";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "¡Porque te suscribiste!";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "Comprar una vez";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "Comprar Robux";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "Confirmar";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "Tu plan actual";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "Obtén un descuento del 10% en la compra de Robux";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "Obtener más Robux";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "Para gestionar su suscripción a Premium, navega a la configuración de Facturación.";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "No";

	/// <summary>
	/// Key: "Label.PremiumClub2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelPremiumClub2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium"
	/// English String: "Roblox Premium"
	/// </summary>
	public override string LabelRobloxPremium => "Roblox Premium";

	/// <summary>
	/// Key: "Label.RobloxPremium1000"
	/// English String: "Roblox Premium 1000"
	/// </summary>
	public override string LabelRobloxPremium1000 => "Roblox Premium 1000";

	/// <summary>
	/// Key: "Label.RobloxPremium1000OneMonth"
	/// English String: "Roblox Premium 1000 One Month"
	/// </summary>
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 Un Mes";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 Un Mes";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 Un Mes";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "Vender más";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "desde el momento en que te suscribes";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "¡Suscríbete";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "Intercambiar";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "Paquetes económicos";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "¿Quieres obtener más Robux?";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "Sí";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "Se ha producido un error al actualizar tu suscripción. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "No hay información de las suscripciones.";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "Se ha producido un error del servidor al actualizar tu suscripción. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "No se puede encontrar la información del Builders Club de este usuario.";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "Lo sentimos, no puedes cambiar tu suscripción porque actualmente no existe un paquete equivalente al Lifetime Builders Club.";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "Confirmar actualización de la suscripción";

	public PremiumResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "Comprado";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "Comprar ahora";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Comprar Robux";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Obtén Robux para comprar mejoras para tu avatar o conseguir habilidades especiales en el juego.{lineBreak} Suscríbete a Roblox Premium y consigue aún más Robux por mes, así como funciones adicionales. La suscripción se factura una vez al mes hasta que se cancele. {learnMoreLinkStart}Aprende más aquí{learnMoreLinkEnd}";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Obtén Robux para comprar mejoras para tu avatar o conseguir habilidades especiales en el juego.{lineBreak} Suscríbete a Roblox Premium y consigue aún más Robux por mes, así como funciones adicionales. La suscripción se factura una vez al mes hasta que se cancele. {learnMoreLinkStart}Aprende más aquí{learnMoreLinkEnd}";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Obtén Robux para comprar mejoras para tu avatar o conseguir habilidades especiales en el juego. Para más información sobre cómo obtenerlos, visita nuestra {helpLinkStart}Página de ayuda de Robux{helpLinkEnd}.{paragraphBreaker}Suscríbete a Roblox Premium para conseguir más Robux por el mismo precio. La suscripción se factura una vez al mes hasta que se cancele. {learnMoreLinkStart}Aprende más aquí{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "Obtén Robux para comprar mejoras para tu avatar o conseguir habilidades especiales en el juego. Para más información sobre cómo obtenerlos, visita nuestra {helpLinkStart}Página de ayuda de Robux{helpLinkEnd}.{paragraphBreaker}Suscríbete a Roblox Premium para conseguir más Robux por el mismo precio. La suscripción se factura una vez al mes hasta que se cancele. {learnMoreLinkStart}Aprende más aquí{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "Obtén un 10% adicional en tu compra de Robux";
	}

	protected override string _GetTemplateForDescriptionGooglePlayMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium es una suscripción mensual que se factura a tu cuenta de Google Play una vez que se confirme la compra. Premium se renovará automáticamente, a menos que no se desactive la renovación automática por lo menos 24 horas antes de que termine el periodo actual. Tu cuenta se facturará durante las 24 horas anteriores a la finalización del periodo vigente. Se pueden gestionar las suscripciones y desactivar la renovación automática en Configuración de la cuenta de Google Play. Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores antes de comprar. Realizar una compra sin su permiso puede resultar en la eliminación de la cuenta.";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premium es una suscripción mensual que cuesta {costPrice}. El pago se facturará a la cuenta iTunes una vez que se confirme la compra. Premium se renovará automáticamente, a menos que no se desactive la renovación automática por lo menos 24 horas antes de que termine el periodo actual. Se facturará el precio de {renewalPrice} a tu cuenta durante las 24 horas anteriores a la finalización del periodo vigente. Se pueden gestionar las suscripciones y desactivar la renovación automática en Configuración de la cuenta. Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores antes de comprar. Realizar una compra sin su permiso puede resultar en la eliminación de la cuenta.";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium es una suscripción mensual que cuesta {costPrice}. El pago se facturará a la cuenta iTunes una vez que se confirme la compra. Premium se renovará automáticamente, a menos que no se desactive la renovación automática por lo menos 24 horas antes de que termine el periodo actual. Se facturará el precio de {renewalPrice} a tu cuenta durante las 24 horas anteriores a la finalización del periodo vigente. Se pueden gestionar las suscripciones y desactivar la renovación automática en Configuración de la cuenta. Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores antes de comprar. Realizar una compra sin su permiso puede resultar en la eliminación de la cuenta.";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premium es una suscripción {durationType} que cuesta {costPrice}. El pago se facturará en la cuenta iTunes una vez que se confirme la compra. Premium se renovará automáticamente a menos que no se desactive la renovación automática 24 horas antes de que termine el periodo actual. Se cobrará el precio de {renewalPrice} a tu cuenta durante las 24 horas anteriores a la finalización del periodo vigente. Se pueden gestionar las suscripciones y desactivar la renovación automática en Configuración de la cuenta.";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premium es una suscripción {durationType} que cuesta {costPrice}. El pago se facturará en la cuenta iTunes una vez que se confirme la compra. Premium se renovará automáticamente a menos que no se desactive la renovación automática 24 horas antes de que termine el periodo actual. Se cobrará el precio de {renewalPrice} a tu cuenta durante las 24 horas anteriores a la finalización del periodo vigente. Se pueden gestionar las suscripciones y desactivar la renovación automática en Configuración de la cuenta.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"Al comprar Robux, recibirás una licencia limitada, no reembolsable, intransferible y revocable que te permite usar Robux, los cuales no tienen ningún valor en moneda real. Consulta los {termsLinkStart}Términos de uso{termsLinkEnd} para ver otras limitaciones que aplican. Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores antes de hacer una compra. Una compra que se lleve a cabo sin permiso puede resultar en la eliminación de la cuenta.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "Al comprar Robux, recibirás una licencia limitada, no reembolsable, intransferible y revocable que te permite usar Robux, los cuales no tienen ningún valor en moneda real. Consulta los {termsLinkStart}Términos de uso{termsLinkEnd} para ver otras limitaciones que aplican. Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores antes de hacer una compra. Una compra que se lleve a cabo sin permiso puede resultar en la eliminación de la cuenta.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores ante de hacer una compra. Una compra que se lleve a cabo sin permiso puede resultar en la eliminación de la cuenta. Al hacer clic en Enviar el pedido 1) nos autorizarás a facturar tu cuenta mensualmente hasta que canceles la suscripción; 2) demostrarás que entiendes y aceptas los {termsLinkStart}Términos de uso{termsLinkEnd} y la {privacyLinkStart}Política de privacidad{privatyLinkEnd}. Puedes cancelar la suscripción en cualquier momento haciendo clic en Cancelar suscripción en la pestaña {billingLinkStart}Facturación{billingLinkEnd} de la página Configuración. Aunque canceles, se te cobrará por el periodo actual de facturación.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores ante de hacer una compra. Una compra que se lleve a cabo sin permiso puede resultar en la eliminación de la cuenta. Al hacer clic en Enviar el pedido 1) nos autorizarás a facturar tu cuenta mensualmente hasta que canceles la suscripción; 2) demostrarás que entiendes y aceptas los {termsLinkStart}Términos de uso{termsLinkEnd} y la {privacyLinkStart}Política de privacidad{privatyLinkEnd}. Puedes cancelar la suscripción en cualquier momento haciendo clic en Cancelar suscripción en la pestaña {billingLinkStart}Facturación{billingLinkEnd} de la página Configuración. Aunque canceles, se te cobrará por el periodo actual de facturación.";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores ante de comprar. Realizar una compra sin su permiso puede resultar en la eliminación de la cuenta. Al hacer clic en Enviar el pedido: 1) nos autorizarás a facturar tu cuenta mensualmente hasta que canceles la suscripción; 2) demostrarás que entiendes y aceptas los {teamOfUseLinkStart}Términos de uso{teamOfUseLinkEnd} y la {privacyPolicyLinkStart}Política de privacidad{privacyPolicyLinkEnd}. Puedes cancelar la suscripción en cualquier momento haciendo clic en Cancelar suscripción en la pestaña {billingTabLinkStart}Facturación{billingTabLinkEnd} de la página Configuración. Aunque canceles, se te cobrará el periodo actual de facturación.";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "Si eres menor de 18 años, asegúrate de obtener el permiso de uno de tus padres o tutores ante de comprar. Realizar una compra sin su permiso puede resultar en la eliminación de la cuenta. Al hacer clic en Enviar el pedido: 1) nos autorizarás a facturar tu cuenta mensualmente hasta que canceles la suscripción; 2) demostrarás que entiendes y aceptas los {teamOfUseLinkStart}Términos de uso{teamOfUseLinkEnd} y la {privacyPolicyLinkStart}Política de privacidad{privacyPolicyLinkEnd}. Puedes cancelar la suscripción en cualquier momento haciendo clic en Cancelar suscripción en la pestaña {billingTabLinkStart}Facturación{billingTabLinkEnd} de la página Configuración. Aunque canceles, se te cobrará el periodo actual de facturación.";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "Al unirte a Roblox Premium, recibirás un estipendio mensual de Robux y un bonus del 10% en la compra de nuestra moneda virtual. También te beneficiarás de nuestra economía, que incluye la compra, venta e intercambio de objetos, además de obtener mayores ganancias en todas las ventas en tus juegos.";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "Revende objetos y obtén más Robux al vender tus creaciones";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "Intercambia objetos con otros miembros de Premium";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Comprar Robux";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "Confirmar cancelación";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "Con aún más funciones";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "Error";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "Como suscriptor(a) de Premium, recibirás descuentos en la compra de Robux.";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "Error del servidor";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "Suscripción no disponible";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "Confirmar actualización de la suscripción";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "No se puede encontrar el Builders Club";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "Mejorar a Roblox Premium";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "Actualización no disponible";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "Obtendrás un 10% más de Robux";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "y obtén más!";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "¡Porque te suscribiste!";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "Comprar una vez";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "Comprar Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "Confirmar";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "Tu plan actual";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "Obtén un descuento del 10% en la compra de Robux";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "Obtener más Robux";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "Para gestionar su suscripción a Premium, navega a la configuración de Facturación.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"Tu plan actual es {premiumSubscription}. Se vencerá el {expirationDate}.";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "Tu plan actual es {premiumSubscription}. Se vencerá el {expirationDate}.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"Tu plan actual es {premiumSubscription}. Se vencerá el {expirationDate}. Puedes volver a comprar el mismo o escoger uno nuevo cuando se venza tu suscripción. ";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "Tu plan actual es {premiumSubscription}. Se vencerá el {expirationDate}. Puedes volver a comprar el mismo o escoger uno nuevo cuando se venza tu suscripción. ";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"Tu plan actual es {premiumSubscription}. Se renovará el {renewal}.";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "Tu plan actual es {premiumSubscription}. Se renovará el {renewal}.";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "No";
	}

	protected override string _GetTemplateForLabelPremiumClub2200()
	{
		return "Roblox Premium 2200";
	}

	/// <summary>
	/// Key: "Label.PriceMonth"
	/// English String: "{robux}{subTextStart}/month{subTextEnd}"
	/// </summary>
	public override string LabelPriceMonth(string robux, string subTextStart, string subTextEnd)
	{
		return $"{robux}{subTextStart} al mes{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart} al mes{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount} al mes";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount} al mes";
	}

	protected override string _GetTemplateForLabelRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForLabelRobloxPremium1000()
	{
		return "Roblox Premium 1000";
	}

	protected override string _GetTemplateForLabelRobloxPremium1000OneMonth()
	{
		return "Roblox Premium 1000 Un Mes";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 Un Mes";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 Un Mes";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "Vender más";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "desde el momento en que te suscribes";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "¡Suscríbete";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"Suscríbete a {upsellLinkStart} y obtén más.{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "Suscríbete a {upsellLinkStart} y obtén más.{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "Intercambiar";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "Paquetes económicos";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "¿Quieres obtener más Robux?";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "Sí";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"Al hacer clic en \"Confirmar\", tu membresía al Builders Club terminará y podrás suscribirte a Roblox Premium.{newLine} Recibirás un pago único de {robuxAmount}";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "Al hacer clic en \"Confirmar\", tu membresía al Builders Club terminará y podrás suscribirte a Roblox Premium.{newLine} Recibirás un pago único de {robuxAmount}";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "Se ha producido un error al actualizar tu suscripción. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "No hay información de las suscripciones.";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "Se ha producido un error del servidor al actualizar tu suscripción. Inténtalo de nuevo más tarde.";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"Lo sentimos, no puedes suscribirte hasta que se venza el plan actual que has cancelado. Vuelve a suscribirte el {expiredDate}.";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "Lo sentimos, no puedes suscribirte hasta que se venza el plan actual que has cancelado. Vuelve a suscribirte el {expiredDate}.";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"Al hacer clic en \"Confirmar\", nos autorizas a cobrarte {price} mensuales a partir del {renewalDate} hasta que no canceles la suscripción o te cambies a otra.";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "Al hacer clic en \"Confirmar\", nos autorizas a cobrarte {price} mensuales a partir del {renewalDate} hasta que no canceles la suscripción o te cambies a otra.";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "No se puede encontrar la información del Builders Club de este usuario.";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "Lo sentimos, no puedes cambiar tu suscripción porque actualmente no existe un paquete equivalente al Lifetime Builders Club.";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "Confirmar actualización de la suscripción";
	}
}
