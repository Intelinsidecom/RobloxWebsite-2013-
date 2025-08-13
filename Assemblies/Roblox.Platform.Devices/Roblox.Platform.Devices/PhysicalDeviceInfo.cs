using System;
using System.Text.RegularExpressions;

namespace Roblox.Platform.Devices;

public abstract class PhysicalDeviceInfo
{
	public int Memory { get; set; }

	public int ScreenResolutionX { get; set; }

	public int ScreenResolutionY { get; set; }

	public int DotsPerInchX { get; set; }

	public int DotsPerInchY { get; set; }

	public int DeviceIndependentPixelsX { get; set; }

	public int DeviceIndependentPixelsY { get; set; }

	public string DeviceName { get; set; }

	public string OperatingSystem { get; set; }

	public double PhysicalInchX => (double)DeviceIndependentPixelsX / 160.0;

	public double PhysicalInchY => (double)DeviceIndependentPixelsY / 160.0;

	public virtual bool Populate(string userAgent)
	{
		Match match = Regex.Match(userAgent, "\\((?<memory>\\d+)MB; (?<screenX>\\d+)x(?<screenY>\\d+); (?<dpiX>\\d+)x(?<dpiY>\\d+); (?<dipX>\\d+)x(?<dipY>\\d+); (?<deviceName>[^;]*); (?<os>[^)]*)\\)");
		if (!match.Success)
		{
			return false;
		}
		try
		{
			Memory = int.Parse(match.Groups["memory"].Value);
			ScreenResolutionX = int.Parse(match.Groups["screenX"].Value);
			ScreenResolutionY = int.Parse(match.Groups["screenY"].Value);
			DotsPerInchX = int.Parse(match.Groups["dpiX"].Value);
			DotsPerInchY = int.Parse(match.Groups["dpiY"].Value);
			DeviceIndependentPixelsX = int.Parse(match.Groups["dipX"].Value);
			DeviceIndependentPixelsY = int.Parse(match.Groups["dipY"].Value);
			DeviceName = match.Groups["deviceName"].Value;
			OperatingSystem = match.Groups["os"].Value;
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}
}
