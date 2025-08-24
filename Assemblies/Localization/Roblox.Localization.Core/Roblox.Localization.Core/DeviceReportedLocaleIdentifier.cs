namespace Roblox.Platform.Localization.Core;

public class DeviceReportedLocaleIdentifier : IDeviceReportedLocaleIdentifier
{
	public int Id { get; }

	public DeviceReportedLocaleIdentifier(int id)
	{
		Id = id;
	}
}
