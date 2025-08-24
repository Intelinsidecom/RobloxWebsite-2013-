using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class TranslationAnalyticsResources_en_us : TranslationResourcesBase, ITranslationAnalyticsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public virtual string ActionDownload => "Download";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public virtual string ActionRequest => "Request";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public virtual string DescriptionReportHint => "Please note: Once requested, downloads may take a few minutes to prepare.";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public virtual string HeadingTranslationAnalytics => "Translator Contribution Report";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public virtual string LabelPending => "Pending";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public virtual string LabelSelectDates => "Select Date Range";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public virtual string MessageGenericError => "There was a problem with your request. Please try again later.";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public virtual string MessagePermissionError => "You do not have sufficient permission to download this report.";

	public TranslationAnalyticsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Download",
				_GetTemplateForActionDownload()
			},
			{
				"Action.Request",
				_GetTemplateForActionRequest()
			},
			{
				"Description.ReportHint",
				_GetTemplateForDescriptionReportHint()
			},
			{
				"Heading.TranslationAnalytics",
				_GetTemplateForHeadingTranslationAnalytics()
			},
			{
				"Label.Pending",
				_GetTemplateForLabelPending()
			},
			{
				"Label.SelectDates",
				_GetTemplateForLabelSelectDates()
			},
			{
				"Message.GenericError",
				_GetTemplateForMessageGenericError()
			},
			{
				"Message.PermissionError",
				_GetTemplateForMessagePermissionError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.TranslationAnalytics";
	}

	protected virtual string _GetTemplateForActionDownload()
	{
		return "Download";
	}

	protected virtual string _GetTemplateForActionRequest()
	{
		return "Request";
	}

	protected virtual string _GetTemplateForDescriptionReportHint()
	{
		return "Please note: Once requested, downloads may take a few minutes to prepare.";
	}

	protected virtual string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "Translator Contribution Report";
	}

	protected virtual string _GetTemplateForLabelPending()
	{
		return "Pending";
	}

	protected virtual string _GetTemplateForLabelSelectDates()
	{
		return "Select Date Range";
	}

	protected virtual string _GetTemplateForMessageGenericError()
	{
		return "There was a problem with your request. Please try again later.";
	}

	protected virtual string _GetTemplateForMessagePermissionError()
	{
		return "You do not have sufficient permission to download this report.";
	}
}
