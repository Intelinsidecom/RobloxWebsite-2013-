using Roblox.Platform.Devices;

namespace Roblox.Platform.Party;

public interface IPartyMetricsTracker
{
	void RecordPartyCreation(DeviceType deviceType);

	void RecordPartyUserJoined(DeviceType deviceType, int userCount = 1);

	void RecordPartyJoinedGame(DeviceType deviceType, int usersInParty);
}
