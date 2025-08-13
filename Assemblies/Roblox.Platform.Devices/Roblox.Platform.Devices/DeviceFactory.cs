using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Classification;
using Roblox.EventLog;
using Roblox.Platform.Core;

namespace Roblox.Platform.Devices;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.Devices.IDeviceFactory" />.
/// </summary>
public class DeviceFactory : IDeviceFactory
{
	private readonly ICollection<DeviceType> _DeviceTypes = new List<DeviceType>
	{
		DeviceType.Computer,
		DeviceType.Phone,
		DeviceType.Tablet,
		DeviceType.Console
	};

	private readonly ICollection<OperatingSystemType> _OperatingSystemTypes = new List<OperatingSystemType>
	{
		OperatingSystemType.Android,
		OperatingSystemType.iOS,
		OperatingSystemType.Windows,
		OperatingSystemType.WindowsPhone,
		OperatingSystemType.Windows10,
		OperatingSystemType.OSX,
		OperatingSystemType.Unknown
	};

	private readonly ILogger _Logger;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Devices.DeviceFactory" /> class.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" /> for registering information.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="logger" /></exception>
	public DeviceFactory(ILogger logger)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public ICollection<DeviceType> GetAllDeviceTypes()
	{
		return _DeviceTypes;
	}

	public ICollection<OperatingSystemType> GetAllOperatingSystemTypes()
	{
		return _OperatingSystemTypes;
	}

	public OperatingSystemType GetOperatingSystemType(string osType)
	{
		return Roblox.Classification.OperatingSystemType.GetByValue(osType)?.Translate() ?? OperatingSystemType.Unknown;
	}

	public ICollection<DeviceType> GetSupportedDeviceTypesForSponsoredPage(long sponsoredPageSupportedDevicesBitVector)
	{
		List<DeviceType> supportedDeviceTypes = new List<DeviceType>();
		foreach (DeviceType deviceType in GetAllDeviceTypesButConsole())
		{
			long bitMask = Roblox.Classification.DeviceType.Get((byte)deviceType).BitMask;
			if ((sponsoredPageSupportedDevicesBitVector & bitMask) > 0)
			{
				supportedDeviceTypes.Add(deviceType);
			}
		}
		return supportedDeviceTypes;
	}

	public long GetSponsoredPageSupportedDevicesBitVector(long sponsoredPageSupportedDevicesBitVector, ICollection<DeviceType> deviceTypes)
	{
		long supportedDevicesBitVector = sponsoredPageSupportedDevicesBitVector;
		long lastSupportedDevicesBitVector = supportedDevicesBitVector;
		foreach (DeviceType deviceType in GetAllDeviceTypesButConsole())
		{
			Roblox.Classification.DeviceType deviceTypeEntity = Roblox.Classification.DeviceType.Get((byte)deviceType);
			bool isSupported = deviceTypes.Contains(deviceType);
			supportedDevicesBitVector = AddOrRemoveDeviceTypeBit(supportedDevicesBitVector, deviceTypeEntity, isSupported);
			if (lastSupportedDevicesBitVector != supportedDevicesBitVector)
			{
				lastSupportedDevicesBitVector = supportedDevicesBitVector;
			}
		}
		return supportedDevicesBitVector;
	}

