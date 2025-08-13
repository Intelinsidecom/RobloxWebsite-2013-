using System.Text;

namespace Roblox.Platform.Notifications.Push;

internal static class DestinationUtilities
{
	public static byte[] ComputeDestinationServiceIDHash(string destinationServiceId)
	{
		return HashFunctions.ComputeHash(Encoding.UTF8.GetBytes(destinationServiceId.ToLowerInvariant()));
	}
}
