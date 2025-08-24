using System;
using Roblox.Platform.Party.Events;

namespace Roblox.Platform.Party;

public interface IPartyEventsPublisher
{
	void Publish(Guid partyId, PartyEventType partyEventType, long? affectedUserId = null);
}
