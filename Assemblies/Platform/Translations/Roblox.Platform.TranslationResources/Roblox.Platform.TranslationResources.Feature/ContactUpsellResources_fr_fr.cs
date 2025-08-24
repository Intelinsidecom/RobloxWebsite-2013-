namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_fr_fr : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "Ajouter une adresse e-mail";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "Ajouter une adresse e-mail";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "Ajouter une adresse e-mail";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "Ajouter maintenant";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "Ajouter une adresse e-mail parentale";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "Ajouter une adresse e-mail parentale";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "Ajouter un numéro de téléphone";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "Ajouter un numéro de téléphone";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fermer";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "Confirmer l'adresse e-mail";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "Modifier le numéro de téléphone";

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
	public override string ActionResendCode => "Renvoyer le code";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Envoyer";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Vérifier";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "Vérifier l'adresse e-mail";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "Vérifier le numéro de téléphone";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "Ajouter une adresse e-mail parentale";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "Ajouter une adresse e-mail";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "Ne perds pas l'accès à ton compte\u00a0!";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "N'oubliez pas de confirmer\u00a0!";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "Une erreur est survenue.";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "Aidez vos amis à vous trouver\u00a0!";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "Obtenez un chapeau gratuit\u00a0!";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public override string HeadingSuccess => "Succès";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public override string HeadingVerifyEmail => "Vérifier l'adresse e-mail";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "Ajouter numéro de téléphone";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "Adresse e-mail";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "Une erreur est survenue.";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Adresse e-mail invalide";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Numéro de téléphone invalide";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "Vous n'avez pas d'adresse e-mail\u00a0?";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "Vous n'avez pas de numéro de téléphone\u00a0?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Vous n'avez pas reçu d'e-mail\u00a0?";

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
	public override string LabelParentsEmailPlaceholder => "Adresse e-mail parentale";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Mot de passe du compte Roblox";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "Numéro de téléphone";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "Protège ton compte avec une adresse e-mail\u00a0!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "Protège ton compte grâce à l'adresse e-mail parentale\u00a0!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "Protège ton compte avec un numéro de téléphone\u00a0!";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "Renvoyer l'e-mail";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "Vérifie ton adresse e-mail pour protéger ton compte\u00a0!";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "Vérifie l'adresse e-mail parentale pour protéger ton compte\u00a0!";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Mot de passe du compte Roblox";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "Une erreur est survenue lors du chargement de la liste des pays.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "Ajoute une adresse e-mail à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès et recevoir un chapeau gratuit\u00a0!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "Ajoute une adresse e-mail parentale à ton compte Roblox faire en sorte de ne jamais en perdre l'accès et recevoir un chapeau gratuit\u00a0!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "Il faut indiquer ton adresse e-mail. Un lien sera envoyé afin de terminer la vérification.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "Veuillez indiquer l'adresse e-mail d'un parent. Un lien sera envoyé afin de terminer la vérification.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "Il faut ajouter une adresse e-mail à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "Il faut ajouter l'adresse e-mail d'un parent à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "Il faut ajouter un numéro de téléphone à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "Ajoute un numéro de téléphone à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès et recevoir un chapeau gratuit\u00a0!";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "Confirme l'indicatif pays et saisis ton numéro de téléphone. Un SMS te sera envoyé pour finaliser la vérification (des frais de messagerie texte peuvent s'appliquer)";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "N'oubliez pas de confirmer l'adresse e-mail pour recevoir le chapeau gratuit\u00a0!";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "N'oubliez pas de confirmer l'adresse e-mail parentale pour recevoir le chapeau gratuit\u00a0!";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "Il faut ajouter un numéro de téléphone à ton compte Roblox pour que tes amis puissent te retrouver\u00a0!";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "Ton numéro de téléphone a été confirmé. Profite bien du chapeau gratuit\u00a0!";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "Le numéro de téléphone a été ajouté.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "Un lien de vérification a été envoyé à ton adresse e-mail. Il faut procéder à la vérification afin de sécuriser ton compte.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "Il faut vérifier ton adresse e-mail pour faire en sorte de ne jamais perdre l'accès à ton compte Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "Il faut vérifier l'adresse e-mail de ton parent pour faire en sorte de ne jamais perdre l'accès à ton compte Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "Un lien de vérification a été envoyé à l'adresse e-mail de ton parent. Veuillez procéder à la vérification afin de sécuriser ton compte.";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "Un lien de vérification a été envoyé à ton adresse e-mail. Il faut procéder à la vérification afin de sécuriser ton compte. Il est possible d'y apporter des modifications à tout moment depuis Paramètres > Infos sur le compte.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "Une erreur est survenue. Veuillez réessayer plus tard.";

	public ContactUpsellResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "Ajouter une adresse e-mail";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "Ajouter une adresse e-mail";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "Ajouter une adresse e-mail";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "Ajouter maintenant";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "Ajouter une adresse e-mail parentale";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "Ajouter une adresse e-mail parentale";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "Ajouter un numéro de téléphone";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "Ajouter un numéro de téléphone";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fermer";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "Confirmer l'adresse e-mail";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "Modifier le numéro de téléphone";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "Renvoyer le code";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Envoyer";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Vérifier";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "Vérifier l'adresse e-mail";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "Vérifier le numéro de téléphone";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "Ajouter une adresse e-mail parentale";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "Ajouter une adresse e-mail";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "Ne perds pas l'accès à ton compte\u00a0!";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "N'oubliez pas de confirmer\u00a0!";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "Une erreur est survenue.";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "Aidez vos amis à vous trouver\u00a0!";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "Obtenez un chapeau gratuit\u00a0!";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "Succès";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "Vérifier l'adresse e-mail";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "Ajouter numéro de téléphone";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"Saisir le code ({number}\u00a0chiffres)";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "Saisir le code ({number}\u00a0chiffres)";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "Adresse e-mail";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Une erreur est survenue.";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Adresse e-mail invalide";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Numéro de téléphone invalide";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "Vous n'avez pas d'adresse e-mail\u00a0?";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "Vous n'avez pas de numéro de téléphone\u00a0?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Vous n'avez pas reçu d'e-mail\u00a0?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Ou";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "Adresse e-mail parentale";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Mot de passe du compte Roblox";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "Numéro de téléphone";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "Protège ton compte avec une adresse e-mail\u00a0!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "Protège ton compte grâce à l'adresse e-mail parentale\u00a0!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "Protège ton compte avec un numéro de téléphone\u00a0!";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "Renvoyer l'e-mail";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "Vérifie ton adresse e-mail pour protéger ton compte\u00a0!";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "Vérifie l'adresse e-mail parentale pour protéger ton compte\u00a0!";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Mot de passe du compte Roblox";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "Une erreur est survenue lors du chargement de la liste des pays.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "Ajoute une adresse e-mail à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès et recevoir un chapeau gratuit\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "Ajoute une adresse e-mail parentale à ton compte Roblox faire en sorte de ne jamais en perdre l'accès et recevoir un chapeau gratuit\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "Il faut indiquer ton adresse e-mail. Un lien sera envoyé afin de terminer la vérification.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "Veuillez indiquer l'adresse e-mail d'un parent. Un lien sera envoyé afin de terminer la vérification.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "Il faut ajouter une adresse e-mail à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "Il faut ajouter l'adresse e-mail d'un parent à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès.";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "Il faut ajouter un numéro de téléphone à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès.";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "Ajoute un numéro de téléphone à ton compte Roblox pour faire en sorte de ne jamais en perdre l'accès et recevoir un chapeau gratuit\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "Confirme l'indicatif pays et saisis ton numéro de téléphone. Un SMS te sera envoyé pour finaliser la vérification (des frais de messagerie texte peuvent s'appliquer)";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "N'oubliez pas de confirmer l'adresse e-mail pour recevoir le chapeau gratuit\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "N'oubliez pas de confirmer l'adresse e-mail parentale pour recevoir le chapeau gratuit\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "Il faut ajouter un numéro de téléphone à ton compte Roblox pour que tes amis puissent te retrouver\u00a0!";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"Saisissez le code figurant dans le message envoyé au {phoneNumber}.";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "Saisissez le code figurant dans le message envoyé au {phoneNumber}.";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "Ton numéro de téléphone a été confirmé. Profite bien du chapeau gratuit\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "Le numéro de téléphone a été ajouté.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "Un lien de vérification a été envoyé à ton adresse e-mail. Il faut procéder à la vérification afin de sécuriser ton compte.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "Il faut vérifier ton adresse e-mail pour faire en sorte de ne jamais perdre l'accès à ton compte Roblox.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "Il faut vérifier l'adresse e-mail de ton parent pour faire en sorte de ne jamais perdre l'accès à ton compte Roblox.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "Un lien de vérification a été envoyé à l'adresse e-mail de ton parent. Veuillez procéder à la vérification afin de sécuriser ton compte.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "Un lien de vérification a été envoyé à ton adresse e-mail. Il faut procéder à la vérification afin de sécuriser ton compte. Il est possible d'y apporter des modifications à tout moment depuis Paramètres > Infos sur le compte.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Une erreur est survenue. Veuillez réessayer plus tard.";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"Le code doit contenir {number}\u00a0chiffres.";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "Le code doit contenir {number}\u00a0chiffres.";
	}
}
