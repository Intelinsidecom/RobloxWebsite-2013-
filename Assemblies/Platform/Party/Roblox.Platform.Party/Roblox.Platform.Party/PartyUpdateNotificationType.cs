namespace Roblox.Platform.Party;

public enum PartyUpdateNotificationType
{
	InvitedToParty,
	PartyUserJoined,
	PartyUserLeft,
	PartyJoinedGame,
	PartyLeftGame,
	PartyDeleted,
	/// <summary>
	/// This goes out to the user who left the party. 
	/// </summary>
	ILeftParty,
	/// <summary>
	/// This goes out to the user who created the party. 
	/// </summary>
	ICreatedParty,
	/// <summary>
	/// This goes out to the user who joined the party. 
	/// </summary>
	IJoinedParty,
	PartyUserDeviceUpdated
}
