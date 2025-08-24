namespace Roblox.Amazon.Sqs;

/// <summary>
/// A factory object that is capable of creating AWS <seealso cref="T:Roblox.Amazon.Sqs.ISqsConfigSettings" />.
/// </summary>
public interface ISqsConfigSettingsFactory
{
	/// <summary>
	/// Create and return the Sqs config settings based on the input.
	/// </summary>
	/// <param name="sqsUrl">The Url of the AWS Sqs.</param>
	/// <param name="sqsAccessKey">The access key of the AWS Sqs.</param>
	/// <param name="sqsSecretAccessKey">The secret access key of the AWS Sqs.</param>
	/// <returns>The <see cref="T:Roblox.Amazon.Sqs.ISqsConfigSettings" />.</returns>
	ISqsConfigSettings GetSqsConfigSettings(string sqsUrl, string sqsAccessKey, string sqsSecretAccessKey);
}
