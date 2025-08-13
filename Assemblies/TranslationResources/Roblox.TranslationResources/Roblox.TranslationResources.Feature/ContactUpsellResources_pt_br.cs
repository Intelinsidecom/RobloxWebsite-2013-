namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_pt_br : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "Adicionar e-mail";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "Adicionar e-mail";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "Adicionar e-mail agora";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "Adicionar agora";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "Adicionar e-mail do responsável";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "Adicionar e-mail do responsável agora";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "Adicionar número de telefone";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "Adicionar telefone agora";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fechar";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "Confirmar e-mail";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "Editar número de telefone";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

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
	public override string ActionVerifyEmail => "Verificar e-mail";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "Verificar telefone";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "Adicionar e-mail do responsável";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "Adicionar e-mail";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "Não fique trancado do lado de fora!";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "Não se esqueça de confirmar!";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "Ocorreu um erro";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "Ajude seus amigos a encontrarem você!";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "Ganhe um chapéu grátis!";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public override string HeadingSuccess => "Sucesso";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public override string HeadingVerifyEmail => "Verificar e-mail";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "Adicionar telefone";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "Endereço de e-mail";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "Ocorreu um erro";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "E-mail inválido";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Número de telefone inválido";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "Você não tem um e-mail?";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "Você não tem um telefone?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Não recebeu?";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Ou";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "Endereço de e-mail do responsável";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Senha da conta Roblox";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "Número de telefone";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "Proteja sua conta com um e-mail!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "Proteja sua conta com o e-mail do responsável!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "Proteja sua conta com um número de telefone!";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "Reenviar e-mail";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "Verifique seu e-mail para proteger sua conta!";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "Verifique o e-mail do responsável para proteger sua conta!";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Senha da conta Roblox";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "Ocorreu um erro ao carregar a lista de países";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "Adicione seu e-mail à sua conta para receber um chapéu grátis e garantir que você nunca perca o acesso à sua conta!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "Adicione o e-mail do seu responsável à sua conta para receber um chapéu grátis e garantir que você nunca perca o acesso à sua conta!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "Insira seu endereço de e-mail. Enviaremos um link para você completar a verificação.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "Insira o endereço de e-mail do responsável. Enviaremos um link para você completar a verificação.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "Adicione um endereço de e-mail à sua conta para que você sempre possa ter acesso à sua conta Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "Adicione o endereço de e-mail do responsável à sua conta para que você sempre possa ter acesso à sua conta Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "Adicione um número de telefone à sua conta para garantir que você nunca perca o acesso à sua conta.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "Adicione um número de telefone à sua conta para receber um chapéu grátis e garantir que você nunca perca o acesso à sua conta!";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "Confirme o código do seu país e digite o seu número de telefone. Enviaremos uma mensagem de texto para completar a verificação. (Aviso: taxas de envio de mensagem de texto podem ser cobradas)";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "Lembre-se de confirmar seu endereço de e-mail para receber o chapéu grátis!";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "Lembre-se de confirmar o endereço de e-mail do responsável para receber o chapéu grátis!";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "Adicione um número de telefone à sua conta para que seus amigos possam encontrar você!";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "Seu número de telefone foi confirmado. Faça bom uso do seu chapéu grátis!";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "Telefone adicionado com sucesso.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "Link de verificação enviado para o seu e-mail. Verifique seu e-mail para proteger a sua conta.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "Verifique seu endereço de e-mail para que você sempre possa ter acesso à sua conta Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "Verifique o endereço de e-mail do responsável para que você sempre possa ter acesso à sua conta Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "Link de verificação enviado para o e-mail do responsável. Verifique o e-mail do responsável para proteger a sua conta.";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "Link de verificação enviado para o seu e-mail. Verifique seu e-mail para proteger a sua conta. Você sempre pode visitar Configurações > Informações da conta para modificar sua conta.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "Ocorreu um erro. Tente novamente mais tarde.";

	public ContactUpsellResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "Adicionar e-mail";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "Adicionar e-mail";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "Adicionar e-mail agora";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "Adicionar agora";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "Adicionar e-mail do responsável";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "Adicionar e-mail do responsável agora";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "Adicionar número de telefone";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "Adicionar telefone agora";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fechar";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "Confirmar e-mail";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "Editar número de telefone";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
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
		return "Verificar e-mail";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "Verificar telefone";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "Adicionar e-mail do responsável";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "Adicionar e-mail";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "Não fique trancado do lado de fora!";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "Não se esqueça de confirmar!";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "Ocorreu um erro";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "Ajude seus amigos a encontrarem você!";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "Ganhe um chapéu grátis!";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "Sucesso";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "Verificar e-mail";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "Adicionar telefone";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"Insira o código ({number} dígitos)";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "Insira o código ({number} dígitos)";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "Endereço de e-mail";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Ocorreu um erro";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "E-mail inválido";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Número de telefone inválido";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "Você não tem um e-mail?";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "Você não tem um telefone?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Não recebeu?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Ou";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "Endereço de e-mail do responsável";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Senha da conta Roblox";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "Número de telefone";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "Proteja sua conta com um e-mail!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "Proteja sua conta com o e-mail do responsável!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "Proteja sua conta com um número de telefone!";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "Reenviar e-mail";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "Verifique seu e-mail para proteger sua conta!";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "Verifique o e-mail do responsável para proteger sua conta!";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Senha da conta Roblox";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "Ocorreu um erro ao carregar a lista de países";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "Adicione seu e-mail à sua conta para receber um chapéu grátis e garantir que você nunca perca o acesso à sua conta!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "Adicione o e-mail do seu responsável à sua conta para receber um chapéu grátis e garantir que você nunca perca o acesso à sua conta!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "Insira seu endereço de e-mail. Enviaremos um link para você completar a verificação.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "Insira o endereço de e-mail do responsável. Enviaremos um link para você completar a verificação.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "Adicione um endereço de e-mail à sua conta para que você sempre possa ter acesso à sua conta Roblox.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "Adicione o endereço de e-mail do responsável à sua conta para que você sempre possa ter acesso à sua conta Roblox.";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "Adicione um número de telefone à sua conta para garantir que você nunca perca o acesso à sua conta.";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "Adicione um número de telefone à sua conta para receber um chapéu grátis e garantir que você nunca perca o acesso à sua conta!";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "Confirme o código do seu país e digite o seu número de telefone. Enviaremos uma mensagem de texto para completar a verificação. (Aviso: taxas de envio de mensagem de texto podem ser cobradas)";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "Lembre-se de confirmar seu endereço de e-mail para receber o chapéu grátis!";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "Lembre-se de confirmar o endereço de e-mail do responsável para receber o chapéu grátis!";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "Adicione um número de telefone à sua conta para que seus amigos possam encontrar você!";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"Insira o código do texto enviado para {phoneNumber}";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "Insira o código do texto enviado para {phoneNumber}";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "Seu número de telefone foi confirmado. Faça bom uso do seu chapéu grátis!";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "Telefone adicionado com sucesso.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "Link de verificação enviado para o seu e-mail. Verifique seu e-mail para proteger a sua conta.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "Verifique seu endereço de e-mail para que você sempre possa ter acesso à sua conta Roblox.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "Verifique o endereço de e-mail do responsável para que você sempre possa ter acesso à sua conta Roblox.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "Link de verificação enviado para o e-mail do responsável. Verifique o e-mail do responsável para proteger a sua conta.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "Link de verificação enviado para o seu e-mail. Verifique seu e-mail para proteger a sua conta. Você sempre pode visitar Configurações > Informações da conta para modificar sua conta.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Ocorreu um erro. Tente novamente mais tarde.";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"O código deve ter {number} dígitos";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "O código deve ter {number} dígitos";
	}
}
