using Newtonsoft.Json;

namespace Roblox.Platform.Moderation;

/// <summary>
/// AWS SQS config settings.
/// </summary>
public class SqsAccessSetting
{
	/// <summary>
	/// The SQS Access Key.
	/// </summary>
	[JsonProperty("sqs_access_key")]
	public string SqsAccessKey { get; set; }

	/// <summary>
	/// The SQS Secret Access Key.
	/// </summary>
	[JsonProperty("sqs_secret_key")]
	public string SqsSecretAccessKey { get; set; }
}
