using System.Collections.Generic;
namespace Roblox.EventStream {
    interface IEventSender

{
	void PublishEvent(string target, string eventType, IEnumerable<KeyValuePair<string, string>> eventParameters, string clientIp, bool isTrustedSource, string partitionKey = null);
}


}
