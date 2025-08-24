namespace Roblox.Amazon.Sqs;

/// <summary>
/// The default Implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsConfigSettings" />.
/// </summary>
internal class SqsConfigSettings : ISqsConfigSettings
{
	/// <inheritdoc cref="P:Roblox.Amazon.Sqs.ISqsConfigSettings.SqsUrl" />
	public string SqsUrl { get; set; }

	/// <inheritdoc cref="P:Roblox.Amazon.Sqs.ISqsConfigSettings.SqsAccessKey" />
	public string SqsAccessKey { get; set; }

	/// <inheritdoc cref="P:Roblox.Amazon.Sqs.ISqsConfigSettings.SqsSecretAccessKey" />
	public string SqsSecretAccessKey { get; set; }
}
