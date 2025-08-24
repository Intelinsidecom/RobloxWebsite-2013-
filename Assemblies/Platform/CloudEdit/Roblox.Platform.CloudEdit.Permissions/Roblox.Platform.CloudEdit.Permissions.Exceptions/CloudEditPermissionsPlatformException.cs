using Roblox.ApiClientBase;
using Roblox.Platform.Core;

namespace Roblox.Platform.CloudEdit.Permissions.Exceptions;

/// <summary>
/// CloudEdit platform exception
/// </summary>
public class CloudEditPermissionsPlatformException : PlatformException
{
	internal CloudEditPermissionsPlatformException(string message)
		: base(message)
	{
	}

	internal CloudEditPermissionsPlatformException(ApiClientException e)
		: base("API Client Exception wrapped by CloudEdit Platform layer", e)
	{
	}
}
