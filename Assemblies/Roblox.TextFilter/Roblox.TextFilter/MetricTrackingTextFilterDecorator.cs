using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.TextFilter.Properties;

namespace Roblox.TextFilter;

/// <summary>
/// Decorates an <see cref="T:Roblox.TextFilter.ITextFilter" /> instance and records metrics about the results that it returns.
/// It passes through the results of the internal ITextFilter unaltered
/// </summary>
internal class MetricTrackingTextFilterDecorator : ITextFilter
{
	private readonly ITextFilter _TextFilter;

	private readonly ITextFilterMetricsTracker _MetricsTracker;

	private readonly Action<Exception> _ErrorHandler;

	private bool MetricsTrackingEnabled => Settings.Default.IsTextFilterClientMetricsTrackingEnabled;

	[ExcludeFromCodeCoverage]
	public MetricTrackingTextFilterDecorator(ITextFilter textFilter)
		: this(textFilter, new TextFilterMetricsTracker(), ExceptionHandler.LogException)
	{
	}

	internal MetricTrackingTextFilterDecorator(ITextFilter textFilter, ITextFilterMetricsTracker metricsTracker, Action<Exception> errorHandler)
	{
		_TextFilter = textFilter;
		_MetricsTracker = metricsTracker;
		_ErrorHandler = errorHandler;
	}

	public ITextFilterRuleResult FilterText(IModeratedTextRequest request)
	{
		return _TextFilter.FilterText(request);
	}

	public ITextFilterRuleResult FilterTextNoContext(IModeratedTextRequest request)
	{
		return _TextFilter.FilterTextNoContext(request);
	}

	public ITextFilterRuleResult FilterTextForRecipient(IModerateTextForRecipientRequest request)
	{
		ITextFilterRuleResult results = _TextFilter.FilterTextForRecipient(request);
		if (MetricsTrackingEnabled)
		{
			try
			{
				_MetricsTracker.RecordTextFilterResult(request, results, GetAudience(request.Author, request.Recipient));
			}
			catch (Exception exception)
			{
				_ErrorHandler(exception);
			}
		}
		return results;
	}

	public ITextFilterResults FilterLiveText(IModeratedTextRequest request)
	{
		ITextFilterResults results = _TextFilter.FilterLiveText(request);
		if (MetricsTrackingEnabled)
		{
			try
			{
				ITextAuthor author = request.Author;
				if (author != null && author.IsUnder13)
				{
					_MetricsTracker.RecordTextFilterResult(request, results.AgeUnder13Result, TextAudience.AuthorUnder13);
				}
				else
				{
					_MetricsTracker.RecordTextFilterResult(request, results.AgeUnder13Result, TextAudience.Author13AndOverToUnder13);
					_MetricsTracker.RecordTextFilterResult(request, results.Age13OrOverResult, TextAudience.Author13AndOverTo13AndOver);
				}
			}
			catch (Exception exception)
			{
				_ErrorHandler(exception);
			}
		}
		return results;
	}

	public IKeywordSearchQueryValidationResults ValidateKeywordSearchQuery(IKeywordSearchQueryValidationRequest request)
	{
		return _TextFilter.ValidateKeywordSearchQuery(request);
	}

	public IUsernameValidationResult ValidateUsername(IUsernameValidationRequest request)
	{
		return _TextFilter.ValidateUsername(request);
	}

	public IObjectNameValidationResult ValidateObjectName(IObjectNameValidationRequest request)
	{
		return _TextFilter.ValidateObjectName(request);
	}

	public ModerationLevel GetModerationLevelOfFilteredText(string originalText, string filteredText)
	{
		return _TextFilter.GetModerationLevelOfFilteredText(originalText, filteredText);
	}

	internal TextAudience GetAudience(ITextAuthor author, ITextRecipient recipient)
	{
		if (author == null || author.IsUnder13)
		{
			return TextAudience.AuthorUnder13;
		}
		if (recipient == null || recipient.IsUnder13)
		{
			return TextAudience.Author13AndOverToUnder13;
		}
		return TextAudience.Author13AndOverTo13AndOver;
	}
}
