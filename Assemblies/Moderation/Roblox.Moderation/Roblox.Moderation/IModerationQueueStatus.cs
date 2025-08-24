using System.Collections.Generic;

namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface represents an object that is responsible for assembling metrics 
/// about moderation queues.
/// </summary>
public interface IModerationQueueStatus
{
	/// <summary>
	/// Gets metrics for moderation dashboard header based on specified locale Id.
	/// </summary>
	/// <param name="localeId">The locale Id to be retrieved.</param>
	/// <param name="getNewAbuseMetrics">If true, gets the new queue metrics for Abuse, otherwise gets the old DB metrics.</param>
	/// <param name="getNewAssetMetrics">If true, gets the new queue metrics for Assets, otherwise gets the old DB metrics.</param>
	/// <param name="getNewPunishmentMetrics">If true, gets the new queue metrics for Punishment, otherwise gets the old DB metrics.</param>
	/// <returns>A <see cref="T:Roblox.Platform.Moderation.SerializableLocaleMetrics" />.</returns>
	SerializableLocaleMetrics GetDashboardStatus(int localeId, bool getNewAbuseMetrics, bool getNewAssetMetrics, bool getNewPunishmentMetrics);

	/// <summary>
	/// Gets metrics for all supported moderation queues. 
	/// </summary>
	/// <returns>An <see cref="T:System.Collections.Generic.IDictionary`2" /> of {LocaleName, <see cref="T:Roblox.Platform.Moderation.SerializableLocaleMetrics" />} pairs.</returns>
	IDictionary<string, SerializableLocaleMetrics> GetQueueStatus();
}
