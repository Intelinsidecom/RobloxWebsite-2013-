using System.Collections.Generic;
using Roblox.Amazon.Sns;

namespace Roblox.Platform.Games.Events;

internal class PrivateServerConfigureMessage : ISnsMessage
{
	public IList<byte> EventTypes { get; set; }

	public long? PrivateServerId { get; set; }

	public long? UniverseId { get; set; }
}
