using System;

namespace Roblox.Common.NetStandard;

public static class EnumUtils
{
	public static TEnum? StrictTryParseEnum<TEnum>(string value) where TEnum : struct
	{
		if (Enum.TryParse<TEnum>(value, out var result) && Enum.IsDefined(typeof(TEnum), result))
		{
			return result;
		}
		return null;
	}
}
