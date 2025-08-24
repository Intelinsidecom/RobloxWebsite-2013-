namespace Roblox.TextFilter.Properties;

internal interface ITextFilterSettings
{
	string ContentFilterApiKey { get; }

	bool IsTextFilterClientMetricsTrackingEnabled { get; }

	int LongTextSizeCutoff { get; }

	double BlockedContentProbabilityThreshold { get; }

	double UsernameGeneralProbabilityThreshold { get; }

	double UsernamePiiProbabilityThreshold { get; }

	bool ObjectNameValidationEnabled { get; }

	string ObjectNameValidationRegex { get; }
}
