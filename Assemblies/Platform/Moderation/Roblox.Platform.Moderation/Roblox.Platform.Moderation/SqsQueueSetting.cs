using Newtonsoft.Json;

namespace Roblox.Platform.Moderation;

/// <summary>
/// The Sqs publish/receive access settings of a particular SQS queue
/// uniquely identified by a key.
/// </summary>
public class SqsQueueSetting
{
	/// <summary>
	/// The <see cref="P:Roblox.Platform.Moderation.SqsQueueSetting.ModerationTaskType" />.
	/// </summary>
	[JsonProperty("moderation_task_type")]
	public ModerationTaskType ModerationTaskType { get; set; }

	/// <summary>
	/// The locale Id of the queue.
	/// </summary>
	[JsonProperty("locale_id")]
	public int LocaleId { get; set; }

	/// <summary>
	/// The priority of the queue in integer format.
	/// </summary>
	[JsonProperty("priority")]
	public ModerationTaskPriority Priority { get; set; }

	/// <summary>
	/// the URl of the Sqs queue.
	/// </summary>
	[JsonProperty("sqs_url")]
	public string SqsUrl { get; set; }

	/// <summary>
	/// Controls the default number of items per batch get from this queue.
	/// </summary>
	[JsonProperty("batch_size")]
	public int BatchSize { get; set; }

	/// <summary>
	/// Controls after how long the task(s) will become visible and can be leased by others again in seconds if no action is taken, 
	/// aka length of the lease.
	/// </summary>
	[JsonProperty("visibility_timeout")]
	public int VisibilityTimeoutInSeconds { get; set; }

	/// <summary>
	/// The <seealso cref="T:Roblox.Platform.Moderation.SqsAccessSetting" /> required to publish message to the queue.
	/// </summary>
	[JsonProperty("publish_sqs_setting")]
	public SqsAccessSetting PublishSqsAccessSetting { get; set; }

	/// <summary>
	/// The <seealso cref="T:Roblox.Platform.Moderation.SqsAccessSetting" /> required to receive message from the queue.
	/// </summary>
	[JsonProperty("receive_sqs_setting")]
	public SqsAccessSetting ReceiveSqsAccessSetting { get; set; }
}
