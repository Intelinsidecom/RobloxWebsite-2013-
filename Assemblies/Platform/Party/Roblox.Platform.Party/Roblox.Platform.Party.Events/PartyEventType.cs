namespace Roblox.Platform.Party.Events;

public enum PartyEventType
{
	/// <summary>
	/// Used when a party needs to be deleted, i.e. the last member leaves.
	/// </summary>
	PartyReadyToBeDeleted = 1,
	/// <summary>
	/// Used when a party invitation is sent to someone
	/// </summary>
	PartyInvitationSent,
	/// <summary>
	/// Used when someone accepts a party invitation
	/// </summary>
	PartyInvitationAccepted,
	/// <summary>
	/// Used when someone starts a new party
	/// </summary>
	PartyCreated,
	/// <summary>
	/// Used when someone leaves a party
	/// </summary>
	PartyMemberLeft
}
