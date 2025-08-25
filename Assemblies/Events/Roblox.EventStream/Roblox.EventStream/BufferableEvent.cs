using System.Collections.Generic;

namespace Roblox.Platform.EventStream;

internal class BufferableEvent
{
	public string Target { get; set; }

	public string EventType { get; set; }

	public IReadOnlyCollection<KeyValuePair<string, string>> EventParameters { get; set; }

	public string ClientIp { get; set; }

	public bool IsTrustedSource { get; set; }

	public string PartitionKey { get; set; }
}
