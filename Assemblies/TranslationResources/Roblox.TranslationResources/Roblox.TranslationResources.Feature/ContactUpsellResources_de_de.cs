namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ContactUpsellResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ContactUpsellResources_de_de : ContactUpsellResources_en_us, IContactUpsellResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddEmail"
	/// This action will allow the user to add their email.
	/// English String: "Add Email"
	/// </summary>
	public override string ActionAddEmail => "E-Mail-Adresse hinzufügen";

	/// <summary>
	/// Key: "Action.AddEmailLink"
	/// This action will guide the user to add their email.
	/// English String: "Add email"
	/// </summary>
	public override string ActionAddEmailLink => "E-Mail-Adresse hinzufügen";

	/// <summary>
	/// Key: "Action.AddEmailNow"
	/// This action will launch a modal where the user can enter their email
	/// English String: "Add Email Now"
	/// </summary>
	public override string ActionAddEmailNow => "E-Mail-Adresse jetzt hinzufügen";

	/// <summary>
	/// Key: "Action.AddNow"
	/// Add Now
	/// English String: "Add Now"
	/// </summary>
	public override string ActionAddNow => "Jetzt hinzufügen";

	/// <summary>
	/// Key: "Action.AddParentsEmail"
	/// This action will allow the user to add their parent's email.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionAddParentsEmail => "E-Mail-Adresse deiner Eltern hinzufügen";

	/// <summary>
	/// Key: "Action.AddParentsEmailNow"
	/// This action will launch a modal where the user can enter their parent's email
	/// English String: "Add Parent's Email Now"
	/// </summary>
	public override string ActionAddParentsEmailNow => "E-Mail-Adresse deiner Eltern jetzt hinzufügen";

	/// <summary>
	/// Key: "Action.AddPhone"
	/// This action will allow the user to add their phone number.
	/// English String: "Add Phone Number"
	/// </summary>
	public override string ActionAddPhone => "Handynummer hinzufügen";

	/// <summary>
	/// Key: "Action.AddPhoneNow"
	/// This action will launch a modal where the user can enter their phone number
	/// English String: "Add Phone Now"
	/// </summary>
	public override string ActionAddPhoneNow => "Handynummer jetzt hinzufügen";

	/// <summary>
	/// Key: "Action.Close"
	/// This action will allow the user to close the dialog box.
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Schließen";

	/// <summary>
	/// Key: "Action.ConfirmEmail"
	/// This action will allow the user to confirm their email
	/// English String: "Confirm Email"
	/// </summary>
	public override string ActionConfirmEmail => "E-Mail-Adresse bestätigen";

	/// <summary>
	/// Key: "Action.EditPhoneNumber"
	/// This action will allow the user to edit their phone number.
	/// English String: "Edit Phone Number"
	/// </summary>
	public override string ActionEditPhoneNumber => "Handynummer bearbeiten";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Okay";

	/// <summary>
	/// Key: "Action.ResendCode"
	/// Resend Code
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResendCode => "Code erneut senden";

	/// <summary>
	/// Key: "Action.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Senden";

	/// <summary>
	/// Key: "Action.Verify"
	/// Verify
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verifizieren";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// This action will allow the user to verify their email.
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "E-Mail-Adresse verifizieren";

	/// <summary>
	/// Key: "Action.VerifyPhone"
	/// Verify Phone
	/// English String: "Verify Phone"
	/// </summary>
	public override string ActionVerifyPhone => "Handy verifizieren";

	/// <summary>
	/// Key: "Actions.AddParentsEmail"
	/// Do not use. Use Action.AddParentsEmail instead.
	/// English String: "Add Parent's Email"
	/// </summary>
	public override string ActionsAddParentsEmail => "E-Mail-Adresse deiner Eltern hinzufügen";

	/// <summary>
	/// Key: "Heading.AddEmail"
	/// Add Email
	/// English String: "Add Email"
	/// </summary>
	public override string HeadingAddEmail => "E-Mail-Adresse hinzufügen";

	/// <summary>
	/// Key: "Heading.DefaultHeader"
	/// This heading is used to entice users to update their contact information so that they will not be locked out of their account.
	/// English String: "Don't get locked out!"
	/// </summary>
	public override string HeadingDefaultHeader => "Verliere nie den Zugriff auf dein Konto!";

	/// <summary>
	/// Key: "Heading.DontForgetToConfirm"
	/// This heading entices users to confirm their email in order to receive a free hat
	/// English String: "Don't forget to confirm!"
	/// </summary>
	public override string HeadingDontForgetToConfirm => "Bestätigung nicht vergessen!";

	/// <summary>
	/// Key: "Heading.Error"
	/// An error occured
	/// English String: "An error occurred"
	/// </summary>
	public override string HeadingError => "Ein Fehler ist aufgetreten.";

	/// <summary>
	/// Key: "Heading.FindFriends"
	/// This heading is used to entice users to update their contact information so that friends will more easily connect with them on the platform.
	/// English String: "Help your friends find you!"
	/// </summary>
	public override string HeadingFindFriends => "Hilf deinen Freunden, dich zu finden!";

	/// <summary>
	/// Key: "Heading.FreeHat"
	/// This heading is used to entice users to update their contact information in order to receive a free hat
	/// English String: "Get yourself a free hat!"
	/// </summary>
	public override string HeadingFreeHat => "Hol dir einen kostenlosen Hut!";

	/// <summary>
	/// Key: "Heading.Success"
	/// This message is to notify the user that their contact information has successfully been updated.
	/// English String: "Success"
	/// </summary>
	public override string HeadingSuccess => "Erfolg";

	/// <summary>
	/// Key: "Heading.VerifyEmail"
	/// Verify Email
	/// English String: "Verify Email"
	/// </summary>
	public override string HeadingVerifyEmail => "E-Mail-Adresse verifizieren";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// AddPhone
	/// English String: "AddPhone"
	/// </summary>
	public override string LabelAddPhone => "Handy hinzufügen";

	/// <summary>
	/// Key: "Label.EmailPlaceholder"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public override string LabelEmailPlaceholder => "E-Mail-Adresse";

	/// <summary>
	/// Key: "Label.Error"
	/// An error occurred
	/// English String: "An error occurred"
	/// </summary>
	public override string LabelError => "Ein Fehler ist aufgetreten.";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// Invalid email
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Ungültige E-Mail-Adresse";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// Invalid phone number
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Ungültige Handynummer";

	/// <summary>
	/// Key: "Label.NoEmail"
	/// This link is to guide users who don't have an email.
	/// English String: "Don't have an email?"
	/// </summary>
	public override string LabelNoEmail => "Du hast keine E-Mail-Adresse?";

	/// <summary>
	/// Key: "Label.NoPhone"
	/// This link is to guide users who don't have a phone.
	/// English String: "Don't have a phone?"
	/// </summary>
	public override string LabelNoPhone => "Du hast kein Handy?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// Didn't receive it?
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Nicht erhalten?";

	/// <summary>
	/// Key: "Label.Or"
	/// Or
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Oder";

	/// <summary>
	/// Key: "Label.ParentsEmailPlaceholder"
	/// Parent's Email Address
	/// English String: "Parent's Email Address"
	/// </summary>
	public override string LabelParentsEmailPlaceholder => "E-Mail-Adresse deiner Eltern";

	/// <summary>
	/// Key: "Label.Password"
	/// form label
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelPassword => "Roblox-Kontopasswort";

	/// <summary>
	/// Key: "Label.PhonePlaceholder"
	/// Phone Number
	/// English String: "Phone Number"
	/// </summary>
	public override string LabelPhonePlaceholder => "Handynummer";

	/// <summary>
	/// Key: "Label.ProtectAccountWithEmail"
	/// shown to user when we try to upsell them on linking an email to their account
	/// English String: "Protect your account with an email!"
	/// </summary>
	public override string LabelProtectAccountWithEmail => "Schütze dein Konto mit einer E-Mail-Adresse!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithParentsEmail"
	/// shown to user when we try to upsell them on linking their parent's email to their account
	/// English String: "Protect your account with your parent's email!"
	/// </summary>
	public override string LabelProtectAccountWithParentsEmail => "Schütze dein Konto mit der E-Mail-Adresse deiner Eltern!";

	/// <summary>
	/// Key: "Label.ProtectAccountWithPhone"
	/// shown to user when we try to upsell them on linking a phone number to their account
	/// English String: "Protect your account with a phone number!"
	/// </summary>
	public override string LabelProtectAccountWithPhone => "Schütze dein Konto mit einer Telefonnummer!";

	/// <summary>
	/// Key: "Label.ResendEmail"
	/// Resend Email
	/// English String: "Resend Email"
	/// </summary>
	public override string LabelResendEmail => "E-Mail erneut senden";

	/// <summary>
	/// Key: "Label.VerifyEmailToProtectAccount"
	/// shown to user when we try to get them to verify their email
	/// English String: "Verify your email to protect your account!"
	/// </summary>
	public override string LabelVerifyEmailToProtectAccount => "Verifiziere deine E-Mail-Adresse, um dein Konto zu schützen!";

	/// <summary>
	/// Key: "Label.VerifyParentsEmailToProtectAccount"
	/// shown to user when we try to get them to verify their parent's email
	/// English String: "Verify your parent's email to protect your account!"
	/// </summary>
	public override string LabelVerifyParentsEmailToProtectAccount => "Verifiziere die E-Mail-Adresse deiner Eltern, um dein Konto zu schützen!";

	/// <summary>
	/// Key: "Label.VerifyPasswordPlaceholder"
	/// Roblox Account Password
	/// English String: "Roblox Account Password"
	/// </summary>
	public override string LabelVerifyPasswordPlaceholder => "Roblox-Kontopasswort";

	/// <summary>
	/// Key: "Response.CountryListError"
	/// error message
	/// English String: "An error occurred loading the country list"
	/// </summary>
	public override string ResponseCountryListError => "Beim Laden der Länderliste ist ein Fehler aufgetreten.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatOver13"
	/// This message is to persuade the user to add their email address to their account for a free hat.
	/// English String: "Please add your email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatOver13 => "Bitte füge deine E-Mail-Adresse hinzu, um einen kostenlosen Hut zu erhalten und sicherzustellen, dass du immer auf dein Konto zugreifen kannst!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailForFreeHatUnder13"
	/// This message is to persuade the user to add their parent's email address to their account for a free hat.
	/// English String: "Please add your parent's email to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddEmailForFreeHatUnder13 => "Bitte füge die E-Mail-Adresse deiner Eltern hinzu, um einen kostenlosen Hut zu erhalten und sicherzustellen, dass du immer auf dein Konto zugreifen kannst!";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsOver13 => "Bitte gib deine E-Mail-Adresse ein. Wir werden einen Link an dich senden, damit die Verifizierung abgeschlossen werden kann.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailInstructionsUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please enter your parent's email address. We will send a link to complete verification."
	/// </summary>
	public override string ResponseDialogAddEmailInstructionsUnder13 => "Bitte gib die E-Mail-Adresse deiner Eltern ein. Wir werden einen Link an sie senden, damit die Verifizierung abgeschlossen werden kann.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailOver13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add an email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailOver13 => "Bitte füge eine E-Mail-Adresse zu deinem Konto hinzu, um sicherzustellen, dass du immer auf dein Roblox-Konto zugreifen kannst.";

	/// <summary>
	/// Key: "Response.Dialog.AddEmailUnder13"
	/// This message is to persuade the user to add their email address to their account.
	/// English String: "Please add your parent's email address to your account to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogAddEmailUnder13 => "Bitte füge die E-Mail-Adresse deiner Eltern zu deinem Konto hinzu, um sicherzustellen, dass du immer auf dein Roblox-Konto zugreifen kannst.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhone"
	/// This message is to persuade the user to add their phone number to their account.
	/// English String: "Please add a phone number to your account to ensure that you never get locked out of your account."
	/// </summary>
	public override string ResponseDialogAddPhone => "Bitte füge eine Handynummer zu deinem Konto hinzu, um sicherzustellen, dass du immer auf dein Konto zugreifen kannst.";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneForFreeHat"
	/// This message is to persuade the user to add their phone number to their account for a free hat.
	/// English String: "Please add your phone number to receive a free hat and ensure that you never get locked out of your account!"
	/// </summary>
	public override string ResponseDialogAddPhoneForFreeHat => "Bitte füge deine Handynummer hinzu, um einen kostenlosen Hut zu erhalten und sicherzustellen, dass du immer auf dein Konto zugreifen kannst!";

	/// <summary>
	/// Key: "Response.Dialog.AddPhoneInstructions"
	/// This message is to instruct the user on how to add their phone number to their account.
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public override string ResponseDialogAddPhoneInstructions => "Bitte bestätige deine Ländervorwahl und gib deine Handynummer ein. Wir werden dir eine SMS schicken, um die Verifizierung abzuschließen. (Hinweis: Es können SMS-Kosten anfallen.)";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatOver13"
	/// This message is to persuade the user to verify their email address on their account for a free hat.
	/// English String: "Remember to confirm your email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatOver13 => "Denk daran, deine E-Mail-Adresse zu bestätigen, um den kostenlosen Hut zu erhalten!";

	/// <summary>
	/// Key: "Response.Dialog.ConfirmEmailForFreeHatUnder13"
	/// This message is to persuade the user to verify their parent's email address on their account for a free hat.
	/// English String: "Remember to confirm your parent's email address to receive the free hat!"
	/// </summary>
	public override string ResponseDialogConfirmEmailForFreeHatUnder13 => "Denk daran, die E-Mail-Adresse deiner Eltern zu bestätigen, um den kostenlosen Hut zu erhalten!";

	/// <summary>
	/// Key: "Response.Dialog.ContactFriendFinderPhoneUpsell"
	/// This message is to persuade the user to add their phone number to their account by saying that friends will more easily connect with them on the platform if they do so.
	/// English String: "Please add a phone number to your account so that your friends can find you!"
	/// </summary>
	public override string ResponseDialogContactFriendFinderPhoneUpsell => "Bitte füge eine Handynummer zu deinem Konto hinzu, damit deine Freunde dich finden können!";

	/// <summary>
	/// Key: "Response.Dialog.FreeHatForAddingPhone"
	/// This message is to notify the user that their phone number has successfully been updated and they will get a free hat.
	/// English String: "Your phone number has been confirmed. Enjoy the free hat!"
	/// </summary>
	public override string ResponseDialogFreeHatForAddingPhone => "Deine Handynummer wurde bestätigt. Viel Spaß mit deinem kostenlosen Hut!";

	/// <summary>
	/// Key: "Response.Dialog.PhoneAdded"
	/// This message is to notify the user that their phone number has successfully been updated.
	/// English String: "Phone has been successfully added."
	/// </summary>
	public override string ResponseDialogPhoneAdded => "Handynummer wurde erfolgreich hinzugefügt.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmail13AndOverSuccessMessage"
	/// Verification link has been sent to your email - please verify your email to secure your account.
	/// English String: "Verification link has been sent to your email - please verify your email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmail13AndOverSuccessMessage => "Der Verifizierungslink wurde an deine E-Mail-Adresse gesendet. Bitte verifiziere deine E-Mail-Adresse, um dein Konto zu sichern.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailOver13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailOver13 => "Bitte verifiziere deine E-Mail-Adresse, um sicherzustellen, dass du immer auf dein Roblox-Konto zugreifen kannst.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13"
	/// This message is to persuade the user to verify their email address on their account.
	/// English String: "Please verify your parent's email address to ensure that you can always access your Roblox account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13 => "Bitte verifiziere die E-Mail-Adresse deiner Eltern, um sicherzustellen, dass du immer auf dein Roblox-Konto zugreifen kannst.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyEmailUnder13SuccessMessage"
	/// Verification link has been sent to your parent's email - please verify your parent's email to secure your account.
	/// English String: "Verification link has been sent to your parent's email - please verify your parent's email to secure your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailUnder13SuccessMessage => "Der Verifizierungslink wurde an die E-Mail-Adresse deiner Eltern gesendet. Bitte verifiziere die E-Mail-Adresse deiner Eltern, um dein Konto zu sichern.";

	/// <summary>
	/// Key: "Response.DialogVerifyEmailInstructions"
	/// Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account.
	/// English String: "Verification link has been sent to your email. Please verify your email to secure your account. You can always visit Settings &gt; Account Info to modify your account."
	/// </summary>
	public override string ResponseDialogVerifyEmailInstructions => "Der Verifizierungslink wurde an deine E-Mail-Adresse gesendet. Bitte verifiziere deine E-Mail-Adresse, um dein Konto zu sichern. Du kannst dein Konto jederzeit bearbeiten, indem du zu Einstellungen > Kontodetails gehst.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// generic error message
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";

	public ContactUpsellResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddEmail()
	{
		return "E-Mail-Adresse hinzufügen";
	}

	protected override string _GetTemplateForActionAddEmailLink()
	{
		return "E-Mail-Adresse hinzufügen";
	}

	protected override string _GetTemplateForActionAddEmailNow()
	{
		return "E-Mail-Adresse jetzt hinzufügen";
	}

	protected override string _GetTemplateForActionAddNow()
	{
		return "Jetzt hinzufügen";
	}

	protected override string _GetTemplateForActionAddParentsEmail()
	{
		return "E-Mail-Adresse deiner Eltern hinzufügen";
	}

	protected override string _GetTemplateForActionAddParentsEmailNow()
	{
		return "E-Mail-Adresse deiner Eltern jetzt hinzufügen";
	}

	protected override string _GetTemplateForActionAddPhone()
	{
		return "Handynummer hinzufügen";
	}

	protected override string _GetTemplateForActionAddPhoneNow()
	{
		return "Handynummer jetzt hinzufügen";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForActionConfirmEmail()
	{
		return "E-Mail-Adresse bestätigen";
	}

	protected override string _GetTemplateForActionEditPhoneNumber()
	{
		return "Handynummer bearbeiten";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForActionResendCode()
	{
		return "Code erneut senden";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Senden";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verifizieren";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "E-Mail-Adresse verifizieren";
	}

	protected override string _GetTemplateForActionVerifyPhone()
	{
		return "Handy verifizieren";
	}

	protected override string _GetTemplateForActionsAddParentsEmail()
	{
		return "E-Mail-Adresse deiner Eltern hinzufügen";
	}

	protected override string _GetTemplateForHeadingAddEmail()
	{
		return "E-Mail-Adresse hinzufügen";
	}

	protected override string _GetTemplateForHeadingDefaultHeader()
	{
		return "Verliere nie den Zugriff auf dein Konto!";
	}

	protected override string _GetTemplateForHeadingDontForgetToConfirm()
	{
		return "Bestätigung nicht vergessen!";
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "Ein Fehler ist aufgetreten.";
	}

	protected override string _GetTemplateForHeadingFindFriends()
	{
		return "Hilf deinen Freunden, dich zu finden!";
	}

	protected override string _GetTemplateForHeadingFreeHat()
	{
		return "Hol dir einen kostenlosen Hut!";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "Erfolg";
	}

	protected override string _GetTemplateForHeadingVerifyEmail()
	{
		return "E-Mail-Adresse verifizieren";
	}

	protected override string _GetTemplateForLabelAddPhone()
	{
		return "Handy hinzufügen";
	}

	/// <summary>
	/// Key: "Label.CodePlaceHolder"
	/// Enter Code ({number}- digit)
	/// English String: "Enter Code ({number}- digit)"
	/// </summary>
	public override string LabelCodePlaceHolder(string number)
	{
		return $"Code eingeben ({number}-stellig)";
	}

	protected override string _GetTemplateForLabelCodePlaceHolder()
	{
		return "Code eingeben ({number}-stellig)";
	}

	protected override string _GetTemplateForLabelEmailPlaceholder()
	{
		return "E-Mail-Adresse";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Ein Fehler ist aufgetreten.";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Ungültige E-Mail-Adresse";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Ungültige Handynummer";
	}

	protected override string _GetTemplateForLabelNoEmail()
	{
		return "Du hast keine E-Mail-Adresse?";
	}

	protected override string _GetTemplateForLabelNoPhone()
	{
		return "Du hast kein Handy?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Nicht erhalten?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Oder";
	}

	protected override string _GetTemplateForLabelParentsEmailPlaceholder()
	{
		return "E-Mail-Adresse deiner Eltern";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Roblox-Kontopasswort";
	}

	protected override string _GetTemplateForLabelPhonePlaceholder()
	{
		return "Handynummer";
	}

	protected override string _GetTemplateForLabelProtectAccountWithEmail()
	{
		return "Schütze dein Konto mit einer E-Mail-Adresse!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithParentsEmail()
	{
		return "Schütze dein Konto mit der E-Mail-Adresse deiner Eltern!";
	}

	protected override string _GetTemplateForLabelProtectAccountWithPhone()
	{
		return "Schütze dein Konto mit einer Telefonnummer!";
	}

	protected override string _GetTemplateForLabelResendEmail()
	{
		return "E-Mail erneut senden";
	}

	protected override string _GetTemplateForLabelVerifyEmailToProtectAccount()
	{
		return "Verifiziere deine E-Mail-Adresse, um dein Konto zu schützen!";
	}

	protected override string _GetTemplateForLabelVerifyParentsEmailToProtectAccount()
	{
		return "Verifiziere die E-Mail-Adresse deiner Eltern, um dein Konto zu schützen!";
	}

	protected override string _GetTemplateForLabelVerifyPasswordPlaceholder()
	{
		return "Roblox-Kontopasswort";
	}

	protected override string _GetTemplateForResponseCountryListError()
	{
		return "Beim Laden der Länderliste ist ein Fehler aufgetreten.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatOver13()
	{
		return "Bitte füge deine E-Mail-Adresse hinzu, um einen kostenlosen Hut zu erhalten und sicherzustellen, dass du immer auf dein Konto zugreifen kannst!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailForFreeHatUnder13()
	{
		return "Bitte füge die E-Mail-Adresse deiner Eltern hinzu, um einen kostenlosen Hut zu erhalten und sicherzustellen, dass du immer auf dein Konto zugreifen kannst!";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsOver13()
	{
		return "Bitte gib deine E-Mail-Adresse ein. Wir werden einen Link an dich senden, damit die Verifizierung abgeschlossen werden kann.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailInstructionsUnder13()
	{
		return "Bitte gib die E-Mail-Adresse deiner Eltern ein. Wir werden einen Link an sie senden, damit die Verifizierung abgeschlossen werden kann.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailOver13()
	{
		return "Bitte füge eine E-Mail-Adresse zu deinem Konto hinzu, um sicherzustellen, dass du immer auf dein Roblox-Konto zugreifen kannst.";
	}

	protected override string _GetTemplateForResponseDialogAddEmailUnder13()
	{
		return "Bitte füge die E-Mail-Adresse deiner Eltern zu deinem Konto hinzu, um sicherzustellen, dass du immer auf dein Roblox-Konto zugreifen kannst.";
	}

	protected override string _GetTemplateForResponseDialogAddPhone()
	{
		return "Bitte füge eine Handynummer zu deinem Konto hinzu, um sicherzustellen, dass du immer auf dein Konto zugreifen kannst.";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneForFreeHat()
	{
		return "Bitte füge deine Handynummer hinzu, um einen kostenlosen Hut zu erhalten und sicherzustellen, dass du immer auf dein Konto zugreifen kannst!";
	}

	protected override string _GetTemplateForResponseDialogAddPhoneInstructions()
	{
		return "Bitte bestätige deine Ländervorwahl und gib deine Handynummer ein. Wir werden dir eine SMS schicken, um die Verifizierung abzuschließen. (Hinweis: Es können SMS-Kosten anfallen.)";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatOver13()
	{
		return "Denk daran, deine E-Mail-Adresse zu bestätigen, um den kostenlosen Hut zu erhalten!";
	}

	protected override string _GetTemplateForResponseDialogConfirmEmailForFreeHatUnder13()
	{
		return "Denk daran, die E-Mail-Adresse deiner Eltern zu bestätigen, um den kostenlosen Hut zu erhalten!";
	}

	protected override string _GetTemplateForResponseDialogContactFriendFinderPhoneUpsell()
	{
		return "Bitte füge eine Handynummer zu deinem Konto hinzu, damit deine Freunde dich finden können!";
	}

	/// <summary>
	/// Key: "Response.Dialog.EnterCodeInstructions"
	/// Enter the code in the text sent to {phoneNumber}
	/// English String: "Enter the code in the text sent to {phoneNumber}"
	/// </summary>
	public override string ResponseDialogEnterCodeInstructions(string phoneNumber)
	{
		return $"Gib den Code aus der SMS ein, die wir an {phoneNumber} gesendet haben.";
	}

	protected override string _GetTemplateForResponseDialogEnterCodeInstructions()
	{
		return "Gib den Code aus der SMS ein, die wir an {phoneNumber} gesendet haben.";
	}

	protected override string _GetTemplateForResponseDialogFreeHatForAddingPhone()
	{
		return "Deine Handynummer wurde bestätigt. Viel Spaß mit deinem kostenlosen Hut!";
	}

	protected override string _GetTemplateForResponseDialogPhoneAdded()
	{
		return "Handynummer wurde erfolgreich hinzugefügt.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmail13AndOverSuccessMessage()
	{
		return "Der Verifizierungslink wurde an deine E-Mail-Adresse gesendet. Bitte verifiziere deine E-Mail-Adresse, um dein Konto zu sichern.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailOver13()
	{
		return "Bitte verifiziere deine E-Mail-Adresse, um sicherzustellen, dass du immer auf dein Roblox-Konto zugreifen kannst.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13()
	{
		return "Bitte verifiziere die E-Mail-Adresse deiner Eltern, um sicherzustellen, dass du immer auf dein Roblox-Konto zugreifen kannst.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailUnder13SuccessMessage()
	{
		return "Der Verifizierungslink wurde an die E-Mail-Adresse deiner Eltern gesendet. Bitte verifiziere die E-Mail-Adresse deiner Eltern, um dein Konto zu sichern.";
	}

	protected override string _GetTemplateForResponseDialogVerifyEmailInstructions()
	{
		return "Der Verifizierungslink wurde an deine E-Mail-Adresse gesendet. Bitte verifiziere deine E-Mail-Adresse, um dein Konto zu sichern. Du kannst dein Konto jederzeit bearbeiten, indem du zu Einstellungen > Kontodetails gehst.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}

	/// <summary>
	/// Key: "Response.IncorrectCodeLength"
	/// error message
	/// English String: "Code must be {number} digits"
	/// </summary>
	public override string ResponseIncorrectCodeLength(string number)
	{
		return $"Code muss aus {number} Ziffern bestehen.";
	}

	protected override string _GetTemplateForResponseIncorrectCodeLength()
	{
		return "Code muss aus {number} Ziffern bestehen.";
	}
}
