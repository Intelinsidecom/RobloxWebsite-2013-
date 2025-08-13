using Roblox.Classification;
using Roblox.Platform.Core;

namespace Roblox.Platform.Devices;

internal class PlatformTypeTranslator : IPlatformTypeTranslator
{
	private readonly IApplicationTypeFactory _ApplicationTypeFactory;

	public PlatformTypeTranslator(IApplicationTypeFactory applicationTypeFactory)
	{
		_ApplicationTypeFactory = applicationTypeFactory ?? throw new PlatformArgumentNullException("applicationTypeFactory");
	}

	public PlatformType ToEnum(Roblox.Classification.PlatformType platformType)
	{
		if (platformType == null)
		{
			return PlatformType.Unknown;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.MacID)
		{
			return PlatformType.Mac;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.PCID)
		{
			return PlatformType.PC;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPad1ID)
		{
			return PlatformType.iPad1;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPad2ID)
		{
			return PlatformType.iPad2;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPad3ID)
		{
			return PlatformType.iPad3;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPad4ID)
		{
			return PlatformType.iPad4;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPad6ID)
		{
			return PlatformType.iPad6;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadMini1GID)
		{
			return PlatformType.iPadMini1G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadMini2GID)
		{
			return PlatformType.iPadMini2G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadMini3GID)
		{
			return PlatformType.iPadMini3G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadMini4GID)
		{
			return PlatformType.iPadMini4G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadAirID)
		{
			return PlatformType.iPadAir;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadAir2ID)
		{
			return PlatformType.iPadAir2;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadPro9_7ID)
		{
			return PlatformType.iPadPro9_7;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadPro10_5ID)
		{
			return PlatformType.iPadPro10_5;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPadPro12_9ID)
		{
			return PlatformType.iPadPro12_9;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone3GID)
		{
			return PlatformType.iPhone3G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone3GSID)
		{
			return PlatformType.iPhone3GS;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone4ID)
		{
			return PlatformType.iPhone4;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone4SID)
		{
			return PlatformType.iPhone4S;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone5ID)
		{
			return PlatformType.iPhone5;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone5cID)
		{
			return PlatformType.iPhone5c;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone5sID)
		{
			return PlatformType.iPhone5s;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone6ID)
		{
			return PlatformType.iPhone6;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone6PlusID)
		{
			return PlatformType.iPhone6Plus;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone6sID)
		{
			return PlatformType.iPhone6s;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone6sPlusID)
		{
			return PlatformType.iPhone6sPlus;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhoneSEID)
		{
			return PlatformType.iPhoneSE;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone7ID)
		{
			return PlatformType.iPhone7;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone7PlusID)
		{
			return PlatformType.iPhone7Plus;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone8ID)
		{
			return PlatformType.iPhone8;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhone8PlusID)
		{
			return PlatformType.iPhone8Plus;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhoneXID)
		{
			return PlatformType.iPhoneX;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhoneXRID)
		{
			return PlatformType.iPhoneXR;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhoneXSID)
		{
			return PlatformType.iPhoneXS;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPhoneXSMaxID)
		{
			return PlatformType.iPhoneXSMax;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPodTouch3GID)
		{
			return PlatformType.iPodTouch3G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPodTouch4GID)
		{
			return PlatformType.iPodTouch4G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPodTouch5GID)
		{
			return PlatformType.iPodTouch5G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iPodTouch6GID)
		{
			return PlatformType.iPodTouch6G;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iOSUnknownID)
		{
			return PlatformType.iOSUnknown;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iOSUnknownPhoneID)
		{
			return PlatformType.iOSUnknownPhone;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.iOSUnknownTabletID)
		{
			return PlatformType.iOSUnknownTablet;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.AndroidLowEndPhoneID)
		{
			return PlatformType.AndroidLowEndPhone;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.AndroidHighEndPhoneID)
		{
			return PlatformType.AndroidHighEndPhone;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.AndroidLowEndTabletID)
		{
			return PlatformType.AndroidLowEndTablet;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.AndroidHighEndTabletID)
		{
			return PlatformType.AndroidHighEndTablet;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.AndroidUnknownID)
		{
			return PlatformType.AndroidUnknown;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.AndroidUnknownPhoneID)
		{
			return PlatformType.AndroidUnknownPhone;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.AndroidUnknownTabletID)
		{
			return PlatformType.AndroidUnknownTablet;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.WindowsLowEndPhoneID)
		{
			return PlatformType.WindowsLowEndPhone;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.WindowsHighEndPhoneID)
		{
			return PlatformType.WindowsHighEndPhone;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.WindowsUnknownPhoneID)
		{
			return PlatformType.WindowsUnknownPhone;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.WindowsLowEndTabletID)
		{
			return PlatformType.WindowsLowEndTablet;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.WindowsHighEndTabletID)
		{
			return PlatformType.WindowsHighEndTablet;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.WindowsUnknownTabletID)
		{
			return PlatformType.WindowsUnknownTablet;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.XboxOneID)
		{
			return PlatformType.XboxOne;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.DesktopWindowsUwpID)
		{
			return PlatformType.DesktopWindowsUwp;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.StudioWindowsID)
		{
			return PlatformType.StudioWindows;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.StudioMacID)
		{
			return PlatformType.StudioMac;
		}
		if (platformType.ID == Roblox.Classification.PlatformType.ChromebookID)
		{
			return PlatformType.Chromebook;
		}
		return PlatformType.Unknown;
	}

