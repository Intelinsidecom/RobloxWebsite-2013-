namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PeopleListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PeopleListResources_pt_br : PeopleListResources_en_us, IPeopleListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public override string ActionBuy => "Comprar para jogar";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "Entrar";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "Ver detalhes";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "Amigos";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "Ver todos";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "Ver perfil";

	public PeopleListResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Comprar para jogar";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "Entrar";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "Ver detalhes";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "Amigos";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "Ver todos";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"Chat com {username}";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "Chat com {username}";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "Ver perfil";
	}
}
