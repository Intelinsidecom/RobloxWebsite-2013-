using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Roblox.CommunitySift;
using Roblox.ContentFilterApi.Client;
using Roblox.TextFilter.Properties;

namespace Roblox.TextFilter;

/// <summary>
/// Represents an <see cref="T:Roblox.TextFilter.ITextFilter" /> that performs basic text filtering.
/// </summary>
internal class BasicTextFilter : ITextFilter
{
	private const char _ModerationCharacter = '#';

	/// <summary>
	/// Settings for the library.
	/// </summary>
	private readonly ITextFilterSettings _Settings;

	/// <summary>
	/// Client to communicate with CommunitySift
	/// </summary>
	private readonly ICommunitySiftClient _CommunitySiftClient;

	/// <summary>
	/// Client to communicate with Roblox's ContentFilter
	/// </summary>
	private readonly IContentFilterClient _ContentFilterClient;

	/// <summary>
	/// A textfilter to handle username filter requests
	/// </summary>
	private readonly IUsernameFilter _UsernameFilter;

	internal const byte _AbuseTypeBlockedContentCategoryId = 20;

	private static readonly byte[] _AbuseTypeCategoryIds = new byte[8] { 2, 3, 4, 5, 6, 7, 8, 9 };

	private int LongTextSizeCutoff => _Settings.LongTextSizeCutoff;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.TextFilter.BasicTextFilter" /> class.
	/// This is the constructor that we should use going forward.
	/// </summary>
	/// <param name="settings"></param>
	/// <param name="communitySiftClient">Client to communicate with CommunitySift</param>
	/// <param name="contentFilterClient">ContentFilter Client for our internal redaction.</param>
	/// <param name="usernameFilter">Filter for username filter requests</param>
	public BasicTextFilter(ITextFilterSettings settings, ICommunitySiftClient communitySiftClient, IContentFilterClient contentFilterClient, IUsernameFilter usernameFilter)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_CommunitySiftClient = communitySiftClient ?? throw new ArgumentNullException("communitySiftClient");
		_ContentFilterClient = contentFilterClient ?? throw new ArgumentNullException("contentFilterClient");
		_UsernameFilter = usernameFilter ?? throw new ArgumentNullException("usernameFilter");
	}

	/// <summary>
	/// Filters the given text for the given user.
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.ModeratedTextRequest" /> for the text to filter.</param>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException"></exception>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	/// <returns>The <see cref="T:Roblox.TextFilter.ITextFilterRuleResult" /> for the <paramref name="request" />.</returns>
	public ITextFilterRuleResult FilterText(IModeratedTextRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return EmptyAcceptableRuleResult();
		}
		Task<string> blockedContentTask = new Task<string>(() => EvaluateBlockedContentForRequest(request));
		Task<string> commSiftTask = new Task<string>(() => FilterShortOrLongText(request));
		try
		{
			blockedContentTask.Start();
			commSiftTask.Start();
			Task.WaitAll(blockedContentTask, commSiftTask);
		}
		catch (AggregateException ex)
		{
			ex.Handle(delegate(Exception e)
			{
				if (e.GetType() == typeof(CommunitySiftException))
				{
					throw new TextFilterOperationUnavailableException("Failed to connect to CommunitySift", e);
				}
				if (e.GetType() == typeof(TextFilterOperationUnavailableException))
				{
					throw e;
				}
				return false;
			});
		}
		return EvaluateBlockedContentResult(request, blockedContentTask.Result) ?? new TextFilterRuleResult
		{
			FilteredText = commSiftTask.Result,
			ModerationLevel = GetModerationLevelOfFilteredText(request.Text, commSiftTask.Result),
			TriggeredModerationCategories = new HashSet<ModerationCategory>()
		};
	}

	/// <summary>
	/// Filters the given text for the given user.
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.ModeratedTextRequest" /> for the text to filter.</param>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException"></exception>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	/// <returns>The <see cref="T:Roblox.TextFilter.ITextFilterRuleResult" /> for the <paramref name="request" />.</returns>
	public ITextFilterRuleResult FilterTextNoContext(IModeratedTextRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return EmptyAcceptableRuleResult();
		}
		Task<string> blockedContentTask = new Task<string>(() => EvaluateBlockedContentForRequest(request));
		Task<string> commSiftTask = new Task<string>(() => FilterShortOrLongTextNoContext(request));
		try
		{
			blockedContentTask.Start();
			commSiftTask.Start();
			Task.WaitAll(blockedContentTask, commSiftTask);
		}
		catch (AggregateException ex)
		{
			ex.Handle(delegate(Exception e)
			{
				if (e.GetType() == typeof(CommunitySiftException))
				{
					throw new TextFilterOperationUnavailableException("Failed to connect to CommunitySift", e);
				}
				if (e.GetType() == typeof(TextFilterOperationUnavailableException))
				{
					throw e;
				}
				return false;
			});
		}
		return EvaluateBlockedContentResult(request, blockedContentTask.Result) ?? new TextFilterRuleResult
		{
			FilteredText = commSiftTask.Result,
			ModerationLevel = GetModerationLevelOfFilteredText(request.Text, commSiftTask.Result),
			TriggeredModerationCategories = new HashSet<ModerationCategory>()
		};
	}

	/// <summary>
	/// Filter the given request by the given author targeted at the given recipient.
	/// An empty Author or Recipient will be treated either as a U13.
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.IModerateTextForRecipientRequest" /> containing the text, author and recipient.</param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException">Filtering is unavailable for some reason.</exception>
	public ITextFilterRuleResult FilterTextForRecipient(IModerateTextForRecipientRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return EmptyAcceptableRuleResult();
		}
		bool treatAsU13 = !IsRequestFrom13OTo13O(request);
		if (treatAsU13 == request.Author?.IsUnder13)
		{
			return FilterText(request);
		}
		ITextAuthor user;
		if (request.Author == null)
		{
			ITextAuthor textAuthor = new UnknownTextAuthor();
			user = textAuthor;
		}
		else
		{
			ITextAuthor textAuthor = new TextAuthor(request.Author.Id, request.Author.Name, treatAsU13);
			user = textAuthor;
		}
		ModeratedTextRequest newRequest = new ModeratedTextRequest(user, request.Text, request.Server, request.Room, request.Client, request.TrackDetailedClientStatistics);
		return FilterText(newRequest);
	}

	/// <summary>
	/// Filters text for live game chat (and eventually for all 'live' text exchanges).
	///
	/// It passes the given text through multiple filters and returns the results for each filter, the idea being that the
	/// caller can choose which filtered text to show the viewer based on the viewers age or other factors. This is a
	/// departure from all other text moderation we perform in which the text is filtered exclusively based on the status 
	/// of the text creator.
	///
	/// This supplants logic that used to exist only in the Api.Proxy ModerationController.
	///
	/// Currently the filters used are thus:
	///
	/// With CommunitySift enabled:
	///     Age13OrOver: Rule set defined by CommunitySift.Properties.Settings.Default.CommunitySiftTextFiltering13AndOverRule
	///     AgeUnder13: Rule set defined by CommunitySift.Properties.Settings.Default.CommunitySiftTextFilteringUnder13Rule
	///
	/// With CommunitySift disabled:
	///     Age13OrOver: blacklist
	///     AgeUnder13: white list
	///
	/// The returned class takes the form of
	/// {
	///     "success": true,
	///     "message": "",
	///     "data": 
	///     {
	///         "AgeUnder13":"##############################",
	///         "Age13OrOver":"Do you have a twitter account?"
	///     }
	/// }
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.ModeratedTextRequest" /> for the text to filter.</param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	/// <returns><seealso cref="T:Roblox.TextFilter.TextFilterResults" /></returns>
	public ITextFilterResults FilterLiveText(IModeratedTextRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return EmptyTextFilterResults();
		}
		Task<string> blockedContentTask = new Task<string>(() => EvaluateBlockedContentForRequest(request));
		Task<TextFilterResults> commSiftTask = new Task<TextFilterResults>(() => FilterLiveTextSingleCall(request));
		try
		{
			blockedContentTask.Start();
			commSiftTask.Start();
			Task.WaitAll(blockedContentTask, commSiftTask);
		}
		catch (AggregateException ex)
		{
			ex.Handle(delegate(Exception e)
			{
				if (e.GetType() == typeof(CommunitySiftException))
				{
					throw new TextFilterOperationUnavailableException("Failed to connect to CommunitySift", e);
				}
				if (e.GetType() == typeof(TextFilterOperationUnavailableException))
				{
					throw e;
				}
				return false;
			});
		}
		ITextFilterRuleResult blockedContent = EvaluateBlockedContentResult(request, blockedContentTask.Result);
		if (blockedContent != null)
		{
			return new TextFilterResults
			{
				Success = true,
				Message = "",
				Age13OrOverResult = blockedContent,
				AgeUnder13Result = blockedContent
			};
		}
		return commSiftTask.Result;
	}

	/// <summary>
	/// Validates the keyword for the search query against the filtering rules.
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.IKeywordSearchQueryValidationRequest" /> containing the keyword.</param>
	/// <returns>
	/// The <see cref="T:Roblox.TextFilter.IKeywordSearchQueryValidationResults" />.
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">request</exception>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException">Failed to connect to CommunitySift</exception>
	public IKeywordSearchQueryValidationResults ValidateKeywordSearchQuery(IKeywordSearchQueryValidationRequest request)
	{
		try
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			if (!string.IsNullOrWhiteSpace(request.Keyword))
			{
				ITextAuthor author = request.Author;
				if (author != null)
				{
					_ = author.Id;
					if (0 == 0)
					{
						CommunitySiftUserNameRequest communitySiftRequest = new CommunitySiftUserNameRequest(request.Keyword, request.Author.Id.ToString(), request.Author?.IsUnder13 ?? true);
						ICommunitySiftUserNameFilterResult communitySiftResponse = _CommunitySiftClient.PostUserName(communitySiftRequest);
						return new KeywordSearchQueryValidationResults(!communitySiftResponse.IsPrimaryTextFiltered, !communitySiftResponse.IsSecondaryTextFiltered);
					}
				}
			}
			return new KeywordSearchQueryValidationResults(isValid13Over: false, isValidUnder13: false);
		}
		catch (CommunitySiftException ex)
		{
			throw new TextFilterOperationUnavailableException("Failed to connect to CommunitySift", ex);
		}
	}

	/// <inheritdoc cref="!:ITextFilter.ValidateUserName" />
	public IUsernameValidationResult ValidateUsername(IUsernameValidationRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (!request.IsUnder13)
		{
			return _UsernameFilter.Evaluate13OUsername(request.RequestedName);
		}
		return _UsernameFilter.EvaluateU13Username(request.RequestedName);
	}

	/// <inheritdoc cref="M:Roblox.TextFilter.ITextFilter.ValidateObjectName(Roblox.TextFilter.IObjectNameValidationRequest)" />
	public IObjectNameValidationResult ValidateObjectName(IObjectNameValidationRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (!_Settings.ObjectNameValidationEnabled)
		{
			return new ObjectNameValidationResult(isValid: true);
		}
		if (!string.IsNullOrEmpty(_Settings.ObjectNameValidationRegex) && new Regex(_Settings.ObjectNameValidationRegex, RegexOptions.IgnoreCase).IsMatch(request.RequestedName))
		{
			return new ObjectNameValidationResult(isValid: false);
		}
		return new ObjectNameValidationResult(isValid: true);
	}

	private string EvaluateBlockedContentForRequest(IModeratedTextRequest request)
	{
		Evaluation[] categories;
		try
		{
			categories = _ContentFilterClient.GetEvaluationSet(request.Text, new byte[1] { 20 });
		}
		catch (Exception e)
		{
			throw new TextFilterOperationUnavailableException(string.Format("{0} threw exception", "GetEvaluationSet"), e);
		}
		if (categories.Any((Evaluation x) => x.Probability >= _Settings.BlockedContentProbabilityThreshold))
		{
			return new Regex("[^\\s]", RegexOptions.IgnoreCase | RegexOptions.Compiled).Replace(request.Text, '#'.ToString());
		}
		return request.Text;
	}

	private string FilterShortOrLongText(IModeratedTextRequest request)
	{
		long userId = request?.Author?.Id ?? 0;
		string userName = request?.Author?.Name ?? "";
		bool userUnder13 = request?.Author?.IsUnder13 ?? true;
		if (request.Text.Length >= LongTextSizeCutoff)
		{
			ICommunitySiftLongTextFilterResult result2 = _CommunitySiftClient.PostLongText(new CommunitySiftLongTextRequest(userId, userName, userUnder13, request.Text, request.Server, request.Room));
			if (!result2.TextWasFiltered)
			{
				return request.Text;
			}
			return result2.FilteredText;
		}
		ICommunitySiftChatFilterResult result = _CommunitySiftClient.PostChat(new CommunitySiftChatRequest(userId, userName, userUnder13, request.Text, request.Server, request.Room));
		if (!result.TextWasFiltered)
		{
			return request.Text;
		}
		return result.FilteredText;
	}

	private string FilterShortOrLongTextNoContext(IModeratedTextRequest request)
	{
		long userId = request?.Author?.Id ?? 0;
		string userName = request?.Author?.Name ?? "";
		bool userUnder13 = request?.Author?.IsUnder13 ?? true;
		if (request.Text.Length >= LongTextSizeCutoff)
		{
			ICommunitySiftLongTextFilterResult result2 = _CommunitySiftClient.PostLongText(new CommunitySiftLongTextRequest(userId, userName, userUnder13, request.Text, request.Server, request.Room));
			if (!result2.TextWasFiltered)
			{
				return request.Text;
			}
			return result2.FilteredText;
		}
		ICommunitySiftChatFilterNoContextResult result = _CommunitySiftClient.PostChatNoContext(new CommunitySiftChatNoContextRequest(userId, userName, userUnder13, request.Text, request.Server, request.Room));
		if (!result.TextWasFiltered)
		{
			return request.Text;
		}
		return result.FilteredText;
	}

	private ITextFilterRuleResult EvaluateBlockedContentResult(IModeratedTextRequest request, string blockedContentTaskResult)
	{
		if (blockedContentTaskResult != null)
		{
			ModerationLevel moderationLevel = GetModerationLevelOfFilteredText(request.Text, blockedContentTaskResult);
			if (moderationLevel == ModerationLevel.FullyModerated)
			{
				return new TextFilterRuleResult
				{
					FilteredText = blockedContentTaskResult,
					ModerationLevel = moderationLevel,
					TriggeredModerationCategories = new HashSet<ModerationCategory> { ModerationCategory.BlockedContent }
				};
			}
		}
		return null;
	}

	private static bool IsRequestFrom13OTo13O(IModerateTextForRecipientRequest request)
	{
		ITextAuthor author = request.Author;
		bool num = author != null && !author.IsUnder13;
		ITextRecipient recipient = request.Recipient;
		bool isRecipientOver13 = recipient != null && !recipient.IsUnder13;
		return num && isRecipientOver13;
	}

	private ITextFilterResults EmptyTextFilterResults()
	{
		return new TextFilterResults
		{
			Success = true,
			Message = string.Empty,
			Age13OrOverResult = EmptyAcceptableRuleResult(),
			AgeUnder13Result = EmptyAcceptableRuleResult()
		};
	}

	private TextFilterResults FilterLiveTextSingleCall(IModeratedTextRequest request)
	{
		long userId = request.Author?.Id ?? 0;
		string userName = request.Author?.Name ?? "";
		CommunitySiftDoubleChatRequest communitySiftRequest = new CommunitySiftDoubleChatRequest(userId, userName, request.Text, request.Server, request.Room);
		ICommunitySiftDoubleChatFilterResult communitySiftResult = _CommunitySiftClient.PostDoubleChat(communitySiftRequest);
		string age13OrOverText = (communitySiftResult.PrimaryTextWasFiltered ? communitySiftResult.PrimaryFilteredText : request.Text);
		string ageUnder13Text = (communitySiftResult.SecondaryTextWasFiltered ? communitySiftResult.SecondaryFilteredText : request.Text);
		HashSet<ModerationCategory> age13OrOverFilterCategories = CommunitySiftTopicTranslator.TranslateInfringingCategories(communitySiftResult.PrimaryFilteredCategories);
		HashSet<ModerationCategory> ageUnder13FilterCategories = CommunitySiftTopicTranslator.TranslateInfringingCategories(communitySiftResult.SecondaryFilteredCategories);
		return new TextFilterResults
		{
			Success = true,
			Message = "",
			Age13OrOverResult = new TextFilterRuleResult
			{
				ModerationLevel = GetModerationLevelOfFilteredText(request.Text, age13OrOverText),
				FilteredText = age13OrOverText,
				TriggeredModerationCategories = age13OrOverFilterCategories
			},
			AgeUnder13Result = new TextFilterRuleResult
			{
				ModerationLevel = GetModerationLevelOfFilteredText(request.Text, ageUnder13Text),
				FilteredText = ageUnder13Text,
				TriggeredModerationCategories = ageUnder13FilterCategories
			}
		};
	}

	public ModerationLevel GetModerationLevelOfFilteredText(string originalText, string filteredText)
	{
		if (originalText != filteredText && filteredText.Count((char x) => x == '#' || char.IsWhiteSpace(x)) == filteredText.Length)
		{
			return ModerationLevel.FullyModerated;
		}
		if (filteredText.Count((char c) => c == '#') > originalText.Count((char c) => c == '#'))
		{
			return ModerationLevel.PartiallyModerated;
		}
		return ModerationLevel.FullyAcceptable;
	}

	private ITextFilterRuleResult EmptyAcceptableRuleResult()
	{
		return new TextFilterRuleResult
		{
			FilteredText = string.Empty,
			ModerationLevel = ModerationLevel.FullyAcceptable,
			TriggeredModerationCategories = new HashSet<ModerationCategory>()
		};
	}
}
