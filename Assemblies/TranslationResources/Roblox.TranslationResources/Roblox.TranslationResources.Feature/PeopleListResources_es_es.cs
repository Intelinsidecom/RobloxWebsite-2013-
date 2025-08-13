namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PeopleListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PeopleListResources_es_es : PeopleListResources_en_us, IPeopleListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public override string ActionBuy => "Comprar para jugar";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "Unirse";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "Ver detalles";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "Amigos";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "Ver todo";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "Ver perfil";

	public PeopleListResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Comprar para jugar";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "Unirse";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "Ver detalles";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "Amigos";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "Ver todo";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"Chatea con {username}";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "Chatea con {username}";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "Ver perfil";
	}
}