	public byte ToByte(PlatformType platformType)
	{
		return platformType switch
		{
			PlatformType.Mac => Roblox.Classification.PlatformType.MacID, 
			PlatformType.PC => Roblox.Classification.PlatformType.PCID, 
			PlatformType.iPad1 => Roblox.Classification.PlatformType.iPad1ID, 
			PlatformType.iPad2 => Roblox.Classification.PlatformType.iPad2ID, 
			PlatformType.iPad3 => Roblox.Classification.PlatformType.iPad3ID, 
			PlatformType.iPad4 => Roblox.Classification.PlatformType.iPad4ID, 
			PlatformType.iPad6 => Roblox.Classification.PlatformType.iPad6ID, 
			PlatformType.iPadMini1G => Roblox.Classification.PlatformType.iPadMini1GID, 
			PlatformType.iPadMini2G => Roblox.Classification.PlatformType.iPadMini2GID, 
			PlatformType.iPadMini3G => Roblox.Classification.PlatformType.iPadMini3GID, 
			PlatformType.iPadMini4G => Roblox.Classification.PlatformType.iPadMini4GID, 
			PlatformType.iPadAir => Roblox.Classification.PlatformType.iPadAirID, 
			PlatformType.iPadAir2 => Roblox.Classification.PlatformType.iPadAir2ID, 
			PlatformType.iPadPro9_7 => Roblox.Classification.PlatformType.iPadPro9_7ID, 
			PlatformType.iPadPro10_5 => Roblox.Classification.PlatformType.iPadPro10_5ID, 
			PlatformType.iPadPro12_9 => Roblox.Classification.PlatformType.iPadPro12_9ID, 
			PlatformType.iPhone3G => Roblox.Classification.PlatformType.iPhone3GID, 
			PlatformType.iPhone3GS => Roblox.Classification.PlatformType.iPhone3GSID, 
			PlatformType.iPhone4 => Roblox.Classification.PlatformType.iPhone4ID, 
			PlatformType.iPhone4S => Roblox.Classification.PlatformType.iPhone4SID, 
			PlatformType.iPhone5 => Roblox.Classification.PlatformType.iPhone5ID, 
			PlatformType.iPhone5c => Roblox.Classification.PlatformType.iPhone5cID, 
			PlatformType.iPhone5s => Roblox.Classification.PlatformType.iPhone5sID, 
			PlatformType.iPhone6 => Roblox.Classification.PlatformType.iPhone6ID, 
			PlatformType.iPhone6Plus => Roblox.Classification.PlatformType.iPhone6PlusID, 
			PlatformType.iPhone6s => Roblox.Classification.PlatformType.iPhone6sID, 
			PlatformType.iPhone6sPlus => Roblox.Classification.PlatformType.iPhone6sPlusID, 
			PlatformType.iPhoneSE => Roblox.Classification.PlatformType.iPhoneSEID, 
			PlatformType.iPhone7 => Roblox.Classification.PlatformType.iPhone7ID, 
			PlatformType.iPhone7Plus => Roblox.Classification.PlatformType.iPhone7PlusID, 
			PlatformType.iPhone8 => Roblox.Classification.PlatformType.iPhone8ID, 
			PlatformType.iPhone8Plus => Roblox.Classification.PlatformType.iPhone8PlusID, 
			PlatformType.iPhoneX => Roblox.Classification.PlatformType.iPhoneXID, 
			PlatformType.iPhoneXR => Roblox.Classification.PlatformType.iPhoneXRID, 
			PlatformType.iPhoneXS => Roblox.Classification.PlatformType.iPhoneXSID, 
			PlatformType.iPhoneXSMax => Roblox.Classification.PlatformType.iPhoneXSMaxID, 
			PlatformType.iPodTouch3G => Roblox.Classification.PlatformType.iPodTouch3GID, 
			PlatformType.iPodTouch4G => Roblox.Classification.PlatformType.iPodTouch4GID, 
			PlatformType.iPodTouch5G => Roblox.Classification.PlatformType.iPodTouch5GID, 
			PlatformType.iPodTouch6G => Roblox.Classification.PlatformType.iPodTouch6GID, 
			PlatformType.iOSUnknown => Roblox.Classification.PlatformType.iOSUnknownID, 
			PlatformType.iOSUnknownPhone => Roblox.Classification.PlatformType.iOSUnknownPhoneID, 
			PlatformType.iOSUnknownTablet => Roblox.Classification.PlatformType.iOSUnknownTabletID, 
			PlatformType.AndroidLowEndPhone => Roblox.Classification.PlatformType.AndroidLowEndPhoneID, 
			PlatformType.AndroidHighEndPhone => Roblox.Classification.PlatformType.AndroidHighEndPhoneID, 
			PlatformType.AndroidLowEndTablet => Roblox.Classification.PlatformType.AndroidLowEndTabletID, 
			PlatformType.AndroidHighEndTablet => Roblox.Classification.PlatformType.AndroidHighEndTabletID, 
			PlatformType.AndroidUnknown => Roblox.Classification.PlatformType.AndroidUnknownID, 
			PlatformType.AndroidUnknownPhone => Roblox.Classification.PlatformType.AndroidUnknownPhoneID, 
			PlatformType.AndroidUnknownTablet => Roblox.Classification.PlatformType.AndroidUnknownTabletID, 
			PlatformType.WindowsLowEndPhone => Roblox.Classification.PlatformType.WindowsLowEndPhoneID, 
			PlatformType.WindowsHighEndPhone => Roblox.Classification.PlatformType.WindowsHighEndPhoneID, 
			PlatformType.WindowsUnknownPhone => Roblox.Classification.PlatformType.WindowsUnknownPhoneID, 
			PlatformType.WindowsLowEndTablet => Roblox.Classification.PlatformType.WindowsLowEndTabletID, 
			PlatformType.WindowsHighEndTablet => Roblox.Classification.PlatformType.WindowsHighEndTabletID, 
			PlatformType.WindowsUnknownTablet => Roblox.Classification.PlatformType.WindowsUnknownTabletID, 
			PlatformType.XboxOne => Roblox.Classification.PlatformType.XboxOneID, 
			PlatformType.DesktopWindowsUwp => Roblox.Classification.PlatformType.DesktopWindowsUwpID, 
			PlatformType.StudioWindows => Roblox.Classification.PlatformType.StudioWindowsID, 
			PlatformType.StudioMac => Roblox.Classification.PlatformType.StudioMacID, 
			PlatformType.Chromebook => Roblox.Classification.PlatformType.ChromebookID, 
			_ => Roblox.Classification.PlatformType.UnknownID, 
		};
	}

	public ApplicationType ApplicationTypeFromId(byte applicationTypeId)
	{
		return _ApplicationTypeFactory.GetById(applicationTypeId);
	}
}
