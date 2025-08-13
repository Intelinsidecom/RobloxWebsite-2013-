using System;

namespace Roblox.Platform.Infrastructure;

internal class Server : IEquatable<Server>
{
	public int ID;

	public int ServerTypeID;

	public int ServerStatusID;

	public int VendorID;

	public string IPAddress;

	public override bool Equals(object obj)
	{
		if (obj is Server server)
		{
			return Equals(server);
		}
		return false;
	}

	public bool Equals(Server other)
	{
		return ID == other.ID;
	}

	public override int GetHashCode()
	{
		return ID;
	}
}
