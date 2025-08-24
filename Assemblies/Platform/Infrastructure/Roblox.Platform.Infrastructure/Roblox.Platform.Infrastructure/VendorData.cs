namespace Roblox.Platform.Infrastructure;

public static class VendorData
{
	public static string GetVendorNameByPrimaryIpAddress(string primaryIpAddress)
	{
		Server server = GetServerByPrimaryIpAddress(primaryIpAddress);
		if (server == null)
		{
			return null;
		}
		return GetVendorNameByVendorId(server.VendorID);
	}

	public static int GetVendorIdByPrimaryIpAddress(string primaryIpAddress)
	{
		return GetServerByPrimaryIpAddress(primaryIpAddress)?.VendorID ?? 0;
	}

	public static string GetVendorNameByVendorId(int vendorId)
	{
		RefreshAheadDatabaseLookups.VendorIDToNameMap.TryGetValue(vendorId, out var vendorName);
		return vendorName;
	}

	public static int GetServerIdByPrimaryIpAddress(string primaryIPAddress)
	{
		return GetServerByPrimaryIpAddress(primaryIPAddress)?.ID ?? 0;
	}

	private static Server GetServerByPrimaryIpAddress(string primaryIPAddress)
	{
		RefreshAheadDatabaseLookups.IPAddressToServerMap.TryGetValue(primaryIPAddress, out var server);
		return server;
	}
}
