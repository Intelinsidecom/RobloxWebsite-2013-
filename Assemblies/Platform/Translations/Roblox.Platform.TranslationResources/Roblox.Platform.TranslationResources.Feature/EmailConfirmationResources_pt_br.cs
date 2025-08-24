namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides EmailConfirmationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EmailConfirmationResources_pt_br : EmailConfirmationResources_en_us, IEmailConfirmationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Done"
	/// button label
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "Ok";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button which takes user to item details page
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "Ver item";

	/// <summary>
	/// Key: "Heading.ThankYou"
	/// heading
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingThankYou => "Obrigado!";

	/// <summary>
	/// Key: "Message.EmailVerified"
	/// success message confirmation
	/// English String: "Your email has been verified"
	/// </summary>
	public override string MessageEmailVerified => "Seu e-mail foi verificado";

	/// <summary>
	/// Key: "Message.EmailVerifiedEnjoyFreeHat"
	/// success message confirmation notifying user they have verified their email and have received a free hat
	/// English String: "Your email has been verified. Enjoy the free hat!"
	/// </summary>
	public override string MessageEmailVerifiedEnjoyFreeHat => "Seu e-mail foi verificado. Aproveite o chapéu grátis!";

	public EmailConfirmationResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDone()
	{
		return "Ok";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "Ver item";
	}

	protected override string _GetTemplateForHeadingThankYou()
	{
		return "Obrigado!";
	}

	protected override string _GetTemplateForMessageEmailVerified()
	{
		return "Seu e-mail foi verificado";
	}

	protected override string _GetTemplateForMessageEmailVerifiedEnjoyFreeHat()
	{
		return "Seu e-mail foi verificado. Aproveite o chapéu grátis!";
	}
}
