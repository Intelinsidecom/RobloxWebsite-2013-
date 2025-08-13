using System.Diagnostics.CodeAnalysis;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsConfigSettingsFactory" />.
/// </summary>
[ExcludeFromCodeCoverage]
public class SqsConfigSettingsFactory : ISqsConfigSettingsFactory
{
	/// <summary>
	/// <inheritdoc cref="M:Roblox.Amazon.Sqs.ISqsConfigSettingsFactory.GetSqsConfigSettings(System.String,System.String,System.String)" />
	/// </summary>
	public ISqsConfigSettings GetSqsConfigSettings(string sqsUrl, string sqsAccessKey, string sqsSecretAccessKey)
	{
		return new SqsConfigSettings
		{
			SqsUrl = sqsUrl,
			SqsAccessKey = sqsAccessKey,
			SqsSecretAccessKey = sqsSecretAccessKey
		};
	}
}
