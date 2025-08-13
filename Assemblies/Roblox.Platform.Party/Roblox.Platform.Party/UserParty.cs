using Roblox.Platform.Devices;

namespace Roblox.Platform.Party;

internal class UserParty : IUserParty
{
	public IParty Party { get; internal set; }

	public bool AutoFollowPartyLeader { get; internal set; }

	public bool IsPartyLeader { get; internal set; }

	public DeviceType DeviceType { get; internal set; }
}
