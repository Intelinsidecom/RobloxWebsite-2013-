using System;

namespace Roblox.Platform.Games.PrivateServer;

public interface IPrivateServerRenewal
{
	IPrivateServer PrivateServer { get; }

	DateTime PreRenewalExpiryDate { get; }

	PrivateServerStatusType PreRenewalStatus { get; }
}
