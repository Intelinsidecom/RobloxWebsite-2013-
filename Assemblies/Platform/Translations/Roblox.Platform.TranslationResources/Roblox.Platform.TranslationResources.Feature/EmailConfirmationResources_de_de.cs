namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides EmailConfirmationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EmailConfirmationResources_de_de : EmailConfirmationResources_en_us, IEmailConfirmationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Done"
	/// button label
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "Fertig";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button which takes user to item details page
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "Artikel ansehen";

	/// <summary>
	/// Key: "Heading.ThankYou"
	/// heading
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingThankYou => "Danke!";

	/// <summary>
	/// Key: "Message.EmailVerified"
	/// success message confirmation
	/// English String: "Your email has been verified"
	/// </summary>
	public override string MessageEmailVerified => "Deine E-Mail-Adresse wurde verifiziert.";

	/// <summary>
	/// Key: "Message.EmailVerifiedEnjoyFreeHat"
	/// success message confirmation notifying user they have verified their email and have received a free hat
	/// English String: "Your email has been verified. Enjoy the free hat!"
	/// </summary>
	public override string MessageEmailVerifiedEnjoyFreeHat => "Deine E-Mail-Adresse wurde bestätigt. Viel Spaß mit deinem kostenlosen Hut!";

	public EmailConfirmationResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDone()
	{
		return "Fertig";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "Artikel ansehen";
	}

	protected override string _GetTemplateForHeadingThankYou()
	{
		return "Danke!";
	}

	protected override string _GetTemplateForMessageEmailVerified()
	{
		return "Deine E-Mail-Adresse wurde verifiziert.";
	}

	protected override string _GetTemplateForMessageEmailVerifiedEnjoyFreeHat()
	{
		return "Deine E-Mail-Adresse wurde bestätigt. Viel Spaß mit deinem kostenlosen Hut!";
	}
}
