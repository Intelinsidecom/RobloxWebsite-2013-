using Newtonsoft.Json;
using Roblox.RealTimeNotifications.Properties;

namespace Roblox.RealTimeNotifications;

public abstract class UserNotificationMessageBase
{
	public abstract string Type { get; set; }

	public long SequenceNumber { get; internal set; }

	[JsonIgnore]
	public virtual bool IsIncrementSequenceNumberEnabled { get; } = true;


	public bool ShouldSerializeSequenceNumber()
	{
		return Settings.Default.IsUserNotificationNamespaceSequenceEnabled;
	}
}