	public string GetFriendlyIOSDeviceName(IOSDeviceType deviceType, Version deviceVersion)
	{
		switch (deviceType)
		{
		case IOSDeviceType.iPad:
			if (deviceVersion.Major == 2 && deviceVersion.Minor >= 5)
			{
				return "iPad mini 1G";
			}
			if (deviceVersion.Major < 3 || (deviceVersion.Major == 3 && deviceVersion.Minor < 4))
			{
				return "iPad " + deviceVersion.Major;
			}
			if (deviceVersion.Major == 3 && deviceVersion.Minor >= 4)
			{
				return "iPad 4";
			}
			if (deviceVersion.Major == 4 && deviceVersion.Minor >= 1 && deviceVersion.Minor <= 3)
			{
				return "iPad Air";
			}
			if (deviceVersion.Major == 5 && deviceVersion.Minor >= 3 && deviceVersion.Minor <= 4)
			{
				return "iPad Air 2";
			}
			if (deviceVersion.Major == 4 && deviceVersion.Minor >= 4 && deviceVersion.Minor <= 6)
			{
				return "iPad mini 2G";
			}
			if (deviceVersion.Major == 4 && deviceVersion.Minor >= 7)
			{
				return "iPad mini 3G";
			}
			if (deviceVersion.Major == 5 && deviceVersion.Minor >= 1 && deviceVersion.Minor <= 2)
			{
				return "iPad mini 4G";
			}
			if (deviceVersion.Major == 6 && deviceVersion.Minor >= 7 && deviceVersion.Minor <= 8)
			{
				return "iPad Pro 12.9";
			}
			if (deviceVersion.Major == 6 && deviceVersion.Minor >= 3 && deviceVersion.Minor <= 4)
			{
				return "iPad Pro 9.7";
			}
			if (deviceVersion.Major == 7 && deviceVersion.Minor >= 3 && deviceVersion.Minor <= 4)
			{
				return "iPad Pro 10.5";
			}
			if (deviceVersion.Major == 7 && deviceVersion.Minor >= 5 && deviceVersion.Minor <= 6)
			{
				return "iPad 6";
			}
			return "iOS: unknown tablet";
		case IOSDeviceType.iPhone:
			if (deviceVersion.Major == 1 && deviceVersion.Minor == 1)
			{
				return "iPhone 2G";
			}
			if (deviceVersion.Major == 1 && deviceVersion.Minor == 2)
			{
				return "iPhone 3G";
			}
			if (deviceVersion.Major == 2)
			{
				return "iPhone 3GS";
			}
			if (deviceVersion.Major == 3)
			{
				return "iPhone 4";
			}
			if (deviceVersion.Major == 4)
			{
				return "iPhone 4S";
			}
			if (deviceVersion.Major == 5 && (deviceVersion.Minor == 1 || deviceVersion.Minor == 2))
			{
				return "iPhone 5";
			}
			if (deviceVersion.Major == 5 && (deviceVersion.Minor == 3 || deviceVersion.Minor == 4))
			{
				return "iPhone 5c";
			}
			if (deviceVersion.Major == 6 && (deviceVersion.Minor == 1 || deviceVersion.Minor == 2))
			{
				return "iPhone 5s";
			}
			if (deviceVersion.Major == 7 && deviceVersion.Minor == 2)
			{
				return "iPhone 6";
			}
			if (deviceVersion.Major == 7 && deviceVersion.Minor == 1)
			{
				return "iPhone 6+";
			}
			if (deviceVersion.Major == 8 && deviceVersion.Minor == 1)
			{
				return "iPhone 6s";
			}
			if (deviceVersion.Major == 8 && deviceVersion.Minor == 2)
			{
				return "iPhone 6s+";
			}
			if (deviceVersion.Major == 8 && deviceVersion.Minor == 4)
			{
				return "iPhone SE";
			}
			if (deviceVersion.Major == 9 && (deviceVersion.Minor == 1 || deviceVersion.Minor == 3))
			{
				return "iPhone 7";
			}
			if (deviceVersion.Major == 9 && (deviceVersion.Minor == 2 || deviceVersion.Minor == 4))
			{
				return "iPhone 7+";
			}
			if (deviceVersion.Major == 10 && (deviceVersion.Minor == 1 || deviceVersion.Minor == 4))
			{
				return "iPhone 8";
			}
			if (deviceVersion.Major == 10 && (deviceVersion.Minor == 2 || deviceVersion.Minor == 5))
			{
				return "iPhone 8+";
			}
			if (deviceVersion.Major == 10 && (deviceVersion.Minor == 3 || deviceVersion.Minor == 6))
			{
				return "iPhone X";
			}
			if (deviceVersion.Major == 11 && deviceVersion.Minor == 8)
			{
				return "iPhone XR";
			}
			if (deviceVersion.Major == 11 && deviceVersion.Minor == 2)
			{
				return "iPhone XS";
			}
			if (deviceVersion.Major == 11 && (deviceVersion.Minor == 4 || deviceVersion.Minor == 6))
			{
				return "iPhone XS Max";
			}
			return "iOS: unknown phone";
		case IOSDeviceType.iPod:
			if (deviceVersion.Major < 6)
			{
				return "iPod touch " + deviceVersion.Major + "G";
			}
			if (deviceVersion.Major == 7)
			{
				return "iPod touch 6G";
			}
			return "iOS: unknown phone";
		default:
			return "Unknown";
		}
	}

	private ICollection<DeviceType> GetAllDeviceTypesButConsole()
	{
		return (from d in GetAllDeviceTypes()
			where d != DeviceType.Console
			select d).ToList();
	}

	public long AddOrRemoveDeviceTypeBit(long supportedDevicesBitVector, Roblox.Classification.DeviceType deviceTypeEntity, bool isSupported)
	{
		supportedDevicesBitVector = ((!isSupported) ? (supportedDevicesBitVector & ~(1 << deviceTypeEntity.BitOrdinal - 1)) : (supportedDevicesBitVector | (1 << deviceTypeEntity.BitOrdinal - 1)));
		return supportedDevicesBitVector;
	}
}
