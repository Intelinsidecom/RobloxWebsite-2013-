using System.Collections.Specialized;
using Roblox.Classification;

namespace Roblox.Platform.Devices;

public static class Extensions
{
	internal static IPlatform Translate(this Roblox.Classification.PlatformType platformType, IPlatformTypeTranslator platformTypeTranslator)
	{
		if (platformType == null)
		{
			return null;
		}
		Roblox.Classification.DeviceType deviceType = Roblox.Classification.DeviceType.Get(1);
		if (platformType.DeviceTypeID.HasValue)
		{
			deviceType = Roblox.Classification.DeviceType.Get(platformType.DeviceTypeID.Value);
		}
		Roblox.Classification.OperatingSystemType operatingSystemType = (platformType.OperatingSystemTypeID.HasValue ? Roblox.Classification.OperatingSystemType.Get(platformType.OperatingSystemTypeID.Value) : null);
		ApplicationType applicationType = (platformType.ApplicationTypeID.HasValue ? platformTypeTranslator.ApplicationTypeFromId(platformType.ApplicationTypeID.Value) : ApplicationType.Undefined);
		return new Platform(platformType.ID, deviceType.Translate(), platformTypeTranslator.ToEnum(platformType), platformType.Value, operatingSystemType.Translate(), applicationType);
	}

	private static DeviceType Translate(this Roblox.Classification.DeviceType deviceType)
	{
		return (DeviceType)deviceType.ID;
	}

	internal static OperatingSystemType Translate(this Roblox.Classification.OperatingSystemType operatingSystemType)
	{
		return (OperatingSystemType)(operatingSystemType?.ID ?? 0);
	}

	public static bool RequiresCuratedGames(this IPlatform platform, NameValueCollection contextHeader)
	{
		if (platform.OperatingSystemType != OperatingSystemType.iOS)
		{
			return false;
		}
		string requiresCuratedGames = contextHeader["require-curated-games"];
		if (string.IsNullOrWhiteSpace(requiresCuratedGames))
		{
			return false;
		}
		bool result;
		return bool.TryParse(requiresCuratedGames, out result) && result;
	}
}
