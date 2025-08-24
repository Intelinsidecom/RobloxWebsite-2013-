using System;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServerRenewal : IPrivateServerRenewal
{
	public IPrivateServer PrivateServer { get; }

	public DateTime PreRenewalExpiryDate { get; }

	public PrivateServerStatusType PreRenewalStatus { get; }

	public PrivateServerRenewal(IPrivateServer privateServer, DateTime preRenewalExpiryDate, PrivateServerStatusType preRenewalStatus)
	{
		PrivateServer = privateServer;
		PreRenewalExpiryDate = preRenewalExpiryDate;
		PreRenewalStatus = preRenewalStatus;
	}
}
