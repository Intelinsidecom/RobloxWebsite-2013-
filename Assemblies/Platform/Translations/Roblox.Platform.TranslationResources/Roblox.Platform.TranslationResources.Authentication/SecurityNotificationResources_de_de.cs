namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SecurityNotificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SecurityNotificationResources_de_de : SecurityNotificationResources_en_us, ISecurityNotificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Important"
	/// English String: "Important"
	/// </summary>
	public override string HeadingImportant => "Wichtig";

	public SecurityNotificationResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationText"
	/// English String: "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}."
	/// </summary>
	public override string DescriptionSecurityNotificationText(string aTagStartWithHref, string emailMailToLink, string hrefEnd, string emailText, string aTagEnd)
	{
		return $"Aus Sicherheitsgründen wurde dein Roblox-Passwort zurückgesetzt. Um wieder auf dein Konto zuzugreifen, gib bitte deine E-Mail-Adresse oder Telefonnummer ein und klicke auf die Schaltfläche „Senden“ auf dieser Seite. Wenn deinem Konto keine E-Mail-Adresse oder Telefonnummer zugeordnet ist, wende dich an den Roblox-Kundendienst unter {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}.";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationText()
	{
		return "Aus Sicherheitsgründen wurde dein Roblox-Passwort zurückgesetzt. Um wieder auf dein Konto zuzugreifen, gib bitte deine E-Mail-Adresse oder Telefonnummer ein und klicke auf die Schaltfläche „Senden“ auf dieser Seite. Wenn deinem Konto keine E-Mail-Adresse oder Telefonnummer zugeordnet ist, wende dich an den Roblox-Kundendienst unter {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}.";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationTextWarning"
	/// English String: "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised."
	/// </summary>
	public override string DescriptionSecurityNotificationTextWarning(string startSpan, string endSpan)
	{
		return $"Bitte wählen Sie ein Passwort, das {startSpan}brandneu{endSpan} und für Roblox {startSpan}einzigartig{endSpan} ist. Verwende dieses Passwort nicht auf anderen Websites. Dies ist der beste Weg, um zu verhindern, dass dein Roblox-Konto gefährdet wird.";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationTextWarning()
	{
		return "Bitte wählen Sie ein Passwort, das {startSpan}brandneu{endSpan} und für Roblox {startSpan}einzigartig{endSpan} ist. Verwende dieses Passwort nicht auf anderen Websites. Dies ist der beste Weg, um zu verhindern, dass dein Roblox-Konto gefährdet wird.";
	}

	protected override string _GetTemplateForHeadingImportant()
	{
		return "Wichtig";
	}
}
