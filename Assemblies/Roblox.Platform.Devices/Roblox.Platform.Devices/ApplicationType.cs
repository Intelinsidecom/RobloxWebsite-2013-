namespace Roblox.Platform.Devices;

/// <summary>
/// ApplicationType identifies a "build" of the client accessing the website or APIs.
/// </summary>
public enum ApplicationType
{
	Undefined,
	Unknown,
	WindowsClient,
	WindowsStudio,
	MacClient,
	MacStudio,
	IosClient,
	GooglePlayClient,
	AmazonClient,
	XboxOneClient,
	UwpClient
}
