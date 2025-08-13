namespace Roblox.Instrumentation.PrometheusListener;

internal class PrometheusConstants
{
	public const string AverageValue = "generic_average";

	public const string Fraction = "generic_fraction";

	public const string MaximumValue = "generic_max";

	public const string Percentile = "generic_percentile";

	public const string RateOfCountsPerSecond = "generic_rate";

	public const string RawValue = "generic_raw";

	public const string AllowedChars = "[^a-zA-Z0-9_:]";

	public const string EmptyVal = "null";

	public const string ReplacementString = "_";

	public const double MaxPercentileError = 0.01;
}
