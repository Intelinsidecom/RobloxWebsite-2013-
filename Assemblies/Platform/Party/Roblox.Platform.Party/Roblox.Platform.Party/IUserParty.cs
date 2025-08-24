using Roblox.Platform.Devices;

namespace Roblox.Platform.Party;

public interface IUserParty
{
	IParty Party { get; }

	bool AutoFollowPartyLeader { get; }

	bool IsPartyLeader { get; }

	DeviceType DeviceType { get; }
}
