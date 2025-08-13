namespace Roblox.TextFilter;

/// <summary>
/// Provides an interface for filtering textual user content.
/// </summary>
public interface ITextFilter
{
	/// <summary>
	/// Filters the given request for the given user.
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.IModeratedTextRequest" /> for the text to filter.</param>
	/// <returns>
	/// An <see cref="T:Roblox.TextFilter.ITextFilterRuleResult" /> corresponding to the passed in <paramref request="request" />.
	/// </returns>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException">Filtering is unavailable for some reason.</exception>
	ITextFilterRuleResult FilterText(IModeratedTextRequest request);

	/// <summary>
	/// Filters the given request for the given user.
	/// Does not update the UserContext meaning that it will not respect vertical filtering.
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.IModeratedTextRequest" /> for the text to filter.</param>
	/// <returns>
	/// An <see cref="T:Roblox.TextFilter.ITextFilterRuleResult" /> corresponding to the passed in <paramref request="request" />.
	/// </returns>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException">Filtering is unavailable for some reason.</exception>
	ITextFilterRuleResult FilterTextNoContext(IModeratedTextRequest request);

	/// <summary>
	/// Filter the given request by the given author targeted at the given recipient.
	/// An empty Author or Recipient will be treated either as a U13.
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.IModerateTextForRecipientRequest" /> containing the text, author and recipient.</param>
	/// <returns>
	/// The <see cref="T:Roblox.TextFilter.ITextFilterRuleResult" /> corresponding to the passed in <paramref request="request" />.
	/// </returns>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException">Filtering is unavailable for some reason.</exception>
	ITextFilterRuleResult FilterTextForRecipient(IModerateTextForRecipientRequest request);

	/// <summary>
	/// Filters request for live game chat (and eventually for all 'live' request exchanges).
	///
	/// It passes the given request through multiple filters and returns the results for each filter, the idea being that the
	/// caller can choose which filtered request to show the viewer based on the viewers age or other factors. This is a
	/// departure from all other request moderation we perform in which the request is filtered exclusively based on the status 
	/// of the request creator.
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
	/// <param name="request">A <see cref="T:Roblox.TextFilter.IModeratedTextRequest" /> for the text to filter.</param>
	/// <returns>
	/// The <see cref="T:Roblox.TextFilter.ITextFilterResults" />.
	/// </returns>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException"></exception>
	ITextFilterResults FilterLiveText(IModeratedTextRequest request);

	/// <summary>
	/// Validates the given search keyword for U13 and 13+.
	/// </summary>
	/// <param name="request">A <see cref="T:Roblox.TextFilter.IKeywordSearchQueryValidationRequest" /> containing the Keyword.</param>
	/// <returns>
	/// The <see cref="T:Roblox.TextFilter.IKeywordSearchQueryValidationResults" />.
	/// </returns>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException"></exception>
	IKeywordSearchQueryValidationResults ValidateKeywordSearchQuery(IKeywordSearchQueryValidationRequest request);

	/// <summary>
	/// Validates the given text is allowed to be a username.
	/// </summary>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException"></exception>
	IUsernameValidationResult ValidateUsername(IUsernameValidationRequest request);

	/// <summary>
	/// Validate the given text is allowed to be an Object Name.
	/// </summary>
	/// <exception cref="T:Roblox.TextFilter.TextFilterOperationUnavailableException"></exception>
	IObjectNameValidationResult ValidateObjectName(IObjectNameValidationRequest request);

	/// <summary>
	/// Returns the <see cref="T:Roblox.TextFilter.ModerationLevel" /> based on the given Original Text and Filtered Text.
	/// </summary>
	/// <param name="originalText">Original Text that was sent to be filtered</param>
	/// <param name="filteredText">Text that has been filtered for comparison</param>
	/// <returns></returns>
	ModerationLevel GetModerationLevelOfFilteredText(string originalText, string filteredText);
}
