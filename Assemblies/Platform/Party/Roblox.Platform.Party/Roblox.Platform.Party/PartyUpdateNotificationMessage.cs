using System;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Party;

internal class PartyUpdateNotificationMessage : UserNotificationMessageBase
{
	public Guid PartyId { get; set; }

	public string PartyType { get; set; }

	public override string Type { get; set; }

	public PartyUpdateNotificationMessage()
	{
	}

	public PartyUpdateNotificationMessage(Guid partyId, WalledGarden walledGarden, PartyUpdateNotificationType type)
	{
		PartyId = partyId;
		PartyType = Translate(walledGarden).ToString();
		Type = type.ToString();
	}

	private PartyType Translate(WalledGarden walledGarden)
	{
		return walledGarden switch
		{
			WalledGarden.PlayTogether => Roblox.Platform.Party.PartyType.PlayTogether, 
			WalledGarden.Xbox => Roblox.Platform.Party.PartyType.Xbox, 
			_ => Roblox.Platform.Party.PartyType.General, 
		};
	}
}
