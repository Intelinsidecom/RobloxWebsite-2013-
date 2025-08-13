namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PeopleListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PeopleListResources_de_de : PeopleListResources_en_us, IPeopleListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public override string ActionBuy => "Zum Spielen kaufen";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "Beitreten";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "Infos anzeigen";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "Freunde";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "Alle ansehen";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "Profil ansehen";

	public PeopleListResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Zum Spielen kaufen";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "Beitreten";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "Infos anzeigen";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "Freunde";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "Alle ansehen";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"Chatte mit {username}";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "Chatte mit {username}";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "Profil ansehen";
	}
}
