namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_de_de : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "Du kannst deinen Code nicht finden?";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Schließen";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "Weiter zum Video";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "Hast du einen Werbe-Code? Klicke hier";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "So funktioniert das Einlösen";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Anmelden";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Einlösen";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "Weiteren Artikel einlösen";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "Registrieren";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "Artikel ansehen";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "Du verlässt jetzt Roblox, um dir ein Video auf YouTube anzusehen. YouTube gehört nicht zu Roblox.com und unterliegt seiner eigenen Datenschutzrichtlinie.";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "Erfolgreich eingelöst";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "Virtuellen Roblox-Artikel einlösen";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "Du verlässt jetzt Roblox.";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "Spielzeugcode eingeben";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "Ungültiger Code. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "Du musst bei deinem Roblox-Konto angemeldet sein, um den Code für deinen virtuellen Artikel einlösen zu können!";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "Du hast deinen Artikel eingelöst.";

	public RedeemToyResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "Du kannst deinen Code nicht finden?";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "Weiter zum Video";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "Hast du einen Werbe-Code? Klicke hier";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "So funktioniert das Einlösen";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Einlösen";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "Weiteren Artikel einlösen";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Registrieren";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "Artikel ansehen";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"Du hast {spanTagStart}{itemName}{spanTagEnd} ({itemType}) von {creatorName} eingelöst.";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "Du hast {spanTagStart}{itemName}{spanTagEnd} ({itemType}) von {creatorName} eingelöst.";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "Du verlässt jetzt Roblox, um dir ein Video auf YouTube anzusehen. YouTube gehört nicht zu Roblox.com und unterliegt seiner eigenen Datenschutzrichtlinie.";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "Erfolgreich eingelöst";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Virtuellen Roblox-Artikel einlösen";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "Du verlässt jetzt Roblox.";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "Spielzeugcode eingeben";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "Ungültiger Code. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "Du musst bei deinem Roblox-Konto angemeldet sein, um den Code für deinen virtuellen Artikel einlösen zu können!";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "Du hast deinen Artikel eingelöst.";
	}
}
