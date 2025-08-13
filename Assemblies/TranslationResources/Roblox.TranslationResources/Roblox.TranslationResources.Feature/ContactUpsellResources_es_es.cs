namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_es_es : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "Añadir correo electrónico";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "Añadir correo electrónico";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "Añadir correo electrónico ahora";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "Añadir ahora";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "Añadir correo electrónico de un progenitor";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "Añadir correo electrónico de un progenitor ahora";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "Añadir número de teléfono";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "Añadir teléfono ahora";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Cerrar";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "Confirmar correo electrónico";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "Editar número de teléfono";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Aceptar";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "Reenviar código";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verificar";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "Verificar correo electrónico";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "Verificar teléfono";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "Añadir correo electrónico de un progenitor";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "Añadir correo electrónico";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "¡No pierdas el acceso a tu cuenta!";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "¡No te olvides de confirmar!";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "Se ha producido un error.";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "¡Ayuda a tus amigos a encontrarte!";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "¡Consíguete un sombrero gratis!";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public override string HeadingSuccess => "Hecho";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public override string HeadingVerifyEmail => "Verificar correo electrónico";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "Añadir teléfono";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "Dirección de correo electrónico";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "Se ha producido un error.";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Correo electrónico no válido";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Número de teléfono no válido";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "¿No tienes un correo electrónico?";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "¿No tienes un número de teléfono?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "¿No lo has recibido?";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "o";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "Dirección de correo electrónico de un progenitor";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Contraseña de la cuenta de Roblox";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "Número de teléfono";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "¡Protege tu cuenta con un correo electrónico!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "¡Protege tu cuenta con el correo electrónico de uno de tus padres!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "¡Protege tu cuenta con un número de teléfono!";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "Reenviar correo electrónico";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "¡Verifica tu correo electrónico para proteger tu cuenta!";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "¡Verifica el correo electrónico de uno de tus padres para proteger tu cuenta!";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Contraseña de la cuenta de Roblox";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "Se ha producido un error al cargar la lista de países.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "Añade un tu correo electrónico para recibir un sombrero gratis y para no perder el acceso a tu cuenta.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "Añade el correo electrónico de uno de tus padres para recibir un sombrero gratis y para no perder el acceso a tu cuenta.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "Introduce tu dirección de correo electrónico. Te enviaremos un enlace para completar la verificación.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "Introduce la dirección de correo electrónico de uno de tus padres. Te enviaremos un enlace para completar la verificación.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "Añade una dirección de correo electrónico para que siempre puedas acceder a tu cuenta de Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "Añade la dirección de correo electrónico de uno de tus padres para que siempre puedas acceder a tu cuenta de Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "Añade un número de teléfono para que nunca pierdas el acceso a tu cuenta.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "Añade un número de teléfono para recibir un sombrero gratis y para no perder el acceso a tu cuenta.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "Confirma el código de tu país e introduce tu número de teléfono. Te enviaremos un SMS para completar la verificación. (Nota: pueden aplicarse cargos por el servicio de mensajería.)";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "Acuérdate de confirmar tu correo electrónico para recibir un sombrero gratis.";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "Acuérdate de confirmar el correo electrónico de uno de tus padres para recibir un sombrero gratis.";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "Añade un número de teléfono a tu cuenta para que tus amigos te puedan encontrar.";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "Se ha confirmado tu número de teléfono. ¡Disfruta el sombrero gratis!";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "Se ha añadido tu número de teléfono.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "Se ha enviado un enlace de verificación a tu correo electrónico. Verifícalo para proteger tu cuenta.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "Verifica la dirección de correo electrónico para que siempre puedas acceder a tu cuenta de Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "Verifica la dirección de correo electrónico de uno de tus padres para que siempre puedas acceder a tu cuenta de Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "Se ha enviado un enlace de verificación al correo electrónico de uno de tus padres. Verifícalo para proteger tu cuenta.";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "Se ha enviado un enlace de verificación a tu correo electrónico. Verifícalo para proteger tu cuenta. También puedes ir a Mi configuración > Información de la cuenta para modificarla.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "Se ha producido un error. Inténtalo de nuevo más tarde.";

	public ContactUpsellResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "Añadir correo electrónico";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "Añadir correo electrónico";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "Añadir correo electrónico ahora";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "Añadir ahora";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "Añadir correo electrónico de un progenitor";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "Añadir correo electrónico de un progenitor ahora";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "Añadir número de teléfono";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "Añadir teléfono ahora";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Cerrar";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "Confirmar correo electrónico";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "Editar número de teléfono";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "Reenviar código";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "Verificar correo electrónico";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "Verificar teléfono";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "Añadir correo electrónico de un progenitor";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "Añadir correo electrónico";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "¡No pierdas el acceso a tu cuenta!";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "¡No te olvides de confirmar!";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "Se ha producido un error.";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "¡Ayuda a tus amigos a encontrarte!";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "¡Consíguete un sombrero gratis!";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "Hecho";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "Verificar correo electrónico";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "Añadir teléfono";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"Introduce el código ({number} dígitos)";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "Introduce el código ({number} dígitos)";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "Dirección de correo electrónico";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Se ha producido un error.";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Correo electrónico no válido";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Número de teléfono no válido";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "¿No tienes un correo electrónico?";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "¿No tienes un número de teléfono?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "¿No lo has recibido?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "o";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "Dirección de correo electrónico de un progenitor";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Contraseña de la cuenta de Roblox";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "Número de teléfono";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "¡Protege tu cuenta con un correo electrónico!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "¡Protege tu cuenta con el correo electrónico de uno de tus padres!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "¡Protege tu cuenta con un número de teléfono!";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "Reenviar correo electrónico";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "¡Verifica tu correo electrónico para proteger tu cuenta!";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "¡Verifica el correo electrónico de uno de tus padres para proteger tu cuenta!";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Contraseña de la cuenta de Roblox";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "Se ha producido un error al cargar la lista de países.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "Añade un tu correo electrónico para recibir un sombrero gratis y para no perder el acceso a tu cuenta.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "Añade el correo electrónico de uno de tus padres para recibir un sombrero gratis y para no perder el acceso a tu cuenta.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "Introduce tu dirección de correo electrónico. Te enviaremos un enlace para completar la verificación.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "Introduce la dirección de correo electrónico de uno de tus padres. Te enviaremos un enlace para completar la verificación.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "Añade una dirección de correo electrónico para que siempre puedas acceder a tu cuenta de Roblox.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "Añade la dirección de correo electrónico de uno de tus padres para que siempre puedas acceder a tu cuenta de Roblox.";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "Añade un número de teléfono para que nunca pierdas el acceso a tu cuenta.";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "Añade un número de teléfono para recibir un sombrero gratis y para no perder el acceso a tu cuenta.";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "Confirma el código de tu país e introduce tu número de teléfono. Te enviaremos un SMS para completar la verificación. (Nota: pueden aplicarse cargos por el servicio de mensajería.)";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "Acuérdate de confirmar tu correo electrónico para recibir un sombrero gratis.";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "Acuérdate de confirmar el correo electrónico de uno de tus padres para recibir un sombrero gratis.";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "Añade un número de teléfono a tu cuenta para que tus amigos te puedan encontrar.";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"Introduce el código que se ha enviado por SMS al {phoneNumber}.";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "Introduce el código que se ha enviado por SMS al {phoneNumber}.";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "Se ha confirmado tu número de teléfono. ¡Disfruta el sombrero gratis!";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "Se ha añadido tu número de teléfono.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "Se ha enviado un enlace de verificación a tu correo electrónico. Verifícalo para proteger tu cuenta.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "Verifica la dirección de correo electrónico para que siempre puedas acceder a tu cuenta de Roblox.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "Verifica la dirección de correo electrónico de uno de tus padres para que siempre puedas acceder a tu cuenta de Roblox.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "Se ha enviado un enlace de verificación al correo electrónico de uno de tus padres. Verifícalo para proteger tu cuenta.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "Se ha enviado un enlace de verificación a tu correo electrónico. Verifícalo para proteger tu cuenta. También puedes ir a Mi configuración > Información de la cuenta para modificarla.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Se ha producido un error. Inténtalo de nuevo más tarde.";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"El código debe tener {number} dígitos.";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "El código debe tener {number} dígitos.";
	}
}
