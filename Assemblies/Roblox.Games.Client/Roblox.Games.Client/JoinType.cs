namespace Roblox.Games.Client;

public enum JoinType
{
	Unknown,
	NewGame_NoAvailableSlots,
	NewGame_SinglePlayer,
	NewGame_PotentialGame,
	NewGame_PrivateGame,
	Specific,
	Specific_PrivateGame,
	Error,
	ExistingReservation,
	Disabled,
	MatchMade
}
