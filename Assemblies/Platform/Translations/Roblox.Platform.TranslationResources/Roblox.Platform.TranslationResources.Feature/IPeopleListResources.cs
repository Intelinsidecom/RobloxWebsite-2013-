namespace Roblox.TranslationResources.Feature;

public interface IPeopleListResources : ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	string ActionBuy { get; }

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	string ActionJoin { get; }

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	string ActionViewDetails { get; }

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	string HeadingFriends { get; }

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	string HeadingSeeAll { get; }

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	string LabelViewProfile { get; }

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	string LabelChat(string username);
}
