using System.Text.RegularExpressions;

namespace Roblox.Platform.Devices;

public class AndroidAppDeviceInfo : PhysicalDeviceInfo
{
	private string _DefaultAndroidVersion = "4.0";

	public string AndroidVersion
	{
		get
		{
			if (string.IsNullOrEmpty(base.OperatingSystem))
			{
				return "4.0";
			}
			Match match = Regex.Match(base.OperatingSystem, "(?<version>\\d*\\.?\\d+)");
			if (match.Success)
			{
				return match.Groups["version"].Value;
			}
			return _DefaultAndroidVersion;
		}
	}
}
