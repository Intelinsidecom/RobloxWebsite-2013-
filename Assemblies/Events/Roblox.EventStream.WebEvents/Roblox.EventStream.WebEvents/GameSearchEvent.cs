using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class GameSearchEvent : WebEventBase
{
	private const string _Name = "gameSearch";

	private const string _SuggestionCorrection = "suggestionCorrection";

	private const string _SuggestionKwd = "suggestionKwd";

	private const string _SuggestionReplacedKwd = "suggestionReplacedKwd";

	private const string _SuggestionAlgorithm = "suggestionAlgorithm";

	private const string _IllegalKeyword = "illegalKwd";

	private const string _AlgorithmQueryType = "algorithmQueryType";

	private const string _FeaturedSearch = "featuredPlaceId";

	/// <summary>
	/// The event that represents a game search.
	/// </summary>
	public GameSearchEvent(EventStreamer streamer, GameSearchEventArgs eventArgs)
		: base(streamer, "gameSearch", eventArgs)
	{
		if (string.IsNullOrWhiteSpace(eventArgs.Keyword))
		{
			throw new ArgumentException("eventArgs.Keyword is required");
		}
		AddEventArg("kwd", eventArgs.Keyword);
		if (eventArgs.AssetsReturned != null)
		{
			AddEventArg("assetsReturned", eventArgs.AssetsReturned);
		}
		AddEventArg("page", eventArgs.Page.ToString());
		AddEventArg("algorithm", eventArgs.AlgorithmName);
		if (!string.IsNullOrEmpty(eventArgs.SuggestionCorrection))
		{
			AddEventArg("suggestionCorrection", eventArgs.SuggestionCorrection);
		}
		if (!string.IsNullOrEmpty(eventArgs.SuggestionKeyword))
		{
			AddEventArg("suggestionKwd", eventArgs.SuggestionKeyword);
		}
		if (!string.IsNullOrEmpty(eventArgs.SuggestionReplacedKwd))
		{
			AddEventArg("suggestionReplacedKwd", eventArgs.SuggestionReplacedKwd);
		}
		if (!string.IsNullOrEmpty(eventArgs.SuggestionAlgorithm))
		{
			AddEventArg("suggestionAlgorithm", eventArgs.SuggestionAlgorithm);
		}
		if (!string.IsNullOrEmpty(eventArgs.IllegalKeyword))
		{
			AddEventArg("illegalKwd", eventArgs.IllegalKeyword);
		}
		if (!string.IsNullOrEmpty(eventArgs.AlgorithmQueryType))
		{
			AddEventArg("algorithmQueryType", eventArgs.AlgorithmQueryType);
		}
		if (eventArgs.FeaturedPlaceId.HasValue)
		{
			AddEventArg("featuredPlaceId", eventArgs.FeaturedPlaceId.ToString());
		}
	}
}
