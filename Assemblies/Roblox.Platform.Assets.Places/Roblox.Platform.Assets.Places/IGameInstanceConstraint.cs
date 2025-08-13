using Roblox.Platform.Assets.Places.Enums;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Assets.Places;

/// <summary>
/// Constraints set on the instances of a game. These are adjustable by the game creator, and apply to all instances of a game.
/// </summary>
public interface IGameInstanceConstraint
{
	/// <summary>
	/// Maximum number of players who can be in any one place instance
	/// </summary>
	int MaxPlayers { get; }

	/// <summary>
	/// Number of player slots reserved (of MaxPlayers) for friends of players already in game. If an instance has MaxPlayers = 10
	/// and SocialSlots = 3, then 7 strangers can join that instance. Any other join attempts by strangers will be redirected to
	/// other instances. However, friends of anyone already in game can still join that instance, either by matchmaking or by following.
	/// </summary>
	int SocialSlots { get; }

	/// <summary>
	/// There are 3 types for Social Slots.
	/// ID 1 is SocialSlotType.Automatic.
	/// ID 2 is SocialSlotType.Empty.
	/// ID 3 is SocialSlotType.Custom.
	/// </summary>
	int? SocialSlotTypeID { get; }

	/// <summary>
	///
	/// </summary>
	/// <param name="maxPlayers"></param>
	/// <param name="actingUser">The user who is updating the place constraint</param>
	void SetMaxPlayers(int maxPlayers, IUser actingUser);

	/// <summary>
	///
	/// </summary>
	/// <param name="socialSlots"></param>
	/// <param name="actingUser">The user who is updating the place constraint</param>
	void SetSocialSlots(int socialSlots, IUser actingUser);

	/// <summary>
	///
	/// </summary>
	/// <param name="socialSlotType"></param>
	/// <param name="actingUser">The user who is updating the place constraint</param>
	void SetSocialSlotType(SocialSlotType socialSlotType, IUser actingUser);
}
