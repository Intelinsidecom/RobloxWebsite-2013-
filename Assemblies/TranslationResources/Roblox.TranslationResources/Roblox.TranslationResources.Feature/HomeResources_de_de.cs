namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_de_de : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "Zurück zum Seitenanfang";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "Mehr erfahren";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Alle ansehen";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "Mehr ansehen";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "Teilen";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "Was machst du so?";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "Blog-Neuigkeiten";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "Freundesaktivität";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "Freunde";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "Meine Favoriten";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "Mein Feed";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "Zuletzt gespielt";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "Wo ist „Mein Feed“? Sieh im Seitenmenü nach!";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "Ankündigung";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "Erstelle Spiele, verdiene Geld";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "Wird geteilt\u00a0...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "Statusaktualisierung fehlgeschlagen.";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "Aktualisierung darf nicht leer sein. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "Bitte melde dich bei deinem Konto an.";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "Problem mit dem System. Bitte versuche es später erneut und kontaktiere den Support bei weiteren Problemen.";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "Zu viele Aktualisierungen. Bitte versuche es später erneut.";

	public HomeResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "Zurück zum Seitenanfang";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "Mehr erfahren";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Alle ansehen";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "Mehr ansehen";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "Teilen";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "Was machst du so?";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "Blog-Neuigkeiten";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "Freundesaktivität";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"Freunde ({friendCount})";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "Freunde ({friendCount})";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "Freunde";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "Meine Favoriten";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "Mein Feed";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "Zuletzt gespielt";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "Wo ist „Mein Feed“? Sieh im Seitenmenü nach!";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "Ankündigung";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "Erstelle Spiele, verdiene Geld";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"Hallo {username}!";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "Hallo {username}!";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "Wird geteilt\u00a0...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "Statusaktualisierung fehlgeschlagen.";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "Aktualisierung darf nicht leer sein. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "Bitte melde dich bei deinem Konto an.";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "Problem mit dem System. Bitte versuche es später erneut und kontaktiere den Support bei weiteren Problemen.";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "Zu viele Aktualisierungen. Bitte versuche es später erneut.";
	}
}
