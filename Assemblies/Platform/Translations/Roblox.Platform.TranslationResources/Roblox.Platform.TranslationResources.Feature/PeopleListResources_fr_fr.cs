namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PeopleListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PeopleListResources_fr_fr : PeopleListResources_en_us, IPeopleListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public override string ActionBuy => "Acheter et jouer";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "Rejoindre";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "Afficher les détails";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "Amis";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "Afficher tout";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "Voir le profil";

	public PeopleListResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Acheter et jouer";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "Rejoindre";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "Afficher les détails";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "Amis";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "Afficher tout";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"Discuter avec {username}";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "Discuter avec {username}";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "Voir le profil";
	}
}
