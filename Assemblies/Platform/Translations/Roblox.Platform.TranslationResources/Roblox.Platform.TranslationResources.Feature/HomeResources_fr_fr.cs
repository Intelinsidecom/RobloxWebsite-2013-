namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_fr_fr : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "Retour en haut";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "En savoir plus";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Afficher tout";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "Afficher plus";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "Partager";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "Qu'avez-vous en tÃªte\u00a0?";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "ActualitÃ©s du blog";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "ActivitÃ© de vos amis";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "Amis";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "Mes favoris";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "Mes actus";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "JouÃ©s rÃ©cemment";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "Vous cherchez les actus\u00a0? Elles sont dÃ©sormais dans le menu latÃ©ral.";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "Annonce";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "CrÃ©ez des jeux et gagnez de l'argent";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "Partage...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "Ã‰chec de publication du statut.";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "Le statut ne peut pas Ãªtre vide. Veuillez rÃ©essayer.";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "Connecte-toi.";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "ProblÃ¨me systÃ¨me. Veuillez rÃ©essayer plus tard, puis contactez l'assistance.";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "Trop de publications. Veuillez rÃ©essayer plus tard.";

	public HomeResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "Retour en haut";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "En savoir plus";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Afficher tout";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "Afficher plus";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "Partager";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "Qu'avez-vous en tÃªte\u00a0?";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "ActualitÃ©s du blog";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "ActivitÃ© de vos amis";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"Amis ({friendCount})";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "Amis ({friendCount})";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "Amis";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "Mes favoris";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "Mes actus";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "JouÃ©s rÃ©cemment";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "Vous cherchez les actus\u00a0? Elles sont dÃ©sormais dans le menu latÃ©ral.";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "Annonce";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "CrÃ©ez des jeux et gagnez de l'argent";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"Bonjour, {username}\u00a0!";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "Bonjour, {username}\u00a0!";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "Partage...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "Ã‰chec de publication du statut.";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "Le statut ne peut pas Ãªtre vide. Veuillez rÃ©essayer.";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "Connecte-toi.";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "ProblÃ¨me systÃ¨me. Veuillez rÃ©essayer plus tard, puis contactez l'assistance.";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "Trop de publications. Veuillez rÃ©essayer plus tard.";
	}
}


}
